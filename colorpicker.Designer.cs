namespace DWext
{
	partial class colorpicker
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
			this.lblFriendly = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlFriendly = new System.Windows.Forms.Panel();
			this.lblBlue = new System.Windows.Forms.Label();
			this.lblGreen = new System.Windows.Forms.Label();
			this.lblRed = new System.Windows.Forms.Label();
			this.trackBlue = new System.Windows.Forms.TrackBar();
			this.trackGreen = new System.Windows.Forms.TrackBar();
			this.trackRed = new System.Windows.Forms.TrackBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlFriendly.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFriendly
			// 
			this.lblFriendly.AutoSize = true;
			this.lblFriendly.BackColor = System.Drawing.Color.Transparent;
			this.lblFriendly.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFriendly.Location = new System.Drawing.Point(23, 9);
			this.lblFriendly.Name = "lblFriendly";
			this.lblFriendly.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblFriendly.Size = new System.Drawing.Size(62, 20);
			this.lblFriendly.TabIndex = 11;
			this.lblFriendly.Text = "Friendly";
			this.lblFriendly.UseCompatibleTextRendering = true;
			this.lblFriendly.Click += new System.EventHandler(this.lblVisuals_Click);
			this.lblFriendly.Paint += new System.Windows.Forms.PaintEventHandler(this.lblFriendly_Paint);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(21, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(19, 16);
			this.panel2.TabIndex = 9;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// pnlFriendly
			// 
			this.pnlFriendly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlFriendly.Controls.Add(this.lblBlue);
			this.pnlFriendly.Controls.Add(this.lblGreen);
			this.pnlFriendly.Controls.Add(this.lblRed);
			this.pnlFriendly.Controls.Add(this.trackBlue);
			this.pnlFriendly.Controls.Add(this.trackGreen);
			this.pnlFriendly.Controls.Add(this.trackRed);
			this.pnlFriendly.Location = new System.Drawing.Point(10, 16);
			this.pnlFriendly.Name = "pnlFriendly";
			this.pnlFriendly.Size = new System.Drawing.Size(247, 156);
			this.pnlFriendly.TabIndex = 10;
			this.pnlFriendly.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVis_Paint);
			// 
			// lblBlue
			// 
			this.lblBlue.AutoSize = true;
			this.lblBlue.BackColor = System.Drawing.Color.Transparent;
			this.lblBlue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBlue.Location = new System.Drawing.Point(19, 116);
			this.lblBlue.Name = "lblBlue";
			this.lblBlue.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblBlue.Size = new System.Drawing.Size(36, 20);
			this.lblBlue.TabIndex = 14;
			this.lblBlue.Text = "Blue";
			this.lblBlue.UseCompatibleTextRendering = true;
			this.lblBlue.Paint += new System.Windows.Forms.PaintEventHandler(this.lblBlue_Paint);
			// 
			// lblGreen
			// 
			this.lblGreen.AutoSize = true;
			this.lblGreen.BackColor = System.Drawing.Color.Transparent;
			this.lblGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblGreen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGreen.Location = new System.Drawing.Point(14, 70);
			this.lblGreen.Name = "lblGreen";
			this.lblGreen.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblGreen.Size = new System.Drawing.Size(47, 20);
			this.lblGreen.TabIndex = 13;
			this.lblGreen.Text = "Green";
			this.lblGreen.UseCompatibleTextRendering = true;
			this.lblGreen.Click += new System.EventHandler(this.label2_Click);
			this.lblGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.lblGreen_Paint);
			// 
			// lblRed
			// 
			this.lblRed.AutoSize = true;
			this.lblRed.BackColor = System.Drawing.Color.Transparent;
			this.lblRed.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRed.Location = new System.Drawing.Point(21, 24);
			this.lblRed.Name = "lblRed";
			this.lblRed.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblRed.Size = new System.Drawing.Size(32, 20);
			this.lblRed.TabIndex = 12;
			this.lblRed.Text = "Red";
			this.lblRed.UseCompatibleTextRendering = true;
			this.lblRed.Paint += new System.Windows.Forms.PaintEventHandler(this.lblRed_Paint);
			// 
			// trackBlue
			// 
			this.trackBlue.Location = new System.Drawing.Point(63, 108);
			this.trackBlue.Maximum = 255;
			this.trackBlue.Name = "trackBlue";
			this.trackBlue.Size = new System.Drawing.Size(164, 45);
			this.trackBlue.TabIndex = 3;
			this.trackBlue.Value = 1;
			this.trackBlue.Scroll += new System.EventHandler(this.trackBlue_Scroll);
			this.trackBlue.ValueChanged += new System.EventHandler(this.trackBlue_ValueChanged);
			// 
			// trackGreen
			// 
			this.trackGreen.Location = new System.Drawing.Point(63, 62);
			this.trackGreen.Maximum = 255;
			this.trackGreen.Name = "trackGreen";
			this.trackGreen.Size = new System.Drawing.Size(164, 45);
			this.trackGreen.TabIndex = 1;
			this.trackGreen.Scroll += new System.EventHandler(this.trackBlue_Scroll);
			this.trackGreen.ValueChanged += new System.EventHandler(this.trackGreen_ValueChanged);
			// 
			// trackRed
			// 
			this.trackRed.Location = new System.Drawing.Point(63, 16);
			this.trackRed.Maximum = 255;
			this.trackRed.Name = "trackRed";
			this.trackRed.Size = new System.Drawing.Size(164, 45);
			this.trackRed.TabIndex = 0;
			this.trackRed.Scroll += new System.EventHandler(this.trackBlue_Scroll);
			this.trackRed.ValueChanged += new System.EventHandler(this.trackRed_ValueChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblFriendly);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.pnlFriendly);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(373, 244);
			this.panel1.TabIndex = 12;
			// 
			// colorpicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(397, 271);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "colorpicker";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "colorpicker";
			this.TopMost = true;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.colorpicker_Paint);
			this.pnlFriendly.ResumeLayout(false);
			this.pnlFriendly.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblFriendly;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnlFriendly;
		private System.Windows.Forms.Label lblBlue;
		private System.Windows.Forms.Label lblGreen;
		private System.Windows.Forms.Label lblRed;
		public System.Windows.Forms.TrackBar trackBlue;
		public System.Windows.Forms.TrackBar trackGreen;
		public System.Windows.Forms.TrackBar trackRed;
		private System.Windows.Forms.Panel panel1;
	}
}