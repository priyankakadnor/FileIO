using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Array
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter The Size");
             int size = Convert.ToInt32(Console.ReadLine());*/
            int[] a = new int[] { 2, 7, 8, 8, 70 };
            Console.WriteLine("Original Array");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Reverse Array");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }

    }



        class CountFrequency
        {

        static void Main(string[] args)
        {

            int[] arr = new int[] { 10, 20, 20, 10, 10, 20, 5, 20 };
                int n = arr.Length;

                bool[] visited = new bool[n];

                // Traverse through array elements and
                // count frequencies
                for (int i = 0; i < n; i++)
                {

                    // Skip this element if already processed
                    if (visited[i] == true)
                        continue;

                    // Count frequency
                    int count = 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            visited[j] = true;
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + " " + count);
                }
            }

}

        }
    

