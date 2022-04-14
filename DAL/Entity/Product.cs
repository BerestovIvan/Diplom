using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Guid SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }
        public string CreatorId { get; set; }
        public ApplicationUser Creator { get; set; }
        public IEnumerable<OrderProducts> OrderProducts { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
