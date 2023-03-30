using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories;
using FA.JustBlog.Core.Repositories.Impl;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            IPostRepository postRepository = new PostRepository();
            List<Post> posts = postRepository.GetAll().ToList();
            return View(posts);
        }
    }
}
