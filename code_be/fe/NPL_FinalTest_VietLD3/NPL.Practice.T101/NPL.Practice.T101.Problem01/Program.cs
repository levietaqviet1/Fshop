
using System;

class Program
{
    public static void Main(string[] args)
    {
        Function();
    }

    /// <summary>
    /// Hàm xử lý chương trình
    /// </summary>
    public static void Function()
    {
        // tạo mảng số nguyên
        int[] intArr = { 1, 1, 2, 3 };

        Console.Write("Input: ");
        foreach (var item in intArr)
        {
            Console.Write($"{item}\t");
        }

        // gọi hàm DrawCicleChart xử lý dữ liệu
        decimal[] decimalArr = DrawCicleChart(intArr);

        Console.Write("\nOutput: ");
        foreach (decimal d in decimalArr)
        {
            Console.Write($"{d}\t");
        }

        Console.ReadLine();

    }
    /// <summary>
    /// Hàm xử lý chuyển 1 mảng số nguyên thành phần trăm tương ứng so với tổng giá trị trong mảng
    /// </summary>
    /// <param name="intArr"></param>
    /// <returns></returns>
    public static decimal[] DrawCicleChart(int[] intArr)
    {
        // tạo biến nhận tổng giá trị 
        int total = 0;
        // tạo biến nhận tổng phần tràm trừ giá trị cuối 
        decimal totalCh = 0;

        foreach (int i in intArr)
        {
            total += i;
        }
        // tạo mảng chứa số thập phân
        decimal[] decimalArr = new decimal[intArr.Length];

        for (int i = 0; i < intArr.Length - 1; i++)
        {
            // dùng Math.Round để làm tròn số
            decimalArr[i] = Math.Round(((decimal)intArr[i] / total) * 100, 2);
            totalCh += decimalArr[i];
        }

        //Tính giá trị cuối cùng để phù hợp tổng 100%
        decimalArr[decimalArr.Length - 1] = Math.Round(100 - totalCh, 2); 

        return decimalArr;
    }
}
