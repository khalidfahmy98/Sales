using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GenericDAL<T> where T : class
    {
        protected static SalesEntities entity ;

        public virtual T Create(T Model)
        {
            entity = new SalesEntities();
            entity.Set<T>().Add(Model);
            entity.SaveChanges();
            return Model;
        }
        public virtual bool Update(T Model)
        {
            entity = new SalesEntities();
            dynamic x = Model;
            var model = entity.Set<T>().Find(x.Id);
            entity.Entry(model).CurrentValues.SetValues(Model);
            entity.SaveChanges();
            return true;
        }
        public virtual IQueryable<T> List()
        {
            entity = new SalesEntities();
            var model = entity.Set<T>();
            return model;

        }

        public virtual T Get(int Id)
        {
            entity = new SalesEntities();
            var model = entity.Set<T>().Find(Id);
            return model;

        }

        public virtual bool Delete(int id)
        {
            try
            {
                entity = new SalesEntities();
                var model = entity.Set<T>().Find(id);
                entity.Set<T>().Remove(model);
                entity.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
