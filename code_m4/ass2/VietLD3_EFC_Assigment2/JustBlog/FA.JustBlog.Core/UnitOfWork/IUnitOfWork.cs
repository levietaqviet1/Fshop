namespace FA.JustBlog.Core.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
        ITagRepository TagRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICommentRepository CommentRepository { get; }
        void SaveChange();
    }
}
