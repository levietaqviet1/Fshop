using FA.JustBlog.ViewModel;
using FA.JustBlog.ViewModel.ViewModel;

namespace FA.JustBlog.Service.comment
{
    public interface ICommentService
    {
        public ResponseResult<CommentViewModel> GetAll();
        public ResponseResult<CommentViewModel> GetById(int id);
        public ResponseResult<CommentViewModel> Add(CommentViewModel commentViewModel);
        public ResponseResult<CommentViewModel> Update(CommentViewModel commentViewModel);
        public ResponseResult<CommentViewModel> Delete(int id);
    }
}
