using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Mvc.Models
{
    public class ResetViewModel
    {
        [Display(Name = "Email", Prompt = "name@example.com"),
         Required(ErrorMessage = "{0} required.")]
        public string Email { get; set; }

    }
}
