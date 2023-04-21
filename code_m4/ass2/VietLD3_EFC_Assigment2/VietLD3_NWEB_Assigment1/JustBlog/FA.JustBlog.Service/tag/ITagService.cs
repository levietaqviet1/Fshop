using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.tag
{
    public interface ITagService
    {
        public ResponseResult<TagViewModel> GetAll();
        public ResponseResult<TagViewModel> GetById(int id);
        public ResponseResult<TagViewModel> GetByUrl(string urlSlug);
        public ResponseResult<TagViewModel> Add(TagViewModel tagViewModel);
        public ResponseResult<TagViewModel> Update(TagViewModel tagViewModel);
        public ResponseResult<TagViewModel> Delete(int id);
    }
}
