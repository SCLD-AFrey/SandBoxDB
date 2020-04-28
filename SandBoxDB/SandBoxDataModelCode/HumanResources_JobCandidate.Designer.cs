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

    [Persistent(@"HumanResources.JobCandidate")]
    public partial class HumanResources_JobCandidate : XPLiteObject
    {
        int fJobCandidateID;
        [Key(true)]
        public int JobCandidateID
        {
            get { return fJobCandidateID; }
            set { SetPropertyValue<int>(nameof(JobCandidateID), ref fJobCandidateID, value); }
        }
        HumanResources_Employee fBusinessEntityID;
        [Association(@"HumanResources_JobCandidateReferencesHumanResources_Employee")]
        public HumanResources_Employee BusinessEntityID
        {
            get { return fBusinessEntityID; }
            set { SetPropertyValue<HumanResources_Employee>(nameof(BusinessEntityID), ref fBusinessEntityID, value); }
        }
        string fResume;
        [Size(SizeAttribute.Unlimited)]
        public string Resume
        {
            get { return fResume; }
            set { SetPropertyValue<string>(nameof(Resume), ref fResume, value); }
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