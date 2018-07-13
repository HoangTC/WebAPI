using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPI2.Models;

namespace WebAPI2.DAL
{
    public class ApiContext : DbContext
    {
        public ApiContext() : base("ApiContext")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}