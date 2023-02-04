internal class Program
{
    static void Main(string[] args)
    {
        Ex2();
    }
    public static void Ex2()
    { 
        int n = GetPositiveInteger("Input n: "); // nhập n
        PrintListFibonacci(n);  // gọi hàm truyền n
    }   
    public static void PrintListFibonacci(int n)
    {
        int first = 1, second = 1, next;
        Console.WriteLine(first);
        Console.WriteLine(second);
        for (int i = 2; i < n; i++) // chạy từ 2 đến n-1
        {
            next = first + second; // số tiếp bằng tổng 2 số trước đó
            Console.WriteLine(next); // in số ra
            first = second; 
            second = next;
        } 
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
}