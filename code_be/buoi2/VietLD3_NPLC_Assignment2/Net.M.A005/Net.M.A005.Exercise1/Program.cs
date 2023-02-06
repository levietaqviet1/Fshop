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
        Console.WriteLine($"Binary representation of {decimalNumber} is {binary}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mess"></param>
    /// <returns></returns>
    public static int GetInt(string mess)
    {
        int a = -1;
        do
        {
            try
            {
                Console.Write(mess);
                a = int.Parse(Console.ReadLine()); // dùng Console.ReadLine() để nhập chữ sau đó dùng int.Parse để ép kiểu sang int
                if (a >= 0)
                {
                    return a;
                }
                else
                {
                    a = -1;
                }
            }
            catch (Exception)
            {
            }

        } while (a == -1);

        return a;
    }


    //TODO: check
}