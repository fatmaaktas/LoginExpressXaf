using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace testTest.Module.BusinessObjects.dbDeneme
{
    [DefaultClassOptions]
    public partial class Personel
    {
        public Personel(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        
    }

   
}
