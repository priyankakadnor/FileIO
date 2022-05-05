using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Parent_over
    {
        public virtual void study()
        {
            Console.WriteLine("Libary");
        }
    

        class child : Parent_over
        {
            public override void study()
            {
                Console.WriteLine("going School");
            }

        


       
            static void Main(string[] args)
            {
                Parent_over op = new child();

            }
        }
    }
}
