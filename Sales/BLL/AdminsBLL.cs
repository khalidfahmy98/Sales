using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
    public class AdminsBLL
    {
        //    public static IQueryable<Admins> List() => DataService.Admins.List();
        //    public static Admins Login(String Username , String Password )
        //    {
        //        Admins admin = new Admins();
        //        admin = List().Where(e => e.Username == Username && e.Password == Password).FirstOrDefault();
        //        if ( admin != null)
        //        {
        //            return (admin);
        //        }
        //        return null;
        //    } 
        //    public static Admins Get(int Id)
        //    {
        //        return DataService.Admins.Get(Id);
        //    }

        //    public static int Add(Admins Model)
        //    {
        //        Admins admin = new Admins();
        //        admin = List().Where(e => e.Username == Model.Username ).FirstOrDefault();
        //        if ( admin == null)
        //        {
        //            return DataService.Admins.Create(Model).Id;
        //        }
        //        else
        //        {
        //            return (0);
        //        }
        //    }

        //    public static int Count() => List().Count();

        //    public static bool Edit(Admins Model)
        //    {
        //        Admins admin = new Admins();
        //        admin = List().Where(e => e.Username == Model.Username && e.Id != Model.Id).FirstOrDefault();
        //        if( admin == null )
        //        {
        //            return DataService.Admins.Update(Model);
        //        }
        //        return false;
        //    }

        //    public static bool Delete(int Id) => DataService.Admins.Delete(Id);

        //}
    }
}