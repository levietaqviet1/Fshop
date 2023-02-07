using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3
{
    internal class MyOwnAutoShop
    {
        static void Main(string[] args)
        {
            Sedan sedan = new Sedan(2, 1, 5, "red"); // truyền dữ liệu  vào Sedan
            Console.WriteLine(sedan.ToString()); // in ra

            Ford ford = new Ford(3, 1, 5, 2, "red"); // truyền dữ liệu  vào Ford
            Console.WriteLine(ford.ToString()); // in ra

            Truck truck = new Truck(4, 2, 3, "red"); // truyền dữ liệu  vào Truck
            Console.WriteLine(truck.ToString()); // in ra
        }

    }
}
