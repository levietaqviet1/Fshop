using System.Collections;

namespace NPLC.Assignment5.Exercise1
{
    public static class ArrayListExtension
    {
        /// <summary>
        /// Trả về số lượng dữ liệu có kiểu int trong mảng
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int CountInt(this ArrayList array)
        {
            // tạo biến đếm
            int count = 0;
            foreach (var item in array)
            {
                // nếu kiểu dữ liệu int thì count tăng lên 1
                if (item is int)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Trả về số lượng phần tử trong mảng có kiểu dữ liệu là dataType.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public static int CountOf(this ArrayList array, Type dataType)
        {
            // tạo biến đếm
            int count = 0;
            foreach (var item in array)
            {
                // so sánh có cùng Type thì count tăng lên 1
                if (item.GetType() == dataType)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Trả về số lượng phần tử trong mảng có kiểu dữ liệu là T truyền vào
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int CountOf<T>(this ArrayList array)
        {
            // tạo biến đếm
            int count = 0;
            foreach (var item in array)
            {
                // so sánh có cùng kiểu dữ liệu thì count tăng lên 1
                if (item is T)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Trả về giá trị lớn nhất của kiểu dữ liệu đó trong màng, nếu kiểu dữ khác kiểu số sẽ báo lỗi
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static T MaxOf<T>(this ArrayList array) where T : IComparable<T>
        {
            // IComparable cung cấp một phương thức CompareTo để so sánh với các đối tượng khác cùng loại.
            // sử dụng hàm để kiểm tra xem kiểu dữ liệu truyền vào có phải số hay ko
            // nếu ko phải số sẽ trả về lỗi
            if (!typeof(T).IsNumericType())
            {
                throw new InvalidOperationException("T must be a numeric data type.");
            }
            // tạo biến max có kiểu dữ liệu T truyền vào và giá trị mặc định của kiểu dữ liệu đó
            T max = default(T);
            bool first = true;
            foreach (var item in array)
            {
                // so sánh với 2 điều kiện
                // 1. Cùng kiểu dữ liệu item is T
                // 2. Dùng hàm CompareTo để so sánh nếu trả về dương có nghĩa là đối tượng gọi phương thức lớn  hơn đối tượng truyền vào
                if (item is T && ((IComparable<T>)item).CompareTo(max) > 0)
                {
                    // gán giá trị cho max khi tìm đc giá trị khác cao hơn trong mảng có cùng kiểu dữ liệu
                    max = (T)item;
                    first = false;
                }
            }

            // nếu không có giá trị nào sẽ báo lỗi là mảng trống
            if (first)
            {
                throw new InvalidOperationException("ArrayList is empty.");
            }

            return max;
        }

        /// <summary>
        /// Hỗ trợ để kiểm tra xem dữ liệu truyền vào có phải là kiểu dữ liệu số hay không
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static bool IsNumericType(this Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }
    }
}
