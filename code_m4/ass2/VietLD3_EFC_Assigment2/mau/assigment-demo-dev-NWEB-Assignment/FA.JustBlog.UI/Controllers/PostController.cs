using FA.JustBlog.Repository.Infrastructures;
using FA.JustBlog.Service.post;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.UI.Controllers
{
	[Route("Post/{action}")]	
	public class PostController : Controller
	{
		private readonly IPostService PostService;
		public PostController(IPostService postService)
		{
			this.PostService = postService;
		}

		[Route("")]
		public IActionResult Index()
		{
			var result = PostService.GetAll();
			return View(result.DataList);
		}
	}
}
