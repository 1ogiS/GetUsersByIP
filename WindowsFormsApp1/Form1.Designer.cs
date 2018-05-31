namespace WindowsFormsApp1
{
	partial class GUBI
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUBI));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.стандартнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.спутникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.гибриднаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.DarkViolet;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(12, 60);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(159, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkViolet;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(216, 60);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(189, 20);
			this.button1.TabIndex = 1;
			this.button1.Text = "Найти ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.DarkViolet;
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.ForeColor = System.Drawing.Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 109);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(393, 210);
			this.listBox1.TabIndex = 2;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.DarkViolet;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem,
            this.настройкиКартыToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(530, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mapToolStripMenuItem
			// 
			this.mapToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.mapToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
			this.mapToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.mapToolStripMenuItem.Text = "&Карта";
			this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
			// 
			// настройкиКартыToolStripMenuItem
			// 
			this.настройкиКартыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартнаяToolStripMenuItem,
            this.спутникToolStripMenuItem,
            this.гибриднаяToolStripMenuItem});
			this.настройкиКартыToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.настройкиКартыToolStripMenuItem.Name = "настройкиКартыToolStripMenuItem";
			this.настройкиКартыToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
			this.настройкиКартыToolStripMenuItem.Text = "&Настройки карты";
			// 
			// стандартнаяToolStripMenuItem
			// 
			this.стандартнаяToolStripMenuItem.Name = "стандартнаяToolStripMenuItem";
			this.стандартнаяToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.стандартнаяToolStripMenuItem.Text = "&Схематическая";
			this.стандартнаяToolStripMenuItem.Click += new System.EventHandler(this.стандартнаяToolStripMenuItem_Click);
			// 
			// спутникToolStripMenuItem
			// 
			this.спутникToolStripMenuItem.Name = "спутникToolStripMenuItem";
			this.спутникToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.спутникToolStripMenuItem.Text = "&Спутник";
			this.спутникToolStripMenuItem.Click += new System.EventHandler(this.спутникToolStripMenuItem_Click);
			// 
			// гибриднаяToolStripMenuItem
			// 
			this.гибриднаяToolStripMenuItem.Name = "гибриднаяToolStripMenuItem";
			this.гибриднаяToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.гибриднаяToolStripMenuItem.Text = "&Гибридная";
			this.гибриднаяToolStripMenuItem.Click += new System.EventHandler(this.гибриднаяToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(432, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(432, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Введите IP-адресс";
			// 
			// GUBI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(530, 350);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "GUBI";
			this.Text = "GUBI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUBI_FormClosing);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripMenuItem настройкиКартыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem гибриднаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem спутникToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem стандартнаяToolStripMenuItem;
	}
}

