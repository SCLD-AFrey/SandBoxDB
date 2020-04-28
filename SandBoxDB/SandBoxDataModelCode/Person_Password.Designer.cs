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

    [Persistent(@"Person.Password")]
    public partial class Person_Password : XPLiteObject
    {
        int fBusinessEntityID;
        [Key]
        public int BusinessEntityID
        {
            get { return fBusinessEntityID; }
            set { SetPropertyValue<int>(nameof(BusinessEntityID), ref fBusinessEntityID, value); }
        }
        string fPasswordHash;
        [Size(128)]
        public string PasswordHash
        {
            get { return fPasswordHash; }
            set { SetPropertyValue<string>(nameof(PasswordHash), ref fPasswordHash, value); }
        }
        string fPasswordSalt;
        [Size(10)]
        public string PasswordSalt
        {
            get { return fPasswordSalt; }
            set { SetPropertyValue<string>(nameof(PasswordSalt), ref fPasswordSalt, value); }
        }
        Guid frowguid;
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