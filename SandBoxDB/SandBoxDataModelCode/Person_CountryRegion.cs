﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SandBox.Data
{

    public partial class Person_CountryRegion
    {
        public Person_CountryRegion(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
