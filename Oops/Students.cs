using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Students
    {
        string name;
        int rno, m1, m2, m3;
        Students()
        {
            Console.WriteLine( "In Students Costructor");
        }

        public void Accept()
        {
            Console.WriteLine("Enter The Name");
           name =Console.ReadLine();
            Console.WriteLine("Enter The rollno");
            rno  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The m1");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The m1");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The m1");
             m3 = Convert.ToInt32(Console.ReadLine());


        }
        public void display()

        {
           int avr =m1 + m2 + m3/3;
            Console.WriteLine("The Marks Of Average"+avr);
        }

        
             
        static void Main(string[] args)
        {
            Students sp = new Students();
            sp.Accept();
            sp.Accept();
        }
    }
}
