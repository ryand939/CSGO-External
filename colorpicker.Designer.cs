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
			this.lblEnemy = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pnlVisEnemy = new System.Windows.Forms.Panel();
			this.lblBlueEnemy = new System.Windows.Forms.Label();
			this.lblGreenEnemy = new System.Windows.Forms.Label();
			this.lblRedEnemy = new System.Windows.Forms.Label();
			this.trackBlueEnemy = new System.Windows.Forms.TrackBar();
			this.trackGreenEnemy = new System.Windows.Forms.TrackBar();
			this.trackRedEnemy = new System.Windows.Forms.TrackBar();
			this.checkHealthBasedE = new System.Windows.Forms.CheckBox();
			this.checkHealthBasedF = new System.Windows.Forms.CheckBox();
			this.pnlFriendly.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnlVisEnemy.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBlueEnemy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackGreenEnemy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackRedEnemy)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFriendly
			// 
			this.lblFriendly.AutoSize = true;
			this.lblFriendly.BackColor = System.Drawing.Color.Transparent;
			this.lblFriendly.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFriendly.Location = new System.Drawing.Point(18, 0);
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
			this.panel2.Location = new System.Drawing.Point(16, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(19, 16);
			this.panel2.TabIndex = 9;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// pnlFriendly
			// 
			this.pnlFriendly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlFriendly.Controls.Add(this.checkHealthBasedF);
			this.pnlFriendly.Controls.Add(this.lblBlue);
			this.pnlFriendly.Controls.Add(this.lblGreen);
			this.pnlFriendly.Controls.Add(this.lblRed);
			this.pnlFriendly.Controls.Add(this.trackBlue);
			this.pnlFriendly.Controls.Add(this.trackGreen);
			this.pnlFriendly.Controls.Add(this.trackRed);
			this.pnlFriendly.Location = new System.Drawing.Point(5, 7);
			this.pnlFriendly.Name = "pnlFriendly";
			this.pnlFriendly.Size = new System.Drawing.Size(223, 129);
			this.pnlFriendly.TabIndex = 10;
			this.pnlFriendly.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVis_Paint);
			// 
			// lblBlue
			// 
			this.lblBlue.AutoSize = true;
			this.lblBlue.BackColor = System.Drawing.Color.Transparent;
			this.lblBlue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBlue.Location = new System.Drawing.Point(12, 81);
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
			this.lblGreen.Location = new System.Drawing.Point(7, 50);
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
			this.lblRed.Location = new System.Drawing.Point(14, 19);
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
			this.trackBlue.Location = new System.Drawing.Point(56, 73);
			this.trackBlue.Maximum = 255;
			this.trackBlue.Name = "trackBlue";
			this.trackBlue.Size = new System.Drawing.Size(164, 45);
			this.trackBlue.TabIndex = 3;
			this.trackBlue.Scroll += new System.EventHandler(this.trackBlue_Scroll);
			this.trackBlue.ValueChanged += new System.EventHandler(this.trackBlue_ValueChanged);
			// 
			// trackGreen
			// 
			this.trackGreen.Location = new System.Drawing.Point(56, 42);
			this.trackGreen.Maximum = 255;
			this.trackGreen.Name = "trackGreen";
			this.trackGreen.Size = new System.Drawing.Size(164, 45);
			this.trackGreen.TabIndex = 1;
			this.trackGreen.Scroll += new System.EventHandler(this.trackBlue_Scroll);
			this.trackGreen.ValueChanged += new System.EventHandler(this.trackGreen_ValueChanged);
			// 
			// trackRed
			// 
			this.trackRed.Location = new System.Drawing.Point(56, 11);
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
			this.panel1.Controls.Add(this.lblEnemy);
			this.panel1.Controls.Add(this.pnlVisEnemy);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(235, 295);
			this.panel1.TabIndex = 12;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// lblEnemy
			// 
			this.lblEnemy.AutoSize = true;
			this.lblEnemy.BackColor = System.Drawing.Color.Transparent;
			this.lblEnemy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnemy.Location = new System.Drawing.Point(18, 139);
			this.lblEnemy.Name = "lblEnemy";
			this.lblEnemy.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblEnemy.Size = new System.Drawing.Size(52, 20);
			this.lblEnemy.TabIndex = 15;
			this.lblEnemy.Text = "Enemy";
			this.lblEnemy.UseCompatibleTextRendering = true;
			this.lblEnemy.Paint += new System.Windows.Forms.PaintEventHandler(this.lblEnemy_Paint);
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(16, 142);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(19, 16);
			this.panel3.TabIndex = 13;
			// 
			// pnlVisEnemy
			// 
			this.pnlVisEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlVisEnemy.Controls.Add(this.checkHealthBasedE);
			this.pnlVisEnemy.Controls.Add(this.lblBlueEnemy);
			this.pnlVisEnemy.Controls.Add(this.lblGreenEnemy);
			this.pnlVisEnemy.Controls.Add(this.lblRedEnemy);
			this.pnlVisEnemy.Controls.Add(this.trackBlueEnemy);
			this.pnlVisEnemy.Controls.Add(this.trackGreenEnemy);
			this.pnlVisEnemy.Controls.Add(this.trackRedEnemy);
			this.pnlVisEnemy.Location = new System.Drawing.Point(5, 146);
			this.pnlVisEnemy.Name = "pnlVisEnemy";
			this.pnlVisEnemy.Size = new System.Drawing.Size(223, 129);
			this.pnlVisEnemy.TabIndex = 14;
			this.pnlVisEnemy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			// 
			// lblBlueEnemy
			// 
			this.lblBlueEnemy.AutoSize = true;
			this.lblBlueEnemy.BackColor = System.Drawing.Color.Transparent;
			this.lblBlueEnemy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBlueEnemy.Location = new System.Drawing.Point(12, 81);
			this.lblBlueEnemy.Name = "lblBlueEnemy";
			this.lblBlueEnemy.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblBlueEnemy.Size = new System.Drawing.Size(36, 20);
			this.lblBlueEnemy.TabIndex = 14;
			this.lblBlueEnemy.Text = "Blue";
			this.lblBlueEnemy.UseCompatibleTextRendering = true;
			this.lblBlueEnemy.Paint += new System.Windows.Forms.PaintEventHandler(this.label2_Paint);
			// 
			// lblGreenEnemy
			// 
			this.lblGreenEnemy.AutoSize = true;
			this.lblGreenEnemy.BackColor = System.Drawing.Color.Transparent;
			this.lblGreenEnemy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblGreenEnemy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGreenEnemy.Location = new System.Drawing.Point(7, 50);
			this.lblGreenEnemy.Name = "lblGreenEnemy";
			this.lblGreenEnemy.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblGreenEnemy.Size = new System.Drawing.Size(47, 20);
			this.lblGreenEnemy.TabIndex = 13;
			this.lblGreenEnemy.Text = "Green";
			this.lblGreenEnemy.UseCompatibleTextRendering = true;
			this.lblGreenEnemy.Paint += new System.Windows.Forms.PaintEventHandler(this.label3_Paint);
			// 
			// lblRedEnemy
			// 
			this.lblRedEnemy.AutoSize = true;
			this.lblRedEnemy.BackColor = System.Drawing.Color.Transparent;
			this.lblRedEnemy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRedEnemy.Location = new System.Drawing.Point(14, 19);
			this.lblRedEnemy.Name = "lblRedEnemy";
			this.lblRedEnemy.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblRedEnemy.Size = new System.Drawing.Size(32, 20);
			this.lblRedEnemy.TabIndex = 12;
			this.lblRedEnemy.Text = "Red";
			this.lblRedEnemy.UseCompatibleTextRendering = true;
			this.lblRedEnemy.Paint += new System.Windows.Forms.PaintEventHandler(this.label4_Paint);
			// 
			// trackBlueEnemy
			// 
			this.trackBlueEnemy.Location = new System.Drawing.Point(56, 73);
			this.trackBlueEnemy.Maximum = 255;
			this.trackBlueEnemy.Name = "trackBlueEnemy";
			this.trackBlueEnemy.Size = new System.Drawing.Size(164, 45);
			this.trackBlueEnemy.TabIndex = 3;
			this.trackBlueEnemy.ValueChanged += new System.EventHandler(this.trackRedEnemy_ValueChanged);
			// 
			// trackGreenEnemy
			// 
			this.trackGreenEnemy.Location = new System.Drawing.Point(56, 42);
			this.trackGreenEnemy.Maximum = 255;
			this.trackGreenEnemy.Name = "trackGreenEnemy";
			this.trackGreenEnemy.Size = new System.Drawing.Size(164, 45);
			this.trackGreenEnemy.TabIndex = 1;
			this.trackGreenEnemy.ValueChanged += new System.EventHandler(this.trackRedEnemy_ValueChanged);
			// 
			// trackRedEnemy
			// 
			this.trackRedEnemy.Location = new System.Drawing.Point(56, 11);
			this.trackRedEnemy.Maximum = 255;
			this.trackRedEnemy.Name = "trackRedEnemy";
			this.trackRedEnemy.Size = new System.Drawing.Size(164, 45);
			this.trackRedEnemy.TabIndex = 0;
			this.trackRedEnemy.ValueChanged += new System.EventHandler(this.trackRedEnemy_ValueChanged);
			// 
			// checkHealthBasedE
			// 
			this.checkHealthBasedE.AutoSize = true;
			this.checkHealthBasedE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkHealthBasedE.FlatAppearance.BorderSize = 3;
			this.checkHealthBasedE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkHealthBasedE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkHealthBasedE.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkHealthBasedE.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.checkHealthBasedE.Location = new System.Drawing.Point(122, 105);
			this.checkHealthBasedE.Name = "checkHealthBasedE";
			this.checkHealthBasedE.Size = new System.Drawing.Size(96, 19);
			this.checkHealthBasedE.TabIndex = 19;
			this.checkHealthBasedE.Text = "Health Based";
			this.checkHealthBasedE.UseCompatibleTextRendering = true;
			this.checkHealthBasedE.UseVisualStyleBackColor = true;
			// 
			// checkHealthBasedF
			// 
			this.checkHealthBasedF.AutoSize = true;
			this.checkHealthBasedF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkHealthBasedF.FlatAppearance.BorderSize = 3;
			this.checkHealthBasedF.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkHealthBasedF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkHealthBasedF.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkHealthBasedF.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.checkHealthBasedF.Location = new System.Drawing.Point(122, 105);
			this.checkHealthBasedF.Name = "checkHealthBasedF";
			this.checkHealthBasedF.Size = new System.Drawing.Size(96, 19);
			this.checkHealthBasedF.TabIndex = 20;
			this.checkHealthBasedF.Text = "Health Based";
			this.checkHealthBasedF.UseCompatibleTextRendering = true;
			this.checkHealthBasedF.UseVisualStyleBackColor = true;
			// 
			// colorpicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(494, 352);
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
			this.pnlVisEnemy.ResumeLayout(false);
			this.pnlVisEnemy.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBlueEnemy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackGreenEnemy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackRedEnemy)).EndInit();
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
		private System.Windows.Forms.Label lblEnemy;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel pnlVisEnemy;
		private System.Windows.Forms.Label lblBlueEnemy;
		private System.Windows.Forms.Label lblGreenEnemy;
		private System.Windows.Forms.Label lblRedEnemy;
		public System.Windows.Forms.TrackBar trackBlueEnemy;
		public System.Windows.Forms.TrackBar trackGreenEnemy;
		public System.Windows.Forms.TrackBar trackRedEnemy;
		public System.Windows.Forms.CheckBox checkHealthBasedF;
		public System.Windows.Forms.CheckBox checkHealthBasedE;
	}
}