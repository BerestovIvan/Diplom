using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface ISubcategoryServcie
    {
        Task<IEnumerable<SubcategoryModel>> Get();
        Task<SubcategoryModel> Get(Guid id);
        Task<SubcategoryModel> Create(SubcategoryModel subcategoryModel);
        Task<SubcategoryModel> Update(SubcategoryModel subcategoryModel);
        Task Delete(Guid id);
    }
}
