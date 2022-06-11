using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class SchedualeBLL
    {
        public static IQueryable<Scheduale> List() => DataService.Scheduale.List();

        public static Scheduale Get(int Id) => DataService.Scheduale.Get(Id);

        public static int Add(Scheduale Model) => DataService.Scheduale.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Scheduale Model) => DataService.Scheduale.Update(Model);

        public static bool Delete(int Id) => DataService.Scheduale.Delete(Id);

    }
}
