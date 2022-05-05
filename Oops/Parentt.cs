using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Parentt
    {
        public virtual void m1()
        {
            Console.WriteLine("In Virtual method");
        }
    }
    class child : Parentt
    {
        public override void m1()
        {
            Console.WriteLine("In OverRide Method");
        }

    }
    class ABC
    { 
            static void Main(string[] args)
            {


                Parentt p = new Parentt();
                p.m1();

                Parentt pp = new child();
                pp.m1();
            }
        }
    }

