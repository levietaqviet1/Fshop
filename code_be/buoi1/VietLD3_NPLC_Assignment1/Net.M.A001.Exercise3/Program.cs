using System;

internal class Program
{
    //private static void Main(string[] args)
    //{
    //    Exercise3();// gọi hàm Exercise3
    //}
    public static void Exercise3()
    {
        Console.WriteLine("Exercise3:");// hiện thị Exercise3
        Console.Write("Input n:"); // hiện thị báo nhập n
        int n = GetPositiveInteger("Input n: ");  
        int[] arr = new int[n]; // khái báo mảng
        for (int i = 0; i < n; i++)
        { 
            arr[i] = GetInt($"Input arr[{i}]: ");
        }
        Console.WriteLine($"Greatest common divisor of [{string.Join(", ", arr)}] is {GetGreatestCommonDivisorOfAnArray(arr)}");
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    static int GetGreatestCommonDivisorOf2Numbers(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    static int GetGreatestCommonDivisorOfAnArray(int[] arr)
    {
        int gcd = arr[0]; // tạo biến gcd có giá trị bằng giá trị đầu tiên của mảng
        for (int i = 1; i < arr.Length; i++)
        {
            gcd = GetGreatestCommonDivisorOf2Numbers(gcd, arr[i]); // tìm ước chung lần lượt qua từng phần tử...
        }
        return gcd;// trả về giá trị
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="mess"></param>
    /// <returns></returns>
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
    /// <summary>
    /// nhập số nguyên dương
    /// </summary>
    /// <param name="mess"></param>
    /// <returns></returns>
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

            return GetInt(mess); // dùng đệ quy
        }
        return a;
    }
}