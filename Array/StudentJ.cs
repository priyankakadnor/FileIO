using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Array
{
    class StudentJ
    {
        string name;
        int percentage;
        public StudentJ(string name,int percentage)
        {
            this.name = name;
            this.percentage = percentage;
        }
        static void Main(string[] args)
        {
            StudentJ[] ss = new StudentJ[10];
            string nm;
            int per;
            for(int i=0;i<ss.Length;i++)
            {
                Console.WriteLine("Enter The Student  name,percentage");
                nm = Console.ReadLine();
                per = int.Parse(Console.ReadLine());
                ss[i] = new StudentJ(nm, per);

            }
        }
    }
}
