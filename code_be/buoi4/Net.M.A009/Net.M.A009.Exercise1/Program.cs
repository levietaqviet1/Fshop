using System.Text.RegularExpressions;

internal class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Exercise1();
    }

    /// <summary>
    /// 
    /// </summary>
    public static void Exercise1()
    {
        string input = InputString("Input Name: ");
        Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
        input = trimmer.Replace(input, " ");
        string[] arr = input.Split(" ");
        input = "";
        foreach (string s in arr)
        {
            input += s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1).ToLower() + " ";
        }
        Console.WriteLine(input.Trim());
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
}