using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestExample
{
    public class Res
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            ////node1
            //if (user.IsAdmin)
            //{
            //    //node2
            //    return true;
            //}

            ////node3
            //if (user == MadeBy)
            //{
            //    //node4
            //    return true;
            //}

            ////node5
            //return false;

            return (user.IsAdmin || user == MadeBy);
        }
    }
}
