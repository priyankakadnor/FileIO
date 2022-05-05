using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Array
{
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a= { 3, 4, 6, 1, 2, 34 };
            int[] b = { 4, 5, 8, 2, 34, 56 };

            int[] c = new int[a.Length + b.Length];
            int j= 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }
           
            

        }
       
    }
}
