using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lisajour
{
    public partial class Form1 : Form
    {
        double[] x1 = new double[100]; //datavalues for series 1
        double[] y1 = new double[100];
        double f1 = 1;

        double[] x2 = new double[100]; // data values for series 2
        double[] y2 = new double[100];
        double f2 = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // draws figure without changing any values
        {
            Draw();
        }

        private void Series1FDial_ValueChanged(object sender, EventArgs e) //changes frequency of series 1
        {
            f1 = (double)Series1FDial.Value;
            Draw();
        }

        private void Series2FDial_ValueChanged(object sender, EventArgs e) // changes frequency of series 2
        {
            f2 = (double)Series2FDial.Value;
            Draw();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // hides/displays legend
        {
            if (checkBox1.Checked)
            {
                chart1.Series[0].IsVisibleInLegend = false;
                chart1.Series[1].IsVisibleInLegend = false;
            }
            else
            {
                chart1.Series[0].IsVisibleInLegend = true;
                chart1.Series[1].IsVisibleInLegend = true;
            }
        }


        //helper functions
        private void Draw() // updates charts with lisabon figures
        {

            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();

            for (int i = 0; i < 100; i++) // plotting series 1
            {
                x1[i] = -1 * Math.PI + 0.02 * i * Math.PI;
                y1[i] = Math.Sin(x1[i] * f1);

                chart1.Series["Series1"].Points.AddXY(y1[i], -1+0.02*i);
            }

            for (int i = 0; i < 100; i++) // plotting series 2
            {
                x2[i] = -1 * Math.PI + 0.02 * i * Math.PI;
                y2[i] = Math.Sin(x2[i] * -f2);

                chart1.Series["Series2"].Points.AddXY(y2[i], -1 + 0.02 * i);
            }
        }


    }
}
