using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.category
{
    public interface ICategoryService
    {
        public ResponseResult<CategoryViewModel> GetAll();
        public ResponseResult<CategoryViewModel> GetById(int id);
        public ResponseResult<CategoryViewModel> Add(CategoryViewModel categoryViewModel);
        public ResponseResult<CategoryViewModel> Update(CategoryViewModel categoryViewModel);
        public ResponseResult<CategoryViewModel> Delete(int id);
    }
}
