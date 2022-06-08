using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ColorsBLL
    {
        public static IQueryable<Colors> List() => DataService.Colors.List();

        public static Colors Get(int Id) => DataService.Colors.Get(Id);

        public static int Add(Colors Model) => DataService.Colors.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Colors Model) => DataService.Colors.Update(Model);

        public static bool Delete(int Id) => DataService.Colors.Delete(Id);

    }
}
