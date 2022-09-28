using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ReportHeaderBLL
    {
        public static IQueryable<ReportHeader> List() => DataService.ReportHeader.List();

        public static ReportHeader Get(int Id) => DataService.ReportHeader.Get(Id);

        public static int Add(ReportHeader Model) => DataService.ReportHeader.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(ReportHeader Model) => DataService.ReportHeader.Update(Model);

        public static bool Delete(int Id) => DataService.ReportHeader.Delete(Id);

    }
}
