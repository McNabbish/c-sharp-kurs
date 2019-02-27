using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudGUI
{
    class Board
    {

        public List<List<Cell>> SBoard = new List<List<Cell>>(); // list used in calculations
        List<Cell> SubList = new List<Cell>(); //sublist to construct SBoard

        List<List<List<String>>> BoardVals = new List<List<List<String>>>();
        List<List<List<String>>> BoardPosi = new List<List<List<String>>>();

        int GuessLevel = 0;
        public int NeededGuesses = 0;

        Stack MyValStack = new Stack();
        Stack MyPosStack = new Stack();

        bool changed = false;
        bool error = false;

        public void SaveBoardVals()
        {
            List<List<String>> tempboard = new List<List<String>>();


            for (int i = 0; i < 9; i++)
            {
                List<String> temprow = new List<String>();
                for (int j = 0; j < 9; j++)
                {
                    temprow.Add(SBoard[i][j].Value);
                }
                tempboard.Add(temprow);
            }
            BoardVals.Add(tempboard);

            //Console.WriteLine("Saved boardvals at boardvals[{0}]", GuessLevel);
        }

        public void SaveBoardPosi()
        {
            List<List<String>> tempboard = new List<List<String>>();


            for (int i = 0; i < 9; i++)
            {
                List<String> temprow = new List<String>();
                for (int j = 0; j < 9; j++)
                {
                    temprow.Add(SBoard[i][j].Possibly);
                }
                tempboard.Add(temprow);
            }
            BoardPosi.Add(tempboard);

            // Console.WriteLine("Saved boardPossibles at boardposi[{0}]", GuessLevel);
        }

        public void LoadBoardVals(int GuessIndex)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SBoard[i][j].Value = BoardVals[GuessIndex][i][j];
                }
            }

            //  Console.WriteLine("Loaded saved board values");
        }

        public void LoadBoardPosi(int GuessIndex)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SBoard[i][j].Possibly = BoardPosi[GuessIndex][i][j];
                }
            }

            //  Console.WriteLine("Loaded saved board possibilities");
        }

        public void solve()
        {
            changed = true;
            error = false;
            while (changed == true && error == false)
            {
                UpdatePossibleValues();
                InsertObvious();
            }

            if (IsSolved() == true)
            {
                Console.WriteLine("Sudoku solved: ");
                PrintBoardValues();
                return;
            }



            if (CanGuess() == false || error == true) // this check stops working suddenly
            {
                if (GuessLevel == 0)
                {
                    Console.WriteLine("Sudoku has no solution");
                    return;
                }
                LoadBoardPosi(GuessLevel - 1); // reverting to board before first guess
                LoadBoardVals(GuessLevel - 1);
                BoardVals.RemoveAt(GuessLevel - 1);
                BoardPosi.RemoveAt(GuessLevel - 1);
                GuessLevel--;
                RemoveFirstGuess(); //first revert -> remove 1 value
                SaveBoardPosi();
                SaveBoardVals();
                solve();
            }
            else
            {
                SaveBoardPosi();
                SaveBoardVals();
                GuessLevel++;
                guess();
                NeededGuesses++;
                solve();
            }
        }



        public bool CanGuess()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SBoard[i][j].Value == "0" && SBoard[i][j].Possibly.Length < 1)
                        return false;
                }
            }
            return true;

        }

        public bool IsSolved()
        {
            //Console.WriteLine("Testing if solved: ");

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SBoard[i][j].Value == "0")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void RemoveFirstGuess()
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SBoard[i][j].Value == "0")
                    {
                        if (SBoard[i][j].Possibly.Length < 1)
                        {
                            //Console.WriteLine("Error removing possible guess from [{0}],[{1}], possible = {2}", i, j, SBoard[i][j].Possibly);
                            return;
                        }

                        SBoard[i][j].RemovePossible(SBoard[i][j].Possibly[0].ToString());
                        return;
                    }
                }
            }

        }

        public Board(string[][] inp) // constructor, generates sudokuboard of cells
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SubList.Add(new Cell(inp[i][j]));
                }
                SBoard.Add(SubList);
                SubList = new List<Cell>();
            }

        }

        public void PrintBoardValues() // prints  current sudoku-board
        {
            foreach (var a in SBoard)
            {
                foreach (var b in a)
                    Console.Write(" {0} ", b.Value);
                Console.WriteLine();
            }
        }

        public void PrintPossibleValues()
        {
            foreach (var a in SBoard)
            {
                foreach (var b in a)
                    Console.Write(" {0} ", b.Possibly);
                Console.WriteLine();
            }

        } // prints possible values of cell

        public void UpdatePossibleValues()
        {
            //Console.WriteLine("updating possible values");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    CheckRow(i, j);
                    CheckCol(i, j);
                    CheckSub(i, j);

                    if (SBoard[i][j].Possibly.Length == 0 && SBoard[i][j].Value == "0") //error in input or wrong guess
                    {
                        error = true;
                        return;
                    }
                }
            }
        } // updates possible values of cell

        public void InsertObvious()
        {
            //Console.WriteLine("inserting obvious values");
            changed = false;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SBoard[i][j].Possibly.Length == 1 && SBoard[i][j].Value == "0")
                    {
                        //Console.WriteLine("Inserting {0} at [{1}],[{2}]", SBoard[i][j].Possibly, i, j);
                        SBoard[i][j].Value = SBoard[i][j].Possibly;
                        SBoard[i][j].Possibly = "";
                        changed = true;
                        return;
                    }
                }
            }
            if (changed != true)
            {
                //Console.WriteLine("All obvious found, board is now: ");
                //PrintBoardValues();
            }
        }

        void guess()
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SBoard[i][j].Value == "0")
                    {
                        SBoard[i][j].Value = SBoard[i][j].Possibly[0].ToString(); // guess first possible value of first unfilled cell
                        //Console.WriteLine("Guessing [{0}],[{1}] = {2}", i, j, SBoard[i][j].Possibly[0].ToString());
                        //PrintBoardValues();
                        return;
                    }
                }
            }
            Console.WriteLine("No Possible guess found"); // this point should not be reached...
            //PrintPossibleValues();


        }


        void CheckRow(int row, int col) // checks row of input cell and removes found found values from possible values
        {
            if (SBoard[row][col].Value != "0") // if cell already filled do nothing
                return;

            for (int j = 0; j < 9; j++)
            {
                if (SBoard[row][j].Value != "0")
                {
                    SBoard[row][col].RemovePossible(SBoard[row][j].Value);
                }
            }
        }

        void CheckCol(int row, int col) // checks cols of input cell and removes found values from possible values
        {
            if (SBoard[row][col].Value != "0") // if cell already filled do nothing
                return;

            for (int j = 0; j < 9; j++)
            {
                if (SBoard[j][col].Value != "0")
                {
                    SBoard[row][col].RemovePossible(SBoard[j][col].Value);
                }
            }
        }

        void CheckSub(int row, int col) // check subgrid for values to remove from possible
        {
            if (SBoard[row][col].Value != "0") // if cell already filled do nothing
                return;

            int rowstart = (row / 3) * 3;
            int colstart = (col / 3) * 3;

            for (int i = rowstart; i < (rowstart + 3); i++)
            {
                for (int j = colstart; j < (colstart + 3); j++)
                {
                    SBoard[row][col].RemovePossible(SBoard[i][j].Value);
                }
            }
        }

    }
}