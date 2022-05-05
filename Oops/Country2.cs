using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Country2
    {
        string countryname;
        int noofstate;
        int nooflaunage;
        string capital;

        public string CountryName
        {
            get { return countryname; }
            set { countryname = value; }

        }
        public int NoOfState
        {
            get { return noofstate; }
            set { noofstate = value; }
        }
        public int NoOfLaunage
        {
            set { nooflaunage = value; }
            get { return nooflaunage; }
        }


        public string Capital
        {
            get { return capital; }
            set { capital = value; }

        }
    
        static void Main(string[] args)
        {
            Country2 c = new Country2();
            c.CountryName = "India";
            c.NoOfState=4;
            c.NoOfLaunage=4;
            c.Capital="Malegaon";

            Console.WriteLine(c.CountryName);
            Console.WriteLine(c.NoOfState);
            Console.WriteLine(c.NoOfLaunage);
            Console.WriteLine(c.Capital);

        }

    }
}
