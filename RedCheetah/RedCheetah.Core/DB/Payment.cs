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
    
    public partial class Payment
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string ApplicationId { get; set; }
        public string Gateway { get; set; }
        public string CustomerName { get; set; }
        public float Amount { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string ReturnedReference { get; set; }
        public string IPAddress { get; set; }
        public string ChargeTransID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public string TransactionID { get; set; }
        public Nullable<System.DateTime> ConfirmationDate { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> ConfirmCalled { get; set; }
        public string PaymentStep { get; set; }
        public int PaymentOption { get; set; }
        public string Card_Number { get; set; }
        public Nullable<double> Gateway_Returned_Amount { get; set; }
        public Nullable<int> PaymentStatus { get; set; }
    }
}
