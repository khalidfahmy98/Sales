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
    
    public partial class CustomerBridgeGrade
    {
        public int Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> GradeId { get; set; }
        public Nullable<int> ManEmpId { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Leader { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Grades Grades { get; set; }
        public virtual ManEmp ManEmp { get; set; }
    }
}
