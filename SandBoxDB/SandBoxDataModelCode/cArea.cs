﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SandBox.Data
{

    public partial class cArea
    {
        public cArea(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}