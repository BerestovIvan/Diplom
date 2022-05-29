using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RepositoriesInterfaces
{
    public interface ISubcategoryRepository
    {
        Task<IEnumerable<Subcategory>> Get();
        Task<Subcategory> Get(Guid id);
        Task<Subcategory> Get(string title);
        Task<Subcategory> Create(Subcategory subcategory);
        Task<Subcategory> Update(Subcategory subcategory);
        Task Delete(Subcategory subcategory);
    }
}
