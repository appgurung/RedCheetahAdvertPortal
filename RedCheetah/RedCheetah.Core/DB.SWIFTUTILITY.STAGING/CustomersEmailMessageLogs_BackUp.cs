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
    
    public partial class CustomersEmailMessageLogs_BackUp
    {
        public int EmailID { get; set; }
        public Nullable<int> i_customer { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> Send_Date { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Sent_Date { get; set; }
        public string eReceiptNo { get; set; }
        public string ErrorMessage { get; set; }
        public string FileName { get; set; }
        public string BatchNo { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string MailFrom { get; set; }
    }
}
