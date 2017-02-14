using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writes line to screen
            //Waits user input
            Console.WriteLine("Type your first name:");
            string strName=Console.ReadLine();
            //Console.WriteLine("Your name is " + strName);
            Console.WriteLine("Type your last name:");
            string strLastName = Console.ReadLine();
            Console.WriteLine("Your firstname is {0} and lastname {1} ", strName,strLastName);
            Console.ReadKey();
        }
    }
}
