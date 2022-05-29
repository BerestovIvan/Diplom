using BLL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public class CategoryService : ICategoryService
    {
        public Task<CategoryModel> Create(CategoryModel categoryModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> Update(CategoryModel categoryModel)
        {
            throw new NotImplementedException();
        }
    }
}
