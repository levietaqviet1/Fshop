using System.Xml.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        Function();
    }
    private static void Function()
    {
        // tạo mảng chữa 1 danh sách tên
        List<string> stringArrName = new List<string>() { "Ngo Viet Hung", "Dang Quang Duong", "Ngo Ba Kha", "Phan Ta Xi", "Ngo Viet Hung" };

        Console.WriteLine($"Input: ");
        foreach (string str in stringArrName)
        {
            Console.WriteLine($"{str} ");
        }

        // tạo mảng chứa 1 danh sách gmail đã chuển đổi
        List<string> stringArrEmail = GenerateEmailAddress(stringArrName);

        Console.WriteLine();
        Console.WriteLine($"Output: ");
        foreach (string str in stringArrEmail)
        {
            Console.WriteLine($"{str} ");
        }
    }

    /// <summary>
    /// hàm nhận mảng tên sau đó trả về 1 danh sách email theo quy tắc
    /// </summary>
    /// <param name="stringArrName"></param>
    /// <returns></returns>
    static private List<string> GenerateEmailAddress(List<string> stringArrName)
    {
        List<string> stringArrEmail = new List<string>();

        string[] nameParts;

        foreach (string name in stringArrName)
        {
            // Tách họ và tên đệm ra khỏi tên của nhân viên
            nameParts = name.Split(' ');

            // Lấy họ của nhân viên
            string lastName = nameParts[0];

            // Lấy chữ cái đầu tiên của tên của nhân viên
            string firstNameInitial = nameParts[1][0].ToString();

            // Lấy chữ cái đầu tiên của tên đệm của nhân viên (nếu có)
            string middleNameInitial = "";
            if (nameParts.Length > 2)
            {
                middleNameInitial = nameParts[2][0].ToString();
            }

            // Tạo địa chỉ email ban đầu bằng cách nối họ và tên với chữ cái đầu tiên của tên
            string email = $"{lastName.ToLower()}{firstNameInitial.ToLower()}{middleNameInitial.ToLower()}@fsoft.com.vn";

            // Kiểm tra xem địa chỉ email đã được sử dụng chưa
            int count = 1;
            while (stringArrEmail.Contains(email))
            {
                // Nếu địa chỉ email đã tồn tại, tăng số tự động và tạo lại địa chỉ email
                email = $"{lastName.ToLower()}{firstNameInitial.ToLower()}{middleNameInitial.ToLower()}{count}@fsoft.com.vn";
                count++;
            }

            stringArrEmail.Add(email);
        }

        return stringArrEmail;
    }

}