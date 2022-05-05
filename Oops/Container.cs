using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
   


        class Stud
        {
            int rollno;
            string name;
            Address add = new Address();
            Batch b = new Batch();
            public Stud()
            {

            }

            public Stud(int rollno, string name)
            {
                this.Rollno = rollno;
                this.Name = name;
            }

            public int Rollno { get => rollno; set => rollno = value; }
            public string Name { get => name; set => name = value; }
            internal Batch B { get => b; set => b = value; }
            private Address Add { get => add; set => add = value; }
        }
        class Address
        {
            string city;
            string area;

            public Address()
            {

            }

            public Address(string city, string area)
            {
                this.City = city;
                this.Area = area;
            }

            public string City { get => city; set => city = value; }
            public string Area { get => area; set => area = value; }
        }

        class Batch
        {
            string name;
            string subject;
            public Batch()
            {

            }

            public Batch(string name, string subject)
            {
                this.Name = name;
                this.Subject = subject;
            }

            public string Name { get => name; set => name = value; }
            public string Subject { get => subject; set => subject = value; }
        }

        class Test
        {
            static void Main(string[] args)
            {
                Stud s = new Stud();
                s.Rollno = 1;
                s.Name = "Priyanka";

            Console.WriteLine(s.Rollno);
            Console.WriteLine(s.Name);




            }
        }
    }

