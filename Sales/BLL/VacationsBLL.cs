﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
    public class VacationsBLL
    {
        public static IQueryable<Vacations> List() => DataService.Vacations.List();

        public static Vacations Get(int Id) => DataService.Vacations.Get(Id);

        public static int Add(Vacations Model) => DataService.Vacations.Create(Model).Id;

        public static int Count() => List().Count();

        public static bool Edit(Vacations Model) => DataService.Vacations.Update(Model);

        public static bool Delete(int Id) => DataService.Vacations.Delete(Id);

    }
}
