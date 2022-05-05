using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.AccessModifier
{
    class Inheri
    {
        public void add()
        {
            Console.WriteLine("hello");
        }

    }
        class sum : Inheri
        {

            static void Main(string[] args)
            {
                Inheri ob = new Inheri();
                ob.add();
            }
        }
    }

   