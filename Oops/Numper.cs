using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch.Oops
{
    class Numper
    {
		static void Main(string[] args)
		{

			int num = Convert.ToInt32(Console.ReadLine());
			Boolean flag = true;
			for (int i = 2; i <=100; i++)
			{
				if (num % i == 0)
				{
					flag = false;
					break;

				}
			}
			if (flag == true)
			{
				Console.WriteLine("The Number is prime");
			}
			else
			{
				Console.WriteLine("The Number is Not Prime");
			}
		}
	}
}
    
