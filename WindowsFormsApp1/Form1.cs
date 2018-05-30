using System;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		GetUser _gu;
		public Form1()
		{
			InitializeComponent();
			_gu = new GetUser(listBox1, label1, label2);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void mapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Map FormMap = new Map(label1, label2);
			FormMap.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_gu.GetCountryByIP(textBox1.Text.ToString());
			string LAT1 = label1.Text;
			Convert.ToDouble(LAT1,CultureInfo.InvariantCulture);
			double LON = Double.Parse(label2.Text.ToString(), CultureInfo.InvariantCulture);
			MessageBox.Show(LAT1 + " " + LON);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
