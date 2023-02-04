internal class Program
{
    static double EvaluatePolynomial(double x)
    {
        return 2 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 2 * x - 1; // trả ra kết quả
    }

    static void Main(string[] args)
    {
        Ex1();
    }
    public static void Ex1()
    {
        double x = GetDouble("Input x: "); // nhập x
        double y = EvaluatePolynomial(x); // gọi hàm EvaluatePolynomial
        Console.WriteLine($"At x = {x}, y = {y}");
    }
    public static double GetDouble(string mess)
    {
        double a = 0;
        try
        {
            Console.Write(mess);
            a = double.Parse(Console.ReadLine()); // dùng Console.ReadLine() để nhập chữ sau đó dùng int.Parse để ép kiểu sang int
        }
        catch (Exception)
        {

            return GetDouble(mess); // dùng đệ quy
        }
        return a;
    }
}