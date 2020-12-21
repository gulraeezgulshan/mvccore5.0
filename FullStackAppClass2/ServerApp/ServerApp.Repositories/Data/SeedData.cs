using Microsoft.EntityFrameworkCore;
using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerApp.Repositories.Data
{
    public class SeedData
    {
        public static void SeedDatabase(AppDbContext context)
        {
            context.Database.Migrate();
            if (context.Products.Count() == 0)
            {
                var s1 = new Supplier
                {
                    Name = "Arif Enterprise",
                    City = "Karachi",
                    State = "Sindh"
                };
                var s2 = new Supplier
                {
                    Name = "Suneel And Co.",
                    City = "Lahore",
                    State = "Punjab"
                };
                var s3 = new Supplier
                {
                    Name = "Dell and Well",
                    City = "Peshawar",
                    State = "KPK"
                };
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Product 1",
                        Description = "Description 1",
                        Category = "Shoe",
                        Price = 275,
                        Supplier = s1,
                        Ratings = new List<Rating>
                        {
                            new Rating { Stars = 4 }, 
                            new Rating { Stars = 3 }
                        }
                    },
                    new Product
                    {
                        Name = "Product 2",
                        Description = "Description 2",
                        Category = "Shoe",
                        Price = 48.95m,
                        Supplier = s1,
                        Ratings = new List<Rating>
                        {
                            new Rating { Stars = 2 }, 
                            new Rating { Stars = 5 }
                        }
                    },
                    new Product
                    {
                        Name = "Product 3",
                        Description = "Description 3",
                        Category = "Bag",
                        Price = 19.50m,
                        Supplier = s2,
                        Ratings = new List<Rating> 
                        {
                            new Rating { Stars = 1 }, 
                            new Rating { Stars = 3 }
                        }
                    },
                    new Product
                    {
                        Name = "Product 4",
                        Description = "Description 4",
                        Category = "Bag",
                        Price = 34.95m,
                        Supplier = s2,
                        Ratings = new List<Rating> 
                        { 
                            new Rating { Stars = 3 } 
                        }
                    },
                    new Product
                    {
                        Name = "Product 5",
                        Description = "Description 5",
                        Category = "Bag",
                        Price = 79500,
                        Supplier = s2,
                        Ratings = new List<Rating> 
                        { 
                            new Rating { Stars = 1 },
                            new Rating { Stars = 4 }, 
                            new Rating { Stars = 3 }
                        }
                    },
                    new Product
                    {
                        Name = "Product 6",
                        Description = "Description 6",
                        Category = "Jacket",
                        Price = 16,
                        Supplier = s3,
                        Ratings = new List<Rating> 
                        { 
                            new Rating { Stars = 5 },
                            new Rating { Stars = 4 }
                        }
                    },
                    new Product
                    {
                        Name = "Product 7",
                        Description = "Description 7",
                        Category = "Jacket",
                        Price = 29.95m,
                        Supplier = s3,
                        Ratings = new List<Rating> 
                        { 
                            new Rating { Stars = 3 } 
                        }
                    },
                    new Product
                    {
                        Name = "Product 8",
                        Description = "Description 8",
                        Category = "Jacket",
                        Price = 75,
                        Supplier = s3
                    },
                    new Product
                    {
                        Name = "Product 9",
                        Description = "Description 9",
                        Category = "Jacket",
                        Price = 1200,
                        Supplier = s3
                    });
                context.SaveChanges();
            }
        }
    }
}
