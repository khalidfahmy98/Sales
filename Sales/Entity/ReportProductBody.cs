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
    
    public partial class ReportProductBody
    {
        public int Id { get; set; }
        public Nullable<int> ReportHeaderId { get; set; }
        public Nullable<int> ReportCustomerBodyId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual ReportCustomerBody ReportCustomerBody { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }
    }
}