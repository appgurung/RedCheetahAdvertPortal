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
    
    public partial class AdPlan
    {
        public int AdPlanId { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public Nullable<int> NoVideosToPlay { get; set; }
        public Nullable<int> NoBannersToShow { get; set; }
        public Nullable<int> MinTimeBetweenAds { get; set; }
        public Nullable<int> MaxTimeBetwenAds { get; set; }
        public Nullable<int> MinDataConsumption { get; set; }
        public Nullable<int> MaxDataConsumption { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastModified { get; set; }
        public Nullable<bool> MarkedForDeletion { get; set; }
        public Nullable<System.DateTime> MarkedDeletedDate { get; set; }
    }
}
