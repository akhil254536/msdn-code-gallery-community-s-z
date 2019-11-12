﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Illusion.Sales.EDM
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class IllusionSalesDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new IllusionSalesDBEntities object using the connection string found in the 'IllusionSalesDBEntities' section of the application configuration file.
        /// </summary>
        public IllusionSalesDBEntities() : base("name=IllusionSalesDBEntities", "IllusionSalesDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new IllusionSalesDBEntities object.
        /// </summary>
        public IllusionSalesDBEntities(string connectionString) : base(connectionString, "IllusionSalesDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new IllusionSalesDBEntities object.
        /// </summary>
        public IllusionSalesDBEntities(EntityConnection connection) : base(connection, "IllusionSalesDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Contact> Contacts
        {
            get
            {
                if ((_Contacts == null))
                {
                    _Contacts = base.CreateObjectSet<Contact>("Contacts");
                }
                return _Contacts;
            }
        }
        private ObjectSet<Contact> _Contacts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Country> Countries
        {
            get
            {
                if ((_Countries == null))
                {
                    _Countries = base.CreateObjectSet<Country>("Countries");
                }
                return _Countries;
            }
        }
        private ObjectSet<Country> _Countries;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Store> Stores
        {
            get
            {
                if ((_Stores == null))
                {
                    _Stores = base.CreateObjectSet<Store>("Stores");
                }
                return _Stores;
            }
        }
        private ObjectSet<Store> _Stores;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Contacts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContacts(Contact contact)
        {
            base.AddObject("Contacts", contact);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Countries EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCountries(Country country)
        {
            base.AddObject("Countries", country);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Stores EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStores(Store store)
        {
            base.AddObject("Stores", store);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IllusionSalesDBModel", Name="Contact")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contact : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contact object.
        /// </summary>
        /// <param name="contactID">Initial value of the ContactID property.</param>
        public static Contact CreateContact(global::System.Int32 contactID)
        {
            Contact contact = new Contact();
            contact.ContactID = contactID;
            return contact;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ContactID
        {
            get
            {
                return _ContactID;
            }
            set
            {
                if (_ContactID != value)
                {
                    OnContactIDChanging(value);
                    ReportPropertyChanging("ContactID");
                    _ContactID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ContactID");
                    OnContactIDChanged();
                }
            }
        }
        private global::System.Int32 _ContactID;
        partial void OnContactIDChanging(global::System.Int32 value);
        partial void OnContactIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Store
        {
            get
            {
                return _Store;
            }
            set
            {
                OnStoreChanging(value);
                ReportPropertyChanging("Store");
                _Store = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Store");
                OnStoreChanged();
            }
        }
        private global::System.String _Store;
        partial void OnStoreChanging(global::System.String value);
        partial void OnStoreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IllusionSalesDBModel", Name="Country")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Country : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Country object.
        /// </summary>
        /// <param name="countryID">Initial value of the CountryID property.</param>
        public static Country CreateCountry(global::System.Int32 countryID)
        {
            Country country = new Country();
            country.CountryID = countryID;
            return country;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CountryID
        {
            get
            {
                return _CountryID;
            }
            set
            {
                if (_CountryID != value)
                {
                    OnCountryIDChanging(value);
                    ReportPropertyChanging("CountryID");
                    _CountryID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CountryID");
                    OnCountryIDChanged();
                }
            }
        }
        private global::System.Int32 _CountryID;
        partial void OnCountryIDChanging(global::System.Int32 value);
        partial void OnCountryIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Store
        {
            get
            {
                return _Store;
            }
            set
            {
                OnStoreChanging(value);
                ReportPropertyChanging("Store");
                _Store = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Store");
                OnStoreChanged();
            }
        }
        private global::System.String _Store;
        partial void OnStoreChanging(global::System.String value);
        partial void OnStoreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CountryRegion
        {
            get
            {
                return _CountryRegion;
            }
            set
            {
                OnCountryRegionChanging(value);
                ReportPropertyChanging("CountryRegion");
                _CountryRegion = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CountryRegion");
                OnCountryRegionChanged();
            }
        }
        private global::System.String _CountryRegion;
        partial void OnCountryRegionChanging(global::System.String value);
        partial void OnCountryRegionChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IllusionSalesDBModel", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerID">Initial value of the CustomerID property.</param>
        public static Customer CreateCustomer(global::System.Int32 customerID)
        {
            Customer customer = new Customer();
            customer.CustomerID = customerID;
            return customer;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID != value)
                {
                    OnCustomerIDChanging(value);
                    ReportPropertyChanging("CustomerID");
                    _CustomerID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustomerID");
                    OnCustomerIDChanged();
                }
            }
        }
        private global::System.Int32 _CustomerID;
        partial void OnCustomerIDChanging(global::System.Int32 value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AddressLine1
        {
            get
            {
                return _AddressLine1;
            }
            set
            {
                OnAddressLine1Changing(value);
                ReportPropertyChanging("AddressLine1");
                _AddressLine1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AddressLine1");
                OnAddressLine1Changed();
            }
        }
        private global::System.String _AddressLine1;
        partial void OnAddressLine1Changing(global::System.String value);
        partial void OnAddressLine1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CountryRegion
        {
            get
            {
                return _CountryRegion;
            }
            set
            {
                OnCountryRegionChanging(value);
                ReportPropertyChanging("CountryRegion");
                _CountryRegion = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CountryRegion");
                OnCountryRegionChanged();
            }
        }
        private global::System.String _CountryRegion;
        partial void OnCountryRegionChanging(global::System.String value);
        partial void OnCountryRegionChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IllusionSalesDBModel", Name="Store")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Store : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Store object.
        /// </summary>
        /// <param name="storeID">Initial value of the StoreID property.</param>
        public static Store CreateStore(global::System.Int32 storeID)
        {
            Store store = new Store();
            store.StoreID = storeID;
            return store;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StoreID
        {
            get
            {
                return _StoreID;
            }
            set
            {
                if (_StoreID != value)
                {
                    OnStoreIDChanging(value);
                    ReportPropertyChanging("StoreID");
                    _StoreID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("StoreID");
                    OnStoreIDChanged();
                }
            }
        }
        private global::System.Int32 _StoreID;
        partial void OnStoreIDChanging(global::System.Int32 value);
        partial void OnStoreIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SalesOrderNumber
        {
            get
            {
                return _SalesOrderNumber;
            }
            set
            {
                OnSalesOrderNumberChanging(value);
                ReportPropertyChanging("SalesOrderNumber");
                _SalesOrderNumber = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SalesOrderNumber");
                OnSalesOrderNumberChanged();
            }
        }
        private global::System.String _SalesOrderNumber;
        partial void OnSalesOrderNumberChanging(global::System.String value);
        partial void OnSalesOrderNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                OnOrderDateChanging(value);
                ReportPropertyChanging("OrderDate");
                _OrderDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderDate");
                OnOrderDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _OrderDate;
        partial void OnOrderDateChanging(Nullable<global::System.DateTime> value);
        partial void OnOrderDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> TotalDue
        {
            get
            {
                return _TotalDue;
            }
            set
            {
                OnTotalDueChanging(value);
                ReportPropertyChanging("TotalDue");
                _TotalDue = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TotalDue");
                OnTotalDueChanged();
            }
        }
        private Nullable<global::System.Decimal> _TotalDue;
        partial void OnTotalDueChanging(Nullable<global::System.Decimal> value);
        partial void OnTotalDueChanged();

        #endregion

    
    }

    #endregion

    
}
