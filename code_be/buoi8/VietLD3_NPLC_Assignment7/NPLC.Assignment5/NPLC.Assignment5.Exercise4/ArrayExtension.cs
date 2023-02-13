namespace NPLC.Assignment5.Exercise4
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Tìm giá trị lớn thứ 2 trong mảng
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int ElementOfOrder2(this int[] array)
        {
            // sử dụng LINQ 
            // OrderByDescending sắp xếp mảng array theo chiều giảm dần dựa trên giá trị của từng phần tử
            // Sau khi sắp xếp, hàm ElementAt trả về phần tử thứ 2 trong mảng đã được sắp xếp tức giá trị lớn thứ 2 trong mảng.
            return array.OrderByDescending(x => x).ElementAt(1);
        }

        /// <summary>
        /// Tìm giá trị lớn thứ orderLargest trong mảng
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="orderLargest"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static T ElementOfOrder<T>(this T[] array, int orderLargest)
        {
            // nếu ví trí max thứ orderLargest lớn hơn phạm vị của mảng trả về lỗi
            if (orderLargest > array.Length)
                throw new Exception("The orderLargest value is greater than the length of the array");

            // tạo 1 mảng T để nhận giá trị lớn nhất lần lượt
            T[] largestElements = new T[orderLargest];
            // tạo biến currentLargest để đếm số giá trị lớn nhất đã add vào mảng largestElements
            int currentLargest = 0;

            foreach (T element in array)
            {
                // thêm đủ orderLargest phân tử vào trong mảng largestElements
                if (currentLargest < orderLargest)
                {
                    largestElements[currentLargest] = element;
                    currentLargest++;
                }
                else
                {
                    // sau khi đã có 1 mảng largestElements thì chúng ta so sánh
                    // lấy ra giá trị nhỏ nhất trong mảng largestElements
                    T smallestLargest = largestElements.Min();

                    // nếu giá trị element của array nhỏ hơn smallestLargest thì gán giá trị đó vào vị trí min trong mảng largestElements
                    if ((dynamic)element > (dynamic)smallestLargest)
                    {
                        // dùng Array.IndexOf để lấy index của smallestLargest
                        int smallestLargestIndex = Array.IndexOf(largestElements, smallestLargest);
                        // gán giá trị
                        largestElements[smallestLargestIndex] = element;
                    }
                }
            }
            // hết vòng lặp ta có được 1 mảng largestElements có lần lượt các giá trị lớn nhất
            // khi đó ta lại dùng hàm .Min() để trả về giá trị nhỏ nhất trong mảng và đó cũng là thứ cần tìm
            return largestElements.Min();
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
    }
}