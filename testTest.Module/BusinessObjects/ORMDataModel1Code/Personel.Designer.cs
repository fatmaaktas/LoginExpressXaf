//------------------------------------------------------------------------------
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
namespace testTest.Module.BusinessObjects.dbDeneme
{

    [Persistent(@"tbl_personel")]
    public partial class Personel : XPLiteObject
    {
        int fid;
        [Key]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        int ffirm_id;
        public int firm_id
        {
            get { return ffirm_id; }
            set { SetPropertyValue<int>(nameof(firm_id), ref ffirm_id, value); }
        }
        string fpers_adi;
        [Size(50)]
        public string pers_adi
        {
            get { return fpers_adi; }
            set { SetPropertyValue<string>(nameof(pers_adi), ref fpers_adi, value); }
        }
        string fpers_tel;
        [Size(50)]
        public string pers_tel
        {
            get { return fpers_tel; }
            set { SetPropertyValue<string>(nameof(pers_tel), ref fpers_tel, value); }
        }
    }

}
