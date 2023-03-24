using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Core.Models
{
    public class Tag
    {
        public Tag()
        {
            Posts = new List<Post>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string UrlSlug { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int Count { get; set; }

        public IList<Post> Posts { get; set; }


    }
}
