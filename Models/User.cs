
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Display(Name = "First Name:")]
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name:")]
        [Required]
        [MinLength(4)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(18, 122, ErrorMessage = "Must be at least 18 years old.")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
    }

}
