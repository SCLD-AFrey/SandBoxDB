using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SandBox.Data
{

    public partial class Person_Selected
    {
        public Person_Selected(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
