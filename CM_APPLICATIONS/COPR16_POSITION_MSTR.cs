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

    public partial class COPR16_POSITION_MSTR
    {

        [DisplayName("POSITION ID")]
        public string POS_ID { get; set; }

        [DisplayName("POSITION DESCRIPTION")]
        public string POS_DESC { get; set; }

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
