using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int math1, math2;
            for (math1 = 2; math1 < 200; math1++)
            {
                for (math2 = 2; math2< math1; math2++)
                {
                    if (math1 % math2 == 0 && math1 != math2)
                    {
                        break;            
                    }
                }
                if (math1 % math2 == 0 && math1 == math2) 
                {
                    textBox1.AppendText(text: math1 + "\t");
                }
            }
        }
    }
}
