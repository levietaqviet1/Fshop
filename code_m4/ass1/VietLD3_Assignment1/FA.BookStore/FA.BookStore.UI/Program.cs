using FA.BookStore.Core.Repositories.UnitOfWork;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var uow = new UnitOfWork())
        {
            var categories = uow.CategoryRepository.GetAll();
            categories.ToList().ForEach(x => Console.WriteLine($"{x.CategoryId}, {x.CategoryName}"));
        }
    }
}