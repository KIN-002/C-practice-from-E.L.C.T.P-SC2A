using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bin2Dec
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "") 
			{
				int nem, r;
				nem = Convert.ToInt32(textBox1.Text); 
				if (radioButton1.Checked == true)
				{
					if (nem < 0)
						MessageBox.Show("請輸入正數");
					else
					{
						int i, d, l,p;
						string bin;
						double ans = 0;
						bin = textBox1.Text;
						l = bin.Length - 1;
						for (i = 0; i <= l; i++)
						{
							d = Convert.ToInt32(Convert.ToString(bin[i]));
							p = l - i;
							ans += d * Math.Pow(2,p);
						}
						ansLbl.Text = "十進制是:" + ans;
					}
				}
				else
				{
					string ans;
					ans = "";
					if (nem < 0)
						MessageBox.Show("請輸入正數");
					else
					{
						while (nem > 0)
						{
							r = nem % 2;
							nem = nem / 2;
							ans = r + ans;
						}
						ansLbl.Text = "二進制是:" + ans;
					}
				}
			}
			else
			{
				MessageBox.Show("請輸入正確數值");
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			label1.Text = "十進制轉二進制";
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			label1.Text = "二進制轉十進制";
		}
	}
}
