using System;

class Program
{

    static void Main()
    {
        Console.Write("Ange en ett tal för att beräkna fakulteten :");
        int n = int.Parse(Console.ReadLine());


        long result = Faculty(n);

        Console.WriteLine($"{n}! = {result}");


    }

    static long Faculty(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        } else
        {
            return n * Faculty(n - 1);
        }
    }
}