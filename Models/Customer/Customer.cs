namespace KafkaModels.Models.Customer
{
    public class Customer
    {
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Email { get; set; }

        public Address BillingAddress { get; set; }

        public Address ShippingAddress { get; set; }
    }
}
