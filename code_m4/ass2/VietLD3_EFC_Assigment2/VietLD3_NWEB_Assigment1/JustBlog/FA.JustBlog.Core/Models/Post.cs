using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Core.Models
{
    public class Post
    {
        public Post()
        {
            PostTagMaps = new List<PostTagMap>();
        }


        public int Id { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(int.MaxValue)]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(int.MaxValue)]
        public string ShortDescription { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(int.MaxValue)]
        public string PostContent { get; set; }

        public string UrlSlug { get; set; }
        [DefaultValue(1)]
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }
        public int ViewCount { get; set; }
        public decimal RateCount { get; set; }
        public decimal TotalRate { get; set; }

        private decimal rate;

        public decimal Rate
        {
            get { return rate; }
            set { rate = value == null ? (RateCount / TotalRate == 0 ? 1 : TotalRate) : value; }
        }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual IList<PostTagMap> PostTagMaps { get; set; }
        public virtual IList<Comment> Comments { get; set; }

        public string UsingIdentityUserId { get; set; }
        public UsingIdentityUser UsingIdentityUser;


    }
}
