using DAL.DbContext;
using DAL.Entity;
using DAL.Models;
using DAL.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Product>> Get(QueryParams queryParams)
        {
            IQueryable<Product> articles = context.Products;



            return await articles.
                Include(x => x.Comments).
                Include(x => x.Creator).
                Include(x => x.SubcategoryId).
                AsNoTracking().ToListAsync();
        }

        public async Task<Product> Get(Guid id)
        {
            return await context.Products.
                Include(x => x.Comments).
                ThenInclude(q=>q.ApplicationUser).
                Include(x => x.Creator).
                Include(x => x.SubcategoryId).
                AsNoTracking().
                FirstOrDefaultAsync(product => product.Id == id);
        }

        public async Task<Product> Create(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> Update(Product product)
        {

            return product;
        }

        public async Task Delete(Product product)
        {

            await context.SaveChangesAsync();
        }
    }
}
