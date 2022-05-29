using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ImageModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public Guid ProductId { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
