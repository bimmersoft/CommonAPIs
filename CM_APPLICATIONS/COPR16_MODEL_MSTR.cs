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

    public partial class COPR16_MODEL_MSTR
    {
        [DisplayName("MODEL ID")]
        public string MODEL_ID { get; set; }

        [DisplayName("BRAND ID")]
        public string BRAND_ID { get; set; }

        [DisplayName("MODEL DESCRIPTION")]
        public string MODEL_DESC { get; set; }

        [DisplayName("CREATED DATE")]
        public Nullable<System.DateTime> ADATE { get; set; }

        [DisplayName("CREATED BY")]
        public string CRE_BY { get; set; }

        [DisplayName("MODIFIED BY")]
        public string MOD_BY { get; set; }

        [DisplayName("MODIFIED DATE")]
        public Nullable<System.DateTime> MOD_DATE { get; set; }

        [DisplayName("ACTIVE")]
        public Nullable<bool> FLGACT { get; set; }
    }
}