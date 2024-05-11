namespace Customer.Domain.Model
{
    public class Address
    {
        public int AddressId { set; get; }
        public string CustomerId { set; get; }
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