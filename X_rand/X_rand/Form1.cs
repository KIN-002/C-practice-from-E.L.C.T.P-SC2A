using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_rand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetColor_button_Click(object sender, EventArgs e)
        {
            int r, g, b;
            Random rand = new Random();
            r = rand.Next(0, 256);
            g = rand.Next(0, 256);
            b = rand.Next(0, 256);
            red.Text = "紅: " + r.ToString();
            green.Text = "綠: " + g.ToString();
            blue.Text = "藍: " + b.ToString();

            this.BackColor = Color.FromArgb(255, r, g, b);
            
            r = 255 - r;
            g = 255 - g;
            b = 255 - b;
            red.ForeColor = Color.FromArgb(255, r, g, b);
            green.ForeColor = Color.FromArgb(255, r, g, b);
            blue.ForeColor = Color.FromArgb(255, r, g, b);
        }

        private void White_button_Click(object sender, EventArgs e)
        {
            red.Text = "紅: 255";
            green.Text = "綠: 255";
            blue.Text = "藍: 255";

            this.BackColor = Color.FromArgb(255, 255, 255, 255);

            red.ForeColor = Color.FromArgb(255, 0, 0, 0);
            green.ForeColor = Color.FromArgb(255, 0, 0, 0);
            blue.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void Black_button_Click(object sender, EventArgs e)
        {
            red.Text = "紅: 0";
            green.Text = "綠: 0";
            blue.Text = "藍: 0";
            this.BackColor = Color.FromArgb(255, 0, 0, 0);
            red.ForeColor = Color.FromArgb(255, 255, 255, 255);
            green.ForeColor = Color.FromArgb(255, 255, 255, 255);
            blue.ForeColor = Color.FromArgb(255, 255, 255, 255);
        }
    }
}
