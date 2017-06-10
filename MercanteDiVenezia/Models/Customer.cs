using System.ComponentModel.DataAnnotations;

namespace MercanteDiVenezia.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string HomeNumber { get; set; }
    }
}
