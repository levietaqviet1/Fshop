using trenLop;

internal class Program
{
    delegate int Caccu(int x, int y);
    private static void Main(string[] args)
    {
        string str = "    nguyen van     a  ";
        Console.WriteLine(str.ChuanHoa());
        Caccu caccu = (a, b) => { return a+b    };
    }
}