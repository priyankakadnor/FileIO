using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Order
    {
        int orderid;
        string orderdate;
        Customer c=new Customer();
        Item I=new Item();

        public Order()
        {

        }
        public Order(int orderid, string orderdate)
        {
            this.Orderid = orderid;
            this.Orderdate = orderdate;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        public Customer C { get => c; set => c = value; }
        public Item Item1 { get => I; set => I = value; }
    }
  
        class Customer
        {
            string custname;
           long custmobno;
        Address_1 add = new Address_1();

        public Customer()
        {

        }

        public Customer(string custname, long custmobno)
        {
            this.Custname = custname;
            this.Custmobno = custmobno;
        }

        public string Custname { get => custname; set => custname = value; }
        public long Custmobno { get => custmobno; set => custmobno = value; }
        internal Address_1 Add { get => add; set => add = value; }
        }
        class Address_1
         {
        string city;
        string area;
        public Address_1()
        {

        }

        public Address_1(string city, string area)
        {
            this.City = city;
            this.Area = area;
        }

        public string City { get => city; set => city = value; }
        public string Area { get => area; set => area = value; }
    }
        class Item
        {
            int itno;
            string name;
        public Item()
        {

        }

            public Item(int itno, string name)
            {
                this.Itno = itno;
                this.Name = name;
            }

            public int Itno { get => itno; set => itno = value; }
            public string Name { get => name; set => name = value; }
        }
        class Product
        {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Orderid = 1;
            o.Orderdate = "2/3/2020";
            o.C.Custname = "Priyanka";
            o.C.Custmobno = 8595652535;
            o.Item1.Itno = 2;
            o.Item1.Name = "Shampoo";
            o.C.Add.Area = "Mitra nagar";
            o.C.Add.City = "Malegaon";

            Console.WriteLine(o.Orderid);
            Console.WriteLine(o.Orderdate);
            Console.WriteLine(o.C.Custname);
            Console.WriteLine(o.C.Custmobno);
            Console.WriteLine(o.Item1.Itno);
            Console.WriteLine(o.Item1.Name);
            Console.WriteLine(o.C.Add.Area);
            Console.WriteLine(o.C.Add.City);



        }

        }
    
}
