using ServerApp.Models;
using ServerApp.Models.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Data.EFCore
{
    public class ProductRepository : Repository<Product, AppDbContext>
    {
        AppDbContext _context;
        public ProductRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Product> GetRelated(long id)
        {
          
            Product result = await _context.Products
                .Include(p => p.Supplier).ThenInclude(s=> s.Products)
                .Include(p => p.Ratings)
                .FirstOrDefaultAsync(p => p.Id == id);

            //if (result !=null)
            //{
            //    if (result.Supplier !=null)
            //    {
            //        result.Supplier.Products = null;
            //    }

            //    if (result.Ratings!= null)
            //    {
            //        foreach (Rating r in result.Ratings)
            //        {
            //            r.Product = null;
            //        }
            //    }
            //}

            if (result != null)
            {
                if (result.Supplier != null)
                {
                    result.Supplier.Products = result.Supplier.Products.Select(p =>

                        new Product
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Category = p.Category,
                            Description = p.Description,
                            Price = p.Price,
                        });
                }
                if (result.Ratings != null)
                {
                    foreach (Rating r in result.Ratings)
                    {
                        r.Product = null;
                    }
                }
            }
            return result;
        }

        public async Task<List<Product>> GetAllRelated(bool related = false)
        {
            IQueryable<Product> query = _context.Products;
            if (related)
            {
                query = query.Include(p => p.Supplier).Include(p => p.Ratings);
                List<Product> data = await query.ToListAsync();
                data.ForEach(p => {
                    if (p.Supplier != null)
                    {
                        p.Supplier.Products = p.Supplier.Products.Select(p =>

                        new Product
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Category = p.Category,
                            Description = p.Description,
                            Price = p.Price,
                        });
                    }
                    if (p.Ratings != null)
                    {
                        p.Ratings.ForEach(r => r.Product = null);
                    }
                });
                return data;
            }
            else
            {
                return await query.ToListAsync();
            }
        }
    }
}
