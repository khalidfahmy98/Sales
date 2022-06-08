using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
   public class DataService
    {
        public static GenericDAL<ManEmp> ManEmp = new GenericDAL<ManEmp>();
        public static GenericDAL<Products> Products = new GenericDAL<Products>();
        public static GenericDAL<Colors> Colors = new GenericDAL<Colors>();
    }
}
