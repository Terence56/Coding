using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwed;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int start = (int)numericUpDown1.Value;
            int end = (int)numericUpDown2.Value;
            if (start < end)
            {
                milesTraveled = end -= start;
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = "$ " + amountOwed;
            }
            else
            {
                MessageBox.Show("This starting mileage must be less than the ending mileage", "Cannot Calculate");
                //label4.Text = "Cannot Calculate";
                //updateForm();
            }

        }

        
    }
}
