using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Array
{
    class Min_Max
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 23, 45, 67, 89, 54, 2 };
            int min, max;
            max = a[0];
            min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
              

                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
                Console.WriteLine("Maximum Number" + max);
                Console.WriteLine("Minimum Number" + min);


            }
        }
    }
}
