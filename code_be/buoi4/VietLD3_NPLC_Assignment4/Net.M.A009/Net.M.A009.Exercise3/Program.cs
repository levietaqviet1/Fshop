using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercise3();
    }

    /// <summary>
    /// 
    /// </summary>
    public static void Exercise3()
    {
        string[] listUser = { "Tony Stark", "Steve Rogers", "Bruce Banner", "Thor", "Natasha Romanoff", "Clint Barton", "James Rhodes", "Scott Lang", "Doctor Strange", "Carol Danvers", "Peter Parker" };
        listUser = SortListUser(listUser); // sắp xếp lại list
        foreach (var item in listUser)
        {
            Console.Write($"{item}, "); // in danh sách ra
        }
    }

    /// <summary>
    /// Hàm sắp xếp
    /// </summary>
    /// <param name="listUser"></param>
    /// <returns></returns>
    public static string[] SortListUser(string[] listUser)
    {
        string temp = ""; // tạo biến trung gian
        for (int i = 0; i < listUser.Length; i++)
        {
            for (int j = i; j < listUser.Length; j++)
            {
                if (GetLastName(listUser[i]).CompareTo(GetLastName(listUser[j])) > 0) // dùng CompareTo để so sánh 
                {
                    temp = listUser[i];
                    listUser[i] = listUser[j];
                    listUser[j] = temp;
                }
            }
        }

        return listUser; // trả về list đã đc sắp xếp
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static string GetLastName(string name)
    {
        string[] arr = name.Split(" "); // dùng Split để tách chuỗi

        return arr[arr.Length-1]; // lấy phần tử cuối cùng là last name
    }
}