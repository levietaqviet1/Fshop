using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.post
{
    public interface IPostService
    {
        public ResponseResult<PostViewModel> GetAll();
        public ResponseResult<PostViewModel> GetById(int id);
        public ResponseResult<PostViewModel> GetByUrl(string urlSlug);
        public ResponseResult<PostViewModel> Add(PostViewModel postViewModel);
        public ResponseResult<PostViewModel> Update(PostViewModel postViewModel);
        public ResponseResult<PostViewModel> Delete(int id);
    }
}
