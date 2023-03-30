namespace FA.JustBlog.Core.Models
{
    public class Category
    {
        public Category()
        {
            Posts = new List<Post>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public virtual IList<Post> Posts { get; set; }
    }
}
