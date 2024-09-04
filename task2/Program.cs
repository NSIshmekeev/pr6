using System;

class Program
{
    static void PrintDigits(int n)
    {
        if (n < 10)
        {
            Console.Write(n);
        }
        else
        {
            PrintDigits(n / 10);
            Console.Write(n % 10);
        }
    }

    static void ProcessRange(int A, int B)
    {
        for (int i = A; i <= B; i++)
        {
            PrintDigits(i);
            Console.WriteLine(); 
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите B: ");
        int B = int.Parse(Console.ReadLine());
        ProcessRange(A, B);
    }
}
