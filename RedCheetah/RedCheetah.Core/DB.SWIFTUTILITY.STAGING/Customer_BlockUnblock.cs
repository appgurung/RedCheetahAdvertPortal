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
    
    public partial class Customer_BlockUnblock
    {
        public int BlockID { get; set; }
        public Nullable<int> i_customer { get; set; }
        public Nullable<int> i_account { get; set; }
        public Nullable<float> Amount { get; set; }
        public Nullable<int> RemDays { get; set; }
        public Nullable<System.DateTime> DateBlocked { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> DateUnblocked { get; set; }
        public string BlockSource { get; set; }
        public string BlockUsername { get; set; }
        public string UnblockSource { get; set; }
        public string UnblockUsername { get; set; }
        public string aXDR { get; set; }
        public Nullable<int> cantOnline { get; set; }
        public string paymentUID { get; set; }
        public string R_paymentUID { get; set; }
    }
}
