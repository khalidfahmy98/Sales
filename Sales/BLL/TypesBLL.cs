using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class TypesBLL
    {
        public static IQueryable<Types> List() => DataService.Types.List();

        public static Types Get(int Id) => DataService.Types.Get(Id);

        public static int Add(Types Model) => DataService.Types.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Types Model) => DataService.Types.Update(Model);

        public static bool Delete(int Id) => DataService.Types.Delete(Id);

    }
}
