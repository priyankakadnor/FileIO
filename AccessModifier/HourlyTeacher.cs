using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.AccessModifier
{
    class HourlyTeacher:Teacher
    {
        int hour;
        int rate;
        int data;
        public HourlyTeacher()
        {
            Console.WriteLine("In Default");
        }
        public HourlyTeacher(int hour,int rate)
        {
            this.Hour = hour;
            this.Rate = rate;
        }

        public int Hour { get => hour; set => hour = value; }
        public int Rate { get => rate; set => rate = value; }
    }
    class TTest
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.Tid = 1;
            t.Tname = "Deepa";
            t.Salary = 300000;
            t.Exp = 15;

            HourlyTeacher h = new HourlyTeacher();
            h.Tid = 2;


        }
    }
}
