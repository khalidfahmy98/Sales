using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class StartingPointsBLL
    {
        public static IQueryable<StartingPoints> List() => DataService.StartingPoints.List();

        public static StartingPoints Get(int Id) => DataService.StartingPoints.Get(Id);

        public static int Add(StartingPoints Model) => DataService.StartingPoints.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(StartingPoints Model) => DataService.StartingPoints.Update(Model);

        public static bool Delete(int Id) => DataService.StartingPoints.Delete(Id);

    }
}
