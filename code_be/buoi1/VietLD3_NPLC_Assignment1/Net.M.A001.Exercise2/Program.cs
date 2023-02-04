internal class Program
{
    private static void Main(string[] args)
    {
        Exercise2(); // gọi hàm Exercise2
    }
    public static void Exercise2()
    {
        Console.WriteLine("Exercise2:");// hiện thị Exercise2
        int a = GetInt("Input a: "); 
        int b = GetInt("Input b: ");
        Console.WriteLine($"Greatest common divisor of {a} and {b} is {GetGreatestCommonDivisorOf2Numbers(a, b)}"); // hiện thị kết quả
    }
    /// <summary>
    /// Sử dụng đệ quy để tìm 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    static int GetGreatestCommonDivisorOf2Numbers(int a, int b)
    {
        return b == 0 ? a : GetGreatestCommonDivisorOf2Numbers(b, a % b);
    }

    public static int GetInt(string mess)
    {
        int a = 0;
        try
        {
            Console.Write(mess);
            a = int.Parse(Console.ReadLine()); // dùng Console.ReadLine() để nhập chữ sau đó dùng int.Parse để ép kiểu sang int
        }
        catch (Exception)
        {

            return GetInt(mess); // dùng đệ quy
        }
        return a;
    }
}