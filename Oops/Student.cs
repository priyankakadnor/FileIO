using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Student
    {
       
        private string name;
        private int age;
        private float percentage;
        
      
        public void setName(string sname)
        {
            name= sname;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int sage)
        {
            age = sage;
        }
        public int getAge()
        {
            return age;
        }
        public void setPercentage(float per)
        {
            percentage = per;
        }
        public float getPercentage()
        {
            return age;
        }
        static void Main(string[] args)
        {
            Student s = new Student();


            Console.WriteLine("Enter Student Name");
            string N = Console.ReadLine();
            s.setName(N);

            Console.WriteLine("Enter Student Age");
            int A = Convert.ToInt32(Console.ReadLine());
            s.setAge(A);


            Console.WriteLine("Enter Student Percentage");
            float P= Convert.ToInt32(Console.ReadLine());
            s.setPercentage(P);

            Student s2 = new Student();
            s2.setName("Priyanka");
            s2.setAge(20);
            s2.setPercentage(89.30f);

            Console.WriteLine(s2.getName());
            Console.WriteLine(s2.getAge());
            Console.WriteLine(s2.getPercentage());

        }

    }
}
