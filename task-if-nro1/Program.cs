﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_if_nro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type number: ");
            int iNro = int.Parse(Console.ReadLine());
            if (iNro < 0)
            {
                Console.WriteLine("You type {0} and it is negative", iNro);
            }
            else if (iNro == 0)
            {
                Console.WriteLine("You type {0} and it is zero", iNro);
            }
            else
            {
                Console.WriteLine("You type {0} and it is positive", iNro);
            }
            Console.ReadLine();
        }
       
    }
}
