using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class CusWorkBLL
    {
        public static IQueryable<CusWork> List() => DataService.CusWork.List();

        public static CusWork Get(int Id) => DataService.CusWork.Get(Id);

        public static int Add(CusWork Model) => DataService.CusWork.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(CusWork Model) => DataService.CusWork.Update(Model);

        public static bool Delete(int Id) => DataService.CusWork.Delete(Id);

    }
}
