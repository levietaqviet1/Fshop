internal class Program
{
    static void Main(string[] args)
    {
        Ex1();
    }

    public static void Ex1()
    {
        int decimalNumber = GetInt("Input decimalNumber: "); // nhập số
        string binary = Convert.ToString(decimalNumber, 2); //chuyển đổi số nguyên decimalNumber thành chuỗi nhị phân (binary).
        Console.WriteLine("Binary representation of {0} is {1}", decimalNumber, binary);   
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