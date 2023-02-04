internal class Program
{
    static void Main(string[] args)
    {
        int n = GetPositiveInteger("Input n: "); // nhập n
        int[] numbers =  new int[n]; 
        for (int i = 0; i < n; i++)
        {
            numbers[i] = GetInt($"arr[{i}]: "); // nhập dữ liệu vào mảng
        }
        foreach (int number in numbers)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " is NOT a prime number");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false; // nhỏ hơn 1 ko phải số nguyên tố
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; // Chia hết cho số khác ngoài 1 và chính nó thì ko phải số nguyên tố
            }
        }
        return true;
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

            return GetPositiveInteger(mess); // dùng đệ quy
        }
        return a;
    }
}