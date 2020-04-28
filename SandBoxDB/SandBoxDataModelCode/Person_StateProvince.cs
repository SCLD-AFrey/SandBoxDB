using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SandBox.Data
{

    public partial class Person_StateProvince
    {
        public Person_StateProvince(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
