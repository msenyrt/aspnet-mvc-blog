using Blog.Business.DtoData;
using Blog.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Mvc.Controllers
{
    public class BlogController : Controller
    {
        private readonly PostService _ps;

        public BlogController(PostService ps)
        {
            _ps = ps;
        }

        public IActionResult Search(string query = "s", int page = 1)
        {
            var posts = _ps.GetAll();

            var list = new List<PostDto>();

            foreach (PostDto post in posts)
            {
                if (post.Title.Contains(query))
                {
                    list.Add(post);
                }
            }

            ViewBag.Query = query;

            return View(list);
        }

        public IActionResult Detail(int id)
        {
            var post = _ps.GetById(id);
            if (post == null)
            {
                return RedirectToAction("index", "home");
            }
            return View(post);
        }
    }
}
