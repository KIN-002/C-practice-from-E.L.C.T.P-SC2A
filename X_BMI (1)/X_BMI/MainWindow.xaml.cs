using System;
using System.Windows;

namespace X_BMI
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

		private void Button_Enter(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				double m, kg, BMI;
				m = Convert.ToDouble(textBox.Text);
				kg = Convert.ToDouble(textBox1.Text);
				BMI = kg / m / m;
				if (BMI < 18.5)
				{
					label2.Content = ("你體重過輕");
					BMIimage.Source = Properties.Resources.image;
				}
				else if (BMI < 24 || BMI >= 18.5)
				{
					label2.Content = ("你的身體質量屬於正常範圍");
					BMIimage.Source = Properties.Resources.image2;
				}
				else if (BMI < 27 || BMI >= 24)
				{
					label2.Content = ("你的身體質量屬於過重");
					BMIimage.Source = Properties.Resources.image3;
				}
				else if (BMI < 30 || BMI >= 27)
				{
					label2.Content = ("你的身體質量屬於輕度肥胖");
					BMIimage.Source = Properties.Resources.image4;
				}
				else if (BMI < 35 || BMI >= 30)
				{
					label2.Content = ("你的身體質量屬於中度肥胖");
					BMIimage.Source = Properties.Resources.image5;
				}
				else
				{
					label2.Content = ("你的身體質量屬於重度肥胖");
					BMIimage.Source = Properties.Resources.image6;
				}
			}
			catch 
			{
				MessageBox.Show("請輸入正確數值");
			}
	}
	}
}
