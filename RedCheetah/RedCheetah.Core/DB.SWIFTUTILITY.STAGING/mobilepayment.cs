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
    
    public partial class mobilepayment
    {
        public string ID { get; set; }
        public string Gateway { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public float Amount { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public Nullable<System.DateTime> PartnerPaymentDate { get; set; }
        public string PartnerReference { get; set; }
        public string MobileNumber { get; set; }
        public string merchantCode { get; set; }
        public string bankCode { get; set; }
        public string bankName { get; set; }
        public string ipaddress { get; set; }
        public string status { get; set; }
        public string macAddress { get; set; }
        public Nullable<int> i_product { get; set; }
        public string aXDR { get; set; }
        public string cXDR { get; set; }
        public string ProductName { get; set; }
        public string apaymentUID { get; set; }
        public string R_apaymentUID { get; set; }
        public Nullable<double> R_Amount { get; set; }
        public Nullable<int> R_Status { get; set; }
        public Nullable<System.DateTime> R_Date { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public Nullable<System.DateTime> AllocationEffectiveDate { get; set; }
        public Nullable<System.DateTime> AllocationExpirationDate { get; set; }
        public Nullable<double> AllocatedAmount { get; set; }
        public Nullable<int> Months { get; set; }
        public Nullable<double> IncentiveAmount { get; set; }
    }
}