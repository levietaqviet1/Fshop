using NPLC.Assignment5.Exercise4;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercise4();
    }
    public static void Exercise4()
    {
        int[] intInput = new int[] { 3, 2, 5, 6, 1, 7, 7, 5, 2 };
        Console.WriteLine($"ElementOfOrder2() should be returns {intInput.RemoveDuplicate().ElementOfOrder2()}");
        Console.WriteLine($"ElementOfOrder(2) should be returns {intInput.RemoveDuplicate().ElementOfOrder(2)}");
        Console.WriteLine($"ElementOfOrder(3) should be return  {intInput.RemoveDuplicate().ElementOfOrder(3)}");
        try
        {

            Console.WriteLine($"ElementOfOrder(20) should be throw an exception {intInput.RemoveDuplicate().ElementOfOrder(20)}");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}