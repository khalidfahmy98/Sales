//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class VisitReports
    {
        public int Id { get; set; }
        public Nullable<int> PlanId { get; set; }
        public string Report { get; set; }
    
        public virtual Scheduale Scheduale { get; set; }
    }
}
