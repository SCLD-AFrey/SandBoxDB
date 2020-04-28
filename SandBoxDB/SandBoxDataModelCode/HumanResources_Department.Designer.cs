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

    [Persistent(@"HumanResources.Department")]
    public partial class HumanResources_Department : XPLiteObject
    {
        short fDepartmentID;
        [Key]
        public short DepartmentID
        {
            get { return fDepartmentID; }
            set { SetPropertyValue<short>(nameof(DepartmentID), ref fDepartmentID, value); }
        }
        string fName;
        [Indexed(Name = @"AK_Department_Name", Unique = true)]
        [Size(50)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fGroupName;
        [Size(50)]
        public string GroupName
        {
            get { return fGroupName; }
            set { SetPropertyValue<string>(nameof(GroupName), ref fGroupName, value); }
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