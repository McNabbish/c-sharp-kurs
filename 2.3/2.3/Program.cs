using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            User A = new User();
            string test;

            Console.WriteLine("input old password: ");
            test = Console.ReadLine();

            A.ChangePassword(test);


            Console.ReadLine();
        }
    }
}
