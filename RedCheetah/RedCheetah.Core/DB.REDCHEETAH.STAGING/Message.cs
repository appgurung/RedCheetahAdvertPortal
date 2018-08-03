//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedCheetah.Core.DB.REDCHEETAH.STAGING
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int MessageId { get; set; }
        public int FromDeviceId { get; set; }
        public int ToDeviceId { get; set; }
        public int MessageType { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public string Parameter3 { get; set; }
        public string Parameter4 { get; set; }
        public string Parameter5 { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastModified { get; set; }
        public Nullable<bool> MarkedForDeletion { get; set; }
        public Nullable<System.DateTime> MarkedDeletedDate { get; set; }
    
        public virtual DeviceInfo DeviceInfo { get; set; }
    }
}
