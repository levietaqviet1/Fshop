using FA.JustBlog.Core.Repositories.Impl;

namespace FA.JustBlog.Core.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
        ITagRepository TagRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICommentRepository CommentRepository { get; }
        IPostTagMapRepository PostTagMapRepository { get; }
        void SaveChange();
    }
}
