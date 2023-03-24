namespace FA.BookStore.Core.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public string Summary { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public Category Category { get; set; }
        public Publisher Publisher { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
