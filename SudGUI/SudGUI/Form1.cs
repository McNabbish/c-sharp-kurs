using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    textBoxFilePath.Text = openFileDialog.FileName;
                    SudokuLoader a = new SudokuLoader();
                    string[][] SudokuBoard = a.Load(openFileDialog.FileName);
                    dataGridView.Rows.Clear();
                    for (int i=0;i<9;i++)
                    {
                        dataGridView.Rows.Add(SudokuBoard[i]);
                    }
                }
            }

        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            SudokuLoader a = new SudokuLoader();
            string[][] SudokuBoard = new string[9][];
            try
            {
             SudokuBoard = a.Load(textBoxFilePath.Text);
            }
            catch
            {
                MessageBox.Show("error loading file");
            }

            Board Sudoku = new Board(SudokuBoard);
            Sudoku.solve();

            dataGridView.Rows.Clear();

            string[] row = new string[9];

            for (int i=0;i<9;i++)
            {
                for (int j=0;j<9;j++)
                {
                    row[j] = Sudoku.SBoard[i][j].Value;
                }
                dataGridView.Rows.Add(row);
            }

            textBoxEval.Text = "Solution required " + Sudoku.NeededGuesses + " guesses.";
        }
    }
}
