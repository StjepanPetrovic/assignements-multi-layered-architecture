using Entity_layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_layer.Repositories
{
    public abstract class Repository<T> : IDisposable where T : class
    {
        protected AssignementsModel Context { get; set; }

        protected DbSet<T> Entities { get; set; }

        public Repository(AssignementsModel context)
        {
            Context = context;
            Entities = Context.Set<T>();
        }

        public virtual void Dispose()
        {
            Context.Dispose();
        }

        public virtual IQueryable<T> GetAll()
        {
            var query = from x in Entities
                        select x;
            return query;
        }

        public virtual int Add(T entity, bool saveChanges = true)
        {
            Entities.Add(entity);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public abstract int Update(T entity, bool saveChanges = true);

        public virtual int Remove(T entity, bool saveChanges = true)
        {
            Entities.Attach(entity);
            Entities.Remove(entity);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public virtual int SaveChanges()
        {
            return Context.SaveChanges();
        }
    }
}
