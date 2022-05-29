using DAL.DbContext;
using DAL.Entity;
using DAL.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SubcategoryRepository : ISubcategoryRepository
    {
        ApplicationDbContext context;
        public SubcategoryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Subcategory>> Get()
        {
            return await context.Subcategories.
                AsNoTracking().
                ToListAsync();
        }

        public async Task<Subcategory> Get(Guid id)
        {
            return await context.Subcategories.
                AsNoTracking().
                FirstOrDefaultAsync(subcategory => subcategory.Id == id);
        }

        public async Task<Subcategory> Create(Subcategory subcategory)
        {
            context.Subcategories.Add(subcategory);
            await context.SaveChangesAsync();
            return subcategory;
        }

        public async Task<Subcategory> Update(Subcategory subcategory)
        {
            context.Subcategories.Update(subcategory);
            await context.SaveChangesAsync();
            return subcategory;
        }

        public async Task Delete(Subcategory subcategory)
        {
            context.Subcategories.Remove(subcategory);
            await context.SaveChangesAsync();
        }

        public Task<Subcategory> Get(string title)
        {
            throw new NotImplementedException();
        }
    }
}
