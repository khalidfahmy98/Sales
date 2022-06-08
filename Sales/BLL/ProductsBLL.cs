using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ProductsBLL
    {
        public static IQueryable<Products> List() => DataService.Products.List();

        public static Products Get(int Id) => DataService.Products.Get(Id);

        public static int Add(Products Model) => DataService.Products.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Products Model) => DataService.Products.Update(Model);

        public static bool Delete(int Id) => DataService.Products.Delete(Id);

    }
}
