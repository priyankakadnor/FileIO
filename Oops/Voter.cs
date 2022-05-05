using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Voter
    {
        long adharcard;
        string votername;
        string votecasted;

        public void setadhar(long anumber)
        {
            adharcard = anumber;
        }
        public long getadhar()
        {
            return adharcard;
        }

        public void setname(string nm)
        {
            votername = nm;
        }
        public string getname()
        {
            return votername;
        }

        public void setcaste(string casted)
        {
            votecasted = casted;
        }
        public string getcaste()
        {
            return votecasted;
        }

        static void Main(string[] args)
        {
            Voter v = new Voter();
            v.setadhar(2585236974);
            long adhar = v.getadhar();

            v.setname("priyanka");
            string name = v.getname();

            v.setcaste("xz");
            string caste = v.getcaste();

        }
    }
}
