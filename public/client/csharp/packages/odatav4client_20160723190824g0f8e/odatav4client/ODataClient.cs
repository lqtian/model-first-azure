/*------------------------------------------------------------
 * Name: TripPin OData Reference Service
 * Version: 1.0.0
 * Description: TripPin is a fictional reference service demonstrating the capabilities of OData v4.
 * Namespace: Microsoft.OData.SampleService.Models.TripPin
 * Conformance-Level: minimal
 * Support-Filter-Functions: contains, endswith, startswith, length, indexof, substring, tolower, toupper, trim, concat, year, month, day, hour, minute, second, round, floor, ceiling, cast, isof
------------------------------------------------------------*/
namespace Microsoft.OData.SampleService.Models.TripPin
{
    /// <summary>
    /// There are no comments for DefaultContainer in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultContainer")]
    public partial class DefaultContainer : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new DefaultContainer object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData Client.Design.T4", "2.4.0")]
        public DefaultContainer(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData Client.Design.T4", "2.4.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, Microsoft.OData.SampleService.Models.TripPin, Microsoft.OData.SampleService.Models.TripPin);
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("Microsoft.OData.SampleService.Models.TripPin", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("Microsoft.OData.SampleService.Models.TripPin.", originalNameAttribute.OriginalName);
                }
                return string.Concat("Microsoft.OData.SampleService.Models.TripPin.", clientType.Name);
            }
            if (originalNameAttribute != null)
            {
                return clientType.Namespace + "." + originalNameAttribute.OriginalName;
            }
            return clientType.FullName;
        }
        /// <summary>
        /// There are no comments for Photos in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("photos")]
        public global::Microsoft.OData.Client.DataServiceQuery<Pho> Photos
        {
            get
            {
                if ((this._Photos == null))
                {
                    this._Photos = base.CreateQuery<Pho>(Photos);
                }
                return this._Photos;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Pho> _Photos;
        /// <summary>
        /// There are no comments for People in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("people")]
        public global::Microsoft.OData.Client.DataServiceQuery<Pers> People
        {
            get
            {
                if ((this._People == null))
                {
                    this._People = base.CreateQuery<Pers>(People);
                }
                return this._People;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Pers> _People;
        /// <summary>
        /// There are no comments for Airlines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("airlines")]
        public global::Microsoft.OData.Client.DataServiceQuery<Airli> Airlines
        {
            get
            {
                if ((this._Airlines == null))
                {
                    this._Airlines = base.CreateQuery<Airli>(Airlines);
                }
                return this._Airlines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Airli> _Airlines;
        /// <summary>
        /// There are no comments for Airports in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("airports")]
        public global::Microsoft.OData.Client.DataServiceQuery<Airpo> Airports
        {
            get
            {
                if ((this._Airports == null))
                {
                    this._Airports = base.CreateQuery<Airpo>(Airports);
                }
                return this._Airports;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Airpo> _Airports;
        /// <summary>
        /// There are no comments for People('{userName}')/trips in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("people('{userName}')/trips")]
        public global::Microsoft.OData.Client.DataServiceQuery<Tr> People('{userName}')/trips
        {
            get
            {
                if ((this._People('{userName}')/trips == null))
                {
                    this._People('{userName}')/trips = base.CreateQuery<Tr>(People('{userName}')/trips);
                }
                return this._People('{userName}')/trips;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Tr> _People('{userName}')/trips;
        /// <summary>
        /// There are no comments for Photos in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToPhotos(Pho pho)
        {
            base.AddObject("Photos", pho);
        }
        /// <summary>
        /// There are no comments for People in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToPeople(Pers pers)
        {
            base.AddObject("People", pers);
        }
        /// <summary>
        /// There are no comments for Airlines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToAirlines(Airli airli)
        {
            base.AddObject("Airlines", airli);
        }
        /// <summary>
        /// There are no comments for Airports in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToAirports(Airpo airpo)
        {
            base.AddObject("Airports", airpo);
        }
        /// <summary>
        /// There are no comments for People('{userName}')/trips in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToPeople('{userName}')/trips(Tr tr)
        {
            base.AddObject("People('{userName}')/trips", tr);
        }
        /// <summary>
        /// There are no comments for Me in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("me")]
        public PersonSingle Me
        {
            get
            {
                if ((this._Me == null))
                {
                    this._Me = new PersonSingle(this, "me");
                }
                return this._Me;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private PersonSingle _Me;
        /// <summary>
        /// There are no comments for GetNearestAirport in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("getNearestAirport")]
        public global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle GetNearestAirport(double lat, double lon)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(this.CreateFunctionQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Airport>("", "getNearestAirport", false, new global::Microsoft.OData.Client.UriOperationParameter("lat", lat),
                    new global::Microsoft.OData.Client.UriOperationParameter("lon", lon)));
        }
        /// <summary>
        /// There are no comments for ResetDataSource in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("resetDataSource")]
        public global::Microsoft.OData.Client.DataServiceActionQuery ResetDataSource()
        {
            return new global::Microsoft.OData.Client.DataServiceActionQuery(this, this.BaseUri.OriginalString.Trim('/') + "resetDataSource");
        }
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonGender")]
    public enum PersonGender: int
    {
        [global::Microsoft.OData.Client.OriginalNameAttribute("Unknown")]
        Unknown = 0,
        [global::Microsoft.OData.Client.OriginalNameAttribute("Female")]
        Female = -1,
        [global::Microsoft.OData.Client.OriginalNameAttribute("Male")]
        Male = 2
    }

    [global::Microsoft.OData.Client.OriginalNameAttribute("City")]
    public partial class City: global::System.ComponentModel.INotifyPropertyChanged
    {
        public static City CreateCity(string countryRegion, string name, string region)
        {
            City city = new City();
            city.CountryRegion = countryRegion;
            city.Name = name;
            city.Region = region;

            return city;
        }

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegion")]
        public string CountryRegion
        {
            get
            {
                return this._CountryRegion;
            }
            set
            {
                this.OnCountryRegionChanging(value);
                this._CountryRegion = value;
                this.OnCountryRegionChanged();
                this.OnPropertyChanged("CountryRegion");
            }
        }

        private string _CountryRegion;

        partial void OnCountryRegionChanging(string value);

        partial void OnCountryRegionChanged();

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }

        private string _Name;

        partial void OnNameChanging(string value);

        partial void OnNameChanged();

        [global::Microsoft.OData.Client.OriginalNameAttribute("Region")]
        public string Region
        {
            get
            {
                return this._Region;
            }
            set
            {
                this.OnRegionChanging(value);
                this._Region = value;
                this.OnRegionChanged();
                this.OnPropertyChanged("Region");
            }
        }

        private string _Region;

        partial void OnRegionChanging(string value);

        partial void OnRegionChanged();

        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }

    }

    [global::Microsoft.OData.Client.OriginalNameAttribute("Location")]
    public partial class Location: global::System.ComponentModel.INotifyPropertyChanged
    {
        public static Location CreateLocation(string address, global::Microsoft.OData.SampleService.Models.TripPin.City city)
        {
            Location location = new Location();
            location.Address = address;
            if(city == null)
            {
                throw new global::System.ArgumentNullException("city");
            }
            location.City = city;

            return location;
        }

        [global::Microsoft.OData.Client.OriginalNameAttribute("Address")]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this.OnAddressChanging(value);
                this._Address = value;
                this.OnAddressChanged();
                this.OnPropertyChanged("Address");
            }
        }

        private string _Address;

        partial void OnAddressChanging(string value);

        partial void OnAddressChanged();

        [global::Microsoft.OData.Client.OriginalNameAttribute("City")]
        public global::Microsoft.OData.SampleService.Models.TripPin.City City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }

        private global::Microsoft.OData.SampleService.Models.TripPin.City _City;

        partial void OnCityChanging(global::Microsoft.OData.SampleService.Models.TripPin.City value);

        partial void OnCityChanged();

        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }

    }

    [global::Microsoft.OData.Client.OriginalNameAttribute("EventLocation")]
    public partial class EventLocation: Location
    {
        public static EventLocation CreateEventLocation(string address, global::Microsoft.OData.SampleService.Models.TripPin.City city)
        {
            EventLocation eventLocation = new EventLocation();
            eventLocation.Address = address;
            if(city == null)
            {
                throw new global::System.ArgumentNullException("city");
            }
            eventLocation.City = city;

            return eventLocation;
        }

        [global::Microsoft.OData.Client.OriginalNameAttribute("BuildingInfo")]
        public string BuildingInfo
        {
            get
            {
                return this._BuildingInfo;
            }
            set
            {
                this.OnBuildingInfoChanging(value);
                this._BuildingInfo = value;
                this.OnBuildingInfoChanged();
                this.OnPropertyChanged("BuildingInfo");
            }
        }

        private string _BuildingInfo;

        partial void OnBuildingInfoChanging(string value);

        partial void OnBuildingInfoChanged();

    }

    [global::Microsoft.OData.Client.OriginalNameAttribute("AirportLocation")]
    public partial class AirportLocation: Location
    {
        public static AirportLocation CreateAirportLocation(string address, global::Microsoft.OData.SampleService.Models.TripPin.City city, global::Microsoft.Spatial.GeographyPoint loc)
        {
            AirportLocation airportLocation = new AirportLocation();
            airportLocation.Address = address;
            if(city == null)
            {
                throw new global::System.ArgumentNullException("city");
            }
            airportLocation.City = city;
            airportLocation.Loc = loc;

            return airportLocation;
        }

        [global::Microsoft.OData.Client.OriginalNameAttribute("Loc")]
        public global::Microsoft.Spatial.GeographyPoint Loc
        {
            get
            {
                return this._Loc;
            }
            set
            {
                this.OnLocChanging(value);
                this._Loc = value;
                this.OnLocChanged();
                this.OnPropertyChanged("Loc");
            }
        }

        private global::Microsoft.Spatial.GeographyPoint _Loc;

        partial void OnLocChanging(global::Microsoft.Spatial.GeographyPoint value);

        partial void OnLocChanged();

    }

    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Photo")]
    public partial class Photo : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Photo CreatePhoto(long id)
        {
            Photo photo = new Photo();
            photo.Id = id;
            return photo;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public long Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private long _Id;
        partial void OnIdChanging(long value);
        partial void OnIdChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("PhotoSingle")]
    public partial class PhotoSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Photo>
    {
        /// <summary>
        /// Initialize a new PhotoSingle object.
        /// </summary>
        public PhotoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PhotoSingle object.
        /// </summary>
        public PhotoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PhotoSingle object.
        /// </summary>
        public PhotoSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Photo> query)
            : base(query) {}
    }
    [global::Microsoft.OData.Client.Key("UserName")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Person")]
    public partial class Person : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Person CreatePerson(string userName, string firstName, string lastName)
        {
            Person person = new Person();
            person.UserName = userName;
            person.FirstName = firstName;
            person.LastName = lastName;
            return person;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("UserName")]
        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                this.OnUserNameChanging(value);
                this._UserName = value;
                this.OnUserNameChanged();
                this.OnPropertyChanged("UserName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _UserName;
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FirstName")]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this._FirstName = value;
                this.OnFirstNameChanged();
                this.OnPropertyChanged("FirstName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LastName")]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this._LastName = value;
                this.OnLastNameChanged();
                this.OnPropertyChanged("LastName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Emails")]
        public global::System.Collections.ObjectModel.ObservableCollection<string> Emails
        {
            get
            {
                return this._Emails;
            }
            set
            {
                this.OnEmailsChanging(value);
                this._Emails = value;
                this.OnEmailsChanged();
                this.OnPropertyChanged("Emails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _Emails = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnEmailsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnEmailsChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressInfo")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.OData.SampleService.Models.TripPin.Location> AddressInfo
        {
            get
            {
                return this._AddressInfo;
            }
            set
            {
                this.OnAddressInfoChanging(value);
                this._AddressInfo = value;
                this.OnAddressInfoChanged();
                this.OnPropertyChanged("AddressInfo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.OData.SampleService.Models.TripPin.Location> _AddressInfo = new global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.OData.SampleService.Models.TripPin.Location>();
        partial void OnAddressInfoChanging(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.OData.SampleService.Models.TripPin.Location> value);
        partial void OnAddressInfoChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Gender")]
        public global::System.Nullable<global::Microsoft.OData.SampleService.Models.TripPin.PersonGender> Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                this.OnGenderChanging(value);
                this._Gender = value;
                this.OnGenderChanged();
                this.OnPropertyChanged("Gender");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<global::Microsoft.OData.SampleService.Models.TripPin.PersonGender> _Gender;
        partial void OnGenderChanging(global::System.Nullable<global::Microsoft.OData.SampleService.Models.TripPin.PersonGender> value);
        partial void OnGenderChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Concurrency")]
        public global::System.Nullable<long> Concurrency
        {
            get
            {
                return this._Concurrency;
            }
            set
            {
                this.OnConcurrencyChanging(value);
                this._Concurrency = value;
                this.OnConcurrencyChanged();
                this.OnPropertyChanged("Concurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<long> _Concurrency;
        partial void OnConcurrencyChanging(global::System.Nullable<long> value);
        partial void OnConcurrencyChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Friends")]
        public global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Person> Friends
        {
            get
            {
                return this._Friends;
            }
            set
            {
                this.OnFriendsChanging(value);
                this._Friends = value;
                this.OnFriendsChanged();
                this.OnPropertyChanged("Friends");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Person> _Friends = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Person>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFriendsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Person> value);
        partial void OnFriendsChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Trips")]
        public global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Trip> Trips
        {
            get
            {
                return this._Trips;
            }
            set
            {
                this.OnTripsChanging(value);
                this._Trips = value;
                this.OnTripsChanged();
                this.OnPropertyChanged("Trips");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Trip> _Trips = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Trip>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTripsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Trip> value);
        partial void OnTripsChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Photo")]
        public global::Microsoft.OData.SampleService.Models.TripPin.Photo Photo
        {
            get
            {
                return this._Photo;
            }
            set
            {
                this.OnPhotoChanging(value);
                this._Photo = value;
                this.OnPhotoChanged();
                this.OnPropertyChanged("Photo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.Photo _Photo;
        partial void OnPhotoChanging(global::Microsoft.OData.SampleService.Models.TripPin.Photo value);
        partial void OnPhotoChanged();
        [global::Microsoft.OData.Client.OriginalNameAttribute("GetFavoriteAirline")]
        public global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle GetFavoriteAirline()
        {
            global::System.Uri requestUri;
            Context.TryGetUri(this, out requestUri);

            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(this.Context.CreateFunctionQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Airline>(string.Join("/", global::System.Linq.Enumerable.Select(global::System.Linq.Enumerable.Skip(requestUri.Segments, this.Context.BaseUri.Segments.Length), s => s.Trim('/'))), "Microsoft.OData.SampleService.Models.TripPin.GetFavoriteAirline", true));
        }
        [global::Microsoft.OData.Client.OriginalNameAttribute("GetFriendsTrips")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> GetFriendsTrips(string userName)
        {
            global::System.Uri requestUri;
            Context.TryGetUri(this, out requestUri);

            return this.Context.CreateFunctionQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip>(string.Join("/", global::System.Linq.Enumerable.Select(global::System.Linq.Enumerable.Skip(requestUri.Segments, this.Context.BaseUri.Segments.Length), s => s.Trim('/'))), "Microsoft.OData.SampleService.Models.TripPin.GetFriendsTrips", true, new global::Microsoft.OData.Client.UriOperationParameter("userName", userName));
        }
        public global::Microsoft.OData.Client.DataServiceActionQuery ShareTrip(string sharedTo, int tripId)
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/Microsoft.OData.SampleService.Models.TripPin.ShareTrip", new global::Microsoft.OData.Client.BodyOperationParameter("sharedTo", sharedTo),
                    new global::Microsoft.OData.Client.BodyOperationParameter("tripId", tripId));
        }
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonSingle")]
    public partial class PersonSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Person>
    {
        /// <summary>
        /// Initialize a new PersonSingle object.
        /// </summary>
        public PersonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonSingle object.
        /// </summary>
        public PersonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonSingle object.
        /// </summary>
        public PersonSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Person> query)
            : base(query) {}
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Friends")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> Friends
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Friends == null))
                {
                    this._Friends = Context.CreateQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person>(GetPath("Friends"));
                }
                return this._Friends;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> _Friends;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Trips")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> Trips
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Trips == null))
                {
                    this._Trips = Context.CreateQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip>(GetPath("Trips"));
                }
                return this._Trips;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> _Trips;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Photo")]
        public global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle Photo
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Photo == null))
                {
                    this._Photo = new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(this.Context, GetPath("Photo"));
                }
                return this._Photo;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle _Photo;
    }
    [global::Microsoft.OData.Client.Key("AirlineCode")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Airline")]
    public partial class Airline : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Airline CreateAirline(string airlineCode, string name)
        {
            Airline airline = new Airline();
            airline.AirlineCode = airlineCode;
            airline.Name = name;
            return airline;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AirlineCode")]
        public string AirlineCode
        {
            get
            {
                return this._AirlineCode;
            }
            set
            {
                this.OnAirlineCodeChanging(value);
                this._AirlineCode = value;
                this.OnAirlineCodeChanged();
                this.OnPropertyChanged("AirlineCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AirlineCode;
        partial void OnAirlineCodeChanging(string value);
        partial void OnAirlineCodeChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("AirlineSingle")]
    public partial class AirlineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Airline>
    {
        /// <summary>
        /// Initialize a new AirlineSingle object.
        /// </summary>
        public AirlineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AirlineSingle object.
        /// </summary>
        public AirlineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AirlineSingle object.
        /// </summary>
        public AirlineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Airline> query)
            : base(query) {}
    }
    [global::Microsoft.OData.Client.Key("IcaoCode")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Airport")]
    public partial class Airport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Airport CreateAirport(string icaoCode, string name, string iataCode, global::Microsoft.OData.SampleService.Models.TripPin.AirportLocation location)
        {
            Airport airport = new Airport();
            airport.IcaoCode = icaoCode;
            airport.Name = name;
            airport.IataCode = iataCode;
            if ((location == null))
            {
                throw new global::System.ArgumentNullException("location");
            }
            airport.Location = location;
            return airport;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IcaoCode")]
        public string IcaoCode
        {
            get
            {
                return this._IcaoCode;
            }
            set
            {
                this.OnIcaoCodeChanging(value);
                this._IcaoCode = value;
                this.OnIcaoCodeChanged();
                this.OnPropertyChanged("IcaoCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _IcaoCode;
        partial void OnIcaoCodeChanging(string value);
        partial void OnIcaoCodeChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IataCode")]
        public string IataCode
        {
            get
            {
                return this._IataCode;
            }
            set
            {
                this.OnIataCodeChanging(value);
                this._IataCode = value;
                this.OnIataCodeChanged();
                this.OnPropertyChanged("IataCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _IataCode;
        partial void OnIataCodeChanging(string value);
        partial void OnIataCodeChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Location")]
        public global::Microsoft.OData.SampleService.Models.TripPin.AirportLocation Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.AirportLocation _Location;
        partial void OnLocationChanging(global::Microsoft.OData.SampleService.Models.TripPin.AirportLocation value);
        partial void OnLocationChanged();
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("AirportSingle")]
    public partial class AirportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Airport>
    {
        /// <summary>
        /// Initialize a new AirportSingle object.
        /// </summary>
        public AirportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AirportSingle object.
        /// </summary>
        public AirportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AirportSingle object.
        /// </summary>
        public AirportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Airport> query)
            : base(query) {}
    }
    [global::Microsoft.OData.Client.Key("PlanItemId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PlanItem")]
    public partial class PlanItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static PlanItem CreatePlanItem(string planItemId)
        {
            PlanItem planItem = new PlanItem();
            planItem.PlanItemId = planItemId;
            return planItem;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanItemId")]
        public string PlanItemId
        {
            get
            {
                return this._PlanItemId;
            }
            set
            {
                this.OnPlanItemIdChanging(value);
                this._PlanItemId = value;
                this.OnPlanItemIdChanged();
                this.OnPropertyChanged("PlanItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PlanItemId;
        partial void OnPlanItemIdChanging(string value);
        partial void OnPlanItemIdChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfirmationCode")]
        public string ConfirmationCode
        {
            get
            {
                return this._ConfirmationCode;
            }
            set
            {
                this.OnConfirmationCodeChanging(value);
                this._ConfirmationCode = value;
                this.OnConfirmationCodeChanged();
                this.OnPropertyChanged("ConfirmationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ConfirmationCode;
        partial void OnConfirmationCodeChanging(string value);
        partial void OnConfirmationCodeChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("StartsAt")]
        public global::System.Nullable<global::System.DateTimeOffset> StartsAt
        {
            get
            {
                return this._StartsAt;
            }
            set
            {
                this.OnStartsAtChanging(value);
                this._StartsAt = value;
                this.OnStartsAtChanged();
                this.OnPropertyChanged("StartsAt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<global::System.DateTimeOffset> _StartsAt;
        partial void OnStartsAtChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnStartsAtChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EndsAt")]
        public global::System.Nullable<global::System.DateTimeOffset> EndsAt
        {
            get
            {
                return this._EndsAt;
            }
            set
            {
                this.OnEndsAtChanging(value);
                this._EndsAt = value;
                this.OnEndsAtChanged();
                this.OnPropertyChanged("EndsAt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<global::System.DateTimeOffset> _EndsAt;
        partial void OnEndsAtChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnEndsAtChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Duration")]
        public global::System.Nullable<global::System.TimeSpan> Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this.OnDurationChanging(value);
                this._Duration = value;
                this.OnDurationChanged();
                this.OnPropertyChanged("Duration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<global::System.TimeSpan> _Duration;
        partial void OnDurationChanging(global::System.Nullable<global::System.TimeSpan> value);
        partial void OnDurationChanged();
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("PlanItemSingle")]
    public partial class PlanItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PlanItem>
    {
        /// <summary>
        /// Initialize a new PlanItemSingle object.
        /// </summary>
        public PlanItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PlanItemSingle object.
        /// </summary>
        public PlanItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PlanItemSingle object.
        /// </summary>
        public PlanItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PlanItem> query)
            : base(query) {}
    }
    [global::Microsoft.OData.Client.Key("PlanItemId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PublicTransportation")]
    public partial class PublicTransportation : PlanItem
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static PublicTransportation CreatePublicTransportation(string planItemId)
        {
            PublicTransportation publicTransportation = new PublicTransportation();
            publicTransportation.PlanItemId = planItemId;
            return publicTransportation;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SeatNumber")]
        public string SeatNumber
        {
            get
            {
                return this._SeatNumber;
            }
            set
            {
                this.OnSeatNumberChanging(value);
                this._SeatNumber = value;
                this.OnSeatNumberChanged();
                this.OnPropertyChanged("SeatNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SeatNumber;
        partial void OnSeatNumberChanging(string value);
        partial void OnSeatNumberChanged();
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("PublicTransportationSingle")]
    public partial class PublicTransportationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PublicTransportation>
    {
        /// <summary>
        /// Initialize a new PublicTransportationSingle object.
        /// </summary>
        public PublicTransportationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PublicTransportationSingle object.
        /// </summary>
        public PublicTransportationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PublicTransportationSingle object.
        /// </summary>
        public PublicTransportationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PublicTransportation> query)
            : base(query) {}
    }
    [global::Microsoft.OData.Client.Key("PlanItemId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Flight")]
    public partial class Flight : PublicTransportation
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Flight CreateFlight(string planItemId, string flightNumber)
        {
            Flight flight = new Flight();
            flight.PlanItemId = planItemId;
            flight.FlightNumber = flightNumber;
            return flight;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FlightNumber")]
        public string FlightNumber
        {
            get
            {
                return this._FlightNumber;
            }
            set
            {
                this.OnFlightNumberChanging(value);
                this._FlightNumber = value;
                this.OnFlightNumberChanged();
                this.OnPropertyChanged("FlightNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _FlightNumber;
        partial void OnFlightNumberChanging(string value);
        partial void OnFlightNumberChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("From")]
        public global::Microsoft.OData.SampleService.Models.TripPin.Airport From
        {
            get
            {
                return this._From;
            }
            set
            {
                this.OnFromChanging(value);
                this._From = value;
                this.OnFromChanged();
                this.OnPropertyChanged("From");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.Airport _From;
        partial void OnFromChanging(global::Microsoft.OData.SampleService.Models.TripPin.Airport value);
        partial void OnFromChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("To")]
        public global::Microsoft.OData.SampleService.Models.TripPin.Airport To
        {
            get
            {
                return this._To;
            }
            set
            {
                this.OnToChanging(value);
                this._To = value;
                this.OnToChanged();
                this.OnPropertyChanged("To");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.Airport _To;
        partial void OnToChanging(global::Microsoft.OData.SampleService.Models.TripPin.Airport value);
        partial void OnToChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Airline")]
        public global::Microsoft.OData.SampleService.Models.TripPin.Airline Airline
        {
            get
            {
                return this._Airline;
            }
            set
            {
                this.OnAirlineChanging(value);
                this._Airline = value;
                this.OnAirlineChanged();
                this.OnPropertyChanged("Airline");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.Airline _Airline;
        partial void OnAirlineChanging(global::Microsoft.OData.SampleService.Models.TripPin.Airline value);
        partial void OnAirlineChanged();
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("FlightSingle")]
    public partial class FlightSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Flight>
    {
        /// <summary>
        /// Initialize a new FlightSingle object.
        /// </summary>
        public FlightSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FlightSingle object.
        /// </summary>
        public FlightSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FlightSingle object.
        /// </summary>
        public FlightSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Flight> query)
            : base(query) {}
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("From")]
        public global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle From
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._From == null))
                {
                    this._From = new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(this.Context, GetPath("From"));
                }
                return this._From;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle _From;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("To")]
        public global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle To
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._To == null))
                {
                    this._To = new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(this.Context, GetPath("To"));
                }
                return this._To;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle _To;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Airline")]
        public global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle Airline
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Airline == null))
                {
                    this._Airline = new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(this.Context, GetPath("Airline"));
                }
                return this._Airline;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle _Airline;
    }
    [global::Microsoft.OData.Client.Key("PlanItemId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Event")]
    public partial class Event : PlanItem
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Event CreateEvent(string planItemId)
        {
            Event @event = new Event();
            @event.PlanItemId = planItemId;
            return @event;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OccursAt")]
        public global::Microsoft.OData.SampleService.Models.TripPin.EventLocation OccursAt
        {
            get
            {
                return this._OccursAt;
            }
            set
            {
                this.OnOccursAtChanging(value);
                this._OccursAt = value;
                this.OnOccursAtChanged();
                this.OnPropertyChanged("OccursAt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.SampleService.Models.TripPin.EventLocation _OccursAt;
        partial void OnOccursAtChanging(global::Microsoft.OData.SampleService.Models.TripPin.EventLocation value);
        partial void OnOccursAtChanged();
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("EventSingle")]
    public partial class EventSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Event>
    {
        /// <summary>
        /// Initialize a new EventSingle object.
        /// </summary>
        public EventSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EventSingle object.
        /// </summary>
        public EventSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EventSingle object.
        /// </summary>
        public EventSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Event> query)
            : base(query) {}
    }
    [global::Microsoft.OData.Client.Key("TripId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Trip")]
    public partial class Trip : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Trip CreateTrip(string tripId, string name, float budget, global::System.DateTimeOffset startsAt, global::System.DateTimeOffset endsAt, global::System.Collections.ObjectModel.ObservableCollection<string> tags, global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Photo> photos, global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> planItems)
        {
            Trip trip = new Trip();
            trip.TripId = tripId;
            trip.Name = name;
            trip.Budget = budget;
            if ((startsAt == null))
            {
                throw new global::System.ArgumentNullException("startsAt");
            }
            trip.StartsAt = startsAt;
            if ((endsAt == null))
            {
                throw new global::System.ArgumentNullException("endsAt");
            }
            trip.EndsAt = endsAt;
            if ((tags == null))
            {
                throw new global::System.ArgumentNullException("tags");
            }
            trip.Tags = tags;
            if ((photos == null))
            {
                throw new global::System.ArgumentNullException("photos");
            }
            trip.Photos = photos;
            if ((planItems == null))
            {
                throw new global::System.ArgumentNullException("planItems");
            }
            trip.PlanItems = planItems;
            return trip;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TripId")]
        public string TripId
        {
            get
            {
                return this._TripId;
            }
            set
            {
                this.OnTripIdChanging(value);
                this._TripId = value;
                this.OnTripIdChanged();
                this.OnPropertyChanged("TripId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TripId;
        partial void OnTripIdChanging(string value);
        partial void OnTripIdChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Budget")]
        public float Budget
        {
            get
            {
                return this._Budget;
            }
            set
            {
                this.OnBudgetChanging(value);
                this._Budget = value;
                this.OnBudgetChanged();
                this.OnPropertyChanged("Budget");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private float _Budget;
        partial void OnBudgetChanging(float value);
        partial void OnBudgetChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("StartsAt")]
        public global::System.DateTimeOffset StartsAt
        {
            get
            {
                return this._StartsAt;
            }
            set
            {
                this.OnStartsAtChanging(value);
                this._StartsAt = value;
                this.OnStartsAtChanged();
                this.OnPropertyChanged("StartsAt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.DateTimeOffset _StartsAt;
        partial void OnStartsAtChanging(global::System.DateTimeOffset value);
        partial void OnStartsAtChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EndsAt")]
        public global::System.DateTimeOffset EndsAt
        {
            get
            {
                return this._EndsAt;
            }
            set
            {
                this.OnEndsAtChanging(value);
                this._EndsAt = value;
                this.OnEndsAtChanged();
                this.OnPropertyChanged("EndsAt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.DateTimeOffset _EndsAt;
        partial void OnEndsAtChanging(global::System.DateTimeOffset value);
        partial void OnEndsAtChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Tags")]
        public global::System.Collections.ObjectModel.ObservableCollection<string> Tags
        {
            get
            {
                return this._Tags;
            }
            set
            {
                this.OnTagsChanging(value);
                this._Tags = value;
                this.OnTagsChanged();
                this.OnPropertyChanged("Tags");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _Tags = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnTagsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnTagsChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Photos")]
        public global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Photo> Photos
        {
            get
            {
                return this._Photos;
            }
            set
            {
                this.OnPhotosChanging(value);
                this._Photos = value;
                this.OnPhotosChanged();
                this.OnPropertyChanged("Photos");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Photo> _Photos = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Photo>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPhotosChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.Photo> value);
        partial void OnPhotosChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanItems")]
        public global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> PlanItems
        {
            get
            {
                return this._PlanItems;
            }
            set
            {
                this.OnPlanItemsChanging(value);
                this._PlanItems = value;
                this.OnPlanItemsChanged();
                this.OnPropertyChanged("PlanItems");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> _PlanItems = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPlanItemsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> value);
        partial void OnPlanItemsChanged();
        [global::Microsoft.OData.Client.OriginalNameAttribute("GetInvolvedPeople")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> GetInvolvedPeople()
        {
            global::System.Uri requestUri;
            Context.TryGetUri(this, out requestUri);

            return this.Context.CreateFunctionQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person>(string.Join("/", global::System.Linq.Enumerable.Select(global::System.Linq.Enumerable.Skip(requestUri.Segments, this.Context.BaseUri.Segments.Length), s => s.Trim('/'))), "Microsoft.OData.SampleService.Models.TripPin.GetInvolvedPeople", true);
        }
    }
    [global::Microsoft.OData.Client.OriginalNameAttribute("TripSingle")]
    public partial class TripSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Trip>
    {
        /// <summary>
        /// Initialize a new TripSingle object.
        /// </summary>
        public TripSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TripSingle object.
        /// </summary>
        public TripSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TripSingle object.
        /// </summary>
        public TripSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Trip> query)
            : base(query) {}
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Photos")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> Photos
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Photos == null))
                {
                    this._Photos = Context.CreateQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo>(GetPath("Photos"));
                }
                return this._Photos;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> _Photos;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanItems")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> PlanItems
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PlanItems == null))
                {
                    this._PlanItems = Context.CreateQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem>(GetPath("PlanItems"));
                }
                return this._PlanItems;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> _PlanItems;
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// There are no comments for GetFavoriteAirline in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("GetFavoriteAirline")]
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle GetFavoriteAirline(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Person> source)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.CreateFunctionQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Airline>("Microsoft.OData.SampleService.Models.TripPin.GetFavoriteAirline", true));
        }

        /// <summary>
        /// There are no comments for GetFriendsTrips in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("GetFriendsTrips")]
        public static global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> GetFriendsTrips(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, string userName)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return source.CreateFunctionQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip>("Microsoft.OData.SampleService.Models.TripPin.GetFriendsTrips", true, new global::Microsoft.OData.Client.UriOperationParameter("userName", userName));
        }

        /// <summary>
        /// There are no comments for ShareTrip in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("ShareTrip")]
        public static global::Microsoft.OData.Client.DataServiceActionQuery ShareTrip(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, string sharedTo, int tripId)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(
                source.Context,
                source.AppendRequestUri("Microsoft.OData.SampleService.Models.TripPin.ShareTrip"),
                new global::Microsoft.OData.Client.BodyOperationParameter("sharedTo", sharedTo),
                new global::Microsoft.OData.Client.BodyOperationParameter("tripId", tripId));
        }

        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Photo as global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Photo> source,
            long id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PhotoSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Person as global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="userName">The value of userName</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> source,
            string userName)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "UserName", userName }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airline as global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="airlineCode">The value of airlineCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airline> source,
            string airlineCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "AirlineCode", airlineCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirlineSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Airport as global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="icaoCode">The value of icaoCode</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Airport> source,
            string icaoCode)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "IcaoCode", icaoCode }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.AirportSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem as global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PlanItemSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation as global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Flight as global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Flight> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Event as global::Microsoft.OData.SampleService.Models.TripPin.EventSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="planItemId">The value of planItemId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Event> source,
            string planItemId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "PlanItemId", planItemId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.OData.SampleService.Models.TripPin.Trip as global::Microsoft.OData.SampleService.Models.TripPin.TripSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="tripId">The value of tripId</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.TripSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source,
            string tripId)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "TripId", tripId }
            };
            return new global::Microsoft.OData.SampleService.Models.TripPin.TripSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle CastToPublicTransportation(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportationSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PublicTransportation> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Flight
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle CastToFlight(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Flight> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Flight>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.FlightSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Microsoft.OData.SampleService.Models.TripPin.PlanItem to its derived type global::Microsoft.OData.SampleService.Models.TripPin.Event
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Microsoft.OData.SampleService.Models.TripPin.EventSingle CastToEvent(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.PlanItem> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Event> query = source.CastTo<global::Microsoft.OData.SampleService.Models.TripPin.Event>();
            return new global::Microsoft.OData.SampleService.Models.TripPin.EventSingle(source.Context, query.GetPath(null));
        }
        /// <summary>
        /// There are no comments for GetInvolvedPeople in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("GetInvolvedPeople")]
        public static global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person> GetInvolvedPeople(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Microsoft.OData.SampleService.Models.TripPin.Trip> source)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return source.CreateFunctionQuery<global::Microsoft.OData.SampleService.Models.TripPin.Person>("Microsoft.OData.SampleService.Models.TripPin.GetInvolvedPeople", true);
        }

    }
}
