using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_car
{
	public partial class Form1 : Form
	{
		int s = 3;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			int x, y;
			x = car.Location.X;
			y = car.Location.Y;
			if ((e.KeyCode == Keys.Oemplus) && (s < 10))
			{
				s++;
				label1.Text = "速度" + s;
			}
			else if ((e.KeyCode == Keys.OemMinus) && (s > 1)) 
			{
				s--;
				label1.Text = "速度" + s;
			}
			if (e.KeyCode == Keys.Up)
			{
				if (y >= 0)
				{
					Downlabel.Visible = false;
					Leftlabel.Visible = false;
					Rightlabel.Visible = false;
					y = y - s;
					uplabel.Visible = true;
				}
				else
				{
					y = 400;
				}
			} 
			else if (e.KeyCode == Keys.Down)
			{
				if (y <= 350)
				{

					uplabel.Visible = false;
					Leftlabel.Visible = false;
					Rightlabel.Visible = false;
					y = y + s;
					Downlabel.Visible = true;
				}
				else
				{
					y = -50;
				}
			}
			else if (e.KeyCode == Keys.Left)
			{
				if (x >= 0)
				{
					Downlabel.Visible = false;
					uplabel.Visible = false;
					Rightlabel.Visible = false;
					x = x - s;
					Leftlabel.Visible = true;
				}
				else
				{
					x = 710;
				}
			}
			else if (e.KeyCode == Keys.Right)
			{
				if (x <= 660)
				{
					Downlabel.Visible = false;
					Leftlabel.Visible = false;
					uplabel.Visible = false;
					x = x + s;
					Rightlabel.Visible = true;
				}
				else
				{
					x = -50;
				}
			}
			car.Location = new Point(x, y);
		}
	}
}
