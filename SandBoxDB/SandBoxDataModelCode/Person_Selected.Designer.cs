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

    [Persistent(@"Person.SelectedPersons")]
    public partial class Person_Selected : XPObject
    {
        string fFirstName;
        public string FirstName
        {
            get { return fFirstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref fFirstName, value); }
        }
        string fMiddleName;
        public string MiddleName
        {
            get { return fMiddleName; }
            set { SetPropertyValue<string>(nameof(MiddleName), ref fMiddleName, value); }
        }
        string fLastName;
        public string LastName
        {
            get { return fLastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref fLastName, value); }
        }
        Person_Person fPersonObj;
        public Person_Person PersonObj
        {
            get { return fPersonObj; }
            set { SetPropertyValue<Person_Person>(nameof(PersonObj), ref fPersonObj, value); }
        }
    }

}
