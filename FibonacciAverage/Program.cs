using System;

namespace FibonacciAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Derinliği girin:");
            int Derinliği = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, sum = 0;
            double ortalama;

            for (int i = 0; i < Derinliği; i++)
            {
                sum += a;
                int c = a;
                a = b;
                b = c + b;
            }
            ortalama = (double)sum / Derinliği;
            Console.WriteLine("Fibonacci dizisinin ortalaması:" + ortalama);
            Console.ReadKey();
        }
    }
}
