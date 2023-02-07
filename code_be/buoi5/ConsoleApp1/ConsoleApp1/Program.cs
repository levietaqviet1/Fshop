using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        ///s
        string a = "abc2fgb4sskmak5.1";
        string[] arr = Regex.Split(a,@"[a-zA-Z]+");
        foreach (var item in arr)
        {
            Console.WriteLine(item.Trim());
        }
    }
}