using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Movie
    {


        string moviname;
        string directorname;
        string producer;
        string actorname;
        int rating;
        string r;

        public Movie()
        {
            Console.WriteLine("In Movie Constructor");
        }
        public void setMoviename(string mname)
        {
            moviname = mname;
        }
        public string getMoviename()
        {
            return moviname;
        }

        public void setDirectorname(string dname)
        {
            directorname = dname;
        }
        public string getDirectorname()
        {
            return directorname;
        }

        public void setProducer(string pname)
        {
            producer = pname;
        }
        public string getProducer()
        {
            return producer;
        }
        public void setActor(string aname)
        {
            actorname = aname;
        }
        public string getActor()
        {
            return actorname;
        }

        public void setRating(int rate)
        {
            rating = rate;
        }
        public int getRating()
        {
            return rating;
        }
    

        static void Main(string[] args)
        {
            Movie m = new Movie();
            Console.WriteLine("Enter The Moviename");
            string mn = Console.ReadLine();
            m.setMoviename(mn);

            Console.WriteLine("Enter The Directorname");
            string dn = Console.ReadLine();
            m.setDirectorname(dn);

            Console.WriteLine("Enter The Producer");
            string pn = Console.ReadLine();
            m.setProducer(pn);

            Console.WriteLine("Enter The ActorName");
            string an = Console.ReadLine();
            m.setActor(an);

            Console.WriteLine("Enter The Rating");
            int ratee = Convert.ToInt32(Console.ReadLine());
            m.setRating(ratee);

            //Console.WriteLine(*******************);
            Console.WriteLine("Detail Of Movies");
            Console.WriteLine(m.getMoviename());
            Console.WriteLine(m.getDirectorname());
            Console.WriteLine(m.getProducer());
            Console.WriteLine(m.getActor());
            Console.WriteLine(m.getRating());

        }  }
}
