﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SandBox.Data
{

    [Persistent(@"Person.Address")]
    public partial class Person_Address : XPLiteObject
    {
        int fAddressID;
        [Key(true)]
        public int AddressID
        {
            get { return fAddressID; }
            set { SetPropertyValue<int>(nameof(AddressID), ref fAddressID, value); }
        }
        string fAddressLine1;
        [Indexed(@"AddressLine2;City;StateProvinceID;PostalCode", Name = @"IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", Unique = true)]
        [Size(60)]
        public string AddressLine1
        {
            get { return fAddressLine1; }
            set { SetPropertyValue<string>(nameof(AddressLine1), ref fAddressLine1, value); }
        }
        string fAddressLine2;
        [Size(60)]
        public string AddressLine2
        {
            get { return fAddressLine2; }
            set { SetPropertyValue<string>(nameof(AddressLine2), ref fAddressLine2, value); }
        }
        string fCity;
        [Size(30)]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>(nameof(City), ref fCity, value); }
        }
        Person_StateProvince fStateProvinceID;
        [Association(@"Person_AddressReferencesPerson_StateProvince")]
        public Person_StateProvince StateProvinceID
        {
            get { return fStateProvinceID; }
            set { SetPropertyValue<Person_StateProvince>(nameof(StateProvinceID), ref fStateProvinceID, value); }
        }
        string fPostalCode;
        [Size(15)]
        public string PostalCode
        {
            get { return fPostalCode; }
            set { SetPropertyValue<string>(nameof(PostalCode), ref fPostalCode, value); }
        }
        Guid frowguid;
        [Indexed(Name = @"AK_Address_rowguid", Unique = true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid rowguid
        {
            get { return frowguid; }
            set { SetPropertyValue<Guid>(nameof(rowguid), ref frowguid, value); }
        }
        DateTime fModifiedDate;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime ModifiedDate
        {
            get { return fModifiedDate; }
            set { SetPropertyValue<DateTime>(nameof(ModifiedDate), ref fModifiedDate, value); }
        }
    }

}