using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            var ObjList = new List<Object>();
            int c=0;

            while (true)
            {
                Console.WriteLine("To spawn object, enter 1, To find number of existing objects enter 2, to print unique id of all objects enter 3:");
                try
                {
                    c = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Console.WriteLine("input error: {0}", e);
                }

                switch (c)
                {
                    case 1:
                        ObjList.Add(new Object());
                        break;
                    case 2:
                        Console.WriteLine("Number of objects created: {0}", Object.nObj);
                        break;
                    case 3:
                        foreach (Object T in ObjList)
                        {
                            Console.WriteLine(T.GetID());
                        }
                        break;
                }


            }



        }
    }
}
