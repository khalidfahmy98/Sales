using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class VacationTypesBLL
    {
        public static IQueryable<VacationTypes> List() => DataService.VacationTypes.List();

        public static VacationTypes Get(int Id) => DataService.VacationTypes.Get(Id);

        public static int Add(VacationTypes Model) => DataService.VacationTypes.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(VacationTypes Model) => DataService.VacationTypes.Update(Model);

        public static bool Delete(int Id) => DataService.VacationTypes.Delete(Id);

    }
}
