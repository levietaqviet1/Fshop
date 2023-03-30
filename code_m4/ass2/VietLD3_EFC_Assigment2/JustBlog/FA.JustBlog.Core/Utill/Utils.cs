using System.Text.RegularExpressions;

namespace FA.JustBlog.Core.Utill
{
    public class Utils
    {
        /// <summary>
        /// Chuyển đổi chuỗi về đúng định dạng urlSlug
        /// </summary>
        /// <param name="urlSlug"></param>
        /// <returns></returns>
        public static string ConFigUrlSlug(string urlSlug)
        {
            if (string.IsNullOrEmpty(urlSlug)) return "";

            // chuyển đổi thành chữ viết thường và loại bỏ khoảng trắng đầu và cuối
            urlSlug = urlSlug.ToLower().Trim();

            // Chuyển đổi khoảng trắng thành dấu gạch ngang
            urlSlug = Regex.Replace(urlSlug.Trim(), @"\s+", "-");

            // chuyển . với # thành dot với sharp
            urlSlug = Regex.Replace(urlSlug, "[.#]", m =>
            {
                return m.Value == "." ? "dot" : "sharp";
            });

            // Chuẩn hóa chuỗi tiếng Việt
            urlSlug = RemoveVietnameseSigns(urlSlug);

            // Loại bỏ các ký tự không mong muốn
            urlSlug = Regex.Replace(urlSlug, @"[^a-z0-9\s-]", "");

            return urlSlug;
        }

        /// <summary>
        /// Hàm chuyển đổi chuỗi tiếng Việt thành chuỗi không dấu
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveVietnameseSigns(string str)
        {
            if (str == null) return null;

            // Tìm và thay thế các ký tự tiếng Việt bằng các ký tự Latin không dấu
            str = Regex.Replace(str, "[áàảãạăắằẳẵặâấầẩẫậ]", "a");
            str = Regex.Replace(str, "[éèẻẽẹêếềểễệ]", "e");
            str = Regex.Replace(str, "[óòỏõọôốồổỗộơớờởỡợ]", "o");
            str = Regex.Replace(str, "[íìỉĩị]", "i");
            str = Regex.Replace(str, "[úùủũụưứừửữự]", "u");
            str = Regex.Replace(str, "[ýỳỷỹỵ]", "y");
            str = Regex.Replace(str, "[đ]", "d");

            return str;
        }
    }
}
