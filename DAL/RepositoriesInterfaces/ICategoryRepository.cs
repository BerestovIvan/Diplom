using DAL.Entity;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.RepositoriesInterfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> Get();
        Task<Category> Get(Guid id);
        Task<Category> Get(string title);
        Task<Category> Create(Category category);
        Task<Category> Update(Category category);
        Task Delete(Category category);
    }
}
