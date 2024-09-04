internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите m");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите n");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine(Sum(m)+ Sum(k));
    }

    public static int Sum(int n)
    {
        if (n == 1) return 1;
        else return n + Sum(n-1);
    }
}