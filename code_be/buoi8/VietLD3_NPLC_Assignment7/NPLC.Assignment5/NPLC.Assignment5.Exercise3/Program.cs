using NPLC.Assignment5.Exercise3;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercise3();
    }

    public static void Exercise3()
    {
        // truyền dữ liệu
        int[] intArray = new int[] { 1, 2, 3, 5, 7, 3, 2 };
        Console.WriteLine($"Input: array= {{1, 2, 3, 5, 7, 3, 2}}, elementValue= 3\n" +
            $"Output: {intArray.LastIndexOf(3)}");

        // truyền dữ liệu
        string[] stringArray = new string[] { "Nguyen", "Van", "A", "Vu", "Van", "Hung" };
        Console.WriteLine($"Input: array = {{ \"Nguyen\", \"Van\", \"A\", \"Vu\", \"Van\", \"Hung\" }}, elementValue= “Van”\n" +
            $"Output: {stringArray.LastIndexOf("Van")}");
    }
}