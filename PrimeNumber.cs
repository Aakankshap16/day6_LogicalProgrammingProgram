﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractice
{
    internal class PrimeNumber
    {
        public static void call()
        {
            bool Flag = true;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 1)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} is not a prime number");
                        Flag = false;
                        break;
                    }
                }


                if (Flag == true)
                    Console.WriteLine($"{num} is a prime number");
            }
            else
            { 
                Console.WriteLine("enter valid number");
            }
            
        }
    }
}
