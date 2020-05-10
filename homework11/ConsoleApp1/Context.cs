using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ConsoleApp1
{
    class Context:DbContext
    {
        public Context():base("OrderDataBase")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
