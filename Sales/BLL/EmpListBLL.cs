using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class EmpListBLL
    {
        public static IQueryable<EmpList> List() => DataService.EmpList.List();

        public static EmpList Get(int Id) => DataService.EmpList.Get(Id);

        public static int Add(EmpList Model) => DataService.EmpList.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(EmpList Model) => DataService.EmpList.Update(Model);

        public static bool Delete(int Id) => DataService.EmpList.Delete(Id);

    }
}
