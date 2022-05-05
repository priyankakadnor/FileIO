using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.AccessModifier
{
    class Teacher
    {
        int tid;
        string tname;
        int exp;
        long salary;

        public Teacher()
        {
            Console.WriteLine("In Teacher Default Parameteries Contrustor");
        }
        public Teacher(int id, string name, int texp, long sal)
        {
            this.Tid = id;
            this.Tname = name;
            this.Exp = texp;
            this.Salary = sal;
        }

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public int Exp { get => exp; set => exp = value; }
        public long Salary { get => salary; set => salary = value; }
    }
}
