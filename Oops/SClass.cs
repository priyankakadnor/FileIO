using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class SClass
    {
        static int no;
        int price;
        string name;
        internal SClass()
        {
            Console.WriteLine("in Default Constructor");
        }

        internal SClass(int price, string name)
        {
            Console.WriteLine("In Parameter Constructor");
            this.price = price;
            this.name = name;

        }
    

        static SClass()
        {
            Console.WriteLine("In Static Constructor");
            no = 123;
            Console.WriteLine(no);
        }
        class Test_1
        {

            static void Main(string[] args)
            {
                SClass s = new SClass(20,"bat");

            }
        }
    }

    }


