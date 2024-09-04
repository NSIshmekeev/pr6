using System;

class Program
{
    static void PrintSequence(int m)
    {
        if (m == 0)
        {
            return;
        }
        Console.Write(m + " ");
        PrintSequence(m - 1);
    }

    static void PrintAll(int m)
    {
        if (m == 0)
        {
            return;
        }
        PrintAll(m-1);
        Console.WriteLine();
        PrintSequence(m);
    }



    static void Main(string[] args)
    {
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());
        PrintAll(n);
    }
}
