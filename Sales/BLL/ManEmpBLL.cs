using Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManEmpBLL
    {
        public static IQueryable<ManEmp> List() => DataService.ManEmp.List();
        public static ManEmp Login(String Username, String Password)
        {
            ManEmp User = new ManEmp();
            User = List().Where(e => e.Username == Username && e.Password == Password).FirstOrDefault();
            if (User != null)
            {
                return (User);
            }
            return null;
        }
        public static ManEmp Get(int Id)
        {
            return DataService.ManEmp.Get(Id);
        }

        public static int Add(ManEmp Model)
        {
            ManEmp user = new ManEmp();
            user = List().Where(e => e.Username == Model.Username || e.NationalId == Model.NationalId || e.Phone == Model.Phone).FirstOrDefault();
            if (user == null)
            {
                return DataService.ManEmp.Create(Model).Id;
            }
            else
            {
                return (0);
            }
        }

        public static int Count() => List().Count();

        public static bool Edit(ManEmp Model)
        {
            ManEmp user = new ManEmp();
            user = List().Where(e => e.Username == Model.Username && e.Id != Model.Id).FirstOrDefault();
            if (user == null)
            {
                return DataService.ManEmp.Update(Model);
            }
            return false;
        }

        public static bool Delete(int Id) => DataService.ManEmp.Delete(Id);

    }
}
