namespace NPLC.Assignment5.Exercise2
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Trả về mảng mới sau khi đã xóa bỏ giá trị trùng lặp
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] RemoveDuplicate(this int[] array)
        {
            //  sử dụng phương thức "Distinct" của LINQ loại bỏ các phần tử trùng lặp
            return array.Distinct().ToArray();
        }

        /// <summary>
        /// Trả về mảng mới sau khi đã xóa bỏ giá trị trùng lặp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[] RemoveDuplicate<T>(this T[] array)
        {
            //HashSet không lưu giá trị trùng lặp.
            // Tao
            HashSet<T> distinctElements = new HashSet<T>();
            foreach (var element in array)
            {
                // HashSet sẽ tự động loại bỏ các phần tử trùng lặp
                distinctElements.Add(element);
            }

            return distinctElements.ToArray();
        }

        /// <summary>
        /// Dùng để in ra phần tử trong mảng
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Printf<T>(this T[] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element}\t");
            }
        }
    }
}
