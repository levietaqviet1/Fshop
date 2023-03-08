public static class Validate
{

    /// <summary>
    /// Hàm kiểm tra số điện thoại
    /// </summary>
    /// <param name="PhoneNumber"></param>
    /// <returns></returns>
    public static bool ValidatePhoneNumber(this string phoneStr)
    { 
        // Kiểm tra độ dài của số điện thoại
        if (phoneStr.Length != 12)
        {
            return false;
        }

        // Kiểm tra ký tự đầu tiên có phải là số 0 không
        if (phoneStr[0] != '0')
        {
            return false;
        }

        // Kiểm tra khoảng trắng đầu tiên
        if (phoneStr[3] != ' ')
        {
            return false;
        }

        // Kiểm tra khoảng trắng thứ hai
        if (phoneStr[7] != ' ')
        {
            return false;
        }

        // Kiểm tra các ký tự còn lại có phải là số hay không
        for (int i = 1; i < 12; i++)
        {
            if (i == 3 || i == 7)
            {
                continue;
            }
            if (!char.IsDigit(phoneStr[i]))
            {
                return false;
            }
        }

        // Nếu không có lỗi, số điện thoại được coi là hợp lệ
        return true;
    }

    /// <summary>
    /// kiểm tra tên nhóm
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static bool ValidateGroup(this string name)
    {
        if (name.Equals("Family") || name.Equals("Colleague") || name.Equals("Friend") || name.Equals("Other"))
        {
            return true;
        }
        return false;
    }
}
