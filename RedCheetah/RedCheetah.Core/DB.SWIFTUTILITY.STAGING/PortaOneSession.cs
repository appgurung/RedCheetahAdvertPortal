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
    
    public partial class PortaOneSession
    {
        public int SessionID { get; set; }
        public string Server { get; set; }
        public string Application { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Session { get; set; }
        public string ApiIp { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public Nullable<int> Offline { get; set; }
        public Nullable<System.DateTime> Deactive_Time { get; set; }
    }
}
