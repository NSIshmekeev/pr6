internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите n ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("B: ");
        Console.WriteLine(B(n));
    }

    public static double B(int n)
    {
        if (n == 1) return 5;
        else
        {
            double previosB = B(n-1);
            return previosB / ((n - 1) * (n - 1) + n); 
        }
    }
}