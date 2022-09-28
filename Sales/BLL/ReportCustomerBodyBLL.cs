using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ReportCustomerBodyBLL
    {
        public static IQueryable<ReportCustomerBody> List() => DataService.ReportCustomerBody.List();

        public static ReportCustomerBody Get(int Id) => DataService.ReportCustomerBody.Get(Id);

        public static int Add(ReportCustomerBody Model) => DataService.ReportCustomerBody.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(ReportCustomerBody Model) => DataService.ReportCustomerBody.Update(Model);

        public static bool Delete(int Id) => DataService.ReportCustomerBody.Delete(Id);

    }
}
