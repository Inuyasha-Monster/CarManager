using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace CarManager.Data
{
    public class CarDbContext : DbContext, IDbContext
    {
        private static readonly string ConnectionStringOrName = "carConnectionstring";

        static CarDbContext()
        {
            Database.SetInitializer<CarDbContext>(new CreateDatabaseIfNotExists<CarDbContext>());
        }

        public CarDbContext() : base(ConnectionStringOrName)
        {

        }

        public int ExcetueSqlCommand(string sql, params object[] paramters)
        {
            return base.Database.ExecuteSqlCommand(sql, paramters);
        }

        public int SaveChange()
        {
            return base.SaveChanges();
        }

        IDbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
