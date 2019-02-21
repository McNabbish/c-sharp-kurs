using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokutesting
{
    class Cell
    {
        public bool Prefilled;
        public string Possibly;
        public string Value;

        public Cell(string inp) // constructor
        {
            if (inp == "0")
            {
                Prefilled = false;
                Possibly = "123456789";
                Value = "0";
            }
            else
            {
                Prefilled = true;
                Possibly = "";
                Value = inp;
            }
        }

        public void PrintPossible() // prints possible values of cell
        {
            Console.Write(Possibly);
        }


        public void RemovePossible(string ToRemove) // removes value from possible list
        {
            if (Possibly.IndexOf(ToRemove) != -1)
            {
                Possibly = Possibly.Remove(Possibly.IndexOf(ToRemove), 1);
            }

        }

    }
}
