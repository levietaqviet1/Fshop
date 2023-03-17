internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(HowManyIntegers(60));
    }
    public static int HowManyIntegers(int n)
    {
        if (n >= 1000)
        {
            n = 1000;
        }
        if (n < 1)
        {
            return 0;
        }

        string intSt = ""; 
        int count = 0;
        bool check = true;
        int h = -1;
        for (int i = 1; i <= n; i++)
        {
            check = true;
            intSt = i + "";
            h = -1;
            for (int k = 0; k < intSt.Length; k++)
            {
                if (k == intSt.Length)
                {
                    if (h != 0 && h != 4 && h != 7)
                    {
                        check = false;
                        break; 
                    }
                    continue;
                }
                h = int.Parse(intSt.Substring(k, 1));
                if (h != 0 && h!= 4 && h!= 7)
                {
                    check = false;
                    break;

                }
            }  
            if (check)
            { 
                count++;
            } 
        }
        return count;
    }
}