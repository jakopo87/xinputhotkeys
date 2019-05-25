namespace XInput_Hotkeys
{
	partial class MainForm
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.trayMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 15;
			this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.trayMenu;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "XInput Hotkeys";
			this.trayIcon.Visible = true;
			this.trayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
			// 
			// trayMenu
			// 
			this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem,
            this.quitMenuItem});
			this.trayMenu.Name = "trayMenu";
			this.trayMenu.ShowImageMargin = false;
			this.trayMenu.Size = new System.Drawing.Size(79, 48);
			// 
			// showMenuItem
			// 
			this.showMenuItem.Name = "showMenuItem";
			this.showMenuItem.Size = new System.Drawing.Size(78, 22);
			this.showMenuItem.Text = "&Show";
			this.showMenuItem.Click += new System.EventHandler(this.ShowMenuItem_Click);
			// 
			// quitMenuItem
			// 
			this.quitMenuItem.Name = "quitMenuItem";
			this.quitMenuItem.Size = new System.Drawing.Size(78, 22);
			this.quitMenuItem.Text = "&Quit";
			this.quitMenuItem.Click += new System.EventHandler(this.QuitMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "GUIDE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "GUIDE + A";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "GUIDE + B";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "GUIDE + X";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(140, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(226, 24);
			this.label5.TabIndex = 5;
			this.label5.Text = "Start/Stop video recording";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(140, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(142, 24);
			this.label6.TabIndex = 6;
			this.label6.Text = "Capture a video";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(140, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(189, 24);
			this.label7.TabIndex = 7;
			this.label7.Text = "Capture a screenshot";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(140, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(147, 24);
			this.label8.TabIndex = 8;
			this.label8.Text = "Open Game Bar";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 127);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Xinput Hotkeys";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.trayMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ContextMenuStrip trayMenu;
		private System.Windows.Forms.ToolStripMenuItem showMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}

