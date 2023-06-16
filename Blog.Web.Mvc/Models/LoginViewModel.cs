using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Mvc.Models
{
    public class LoginViewModel
    {
        [Display(Name ="Email",Prompt ="name@example.com"), Required(ErrorMessage ="{0} required.")]
        public string Email { get; set; }

        [Display(Name = "Password", Prompt = "Password"), Required(ErrorMessage = "{0} required.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
