namespace FA.JustBlog.ViewModel.ViewModel
{
    public class PostViewModel
    {
        public PostViewModel()
        {
            PostTagMapsViewModel = new List<PostTagMapViewModel>();
        }


        public int Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }
        public string PostContent { get; set; }

        public string UrlSlug { get; set; }
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
            set { rate = value == null ? TotalRate == null ? 0 : TotalRate / RateCount == null ? 0 : RateCount : value; }
        }

        public int CategoryId { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }
        public virtual IList<PostTagMapViewModel> PostTagMapsViewModel { get; set; }
        public virtual IList<CommentViewModel> CommentViewModels { get; set; }

        //public int UsingIdentityUserId { get; set; }
        //public UsingIdentityUser UsingIdentityUser;


    }
}
