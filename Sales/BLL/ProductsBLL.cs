using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductsBLL
    {
        public static IQueryable<Categories> List() => DataService.Categories.List();

        public static Categories Get(int Id) => DataService.Categories.Get(Id);

        public static int Add(Categories Model) => DataService.Categories.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Categories Model) => DataService.Categories.Update(Model);

        public static bool Delete(int Id) => DataService.Categories.Delete(Id);

    }
}
