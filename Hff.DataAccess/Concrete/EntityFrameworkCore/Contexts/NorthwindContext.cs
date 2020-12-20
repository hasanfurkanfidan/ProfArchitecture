using Hff.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3VB3SSC\\SQLEXPRESS01;Database=Northwind;Integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
