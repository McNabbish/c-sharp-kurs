using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using sudokutesting;

namespace sudokutesting
{
    class Program
    {


        static void Main(string[] args)
        {
            SudokuLoader a = new SudokuLoader();
            string[][] SudokuBoard = a.Load(@"C:\Users\johan\Documents\EasySudoku.txt");

            Board Sudoku = new Board(SudokuBoard);

            Sudoku.solve();

            Console.ReadLine();
        }





    }
 }   


