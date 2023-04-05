using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.category
{
    public interface ICategoryService
    {
        public ResponseResult<CategoryViewModel> GetAll();
    }
}
