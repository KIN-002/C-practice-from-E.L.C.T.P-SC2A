using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double math1, math2, ans;
                ans = 0;
                math2 = Convert.ToInt32(textBox1.Text);
                for (math1 = 0; math1 <= math2; math1++)
                {
                    ans += Math.Pow(2, math1);
                }
                MessageBox.Show("The ans is:" + ans);
            }
            catch
            {
                MessageBox.Show("Not play");
            }
        }
    }
}
