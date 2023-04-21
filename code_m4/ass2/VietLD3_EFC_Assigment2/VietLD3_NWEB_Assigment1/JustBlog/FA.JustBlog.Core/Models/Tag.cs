namespace FA.JustBlog.Core.Models
{
    public class Tag
    {
        public Tag()
        {
            PostTagMaps = new List<PostTagMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }

        public virtual IList<PostTagMap> PostTagMaps { get; set; }


    }
}
