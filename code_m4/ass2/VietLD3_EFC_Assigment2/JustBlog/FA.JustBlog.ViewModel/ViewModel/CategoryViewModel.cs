namespace FA.JustBlog.ViewModel.ViewModel
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            PostViewModels = new List<PostViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public virtual IList<PostViewModel> PostViewModels { get; set; }
    }
}
