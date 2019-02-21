using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Numkeys // methods to append numbers to input
        
        private void Zero_Click(object sender, EventArgs e)
        {
            this.Input.Text += 0;
        }


        private void One_Click(object sender, EventArgs e)
        {
            this.Input.Text += 1;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.Input.Text += 2;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.Input.Text += 3;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.Input.Text += 4;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.Input.Text += 5;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.Input.Text += 6;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.Input.Text += 7;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.Input.Text += 8;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.Input.Text += 9;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            this.Input.Text += '.';
        }


        #endregion

        #region operatorinput // appends operators to input

        private void Minus_Click(object sender, EventArgs e)
        {
            this.Input.Text += '-';
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            this.Input.Text += '+';
        }

        private void Times_Click(object sender, EventArgs e)
        {
            this.Input.Text += '*';
        }

        private void Divided_Click(object sender, EventArgs e)
        {
            this.Input.Text += '/';
        }
        #endregion

        private void Equals_Click(object sender, EventArgs e) // evaluates expression in input if no = are present
        {
            if (this.Input.Text.Contains("="))
            {
                return;
            }   
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    var v = dt.Compute(this.Input.Text, "");
                    this.Input.Text += " = ";
                    this.Input.Text += v;
                }

                catch (Exception a)
                {
                    this.Input.Text = "";
                    this.Input.Text += a;
                }
            }

        }

        private void Clear_Click(object sender, EventArgs e) // clears input
        {
            this.Input.Text = "";
        }
    }
}
