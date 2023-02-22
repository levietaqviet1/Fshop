using System.Text.RegularExpressions;
namespace TPbank.Entities.ExtensionMethod
{
    public static class ValidateExtension
    {
        /// <summary>
        /// Check CustomerId is not null
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public static bool IsValidCustomerId(this Guid customerId)
        {

            return customerId != Guid.Empty;
        }

        /// <summary>
        /// Check CustomerCode > 0
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        public static bool IsValidCustomerCode(this long customerCode)
        {

            return customerCode > 0;
        }

        /// <summary>
        /// Check CustomerName is not null and less than 40 characters
        /// </summary>
        /// <param name="customerName"></param>
        /// <returns></returns>
        public static bool IsValidCustomerName(this string customerName)
        {

            return !string.IsNullOrWhiteSpace(customerName) && customerName.Length < 40;
        }

        /// <summary>
        /// Check Mobile 10-digit number
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool IsValidMobile(this string mobile)
        {

            return mobile.Length == 10 && mobile.All(x => char.IsNumber(x));
        }

        /// <summary>
        /// Mobile is unique
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool IsValidateUniqueMobile(this string mobile, List<Customer> customers)
        {

            return customers.FirstOrDefault(x => x.Mobile == mobile) != null;
        }

        /// <summary>
        /// Check Username is not null
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool IsValidUsername(this string username)
        {

            return !string.IsNullOrWhiteSpace(username);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="customers"></param>
        /// <returns></returns>
        public static bool IsValidateUniqueUsername(this string username, List<Customer> customers)
        {

            return customers.FirstOrDefault(x => x.Username == username) == null;
        }

        /// <summary>
        /// Check Password at least 6 characters, include lower case, upper case, and digit number
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsValidPassword(this string password)
        {
            Regex rg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$");

            return rg.IsMatch(password);
        }

    }
}
