using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Model
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AddressId { set; get; }
        public Guid CustomerId { set; get; }
        public string AddressLine1 { set; get; }
        public string AddressLine2 { set; get; }
        public int SubDistrict { set; get; }
        public int District { set; get; }
        public int Province { set; get; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}