using System.ComponentModel.DataAnnotations;

namespace KafkaModels.Models.Customer
{
    public class Customer
    {
        public int? CustomerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Billing Address")]
        public Address BillingAddress { get; set; }

        [Required]
        [Display(Name = "Shipping Address")]
        public Address ShippingAddress { get; set; }
    }
}
