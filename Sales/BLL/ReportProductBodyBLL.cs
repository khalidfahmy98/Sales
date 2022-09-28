using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ReportProductBodyBLL
    {
        public static IQueryable<ReportProductBody> List() => DataService.ReportProductBody.List();

        public static ReportProductBody Get(int Id) => DataService.ReportProductBody.Get(Id);

        public static int Add(ReportProductBody Model) => DataService.ReportProductBody.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(ReportProductBody Model) => DataService.ReportProductBody.Update(Model);

        public static bool Delete(int Id) => DataService.ReportProductBody.Delete(Id);
    }
}
