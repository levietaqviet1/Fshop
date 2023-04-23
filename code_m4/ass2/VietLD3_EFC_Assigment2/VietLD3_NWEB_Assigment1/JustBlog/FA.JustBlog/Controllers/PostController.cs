using FA.JustBlog.Service.comment;
using FA.JustBlog.Service.post;
using FA.JustBlog.Service.tag;
using FA.JustBlog.ViewModel.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FA.JustBlog.Controllers
{

    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly ITagService _tagService;
        private readonly ICommentService _commentService;

        public PostController(IPostService postService, ITagService tagService, ICommentService commentService)
        {
            _postService = postService;
            _tagService = tagService;
            _commentService = commentService;
        }


        // GET: PostController
        public ActionResult Index(string? tag, string? category)
        {
            IList<PostViewModel> listPost = _postService.GetAll(tag, category).DataList;
            ViewBag.MostViews = _postService.GetMostView(tag, category).DataList;
            ViewBag.LastPosts = listPost.Take(5).ToList();
            ViewBag.Tags = _tagService.GetAll().DataList;
            return View(listPost);
        }

        // GET: PostController/Details/5
        public ActionResult Details(string? post)
        {
            PostViewModel postViewModel = _postService.GetByUrl(post).Data ?? new PostViewModel();

            return View(postViewModel);
        }


        // GET: PostController/Create
        [Authorize]
        [HttpPost]
        public ActionResult CreateComment(CommentViewModel comment)
        {
            comment.UsingIdentityUserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            _commentService.Add(comment);
            return Redirect("/post/Details?post=" + comment.PostId);
        }

    }
}
