using System;
using System.ComponentModel.DataAnnotations;
using Order.Domain.Enum;

namespace Order.Domain.Model
{
	public class Orders
	{
		[Key]
		public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus? Status { get; set; }
        public Double TotalAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

