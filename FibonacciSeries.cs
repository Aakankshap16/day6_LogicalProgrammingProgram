using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractice
{
    internal class FibonacciSeries
    {
        public static void call()
        {
            int n1 = 0; int n2 = 1;
            int n3;
            Console.WriteLine("Enter the limit:");
            int number = int.Parse(Console.ReadLine());
            
            for (int i =0; i < number; i++)
            {
                Console.Write(n1+ " ");
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
               
            }
        }
    }
}
