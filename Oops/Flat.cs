using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
   
     class Flat
        {
            int fno;
            string buildingname;
            Member mem=new Member();
            public Flat()
            {

            }
            public Flat(int fno, string buildingname)
            {
                this.Fno = fno;
                this.Buildingname = buildingname;
            }

            public int Fno { get => fno; set => fno = value; }
            public string Buildingname { get => buildingname; set => buildingname = value; }
        internal Member Mem { get => mem; set => mem = value; }
    }
        class Member
        {
            string memname;
            char gender;
            int age;
            string profession;
            public Member()
            {

            }

            public Member(string memname, char gender, int age, string profession)
            {
                this.Memname = memname;
                this.Gender = gender;
                this.Age = age;
                this.Profession = profession;
            }

            public string Memname { get => memname; set => memname = value; }
            public char Gender { get => gender; set => gender = value; }
            public int Age { get => age; set => age = value; }
            public string Profession { get => profession; set => profession = value; }
        }


    class info
    {
        static void Main(string[] args)
        {
            Flat f = new Flat();
            f.Fno = 1;
            f.Buildingname = "xyz";
            f.Mem.Memname = "Piya";
            f.Mem.Gender ='f';
            f.Mem.Age = 23;
            f.Mem.Profession = "Teacher";

            Console.WriteLine(f.Fno);
            Console.WriteLine(f.Buildingname);
            Console.WriteLine(f.Mem.Memname);
            Console.WriteLine(f.Mem.Gender);
            Console.WriteLine(f.Mem.Age);
            Console.WriteLine(f.Mem.Profession);


        }
    }
}


