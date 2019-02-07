using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Object
    {
        public static int nObj = 0;
        Random RNG = new Random();
        readonly private int ID;

       public Object()
        {
            nObj++;
            ID = RNG.Next(0, 1000000 + 1);

            Console.WriteLine("Object with ID: '{0}' created", ID);
        }

        public int GetID()
        {
            return ID;
        }

    }
}
