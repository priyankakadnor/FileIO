using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.StringProgram
{
    class AllFunction
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("riya");
            sb[0] = 'p';
            sb.Append("Rakesha");
            sb.AppendLine("Rushikehsa");
            sb.Insert(0, "Priyushi");
            sb.Remove(1, 2);
            sb.Replace('a', 'o');
            sb.Replace("sh", "cc");
            Console.WriteLine(""+sb);


        }
    }

}
