using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class GradesBLL
    {
        public static IQueryable<Grades> List() => DataService.Grades.List();

        public static Grades Get(int Id) => DataService.Grades.Get(Id);

        public static int Add(Grades Model) => DataService.Grades.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Grades Model) => DataService.Grades.Update(Model);

        public static bool Delete(int Id) => DataService.Grades.Delete(Id);

    }
}
