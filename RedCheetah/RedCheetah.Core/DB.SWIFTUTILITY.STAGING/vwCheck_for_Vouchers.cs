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
    
    public partial class vwCheck_for_Vouchers
    {
        public int VoucherID { get; set; }
        public string Voucher { get; set; }
        public float Value { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> IsUsed { get; set; }
        public Nullable<System.DateTime> DateUsed { get; set; }
        public string WebPaymentID { get; set; }
    }
}
