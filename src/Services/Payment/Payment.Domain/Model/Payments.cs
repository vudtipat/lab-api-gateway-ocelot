using System;
using System.ComponentModel.DataAnnotations;

namespace Payment.Domain.Model
{
	public class Payments
	{
		[Key]
		public string PaymentId { set; get; }
        public string OrderId { set; get; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public Double TotalAmount { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

