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

    [Persistent(@"Person.PhoneNumberType")]
    public partial class Person_PhoneNumberType : XPLiteObject
    {
        int fPhoneNumberTypeID;
        [Key(true)]
        public int PhoneNumberTypeID
        {
            get { return fPhoneNumberTypeID; }
            set { SetPropertyValue<int>(nameof(PhoneNumberTypeID), ref fPhoneNumberTypeID, value); }
        }
        string fName;
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
    }

}
