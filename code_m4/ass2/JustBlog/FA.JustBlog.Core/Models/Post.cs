using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Core.Models
{
    public class Post
    {
        public Post()
        {
            Tags = new List<Tag>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string ShortDescription { get; set; }

        [StringLength(500)]
        public string PostContent { get; set; }

        [StringLength(255)]
        public string UrlSlug { get; set; }
        [Required]
        public DateTime Published { get; set; }
        [Required]
        public DateTime PostedOn { get; set; }

        [Required]
        public DateTime Modified { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }

        public IList<Tag> Tags { get; set; }

    }
}
