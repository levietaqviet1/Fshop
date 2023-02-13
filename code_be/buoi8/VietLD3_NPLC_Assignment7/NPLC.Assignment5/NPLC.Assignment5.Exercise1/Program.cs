using NPLC.Assignment5.Exercise1;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercise1();
    }

    /// <summary>
    /// Tạo hàm Exercise1
    /// </summary>
    public static void Exercise1()
    {
        ArrayList array = new ArrayList();
        array.Add("Hung");
        array.Add("Vu");
        array.Add(1);
        array.Add(2);
        array.Add("Van");
        array.Add(3.9d);

        int countInt = array.CountInt();
        Console.WriteLine("CountInt: " + countInt); // returns 2

        int countOfInt = array.CountOf(typeof(int));
        Console.WriteLine("CountOf(typeof(int)): " + countOfInt); // returns 2

        int countOfString = array.CountOf<string>();
        Console.WriteLine("CountOf<string>: " + countOfString); // returns 3

        try
        {
            int maxOfInt = array.MaxOf<int>();
            Console.WriteLine("MaxOf<int>: " + maxOfInt); // returns 2
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message); // in lỗi
        }
    }
}