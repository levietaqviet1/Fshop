internal class Program
{
    static void Main(string[] args)
    {
        Ex2();
    }
    public static void Ex2()
    {
        int n = GetPositiveInteger("Input n: "); 
        double[] coefficients = new double[n+1];
        for (int i = 0; i <= n; i++)
        {
            coefficients[i] = GetDouble($"Input x{i}: ");
        }
       
        double x = GetDouble("\nInput x: "); // nhập x
        double y = EvaluatePolynomial(coefficients, x); // gọi hàm và truyền dữ liệu xuống để tính toán
        Console.WriteLine("At x = {0}, y = {1}", x, y); // in kết quả
    }
    static double EvaluatePolynomial(double[] coefficients, double x)
    {
        int n = coefficients.Length - 1;
        double result = coefficients[n];
        for (int i = n - 1; i >= 0; i--)
        {
            result = result * x + coefficients[i]; // tính
        }
        return result;
    }
    public static int GetPositiveInteger(string mess)
    {
        int a = 0;
        try
        {
            Console.Write(mess);
            a = int.Parse(Console.ReadLine()); // dùng Console.ReadLine() để nhập chữ sau đó dùng int.Parse để ép kiểu sang int
            if (a <= 0)
            {
                throw new Exception();
            }
        }
        catch (Exception)
        {

            return GetPositiveInteger(mess); // dùng đệ quy
        }
        return a;
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