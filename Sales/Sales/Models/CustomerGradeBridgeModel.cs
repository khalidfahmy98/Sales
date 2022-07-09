using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

namespace Sales.Models
{
    public class CustomerGradeBridgeModel
    {
        public ManEmp manEmp { get; set; }
        public Customers customers { get; set; }
        public Grades grades { get; set; }
        public CustomerBridgeGrade customerBridgeGrade { get; set; }

    }
}