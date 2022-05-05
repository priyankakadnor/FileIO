using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Chain
    {
        private int empid;
        private string empname;
        private long mobileno;
        private string address;
        private int salary;

        public Chain(int id, string nm)
        {
            Console.WriteLine("in 2");
            empid = id;
            empname = nm;
        }
        public Chain(int id, string nm,long mb) : this(id, nm)
        {
            Console.WriteLine("in 3");

          /*  empid = id;
            empname = nm;*/
            mobileno = mb;
        }
        public Chain(int id, string nm, long mb, string add) : this(id, nm, mb)
        {/*
            empid = id;
            empname = nm;
            mobileno = mb;*/
            Console.WriteLine(  "in 4");
            address = add;
        }
        public Chain(int id, string nm, long mb, string add,int sal) : this(id, nm, mb,add)

        {
            Console.WriteLine("in 5");
          /*  empid = id;
            empname = nm;
            mobileno = mb;
            address = add;*/
            salary = sal;
        }
        static void Main(string[] args)
        {
            Chain c = new Chain(1, "Priyanka", 7985654523, "Mitra Nagar",500000);
            Console.WriteLine(c.empid);
            Console.WriteLine(c.empname);
            Console.WriteLine(c.address);
            Console.WriteLine(c.mobileno);
            Console.WriteLine(c.salary);

        }

    }
}
