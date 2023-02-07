using Net.M.A011.Exercise1;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book = new Book(1,"Net","Viet","Toan"); // truyền dữ liệu vào contructor
        Console.WriteLine(book.GetBookInformation()); // in dữ liệu của Book ra màn hình 
    }
}