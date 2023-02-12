namespace NPLC.Assignment3.Utill
{
    internal class Validate
    {
        /// <summary>
        /// Cho phép người dùng nhập lại nếu chuỗi nhập vào rỗng hoặc null
        /// </summary>
        /// <param name="mess"></param>
        /// <returns></returns>
        public static string GetStringInput(string mess)
        {
            string input = null;
            //string.IsNullOrEmpty để kiểm tra xem chuỗi nhập vào có rỗng hoặc null hay không
            while (string.IsNullOrEmpty(input))
            {
                Console.Write(mess);
                input = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("The input string is empty or null, please enter again: ");
            }

            return input;
        }

        /// <summary>
        /// cho phép người dùng nhập lại nếu số nhập vào không hợp lệ
        /// </summary>
        /// <returns></returns>
        public static int GetIntInput(string mess)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (int.TryParse(input, out int result) && !string.IsNullOrEmpty(input))
                {

                    return result;
                }
                Console.WriteLine("Invalid input, please enter again: ");
            }
        }
        /// <summary>
        /// cho phép người dùng nhập lại nếu số nhập vào không hợp lệ
        /// </summary>
        /// <returns></returns>
        public static int GetIntInputOption(string mess, int min, int max)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (int.TryParse(input, out int result) && !string.IsNullOrEmpty(input) && result >= min && result <= max)
                {

                    return result;
                }
                Console.WriteLine("Invalid number, please re-enter: ");
            }
        }

        /// <summary>
        /// cho phép người dùng nhập lại nếu số nhập vào không hợp lệ và số phải nguyên dương 
        /// </summary>
        /// <returns></returns>
        public static int GetPositiveIntInput(string mess)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (int.TryParse(input, out int result) && !string.IsNullOrEmpty(input) && result >= 0)
                {

                    return result;
                }
                Console.WriteLine("Số nhập vào không hợp lệ, vui lòng nhập lại: ");
            }
        }
        /// <summary>
        /// cho phép người dùng nhập lại nếu số nhập vào không hợp lệ thì nhập lại
        /// </summary>
        /// <returns></returns>
        public static double GetDoubleInput(string mess)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (double.TryParse(input, out double result) && !string.IsNullOrEmpty(input))
                {

                    return result;
                }
                Console.WriteLine("Invalid input, please enter again: ");
            }
        }

        /// <summary>
        /// cho phép người dùng nhập lại nếu số nhập vào không hợp lệ và số phải nguyên dương 
        /// </summary>
        /// <returns></returns>
        public static double GetPositiveDoubleInput(string mess)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (double.TryParse(input, out double result) && !string.IsNullOrEmpty(input) && result >= 0)
                {

                    return result;
                }
                Console.WriteLine("Invalid input, please enter again: ");
            }
        }

        /// <summary>
        /// nhập enter tiếp tục
        /// </summary>
        public static void EnterToContinue()
        {
            Console.WriteLine("Enter continue.......");
            Console.ReadLine();
        }

        /// <summary>
        /// Nhập thời gian
        /// </summary>
        /// <param name="mess"></param>
        /// <returns></returns>
        public static DateTime GetDateTimeInput(string mess)
        {
            DateTime dateTime;
            while (true)
            {
                Console.Write(mess);
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out dateTime))
                {
                    break;
                }
                Console.WriteLine("Invalid date time. Please enter again.");
            }

            return dateTime;
        }
    }
}
