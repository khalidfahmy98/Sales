using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

namespace Sales.Models
{
    public class EmpListModel
    {
        public ManEmp manEmp { get; set; }
        public Customers customers { get; set; }
        public EmpList emplist { get; set; }

    }
}