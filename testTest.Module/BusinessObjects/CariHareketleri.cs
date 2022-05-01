using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace KasaÖrneği.Module.BusinessObjects
{
    
    public class CariHareketleri : BaseObject
    {
        public CariHareketleri(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
       }

        private DateTime tarih;
        private double tutar;
        private Harekets hareket;
        private Cariler cariID;

        [XafDisplayName("Cari Hesap")]
        [Association("Cariler-CariHareketleri")]
        public Cariler CariID
        {
            get
            {
                return cariID;
            }
            set
            {
                SetPropertyValue(nameof(CariID), ref cariID, value);
            }
        }

        public Harekets Hareket
        {
            get
            {
                return hareket;
            }
            set
            {
                SetPropertyValue(nameof(Hareket), ref hareket, value);
            }
        }

        public double Tutar
        {
            get
            {
                return tutar;
            }
            set
            {
                SetPropertyValue(nameof(Tutar), ref tutar, value);
            }
        }

        public DateTime Tarih
        {
            get
            {
                return tarih;
            }
            set
            {
                SetPropertyValue(nameof(Tarih), ref tarih, value);
            }
        }
                                                                 
    }
}
public enum Harekets
{
    Cikis,
    Giris
}

