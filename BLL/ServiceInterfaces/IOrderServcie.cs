using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IOrderServcie
    {
        Task<IEnumerable<OrderModel>> Get();
        Task<OrderModel> Get(Guid id);
        Task<OrderModel> Create(OrderModel orderModel);
        Task<OrderModel> Update(OrderModel orderModel);
        Task Delete(Guid id);
    }
}