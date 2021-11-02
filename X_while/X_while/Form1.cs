using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = 135;
            int n = 0;
            while (s >= 10) 
            {
                s /= 2;
                n++;
            }
            MessageBox.Show("小明共需要把繩子對摺" + n + "次");
        }
    }
}
