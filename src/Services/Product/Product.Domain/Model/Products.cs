using System;
using System.ComponentModel.DataAnnotations;

namespace Product.Domain.Model
{
	public class Products
	{
		[Key]
		public int ProductId { get; set; }
		public string ProductNameEN { get; set; }
        public string ProductNameTH { get; set; }
        public string Description { get; set; }
		public int CategoryId { get; set; }
		public Double Price { get; set; }
		public int InventoryCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

