using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A001.Exercise3
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 12, -10, 6, 4 }; // khai báo và truyền dữ liệu vào mảng 
            Console.WriteLine(getMinimum(arr));
        }

        public static int FindMax(params int[] arr)
        {
            // tìm hiểu params và dynamic
        } 
        public static (int, int) getMinimum(int[] arr)
        {
             int min = arr[0]; // tạo biến min cho dữ liệu là dữ liệu tại vị trí đầu tiền trong mảng
            int max = arr[0]; // tạo biến max cho dữ liệu là dữ liệu tại vị trí đầu tiền trong mảng
            for (int i = 0; i < arr.Length - 1; i++) // chạy từ vị trí 0 đến hết mảng
            {
                if (arr[i] > max) // nếu có số lớn hơn thì gán nó thành giá trị max
                {
                    max = arr[i];
                }
                if (arr[i] < min) // nếu có số nhỏ hơn thì gán nó thành giá trị min
                {
                    min = arr[i];
                }
            }
            return (min, max); // trả về giá trị min
        }
    }
}
