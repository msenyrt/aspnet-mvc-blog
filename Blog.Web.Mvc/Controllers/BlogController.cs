using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Mvc.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query, int page)
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
