using FA.JustBlog.Core.Models;

namespace FA.JustBlog.ViewModel.ViewModel
{
    public class CommentViewModel
    {
        public CommentViewModel()
        {
        }

        public CommentViewModel(string name, string email, string commentHeader, string commentText, int postViewModelId)
        {
            Name = name;
            Email = email;
            CommentHeader = commentHeader;
            CommentText = commentText;
            CommentTime = DateTime.Now;
            PostViewModelId = postViewModelId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CommentHeader { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }

        public int PostViewModelId { get; set; }
        public PostViewModel PostViewModel { get; set; }
        public string UsingIdentityUserId { get; set; }
        public UsingIdentityUser UsingIdentityUser;

    }
}
