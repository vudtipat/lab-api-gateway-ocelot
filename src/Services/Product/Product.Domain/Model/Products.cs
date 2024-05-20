using System;
using System.ComponentModel.DataAnnotations;

namespace Product.Domain.Model
{
	public class Products
	{
		[Key]
		public string ProductId { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public string CategoryId { get; set; }
		public Double Price { get; set; }
		public int InventoryCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

