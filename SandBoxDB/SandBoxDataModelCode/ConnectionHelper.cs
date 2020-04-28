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
using Microsoft.Extensions.Configuration;
namespace SandBox.Data
{
    public static class ConnectionHelper
    {
        static Type[] persistentTypes = new Type[] {
            typeof(HumanResources_Department),
            typeof(HumanResources_Employee),
            typeof(HumanResources_EmployeeDepartmentHistory),
            typeof(HumanResources_EmployeePayHistory),
            typeof(HumanResources_JobCandidate),
            typeof(HumanResources_Shift),
            typeof(Person_Address),
            typeof(Person_AddressType),
            typeof(Person_BusinessEntity),
            typeof(Person_BusinessEntityAddress),
            typeof(Person_BusinessEntityContact),
            typeof(Person_ContactType),
            typeof(Person_CountryRegion),
            typeof(Person_EmailAddress),
            typeof(Person_Password),
            typeof(Person_Person),
            typeof(Person_PersonPhone),
            typeof(Person_PhoneNumberType),
            typeof(Person_StateProvince),
            typeof(Person_Selected),
            typeof(UserSettings),
            typeof(cDataPull),
            typeof(cArea)
        };
        public static Type[] GetPersistentTypes()
        {
            Type[] copy = new Type[persistentTypes.Length];
            Array.Copy(persistentTypes, copy, persistentTypes.Length);
            return copy;
        }
        public const string ConnectionStringName = "AdventureWorks2016ConnString";
        public static void Connect(IConfiguration configuration, DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, bool threadSafe = false)
        {
            if (threadSafe)
            {
                var provider = GetConnectionProvider(configuration, autoCreateOption);
                var dictionary = new DevExpress.Xpo.Metadata.ReflectionDictionary();
                dictionary.GetDataStoreSchema(persistentTypes);
                XpoDefault.DataLayer = new ThreadSafeDataLayer(dictionary, provider);
            }
            else
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(configuration.GetConnectionString(ConnectionStringName), autoCreateOption);
            }
            XpoDefault.Session = null;
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(IConfiguration configuration, DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetConnectionProvider(configuration.GetConnectionString(ConnectionStringName), autoCreateOption);
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(IConfiguration configuration, DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
        {
            return XpoDefault.GetConnectionProvider(configuration.GetConnectionString(ConnectionStringName), autoCreateOption, out objectsToDisposeOnDisconnect);
        }
        public static IDataLayer GetDataLayer(IConfiguration configuration, DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetDataLayer(configuration.GetConnectionString(ConnectionStringName), autoCreateOption);
        }
    }

}
