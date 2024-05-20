using System;
using System.ComponentModel.DataAnnotations;

namespace Product.Domain.Model
{
	public class Category
	{
        [Key]
        public int CategoryId { get; set; }
        public string CategoryNameEN { get; set; }
        public string CategoryNameTH { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

