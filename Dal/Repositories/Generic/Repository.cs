using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Model;

namespace Dal.Repositories.Generic
{
    public abstract class Repository<TEntity> : IDisposable where TEntity : BaseEntity, new()
    {
        protected readonly AppDbContext Context;

        protected Repository(AppDbContext context)
        {
            Context = context;
        }

        public TEntity GetByID(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }



        public void Add(TEntity item)
        {
            Context.Set<TEntity>().Add(item);
        }

        public void Update(TEntity item)
        {
            var entity = Context.Set<TEntity>().Find(item.Id);
            Context.Entry(entity).CurrentValues.SetValues(item);
            Context.Entry(entity).State = EntityState.Modified;


        }

        public void Delete(TEntity item)
        {
            var dbSet = Context.Set<TEntity>();
            if (Context.Entry(item).State == EntityState.Detached)
            {
                dbSet.Attach(item);
            }
            dbSet.Remove(item);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>();
        }


        public virtual IEnumerable<TEntity> GetAll(Func<TEntity, bool> condition)
        {
            return Context.Set<TEntity>()
                .Where(condition)
                .AsEnumerable();
        }


        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
