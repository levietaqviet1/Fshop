using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercise3();
    }
    public static void Exercise3()
    {
        string[] listUser = { "Tony Stark", "Steve Rogers", "Bruce Banner", "Thor", "Natasha Romanoff", "Clint Barton", "James Rhodes", "Scott Lang", "Doctor Strange", "Carol Danvers", "Peter Parker" };
        listUser = SortListUser(listUser);
        foreach (var item in listUser)
        {
            Console.Write($"{item}, ");
        }
    }

    public static string[] SortListUser(string[] listUser)
    {
        string temp = "";
        for (int i = 0; i < listUser.Length; i++)
        {
            for (int j = i; j < listUser.Length; j++)
            {
                if (GetLastName(listUser[i]).CompareTo(GetLastName(listUser[j])) > 0)
                {
                    temp = listUser[i];
                    listUser[i] = listUser[j];
                    listUser[j] = temp;
                }
            }
        }
        return listUser;
    }

    public static string GetLastName(string name)
    {
        string[] arr = name.Split(" ");
        return arr[arr.Length-1];
    }

    public static int GetPositiveInteger(string message)
    {
        int input = -1;
        do
        {
            try
            {
                input = int.Parse(InputString("Input n"));
                if (input < 1)
                {
                    throw new Exception();
                }
                return input;
            }
            catch (Exception)
            {
            }

        } while (input == -1);

        return input;

    }
    public static string InputString(string message)
    {
        Console.Write(message);
        return Console.ReadLine().Trim(); // xóa khoảng trắng thừa đầu và cuỗi chuỗi
    }
}