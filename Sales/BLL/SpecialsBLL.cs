using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class SpecialsBLL
    {
        public static IQueryable<Specials> List() => DataService.Specials.List();

        public static Specials Get(int Id) => DataService.Specials.Get(Id);

        public static int Add(Specials Model) => DataService.Specials.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Specials Model) => DataService.Specials.Update(Model);

        public static bool Delete(int Id) => DataService.Specials.Delete(Id);
    }
}
