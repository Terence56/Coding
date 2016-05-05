using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda; 
        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant()
            {
                Name = "Lucinda",
                EarSize = 33
            };
            lucinda = new Elephant()
            {
                Name = "Lloyd",
                EarSize = 40
            };

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
            //呼叫方法
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects swapped!");
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //lloyd.TellMe("Hi!",lucinda);
            lloyd.SpeakTo(lucinda, "hellow");
            //lloyd = lucinda;
            //會被複寫
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };
            Elephant biggestEars = elephants[0];
            for(int i = 1; i < elephants.Length; i++)
            {
                if(elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }
            }
            MessageBox.Show(biggestEars.EarSize.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] islands = new string[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";

            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            int y = 0;
            int refNum;
            string result = "";
            while (y < 4)
            {
                refNum = index[y];
                result += "\nisland= ";
                result += islands[refNum];
                //MessageBox.Show(result); 按一次做一次              
                y = y + 1;

            }

            MessageBox.Show(result);

        }
    }
}
