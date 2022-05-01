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
    [DefaultClassOptions]
    [Appearance("RedPriceObject", AppearanceItemType = "ViewItem", TargetItems = "*",
    Criteria = "Bakiye<0", Context = "ListView", BackColor = "Red",
        FontColor = "White", Priority = 2)]
    [Appearance("YellowPriceObject", AppearanceItemType = "ViewItem", TargetItems = "*",
    Criteria = "Bakiye>0", Context = "ListView", BackColor = "Yellow",
        FontColor = "White", Priority = 2)]
    public class Cariler : BaseObject
    {
       
        public Cariler(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            XPCollection<Cariler> collection = new XPCollection<Cariler>(Session);
            Kod = $"Cari-{collection.Count + 1}";
        }
      
        private string eposta;
        private string telefon;
        private string adres;
        private string unvani;
        private string kod;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Kod
        {
            get => kod;
            set => SetPropertyValue(nameof(Kod), ref kod, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Unvan")]
        public string Unvani
        {
            get => unvani;
            set => SetPropertyValue(nameof(Unvani), ref unvani, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Adres
        {
            get => adres;
            set => SetPropertyValue(nameof(Adres), ref adres, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Telefon
        {
            get => telefon;
            set => SetPropertyValue(nameof(Telefon), ref telefon, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Eposta
        {
            get => eposta;
            set => SetPropertyValue(nameof(Eposta), ref eposta, value);
        }

        [Association("Cariler-CariHareketleri")]
        public XPCollection<CariHareketleri> CariHareketleri
        {
            get
            {
                return GetCollection<CariHareketleri>(nameof(CariHareketleri));
            }
        }
        public double Giren
        {
            get
            {
                double temp=0;
                foreach (CariHareketleri item in CariHareketleri.Where(x => x.Hareket == Harekets.Giris))
                {
                    temp += item.Tutar;
                }
                return temp;
            }
        }
        public double Cikan
        {
            get
            {
                return CariHareketleri.Where(x => x.Hareket == Harekets.Cikis).Sum(x=> x.Tutar);
            }
        }
        public double Bakiye
        {
            get
            {
               return Giren - Cikan;
            }
        }

    }
}
public enum Renkler
{
    Kirmizi = 0,
    Sari = 1
}
