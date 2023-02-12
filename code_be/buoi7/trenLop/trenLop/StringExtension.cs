using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace trenLop
{
    static class StringExtension
    {
        public static string ChuanHoa(this string str)
        {
            Regex regex = new Regex(@"\s\s*");
            //str = regex.Replace(str, " ");
            string[] arr = regex.Split(str);
            str = "";
            foreach (string item in arr)
            {
                str+= item.Substring(0,1).ToUpper() + item.Substring(1).ToLower()+" ";
            }
            return str.Trim();
        }
    }
}
