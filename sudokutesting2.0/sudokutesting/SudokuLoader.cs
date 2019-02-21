using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;


namespace sudokutesting
{
    class SudokuLoader // loads sudoku from txt file and returns as jagged array, txt file must use , separators
    {
        string[] input = new string[9];

        public string[][] Load(string filePath)
        {
            String[] text = new string[10];
            String[][] Out = new string[10][];

            try
            {
                text = File.ReadAllLines(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            Console.WriteLine("Input sudoku is: ");
            for (int i = 0; i < 9; i++)
            {
                Out[i] = text[i].Split(',');
                Console.WriteLine("[{0}]", string.Join(", ", Out[i]));
            }
            return Out;

        }
    }
}
