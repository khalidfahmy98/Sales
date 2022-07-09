using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class CustomerBridgeGradeBLL
    {
        public static IQueryable<CustomerBridgeGrade> List() => DataService.CustomerBridgeGrade.List();

        public static CustomerBridgeGrade Get(int Id) => DataService.CustomerBridgeGrade.Get(Id);

        public static int Add(CustomerBridgeGrade Model)
        {
            return DataService.CustomerBridgeGrade.Create(Model).Id;
        }

        public static int Count() => List().Count();

        public static bool Edit(CustomerBridgeGrade Model) => DataService.CustomerBridgeGrade.Update(Model);

        public static bool Delete(int Id) => DataService.CustomerBridgeGrade.Delete(Id);

    }
}
