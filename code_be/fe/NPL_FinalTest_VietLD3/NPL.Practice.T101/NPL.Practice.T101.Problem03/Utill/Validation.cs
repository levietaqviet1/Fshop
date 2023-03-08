using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.Practice.T101.Problem03.Utill
{
    public class Validation
    {
        /// <summary>
        /// Yêu cầu người dùng nhập vào một chuỗi thỏa mãn một điều kiện nhất định
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="pattern"></param>
        /// <param name="err"></param>
        /// <returns></returns>
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

        /// <summary>
        /// hàm chỉ kiểm tra xem có nhập dữ liệu hay ko
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public static string GetStringNotRegex(string msg, string err)
        {
            string s;
            bool check = false;
            do
            {
                Console.Write(msg);
                s = Console.ReadLine().Trim();

                if (s.Equals(""))
                {
                    check = true;
                    Console.Error.WriteLine(err);
                }
            } while (check);
            return s;
        }

        /// <summary>
        /// Yêu cầu người dùng nhập vào một số nguyên trong khoảng từ min đến max.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static int GetInt(string msg)
        {
            int n;
            do
            {
                Console.Write(msg);
                try
                {
                    n = int.Parse(Console.ReadLine());
                    return n;
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Wrong format");
                }
            } while (true);
        }

        /// <summary>
        ///  Yêu cầu người dùng nhập vào một số nguyên trong khoảng từ min đến max.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
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
    }
}
