using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Ex2();
    }

    public static void Ex2()
    {
        Console.WriteLine("Enter the date in format MMM/yyyy");
        try
        { 
        string input = Console.ReadLine(); // nhập date
        DateTime date = DateTime.ParseExact(input, "MMM/yyyy", CultureInfo.InvariantCulture); // ép kiểu từ string sang date theo định dạng MMM/yyyy
        int totalDays = DateTime.DaysInMonth(date.Year, date.Month); // lấy ra tổng số ngày trong tháng đó
        int workingDays = 0; // số ngày làm việc
        for (int i = 1; i <= totalDays; i++) // chạy từ ngày mùng 1 đến hết tháng
        {
            DateTime currentDay = new DateTime(date.Year, date.Month, i); // hỗ trợ kiêm tra xem ngày hôm đó là thứ mấy qua thư viện sẵn của DateTime
            if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday) // nếu không phải là thứ 7 hoặc chủ nhật thì ngày làm việc +1
            {
                workingDays++;
            }
        }
        Console.WriteLine("The number of working days in " + input + " is " + workingDays); // hiện thị kết quả
        }
        catch (Exception e)
        { 
            Console.WriteLine(e.Message);
            Ex2();
        }

    }
}