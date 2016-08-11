using CarManager.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace CarManager.Data
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext dbContext;

        private IDbSet<T> dbSet;

        protected IDbSet<T> DbSet
        {
            get
            {
                this.dbSet = this.dbSet ?? dbContext.Set<T>();
                return this.dbSet;
            }
        }

        public EfRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            this.DbSet.Remove(entity);
            this.dbContext.SaveChange();
        }



        public T GetById(object id)
        {
            return (T)this.DbSet.Find(id);
        }


        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            this.DbSet.Add(entity);
            this.dbContext.SaveChange();
        }


        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            this.dbContext.SaveChange();
        }

        public IQueryable<T> Table()
        {
            return this.DbSet;
        }
    }
}
