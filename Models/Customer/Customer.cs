using System;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace KafkaModels.Models.Customer
{
    public class Customer
    {
        //[BsonId]
        public dynamic CustomerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Billing Address")]
        public Address BillingAddress { get; set; }

        [Required]
        [Display(Name = "Shipping Address")]
        public Address ShippingAddress { get; set; }

        public int? Age { get; set; }
    }
}
