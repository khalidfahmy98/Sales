using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class CustomersBLL
    {
        public static IQueryable<Customers> List() => DataService.Customers.List();
        public static Customers Get(int Id) => DataService.Customers.Get(Id);

        public static int Add(Customers Model)
        {
            Customers user = new Customers();
            user = List().Where(e => e.Phone == Model.Phone || e.MobileP == Model.MobileP || e.MobileS == Model.MobileS).FirstOrDefault();
            if (user == null)
            {
                return DataService.Customers.Create(Model).Id;
            }
            else
            {
                return (0);
            }
        }

        public static int Count() => List().Count();

        public static bool Edit(Customers Model) => DataService.Customers.Update(Model);
        public static bool Delete(int Id) => DataService.Customers.Delete(Id);

    }
}
