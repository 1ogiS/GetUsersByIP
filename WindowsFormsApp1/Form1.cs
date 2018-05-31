using System;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
	public partial class GUBI : Form
	{
		private Point mouseOffset;
		private bool isMouseDown = false;
		Map FormMap;
		GetUser _gu;
		public GUBI()
		{
			InitializeComponent();
			_gu = new GetUser(listBox1, label1, label2);
			FormMap = new Map(label1, label2);
		}
		private void mapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMap.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_gu.GetCountryByIP(textBox1.Text.ToString());
			FormMap.MapCreate();
		}

		private void спутникToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMap.gMapControl1.MapProvider = GMapProviders.BingSatelliteMap;
			GMaps.Instance.Mode = AccessMode.ServerAndCache;
		}

		private void гибриднаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMap.gMapControl1.MapProvider = GMapProviders.BingHybridMap;
			GMaps.Instance.Mode = AccessMode.ServerAndCache;
		}

		private void стандартнаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMap.gMapControl1.MapProvider = GMapProviders.BingMap;
			GMaps.Instance.Mode = AccessMode.ServerAndCache;
		}
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
                    this.Close();
		}
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			int xOffset;
			int yOffset;

			if (e.Button == MouseButtons.Left)
			{
				xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
				yOffset = -e.Y - SystemInformation.CaptionHeight -
					SystemInformation.FrameBorderSize.Height;
				mouseOffset = new Point(xOffset, yOffset);
				isMouseDown = true;
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X, mouseOffset.Y);
				Location = mousePos;
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			// Changes the isMouseDown field so that the form does
			// not move unless the user is pressing the left mouse button.
			if (e.Button == MouseButtons.Left)
			{
				isMouseDown = false;
			}
		}

		private void GUBI_FormClosing(object sender, FormClosingEventArgs e)
		{
		}
	}
}
