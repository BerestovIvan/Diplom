using BLL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> Get();
        Task<CategoryModel> Get(Guid id);
        Task<CategoryModel> Create(CategoryModel categoryModel);
        Task<CategoryModel> Update(CategoryModel categoryModel);
        Task Delete(Guid id);
    }   
}
