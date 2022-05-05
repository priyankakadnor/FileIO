using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class OverLoading
    {
        int c;
        float z;
        public void add(int a, int b)
        {
            c = a + b;

        }
        public void add(float x,float y)
        {
            z = x + y;
        }
        static void Main(string[] args)
        {
            OverLoading obj = new OverLoading();
            obj.add(10, 5);
            obj.add(2f, 5f);
        }
    }
}
