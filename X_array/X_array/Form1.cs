using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nem = new int[20];
            Random math = new Random();
            label2.Text = "";
            for (int i = 0; i < 20; i++)
            {
                label2.Text += nem[i] + "";
            }
        }
    }
}
