using FA.BookStore.Core.Common;
using FA.BookStore.Core.Repository.UnitOfWork;

namespace FA.BookStore.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*using (var uow = new UnitOfWork())
            {
                var categories = uow.Category.GetAll();
                categories.ToList().ForEach(x => Console.WriteLine($"{x.CategoryId}, {x.CategoryName}"));
            }*/
            while(true)
            {
                Console.WriteLine(SeoUrlHepler.FrientlyUrl(Console.ReadLine()));
            }
        }
    }
}