namespace EF6_Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using EF6_Database.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EF6_Database.Context.ProductsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF6_Database.Context.ProductsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(
                p => p.ProductId,
                new Product { ProductId = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1, Content = "テストで1件目のデータを投入してみた。" },
                new Product { ProductId = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M, Content = "テストで2件目のデータを投入してみた。" },
                new Product { ProductId = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M, Content = "テストで3件目のデータを投入してみた。" }
            );

            context.SaveChanges();
            base.Seed(context);
        } // Seed
    } // end of
}
