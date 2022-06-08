using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class AreasBLL
    {
        public static IQueryable<Areas> List() => DataService.Areas.List();

        public static Areas Get(int Id) => DataService.Areas.Get(Id);

        public static int Add(Areas Model) => DataService.Areas.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Areas Model) => DataService.Areas.Update(Model);

        public static bool Delete(int Id) => DataService.Areas.Delete(Id);

    }
}
