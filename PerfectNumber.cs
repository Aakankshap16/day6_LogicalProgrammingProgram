using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractice
{
    internal class PerfectNumber
    {
        public static void FindPerNumber()
        {
                int sum = 0;


            Console.WriteLine("Find the perfect number");
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    Console.Write($" {i} + ");
                }
            }
             
            if (num == sum)
            {
                Console.WriteLine($"Given {num} is a perfect number");
            }
            else
            {
                Console.WriteLine($"Given {num} is not a perfect number");
            }






        }
    }
}
