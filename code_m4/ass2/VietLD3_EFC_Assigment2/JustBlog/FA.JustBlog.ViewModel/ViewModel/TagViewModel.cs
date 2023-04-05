namespace FA.JustBlog.ViewModel.ViewModel
{
    public class TagViewModel
    {
        public TagViewModel()
        {
            PostTagMapViewModels = new List<PostTagMapViewModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }

        public virtual IList<PostTagMapViewModel> PostTagMapViewModels { get; set; }


    }
}
