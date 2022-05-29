using DAL.Entity;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.RepositoriesInterfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> Get(QueryParams queryParams);
        Task<Product> Get(Guid id);
        Task<Product> Create(Product article);
        Task<Product> Update(Product article);
        Task Delete(Product article);
    }
}
