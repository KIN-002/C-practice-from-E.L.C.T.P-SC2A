using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hour;
            DateTime localDate = DateTime.Now;

            string msg = "現在是:";
            msg = msg + localDate.ToString("dd/MM/yyyy HH:mm:ss");
            hour = Convert.ToInt32(localDate.ToString("HH"));
            if (hour <= 18 && hour >= 24)
            {
                msg = msg + "\n" + "Good night";
            }
            else if (hour <= 12 && hour >= 5) 
            {
                msg = msg + "\n" + "Good afternoon";
            }
            else
            {
                msg = msg + "\n" + "Good morning";
            }

            MessageBox.Show(msg);
        }
    }
}
