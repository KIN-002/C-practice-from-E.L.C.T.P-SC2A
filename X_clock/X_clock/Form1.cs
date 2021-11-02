using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            label1.Text = localDate.ToString("HH:mm:ss");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            DateTime todday = DateTime.Now;
            int Week=0;
            if (todday.DayOfWeek==DayOfWeek.Monday)
            {
                label2.Text = localDate.ToString("dd/MM/yyyy")+ "Monday";
            }
            else if (todday.DayOfWeek==DayOfWeek.Tuesday)
            {
                label2.Text = localDate.ToString("dd/MM/yyyy")+"Tuesday";
            }
            else if (todday.DayOfWeek == DayOfWeek.Wednesday)
            {
                label2.Text = localDate.ToString("dd/MM/yyyy")+"Wednesday";
            }
            else if (todday.DayOfWeek == DayOfWeek.Thursday)
            {
                label2.Text = localDate.ToString("dd/MM/yyyy") + "Thursday";
            }
            else if (todday.DayOfWeek == DayOfWeek.Friday)
            {
                label2.Text = localDate.ToString("dd/MM/yyyy") + "Friday";
            }
            else if (todday.DayOfWeek == DayOfWeek.Saturday)
            {
                label2.Text = localDate.ToString("dd/MM/yyyy") + "Saturday";
            }
            else if (todday.DayOfWeek == DayOfWeek.Sunday)
            {
                label2.Text = localDate.ToString("dd/MM/yyyy") + "Sunday";
            }
        }
    }
}
