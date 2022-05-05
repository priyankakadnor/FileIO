using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Car
    {
        int num;
        string Name;
        string Colour;
        long price;
        static void Main(string[] args)
        {
            Car c = new Car();
            c.num = 101;
            c.Name = "PMW";
            c.Colour = "Black";
            c.price=253467;


            Car c2 = new Car();
            c2.num = 102;
            c2.Name = "Indica";
            c2.Colour = "White";
            c2.price = 153467;

            Console.WriteLine(c.num);
            Console.WriteLine($"name={c.Name} colour={c.Colour}  price={c.price}");

            Console.WriteLine(c2.num);
            Console.WriteLine($"name={c2.Name} colour={c2.Colour}  price={c2.price}");


        }
    }
}
