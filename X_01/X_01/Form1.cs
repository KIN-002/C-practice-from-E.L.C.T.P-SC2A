using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int math1 = 1; math1 <= 9; math1++) 
            {
                for (int math2 = 1; math2 <= 9; math2++) 
                {
                    textBox1.AppendText(text: math1 + "*" + math2 + "=" + (math1 * math2).ToString("00") + "\t");
                }
            textBox1.AppendText("\r\n");
            }
        }

        
    }
}
