internal class Program
{
    private static void Main(string[] args)
    {
        // int[] arr = { 3, 2, 6, 5, 0, 3 };
        int[] arr = { 53, 39, 44, 12, 66, 13, 28, 93, 99, 41 };
        //int[] arr = { 2, 4, 1 };
        Console.WriteLine(MaxProfit(arr,3)+"");
    }
    public static int MaxProfit(int[] prices, int k)
    {
        int price = 0;
        int i = 0;
        int j = 0;
        int length = prices.Length;
        int lastIndex = length;

        int minIndex = 0;
        int minValue = prices[0];

        int maxIndex = lastIndex;
        int maxValue = 0;
        while (i < k)
        {
            i++;
            j = 0;
            minValue = prices[j];
            while (j <= lastIndex - 1)
            {
                if (minValue > prices[j])
                {
                    minValue = prices[j];
                    minIndex = j;
                }
                j++;
            }
            j = minIndex;
            maxValue = prices[j];
            while (j < length)
            {
                if (maxValue <= prices[j])
                {
                    maxIndex = j;
                    maxValue = prices[j];
                }
                j++;
            } 
            price += (maxValue - minValue);
            lastIndex = minIndex;
        }

        return price;
    }

}