using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestExample
{
    public class Math
    {
        public int Max(int a, int b)
        {
            return (a> b) ? a : b;  
        }

        public int Max(int a, int b, int c)
        {
            return (a > b) ? a : b;
        }
    }
}
