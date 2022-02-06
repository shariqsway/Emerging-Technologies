using System.ComponentModel.DataAnnotations;

namespace CollegeBlazorApp.Server.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Applicant ID")]
        public string ApplicantId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}
