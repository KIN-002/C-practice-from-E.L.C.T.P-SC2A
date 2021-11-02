using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace month
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month;
            month = listBox1.SelectedIndex;
            switch (month)
            {
                case 0:Engmonth.Text = "January";
                    break;
                case 1:Engmonth.Text = "February";
                    break;
                case 2:Engmonth.Text = "March";
                    break;
                case 3:Engmonth.Text = "April";
                    break;
                case 4:Engmonth.Text = "May";
                    break;
                case 5:Engmonth.Text = "June";
                    break;
                case 6:Engmonth.Text = "July";
                    break;
                case 7:Engmonth.Text = "August";
                    break;
                case 8:Engmonth.Text = "September";
                    break;
                case 9:Engmonth.Text = "October";
                    break;
                case 10:Engmonth.Text = "November";
                    break;
                case 11:Engmonth.Text = "December";
                    break;
            }
        }
    }
}
