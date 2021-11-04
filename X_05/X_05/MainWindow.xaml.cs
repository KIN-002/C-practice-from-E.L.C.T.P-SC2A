using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace X_05
{
	/// <summary>
	/// MainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			int math1, no, min = 101, max = 0;
			Random ran = new Random();
			textBox.Clear();
			for (math1= 1; math1 <= 10; math1++)
			{
				no = ran.Next(1, 100);
				if (no>max)
				{
					max = no;
				}
				if (no<min)
				{
					min = no;
				}
				textBox.Text += no + "\r\n";
			}
			label1.Content = "最大值:" + max;
			label2.Content = "最小值:" + min;
		}
	}
}
