using System;

namespace DotNetBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonacassi sereies");
            for (int i=1;i<=10;i++)
            {
                c = a + b;
                Console.WriteLine(c+"  ");
                a = b;
                b = c;
            }
            Console.ReadLine();
       
        }
    }
}
