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
    
    public partial class Scheduale
    {
        public int Id { get; set; }
        public Nullable<int> ManEmpId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual ManEmp ManEmp { get; set; }
    }
}
