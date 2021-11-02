using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d_chicken, m_chicken, s_chicken;
            int x = 0;
            for (d_chicken = 0; d_chicken <= 50; d_chicken++)
            {
                for (m_chicken = 0; m_chicken <= 100; m_chicken++)
                {
                    for (s_chicken = 0; s_chicken <= 200; s_chicken++) 
                    {
                        if (d_chicken + m_chicken + s_chicken == 100)
                        {
                            if (d_chicken * 2 + m_chicken + s_chicken * 0.5 == 100) 
                            {
                                textBox1.Text += d_chicken + "\t" + m_chicken + "\t" + s_chicken + "\r\n";
                                x++;
                                label1.Text = "共有" + x + "方法";
                            }
                        }
                    }
                }
            }
        }
    }
}
