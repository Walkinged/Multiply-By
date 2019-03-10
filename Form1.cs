using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int answer = 0;
        public int multiplyBy = 12;
        public int loopStart;
        public int loopEnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void loopBTN_Click(object sender, EventArgs e)
        {
            loopStart = Convert.ToInt32(N1TXT.Text);
            loopEnd = Convert.ToInt32(N4TXT.Text);
            


           for (int i = loopStart; i <=loopEnd; i++)
            {
                answer = i = 1;

                listBox1.Items.Add(i + " Times " + multiplyBy + "=" + answer.ToString());
            }
        }

        private void LstartTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
