using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobAndJoe
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            /*bob = new Guy();
            bob.Name = "BOB";
            bob.Cash = 100;*/
            bob = new Guy() { Cash = 100, Name = "BOB" };

            joe = new Guy();
            joe.Name = "JOE";
            joe.Cash = 50;

            UpdateForm();
        }

        public void UpdateForm()
        {
            joeCashlabel1.Text = joe.Name + " has $" + joe.Cash;
            bobCashlabel2.Text = bob.Name + " has $" + bob.Cash;
            bankCashlabel3.Text = "The bankhas $" + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("銀行沒錢");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
            
        }

       

        private void joeGiveBobButton3_Click_1(object sender, EventArgs e)
        {
            //joe to bob//
          
                bob.ReceiveCash(joe.GiveCash(10));
                UpdateForm();
          
        }

        private void bobGiveJoeButton4_Click(object sender, EventArgs e)
        {
          
                joe.ReceiveCash(bob.GiveCash(5));
                UpdateForm();
           
        }
    }
}
