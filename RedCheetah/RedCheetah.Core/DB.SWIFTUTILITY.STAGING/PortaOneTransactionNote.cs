//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedCheetah.Core.DB.SWIFTUTILITY.STAGING
{
    using System;
    using System.Collections.Generic;
    
    public partial class PortaOneTransactionNote
    {
        public int DesciptionID { get; set; }
        public string DescriptionRef { get; set; }
        public string PaymentCategory { get; set; }
        public string PaymentType { get; set; }
        public string Source { get; set; }
        public string Partner { get; set; }
        public string TransactionID { get; set; }
        public string ParentID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> i_customer { get; set; }
        public string macaddress { get; set; }
    }
}
