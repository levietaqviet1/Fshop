using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercise2();
    }

    /// <summary>
    /// Exercise2 
    /// </summary>
    public static void Exercise2()
    {
        string input = InputString("Input Email: ");
        Console.WriteLine($"{input} is {CheckFormatEmail(input)}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static string InputString(string message)
    {
        Console.Write(message);
        return Console.ReadLine().Trim(); // xóa khoảng trắng thừa đầu và cuỗi chuỗi
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool CheckFormatEmail(string email)
    {
        // ^[a-zA-Z0-9]+   Ký từ đầu từ a đến z hoặc A đến Z hoặc 0 đến 9 còn dấu + là có thể lặp lại 1 hoặc nhiều lần
        // ?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+   một hoặc nhiều ký tự [a-zA-Z0-9!#$%&'*+/=?^_`{|}~-] được cho phép trong phần sau dấu chấm
        return Regex.IsMatch(email,
         @"^[a-zA-Z0-9]+[a-zA-Z0-9-]*@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*\.[a-zA-Z]{2,}$");

    }
}