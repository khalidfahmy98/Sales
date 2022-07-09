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
        public static GenericDAL<Customers> Customers = new GenericDAL<Customers>();
        public static GenericDAL<Products> Products = new GenericDAL<Products>();
        public static GenericDAL<Colors> Colors = new GenericDAL<Colors>();
        public static GenericDAL<Types> Types = new GenericDAL<Types>();
        public static GenericDAL<Grades> Grades = new GenericDAL<Grades>();
        public static GenericDAL<Areas> Areas = new GenericDAL<Areas>();
        public static GenericDAL<Specials> Specials = new GenericDAL<Specials>();
        public static GenericDAL<CusWork> CusWork = new GenericDAL<CusWork>();
        public static GenericDAL<CustomerBridgeGrade> CustomerBridgeGrade = new GenericDAL<CustomerBridgeGrade>();
        public static GenericDAL<Scheduale> Scheduale = new GenericDAL<Scheduale>();
        public static GenericDAL<EmpList> EmpList = new GenericDAL<EmpList>();
        public static GenericDAL<VacationTypes> VacationTypes = new GenericDAL<VacationTypes>();
        public static GenericDAL<Vacations> Vacations = new GenericDAL<Vacations>();
    }
}