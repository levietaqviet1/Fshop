namespace FA.BookStore.Core.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int BookId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActice { get; set; }
        public Book Book { get; set; }
    }
}
