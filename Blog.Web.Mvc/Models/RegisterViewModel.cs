using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Mvc.Models
{
    public class RegisterViewModel

    {
        [Display(Name="Name",Prompt ="Name")]
        [MaxLength(100,ErrorMessage = "{0} must be shorter than {1} characters.")]
        public string? Name { get; set; }

        [Display(Name = "Email", Prompt = "name@example.com")]
        [MaxLength(200, ErrorMessage = "{0} must be shorter than {1} characters.")]
        public string? Email { get; set; }

        [Display(Name = "City", Prompt = "City")]
        [MaxLength(100, ErrorMessage = "{0} must be shorter than {1} characters.")]
        public string? City { get; set; }

        [Display(Name = "Password", Prompt = "Password")]
        [MaxLength(100, ErrorMessage = "{0} must be shorter than {1} characters.")]
        public string? Password { get; set; }

        [Display(Name = "Phone", Prompt = "05XX XXX XX XX")]
        [MaxLength(100, ErrorMessage = "{0} must be shorter than 20 characters.")]
        public string? Phone { get; set; }
    }

}
