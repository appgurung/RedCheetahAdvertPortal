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
    
    public partial class KYCUpload
    {
        public int KYCID { get; set; }
        public int i_customer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DoB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string MiddleInitial { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Prof_Occupation { get; set; }
        public string Prof_Company { get; set; }
        public string Prof_CompanyAddress { get; set; }
        public string Prof_JobTitle { get; set; }
        public string Prof_Department { get; set; }
        public string Prof_Manager { get; set; }
        public string Prof_ManagerPhone { get; set; }
        public string Prof_Assistant { get; set; }
        public string Prof_AssistantPhone { get; set; }
        public string MaritalStatus { get; set; }
        public Nullable<System.DateTime> Anniversary { get; set; }
        public string SpouseName { get; set; }
        public string NextofKin { get; set; }
        public string NOK_Phone { get; set; }
        public string NOK_Address { get; set; }
        public string Primary_Contact { get; set; }
        public string Contact_Methods { get; set; }
        public string Identification_Number { get; set; }
        public string Monthly_Income { get; set; }
        public string Favourite_Internet_Activity { get; set; }
        public string Upload_Document_Server { get; set; }
        public string Upload_Document_Link1 { get; set; }
        public string Upload_Document_Link2 { get; set; }
        public Nullable<int> Uploaded { get; set; }
        public Nullable<System.DateTime> Date_Uploaded { get; set; }
        public string Approval_Comment { get; set; }
        public string Validated_Document_Link1 { get; set; }
        public string Validated_Document_Link2 { get; set; }
        public Nullable<System.DateTime> Date_Validated { get; set; }
        public Nullable<int> Validated { get; set; }
        public Nullable<int> ValidatedBy { get; set; }
        public Nullable<int> Rejected { get; set; }
        public string RejectReason { get; set; }
        public Nullable<System.DateTime> Date_Rejected { get; set; }
        public Nullable<int> RejectedBy { get; set; }
        public Nullable<int> CRMSuccess { get; set; }
        public Nullable<System.DateTime> CRMSuccess_Date { get; set; }
        public Nullable<int> BillingSuccess { get; set; }
        public Nullable<System.DateTime> BillingSuccess_Date { get; set; }
        public Nullable<int> Document1Success { get; set; }
        public Nullable<System.DateTime> Document1Success_Date { get; set; }
        public Nullable<int> Document2Success { get; set; }
        public Nullable<System.DateTime> Document2Success_Date { get; set; }
        public Nullable<int> Deleted { get; set; }
        public Nullable<System.DateTime> Date_Deleted { get; set; }
        public string Source { get; set; }
        public Nullable<int> Blocked { get; set; }
        public Nullable<System.DateTime> DateBlocked { get; set; }
        public Nullable<int> Unblocked { get; set; }
        public Nullable<System.DateTime> DateUnbloked { get; set; }
        public Nullable<int> Credited { get; set; }
        public Nullable<System.DateTime> DateCredited { get; set; }
        public Nullable<int> Paid { get; set; }
        public string Platform { get; set; }
        public string PlatformRef { get; set; }
        public Nullable<double> AmountPaid { get; set; }
        public Nullable<System.DateTime> DatePaid { get; set; }
        public Nullable<double> PromoAmount { get; set; }
        public string paymentUID { get; set; }
        public string R_paymentUID { get; set; }
        public Nullable<double> R_Amount { get; set; }
        public Nullable<int> R_Status { get; set; }
        public Nullable<System.DateTime> R_Date { get; set; }
        public Nullable<System.DateTime> FirstDate { get; set; }
    }
}
