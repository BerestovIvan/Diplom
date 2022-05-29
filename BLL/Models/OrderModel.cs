using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public DateTime OrderTime { get; set; }
        public string ApplicationUserId { get; set; }
        public UserModel UserModel { get; set; }
        public IEnumerable<OrderProductsModel> OrderProducts { get; set; }
    }
}