using System.ComponentModel.DataAnnotations;

namespace ValidFormSubmit.Models
{
    public class User
    {
        [Required(ErrorMessage="Please enter a first name.")]
        [MinLength(4, ErrorMessage="First name must be at least 4 characters.")]
        [Display(Name="First Name:")]
        public string FirstName {get; set;}
        [Required(ErrorMessage="Please enter a last name.")]
        [MinLength(4, ErrorMessage="Last name must be at least 4 characters.")]
        [Display(Name="Last Name:")]
        public string LastName {get; set;}
        [Required(ErrorMessage="Please enter an age.")]
        [Range(0,121, ErrorMessage="Please select an age between 0 and 120.")]
        [Display(Name="Age:")]
        public int Age {get; set;}
        [Required(ErrorMessage="Please enter a valid email address.")]
        [EmailAddress(ErrorMessage="Please enter a valid email address.")]
        [Display(Name="Email Address:")]
        public string Email {get; set;}
        [Required(ErrorMessage="Please enter a valid password")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters.")]
        [Display(Name="Password:")]
        [DataType(DataType.Password)]
        public string Password {get; set;}
    }
}