using FA.JustBlog.Core.Models;

namespace FA.JustBlog.ViewModel.ViewModel
{
    public class CommentViewModel
    {
        public CommentViewModel()
        {
        }


        public int Id { get; set; }
        public string CommentHeader { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }

        public int PostId { get; set; }
        public PostViewModel Post { get; set; }
        public string UsingIdentityUserId { get; set; }
        public UsingIdentityUser UsingIdentityUser;

    }
}
