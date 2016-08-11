namespace CarManager.Data.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarManager.Data.CarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CarManager.Data.CarDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Set<Car>().AddOrUpdate(new Car()
            {
                Name = "宝马",
                Price = 1000000m
            }, new Car()
            {
                Name = "法拉利",
                Price = 10000000m
            }, new Car()
            {
                Name = "保时捷",
                Price = 10000m
            });
        }
    }
}
