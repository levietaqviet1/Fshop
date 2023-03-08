using NPL.Practice.T101.Problem03;
using NPL.Practice.T101.Problem03.Utill;

internal class Program
{
    private static void Main(string[] args)
    {
        Function();
    }

    /// <summary>
    /// chuc nang
    /// </summary>
    public static void Function()
    {
        PhoneBookManagement phoneBookManagement = new PhoneBookManagement();
        while (true)
        { 
            switch (GetMenu())
            {
                case 0:
                    return;
                case 1:
                    phoneBookManagement.Add();
                    break;
                case 2:
                    phoneBookManagement.Remove();
                    break;
                case 3:
                    phoneBookManagement.Sort();
                    break;
                case 4:
                    phoneBookManagement.Find();
                    break;
                case 5:
                    phoneBookManagement.Display();
                    break;
            }

        }
    }

    /// <summary>
    /// in menu
    /// </summary>
    /// <returns></returns>
    public static int GetMenu()
    {
        Console.WriteLine("Menu: \n1.Add\n2.Remove\n3.Sort\n4.Find\n5.Display\n0.Exit");
        return Validation.GetInt("Choice: ", 0, 5);
    }
}