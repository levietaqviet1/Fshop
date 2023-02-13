using NPLC.Assignment5.Exercise2;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercise2();
    }

    public static void Exercise2()
    {
        // truyền dữ liệu
        int[] intArray = new int[] { 1, 2, 3, 3, 5, 6, 5, 2 };
        // mảng mới nhận dữ liệu sau khi gọi hàm RemoveDuplicate
        int[] distinctIntArray = intArray.RemoveDuplicate();
        // in ra
        distinctIntArray.Printf();
        Console.WriteLine();
        // truyền dữ liệu
        string[] stringArray = new string[] { "Hung", "Vu", "Van", "Hung", "Quang", "Huy", "Vu" };
        // mảng mới nhận dữ liệu sau khi gọi hàm RemoveDuplicate
        string[] distinctStringArray = stringArray.RemoveDuplicate();
        // in ra
        distinctStringArray.Printf();
    }
}