using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Recrusion_p
    {
        static int revnum = 0;
        static int rem=0;
        public static int  rev(int n)
        {
            while (n > 0)
            {
                rev(n / 10);
                revnum = (n % 10) * rem;
                rem = rem * 10;

            }
            return revnum;
        }
          
        static void Main(string[] args)
        {
            int num =12345;
            Console.WriteLine("Reverse");
            Console.WriteLine(rev(num));
        }

    }
}
