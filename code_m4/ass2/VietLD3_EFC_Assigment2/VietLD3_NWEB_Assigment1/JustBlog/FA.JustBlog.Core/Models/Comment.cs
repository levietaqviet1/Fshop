namespace FA.JustBlog.Core.Models
{
    public class Comment
    {
        public Comment()
        {
        }

        public Comment(string commentHeader, string commentText, int postId, string usingIdentityUserId)
        {
            CommentHeader = commentHeader;
            CommentText = commentText;
            PostId = postId;
            this.UsingIdentityUserId = usingIdentityUserId;
        }

        public int Id { get; set; }
        public string CommentHeader { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }


        public int PostId { get; set; }
        public Post Post { get; set; }

        public string? UsingIdentityUserId { get; set; }

        public UsingIdentityUser? UsingIdentityUser;

    }
}
