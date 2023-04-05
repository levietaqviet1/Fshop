namespace FA.JustBlog.Core.Models
{
    public class Comment
    {
        public Comment()
        {
        }

        public Comment(string name, string email, string commentHeader, string commentText, int postId)
        {
            Name = name;
            Email = email;
            CommentHeader = commentHeader;
            CommentText = commentText;
            CommentTime = DateTime.Now;
            PostId = postId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CommentHeader { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
        public int UsingIdentityUserId { get; set; }
        public UsingIdentityUser UsingIdentityUser;

    }
}
