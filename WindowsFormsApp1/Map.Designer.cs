﻿namespace WindowsFormsApp1
{
	partial class Map
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
			this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
			this.SuspendLayout();
			// 
			// gMapControl1
			// 
			this.gMapControl1.Bearing = 0F;
			this.gMapControl1.CanDragMap = true;
			this.gMapControl1.GrayScaleMode = false;
			this.gMapControl1.LevelsKeepInMemmory = 5;
			this.gMapControl1.Location = new System.Drawing.Point(0, -2);
			this.gMapControl1.MarkersEnabled = true;
			this.gMapControl1.MaxZoom = 18;
			this.gMapControl1.MinZoom = 2;
			this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gMapControl1.Name = "gMapControl1";
			this.gMapControl1.NegativeMode = false;
			this.gMapControl1.PolygonsEnabled = true;
			this.gMapControl1.RetryLoadTile = 0;
			this.gMapControl1.RoutesEnabled = true;
			this.gMapControl1.ShowTileGridLines = true;
			this.gMapControl1.Size = new System.Drawing.Size(800, 453);
			this.gMapControl1.TabIndex = 0;
			this.gMapControl1.Zoom = 5D;
			this.gMapControl1.Click += new System.EventHandler(this.gMapControl1_Click);
			// 
			// Map
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gMapControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Map";
			this.Text = "Map";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Map_FormClosing);
			this.Load += new System.EventHandler(this.Map_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public GMap.NET.WindowsForms.GMapControl gMapControl1;
	}
}