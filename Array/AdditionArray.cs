using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Array
{
    class AdditionArray
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 5, 6 };
            int[] b = { 4, 5, 3, 9, 1 };
            int[] c = new int[a.Length];
            for(int i=0;i<=a.Length;i++)
            {
                c[i] = a[i] + b[i];
                Console.WriteLine("Additon"+c[i]);

            }
            Console.Read();
        }
    }
}
