using System;

public class Program
{
    private static void Main(string[] args)
    {
        Exercise1(); // gọi hàm
    }
    public static void Exercise1()
    {
        Console.WriteLine("Exercise1:");// hiện thị Exercise1
        int[] arr = { 5, 8, 12, -10, 6, 4 }; // khai báo và truyền dữ liệu vào mảng
        Console.WriteLine(getMaximum(arr)); //gọi hàm getMaximum
        Console.WriteLine(getMinimum(arr));//gọi hàm getMinimum

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int getMaximum(int[] arr)
    {
        int max = arr[0]; // tạo biến max cho dữ liệu là dữ liệu tại vị trí đầu tiền trong mảng
        for (int i = 0; i < arr.Length - 1; i++) // chạy từ vị trí 0 đến hết mảng
        {
            if (arr[i] > max) // nếu có số lớn hơn thì gán nó thành giá trị max
            {
                max = arr[i];
            }

        }
        return max; // trả về giá trị max
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static (int,int) getMinimum(int[] arr)
    {
        int min = arr[0]; // tạo biến min cho dữ liệu là dữ liệu tại vị trí đầu tiền trong mảng
        for (int i = 0; i < arr.Length - 1; i++) // chạy từ vị trí 0 đến hết mảng
        {
            if (arr[i] < min) // nếu có số nhỏ hơn thì gán nó thành giá trị min
            {
                min = arr[i];
            }
        }
        int max = 0;
        return (min,max); // trả về giá trị min
    }
}