internal class Program
{
    private static void Main(string[] args)
    {
        Ex1();
    }

    public static void Ex1()
    {
        string date = InputString("Input: ");
        if (DateTime.TryParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None, out DateTime result)) // kiểm tra date đúng định dạng và thời gian có chuẩn ko
        {
            Console.WriteLine(date + " is correct and the first day of the month is " +
                result.AddDays(-(result.Day - 1)).ToString("dd/MM/yyyy")); // trả về ngày đầu tiên trong tháng đó 
        }
        else
        {
            Console.WriteLine(date + " is NOT correct");
        } 
    }
    public static string InputString(string mess)
    {
        Console.Write(mess);
        return Console.ReadLine();
    }
}