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
    
    public partial class coveragemap
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string SiteID { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Radius_Good { get; set; }
        public Nullable<double> Radius_Fair { get; set; }
        public Nullable<double> Radius_Poor { get; set; }
    }
}
