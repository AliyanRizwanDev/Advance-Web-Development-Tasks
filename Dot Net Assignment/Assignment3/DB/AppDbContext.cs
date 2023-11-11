using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Assignment3.Models;

namespace Assignment3.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=conn")
        {



        }
        public DbSet<Products> Products { get; set; }

        public static void SeedData(AppDbContext dbContext)
        {
            var products = new List<Products>
    {
        new Products
        {
            Id = 1,
            Code = 2565,
            Name = "ABC",
            Price = 200,
            Color = "Green",
            Dimension = "2x5x3",
            Description = "Etc",
            Brand = "Logo"
        },
        new Products
        {
            Id = 2,
            Code = 2566,
            Name = "EFG",
            Price = 250,
            Color = "Red",
            Dimension = "5x5x5",
            Description = "Etc",
            Brand = "Service"
        },
        new Products
        {
            Id = 3,
            Code = 2567,
            Name = "HIJ",
            Price = 275,
            Color = "Blue",
            Dimension = "4x5x3",
            Description = "Etc",
            Brand = "Bata"
        }
    };

            dbContext.Products.AddRange(products);
            dbContext.SaveChanges();
        }

    }

}