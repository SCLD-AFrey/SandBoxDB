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

    public partial class UserSettings : XPObject
    {
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fAbbr;
        public string Abbr
        {
            get { return fAbbr; }
            set { SetPropertyValue<string>(nameof(Abbr), ref fAbbr, value); }
        }
        string fGroup;
        public string Group
        {
            get { return fGroup; }
            set { SetPropertyValue<string>(nameof(Group), ref fGroup, value); }
        }
        string fValue;
        public string Value
        {
            get { return fValue; }
            set { SetPropertyValue<string>(nameof(Value), ref fValue, value); }
        }
    }

}
