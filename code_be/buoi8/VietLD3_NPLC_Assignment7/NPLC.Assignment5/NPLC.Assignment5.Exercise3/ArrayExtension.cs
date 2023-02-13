namespace NPLC.Assignment5.Exercise3
{
    public static class ArrayExtension
    {
        /// <summary>
        /// trả về vị trí index cuối cùng của giá trị elementValue truyền vào trong màng nếu ko có trả về -1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="elementValue"></param>
        /// <returns></returns>
        public static int LastIndexOf<T>(this T[] array, T elementValue) where T : IComparable<T>
        {
            // IComparable cung cấp một phương thức CompareTo để so sánh với các đối tượng khác cùng loại.
            for (int i = array.Length - 1; i >= 0; i--)
            {
                //Dùng hàm CompareTo để so sánh nếu = 0 có nghĩa là đối tượng gọi phương thức bằng đối tượng truyền vào
                if (((IComparable<T>)array[i]).CompareTo(elementValue) == 0)
                {

                    return i;
                }
            }
            // nếu ko có trả về -1
            return -1;
        }
    }
}
