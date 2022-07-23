using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
    public class VisitReportsBLL
    {
        public static IQueryable<VisitReports> List() => DataService.VisitReports.List();

        public static VisitReports Get(int Id) => DataService.VisitReports.Get(Id);

        public static int Add(VisitReports Model) => DataService.VisitReports.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(VisitReports Model) => DataService.VisitReports.Update(Model);

        public static bool Delete(int Id) => DataService.VisitReports.Delete(Id);

    }
}
