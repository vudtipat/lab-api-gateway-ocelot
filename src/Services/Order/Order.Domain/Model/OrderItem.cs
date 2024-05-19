using System;
using Order.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Order.Domain.Model
{
	public class OrderItem
	{
        [Key]
        public string OrderItemId { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public Double UnitPrice { get; set; }
        public Double TotalAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

