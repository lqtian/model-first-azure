var jsyaml=require('js-yaml');

function fromYaml(str, errors, config, callback) {
    function OnMessage(message) {
        if (!!callback && typeof callback === 'function')
        {
            callback(message.data.errors);
        }
    }

    function OnError(message) {
        if (!!callback && typeof callback === 'function')
        {
            callback(message.data.errors);
            //callback();
        }
    }

    var obj;
    try {
        obj = jsyaml.load(str);
    } catch (err) {
        callback([{
                yamlError: true,
                lineNumber: err.mark.line,
                message: err.reason
            }]);
        return null;
    }

    var simpleYAMLWorker=require('../errorcheck/simpleYAML.worker');
    var worker = worker || new simpleYAMLWorker();

    worker.onmessage = OnMessage;
    worker.onerror = OnError;
    worker.postMessage({
        definition: obj
    });

    var typeMap = {
        'binary': 'edm.binary',
        'bool': 'edm.boolean',
        'boolean': 'edm.boolean',
        'byte': 'edm.byte',
        'date': 'edm.date',
        'datetimeoffset': 'edm.datetimeoffset',
        'decimal': 'edm.decimal',
        'double': 'edm.double',
        'duration': 'edm.duration',
        'guid': 'edm.guid',
        'short': 'edm.int16',
        'int': 'edm.int32',
        'integer': 'edm.int32',
        'long': 'edm.int64',
        'sbyte': 'edm.sbyte',
        'float': 'edm.single',
        'single': 'edm.single',
        'stream': 'edm.stream',
        'string': 'edm.string',
        'timeofday': 'edm.timeofday',
        'geography': 'edm.geography',
        'geographypoint': 'edm.geographypoint',
        'geographylinestring': 'edm.geographylinestring',
        'geographypolygon': 'edm.geographypolygon',
        'geographymultipoint': 'edm.geographymultipoint',
        'geographymultilinestring': 'edm.geographymultilinestring',
        'geographymultipolygon': 'edm.geographymultipolygon',
        'geographycollection': 'edm.geographycollection',
        'geometry': 'edm.geometry',
        'geometrypoint': 'edm.geometrypoint',
        'geometrylinestring': 'edm.geometrylinestring',
        'geometrypolygon': 'edm.geometrypolygon',
        'geometrymultipoint': 'edm.geometrymultipoint',
        'geometrymultilinestring': 'edm.geometrymultilinestring',
        'geometrymultipolygon': 'edm.geometrymultipolygon',
        'geometrycollection': 'edm.geometrycollection'
    };

    function matches(type) {
        for (var index in typeMap) {
            if (typeMap[index] === type) {
                return true;
            }
        }

        return false;
    }

    function maps(type) {
        var t = type.toLowerCase();
        if (typeMap[t]) {
            return typeMap[t];
        } else if (t.length > 4 && t.slice(0, 4) === 'edm.') {
            if (matches(t)) {
                return t;
            }

            return type;
        } else if (matches('edm.' + t)) {
            return 'edm.' + t;
        } else {
            return type;
        }
    }

    function detectCollectionType(yamlType) {
        var type, col;

        if (yamlType[yamlType.length - 1] === ']') {
            type = yamlType.substr(0, yamlType.length - 2);
            col = true;
        } else {
            type = yamlType;
            col = false;
        }

        return {
            'type': type,
            'isCol': col
        };
    }

    function detectNullableType(yamlType) {
        var type, nul;

        if (yamlType[yamlType.length - 1] === '?') {
            type = yamlType.substr(0, yamlType.length - 1);
            nul = true;
        } else {
            type = yamlType;
            nul = false;
        }

        return {
            'type': type,
            'isNul': nul
        };
    }

    function parseParams(arr) {
        var tempArr = [];
        var tempObj = {};
        if (Array.isArray(arr)) {
            for (var i in arr) {
                if (arr[i].name && arr[i].type) {
                    var paramType = detectCollectionType(arr[i].type);
                    var pt = detectNullableType(paramType.type);
                    tempObj = {
                        'name': arr[i].name,
                        'type': maps(pt.type)
                    };
                    if (paramType.isCol) {
                        tempObj.isCollection = true;
                    }
                    if (pt.isNul) {
                        tempObj.isNullable = true;
                    }

                } else if (arr[i].name && !arr[i].type) {
                    tempObj = {
                        'name': arr[i].name,
                        'type': 'edm.string'
                    };
                } else {
                    tempObj = {
                        'name': arr[i],
                        'type': 'edm.string'
                    };
                }

                tempArr.push(tempObj);
            }
        } else {
            tempObj = {
                'name': arr,
                'type': 'edm.string'
            };
            tempArr.push(tempObj);
        }
        return tempArr;
    }

    function parseRoot(arr) {
        var entitysets = [];
        var singletons = [];
        var operations = [];

        this.visitArr(arr, function (item) {
            if (!item.type) {
                var operation = {};
                if (!item.returns) {
                    operation.type = 'Action';
                } else {
                    operation.type = 'Function';
                }
                operation.operationType = 'Unbound';
                this.visitObj(item, {
                    'name': function (obj) {
                        operation.name = obj;
                    },
                    'params': function (arr) {
                        operation.params = parseParams(arr);
                    },
                    'returns': function (obj) {
                        if (obj) {
                            var returnType = detectCollectionType(obj);
                            var rt = detectNullableType(returnType.type);
                            operation.returns = {
                                type: maps(rt.type)
                            };
                            if (returnType.isCol) {
                                operation.returns.isCollection = true;
                            }
                            if (rt.isNul) {
                                operation.returns.isNullable = true;
                            }
                        }
                    }
                });
                operations.push(operation);
            } else {
                // entityset or singleton
                var mt = detectCollectionType(item.type);
                var et = {
                    name: item.name,
                    type: mt.type,
                    allows: item.allows
                };

                if (mt.isCol) {
                    entitysets.push(et);
                } else {
                    singletons.push(et);
                }
            }
        });

        if (entitysets.length > 0)
            state.container.entitysets = state.container.entitysets.concat(entitysets);
        if (singletons.length > 0)
            state.container.singletons = state.container.singletons.concat(singletons);
        if (operations.length > 0)
            state.container.operations = state.container.operations.concat(operations);
    }

    var visitor = this.getVisitor();
    var state = {
        api:{},
        container:
        {
            entitysets:[],
            singletons:[],
            operations:[]
        },
        types:[]
    };
    visitor.visitObj(obj, {
        'api': function (obj) {
            if(!obj.version)
            {
                obj.version = {current: '0.0.0.0'};
            }
            
            if(!obj.namespace)
            {
                var namesplits = obj.name.split(' ');
                obj.namespace = namesplits[0];
                for(var i=1;i<namesplits.length;i++)
                {
                    if(namesplits[i]!=='')
                    {
                        obj.namespace +='.' + namesplits[i];
                    }
                }
            }
            
            state.api = obj;
        },
        'types': function (arr) {
            this.visitArr(arr, function (item) {
                function isnumber(type)
                {
                    return ['edm.int32', 'edm.int16','edm.int64','edm.double','edm.decimal','edm.single'].indexOf(type) !== -1;
                }
                function handleProperty(obj, extend) {

                    // Add a entityset
                    if(!!obj.containsTarget&&obj.containsTarget===true)
                    {
                        var es ='', key='', keyType='';
                        for(var i in state.container.entitysets) {
                            if(state.container.entitysets[i].type===item.name)
                            {
                                es = state.container.entitysets[i].name; 
                                key = item.key[0].name;
                                keyType = !!item.key.type?maps(detectCollectionType(item.key.type).type):'edm.string';
                                break;
                            }
                        } 

                        var type = maps(detectCollectionType(obj.type).type);

                        var esname ='';
                        if(isnumber(type))
                        {
                            esname = es +'({' + key +'})/'+obj.name;
                        }
                        else
                        {
                            esname = es +"('{" + key +"}')/"+obj.name;
                        }
                        
                        var entityset = {
                            name: esname,
                            type: type,
                            allows: ['read'],

                            implicit: true,
                            keyType: keyType,
                            pathName: key
                        };

                        state.container.entitysets = state.container.entitysets.concat(entityset);
                    }

                    var property;
                    if (typeof obj === 'string') {
                        property = {'name': obj};
                    } else {
                        property = {'name': obj.name};
                        if (obj.type) {
                            var typeInfo = detectCollectionType(obj.type);
                            property.type = maps(typeInfo.type);
                            if (typeInfo.isCol) {
                                property.isCollection = typeInfo.isCol;
                            }
                        }
                    }

                    if (extend)
                        extend(property);

                    return property;
                }

                function handleMember(obj) {
                    var member;

                    if (typeof obj === 'string') {
                        member = {'name': obj};
                    } else {
                        member = {'name': obj.name};
                        if (obj.value >= 0 || obj.value < 0) {
                            member.value = obj.value;
                        }
                    }

                    return member;
                }

                function handleOperation(obj) {
                    var operation;
                    if (obj.name) {
                        operation = {'name': obj.name};

                        // Parse type of an operation.
                        if (!obj.returns) {
                            operation.type = 'Action';
                        } else {
                            operation.type = 'Function';
                        }

                        // Parse parameters.
                        if (obj.params) {
                            operation.params = parseParams(obj.params);
                        }

                        // Parse return type.
                        if (obj.returns) {
                            var returnType = detectCollectionType(obj.returns);
                            var rt = detectNullableType(returnType.type);
                            operation.returns = {
                                type: maps(returnType.type)
                            };
                            if (returnType.isCol) {
                                operation.returns.isCollection = true;
                            }
                            if (rt.isNul) {
                                operation.returns.isNullable = true;
                            }
                        }

                        // Parse operation-type (Bound/Unbound).
                        operation.operationType = 'Bound';
                    }
                    return operation;
                }


                var type = {properties: []};
                this.visitObj(item, {
                    'name': function (obj) {
                        type.name = obj;
                    },
                    'members': function (obj) {
                        type.members = [];
                        delete type.properties;
                        this.visitArr(obj, function (obj) {
                            type.members.push(handleMember(obj));
                        });
                    },
                    'flags': function (obj) {
                        type.flags = obj;
                    },
                    'underlyingType': function (obj) {
                        var typeInfo = detectCollectionType(obj);
                        type.underlyingType = maps(typeInfo.type);
                    },
                    'baseType': function (obj) {
                        type.baseType = obj;
                    },
                    'key': function (obj) {
                        this.visitArr(obj, function (obj) {
                            type.properties.push(handleProperty(obj, function (p) {
                                p.isKey = true;
                            }));
                        });
                    },
                    'requiredProperties': function (obj) {
                        this.visitArr(obj, function (obj) {
                            type.properties.push(handleProperty(obj));
                        });
                    },
                    'optionalProperties': function (obj) {
                        this.visitArr(obj, function (obj) {
                            type.properties.push(handleProperty(obj, function (p) {
                                p.isNullable = true;
                            }));
                        });
                    },
                    'operations': function (obj) {
                        this.visitArr(obj, function (obj) {
                            var operation = handleOperation(obj);
                            if (operation) {
                                type.properties.push(operation);
                            }
                        });
                    }
                });
                state.types.push(type);
            });
        },
        'root': parseRoot,
        'serviceRoot': parseRoot
    });

    if (config.addDefaults) {
        Morpho.addDefaults(state);
    }

    return state;
}

Morpho.registerFrom('yaml', fromYaml);