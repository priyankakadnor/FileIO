using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Sealcs
    {
        public virtual void play()
        {
            Console.WriteLine("Play In Ground");
        }

        internal virtual void study()
        {
            Console.WriteLine("In Library");
        }

        static internal void m1()
        {
            Console.WriteLine("In Static");
        }

      /*  static virtual internal void m2()//
        {
            Console.WriteLine("In Static");
        }*/
    }
    class pp :Sealcs
    {
        public override void play()
        {
            Console.WriteLine("Play In Game");
        }
        internal sealed override void study()
        {
            Console.WriteLine("IN Book");

        }
        static internal new void m1()//
        {
            Console.WriteLine("In Static");
        }

        static internal void m2()// static method can't override
        {
            Console.WriteLine("In Static");
        }
    }
}
