using System.Globalization;

namespace NPLC.Assignment11.Utill
{
    public class Validation
    {
        private static readonly CultureInfo culture = new CultureInfo("en-US");
        private static readonly DateTimeStyles dateStyle = DateTimeStyles.None;

        /**
        * Yêu cầu người dùng nhập vào một số nguyên trong khoảng từ min đến max.
        * @param msg
        * @param min
        * @param max
        * @return 
        */
        public static int GetInt(string msg, int min, int max)
        {
            int n;
            do
            {
                Console.Write(msg);
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (min <= n && n <= max)
                    {
                        return n;
                    }
                    Console.Error.WriteLine("Must from: " + min + " -> " + max);
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Wrong format");
                }
            } while (true);
        }

        /**
        * Yêu cầu người dùng nhập vào một chuỗi thỏa mãn một điều kiện nhất định
        *
        * @param msg
        * @param pattern
        * @param err
        * @return
        */
        public static string GetString(string msg, string pattern, string err)
        {
            string s;
            bool check;
            do
            {
                Console.Write(msg);
                s = Console.ReadLine().Trim();
                check = !System.Text.RegularExpressions.Regex.IsMatch(s, pattern);
                if (check)
                {
                    Console.Error.WriteLine(err);
                }
            } while (check);
            return s;
        }
        /**
        * Yêu cầu người dùng nhập vào một ngày theo định dạng MM/dd/yyyy
        *
        * @param msg
        * @return
        */
        public static DateTime GetDate(string msg, string format = "MM/dd/yyyy")
        {
            DateTime d;
            do
            {
                Console.Write(msg);
                string date = Console.ReadLine().Trim();
                if (!DateTime.TryParseExact(date, format, culture, dateStyle, out d))
                {
                    Console.Error.WriteLine($"Wrong format, must be {format}");
                    d = DateTime.MinValue;
                }
            } while (d == DateTime.MinValue);
            return d;
        }
    }

}
