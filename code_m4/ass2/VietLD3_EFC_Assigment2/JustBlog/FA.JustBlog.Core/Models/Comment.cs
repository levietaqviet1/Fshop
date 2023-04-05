namespace FA.JustBlog.Core.Models
{
    public class Comment
    {
        public Comment()
        {
        }

        public Comment(string commentHeader, string commentText, int postId, int usingIdentityUserId)
        {
            CommentHeader = commentHeader;
            CommentText = commentText;
            PostId = postId;
            UsingIdentityUserId = usingIdentityUserId;
        }

        public int Id { get; set; }
        public string CommentHeader { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
        public int UsingIdentityUserId { get; set; }
        public UsingIdentityUser UsingIdentityUser;

    }
}
