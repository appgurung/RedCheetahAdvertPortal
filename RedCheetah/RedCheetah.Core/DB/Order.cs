//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedCheetah.Core.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public string CustomerEmail { get; set; }
        public Nullable<decimal> OrderTotal { get; set; }
        public Nullable<int> OrderPlaced { get; set; }
        public decimal TotalPaymentExpected { get; set; }
        public decimal TotalPaymentMade { get; set; }
        public decimal OutstandingBalance { get; set; }
        public System.DateTime OrderDate { get; set; }
    }
}
