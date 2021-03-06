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

    [Persistent(@"Person.CountryRegion")]
    public partial class Person_CountryRegion : XPLiteObject
    {
        string fCountryRegionCode;
        [Key]
        [Size(3)]
        public string CountryRegionCode
        {
            get { return fCountryRegionCode; }
            set { SetPropertyValue<string>(nameof(CountryRegionCode), ref fCountryRegionCode, value); }
        }
        string fName;
        [Indexed(Name = @"AK_CountryRegion_Name", Unique = true)]
        [Size(50)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        DateTime fModifiedDate;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime ModifiedDate
        {
            get { return fModifiedDate; }
            set { SetPropertyValue<DateTime>(nameof(ModifiedDate), ref fModifiedDate, value); }
        }
        [Association(@"Person_StateProvinceReferencesPerson_CountryRegion")]
        public XPCollection<Person_StateProvince> Person_StateProvinces { get { return GetCollection<Person_StateProvince>(nameof(Person_StateProvinces)); } }
    }

}
