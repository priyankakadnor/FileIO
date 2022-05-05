using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.String
{
    class Passwrd
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter The Password");
            string password = Console.ReadLine();
            if(password.Length<5)
            {
                Console.WriteLine();
            }

                   
        }
    }
}

