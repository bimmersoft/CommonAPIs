//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CM_APPLICATIONS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class COPR16_BRAND_MSTR
    {
        [DisplayName("BRAND ID")]
        public string BRAND_ID { get; set; }

        [DisplayName("BRAND NAME")]
        public string BRAND_NAME { get; set; }

        [DisplayName("CREATED DATE")]
        public System.DateTime ADATE { get; set; }

        [DisplayName("CREATED DATE")]
        public string CRE_BY { get; set; }

        [DisplayName("MODIFIED DATE")]
        public string MOD_BY { get; set; }

        [DisplayName("MODIFIED DATE")]
        public Nullable<System.DateTime> MOD_DATE { get; set; }

        [DisplayName("ACTIVE")]
        public Nullable<bool> FLGACT { get; set; }
    }
}