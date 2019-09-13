using DeliveryServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeliveryServer.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("name=ExpensesDB")
        {

        }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<User> Users { get; set; }
    }
}