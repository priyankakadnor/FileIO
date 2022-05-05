using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.StringProgram
{
    class Longwrd
    {
        static void Main(string[] args)
        {
            string s = "I Am In Maharsshatra ";
            string[] word = s.Split(" ");
            string longword = " ";
            for(int i=0;i<word.Length;i++)
   
            {
               if(longword.Length<=word[i].Length)
                    {
                        longword = word[i];
                    }
                    Console.WriteLine("Longword"+longword);
            }
        }
    }
}
