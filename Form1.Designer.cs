namespace DWext
{
	partial class Form1
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
			this.lblMain = new System.Windows.Forms.Label();
			this.txtFOV = new System.Windows.Forms.TextBox();
			this.pnlVis = new System.Windows.Forms.Panel();
			this.btnDownFOV = new System.Windows.Forms.Button();
			this.btnUpFOV = new System.Windows.Forms.Button();
			this.lblVisuals = new System.Windows.Forms.Label();
			this.lblAim = new System.Windows.Forms.Label();
			this.pnlAim = new System.Windows.Forms.Panel();
			this.lblMisc = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnQuit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.checkBhop = new System.Windows.Forms.CheckBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.CheckRadar = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlVis.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMain
			// 
			this.lblMain.AutoSize = true;
			this.lblMain.BackColor = System.Drawing.Color.Transparent;
			this.lblMain.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMain.Location = new System.Drawing.Point(13, 11);
			this.lblMain.Name = "lblMain";
			this.lblMain.Size = new System.Drawing.Size(206, 24);
			this.lblMain.TabIndex = 3;
			this.lblMain.Text = "DAERWARE EXTERNAL ";
			this.lblMain.UseCompatibleTextRendering = true;
			this.lblMain.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
			// 
			// txtFOV
			// 
			this.txtFOV.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtFOV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtFOV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFOV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFOV.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.txtFOV.Location = new System.Drawing.Point(29, 72);
			this.txtFOV.MaxLength = 3;
			this.txtFOV.Name = "txtFOV";
			this.txtFOV.Size = new System.Drawing.Size(37, 22);
			this.txtFOV.TabIndex = 6;
			this.txtFOV.Text = "90";
			this.txtFOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFOV.TextChanged += new System.EventHandler(this.txtFOV_TextChanged);
			// 
			// pnlVis
			// 
			this.pnlVis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlVis.Controls.Add(this.txtFOV);
			this.pnlVis.Controls.Add(this.label1);
			this.pnlVis.Controls.Add(this.CheckRadar);
			this.pnlVis.Controls.Add(this.btnDownFOV);
			this.pnlVis.Controls.Add(this.btnUpFOV);
			this.pnlVis.Location = new System.Drawing.Point(13, 148);
			this.pnlVis.Name = "pnlVis";
			this.pnlVis.Size = new System.Drawing.Size(247, 100);
			this.pnlVis.TabIndex = 7;
			this.pnlVis.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVis_Paint);
			// 
			// btnDownFOV
			// 
			this.btnDownFOV.BackColor = System.Drawing.Color.DimGray;
			this.btnDownFOV.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnDownFOV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDownFOV.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold);
			this.btnDownFOV.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDownFOV.Image = global::DWext.Properties.Resources.btnGrad;
			this.btnDownFOV.Location = new System.Drawing.Point(6, 72);
			this.btnDownFOV.Name = "btnDownFOV";
			this.btnDownFOV.Size = new System.Drawing.Size(21, 22);
			this.btnDownFOV.TabIndex = 4;
			this.btnDownFOV.Text = "<";
			this.btnDownFOV.UseVisualStyleBackColor = false;
			this.btnDownFOV.Click += new System.EventHandler(this.btnDownFOV_Click);
			this.btnDownFOV.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDownFOV_Paint);
			// 
			// btnUpFOV
			// 
			this.btnUpFOV.BackColor = System.Drawing.Color.DimGray;
			this.btnUpFOV.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnUpFOV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpFOV.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpFOV.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnUpFOV.Image = global::DWext.Properties.Resources.btnGrad;
			this.btnUpFOV.Location = new System.Drawing.Point(68, 72);
			this.btnUpFOV.Name = "btnUpFOV";
			this.btnUpFOV.Size = new System.Drawing.Size(21, 22);
			this.btnUpFOV.TabIndex = 5;
			this.btnUpFOV.Text = ">";
			this.btnUpFOV.UseVisualStyleBackColor = false;
			this.btnUpFOV.Click += new System.EventHandler(this.btnUpFOV_Click);
			this.btnUpFOV.Paint += new System.Windows.Forms.PaintEventHandler(this.btnUpFOV_Paint);
			// 
			// lblVisuals
			// 
			this.lblVisuals.AutoSize = true;
			this.lblVisuals.BackColor = System.Drawing.Color.Transparent;
			this.lblVisuals.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVisuals.Location = new System.Drawing.Point(25, 141);
			this.lblVisuals.Name = "lblVisuals";
			this.lblVisuals.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblVisuals.Size = new System.Drawing.Size(48, 20);
			this.lblVisuals.TabIndex = 8;
			this.lblVisuals.Text = "Visual";
			this.lblVisuals.UseCompatibleTextRendering = true;
			this.lblVisuals.Paint += new System.Windows.Forms.PaintEventHandler(this.lblVisuals_Paint);
			// 
			// lblAim
			// 
			this.lblAim.AutoSize = true;
			this.lblAim.BackColor = System.Drawing.Color.Transparent;
			this.lblAim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAim.Location = new System.Drawing.Point(24, 31);
			this.lblAim.Name = "lblAim";
			this.lblAim.Size = new System.Drawing.Size(31, 20);
			this.lblAim.TabIndex = 10;
			this.lblAim.Text = "Aim";
			this.lblAim.UseCompatibleTextRendering = true;
			this.lblAim.Paint += new System.Windows.Forms.PaintEventHandler(this.lblAim_Paint);
			// 
			// pnlAim
			// 
			this.pnlAim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlAim.Location = new System.Drawing.Point(12, 38);
			this.pnlAim.Name = "pnlAim";
			this.pnlAim.Size = new System.Drawing.Size(248, 100);
			this.pnlAim.TabIndex = 9;
			this.pnlAim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAim_Paint);
			// 
			// lblMisc
			// 
			this.lblMisc.AutoSize = true;
			this.lblMisc.BackColor = System.Drawing.Color.Transparent;
			this.lblMisc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMisc.Location = new System.Drawing.Point(24, 251);
			this.lblMisc.Name = "lblMisc";
			this.lblMisc.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.lblMisc.Size = new System.Drawing.Size(36, 20);
			this.lblMisc.TabIndex = 12;
			this.lblMisc.Text = "Misc";
			this.lblMisc.UseCompatibleTextRendering = true;
			this.lblMisc.Paint += new System.Windows.Forms.PaintEventHandler(this.lblMisc_Paint);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.checkBhop);
			this.panel1.Location = new System.Drawing.Point(12, 258);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(248, 76);
			this.panel1.TabIndex = 11;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnQuit
			// 
			this.btnQuit.BackColor = System.Drawing.Color.DimGray;
			this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnQuit.Image = global::DWext.Properties.Resources.btnGrad;
			this.btnQuit.Location = new System.Drawing.Point(217, 9);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(45, 23);
			this.btnQuit.TabIndex = 1;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = false;
			this.btnQuit.Click += new System.EventHandler(this.button1_Click);
			this.btnQuit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnQuit_Paint);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(24, 144);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(19, 16);
			this.panel2.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(23, 31);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(19, 16);
			this.panel3.TabIndex = 8;
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(22, 251);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(21, 11);
			this.panel4.TabIndex = 0;
			// 
			// checkBhop
			// 
			this.checkBhop.AutoSize = true;
			this.checkBhop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkBhop.FlatAppearance.BorderSize = 3;
			this.checkBhop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkBhop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBhop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBhop.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.checkBhop.Location = new System.Drawing.Point(10, 16);
			this.checkBhop.Name = "checkBhop";
			this.checkBhop.Size = new System.Drawing.Size(78, 19);
			this.checkBhop.TabIndex = 14;
			this.checkBhop.Text = "Bunnyhop";
			this.checkBhop.ThreeState = true;
			this.checkBhop.UseCompatibleTextRendering = true;
			this.checkBhop.UseVisualStyleBackColor = true;
			this.checkBhop.CheckedChanged += new System.EventHandler(this.checkBhop_CheckedChanged);
			this.checkBhop.MouseEnter += new System.EventHandler(this.checkBhop_MouseEnter);
			this.checkBhop.MouseLeave += new System.EventHandler(this.checkBhop_MouseLeave);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblStatus.Location = new System.Drawing.Point(8, 337);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 13);
			this.lblStatus.TabIndex = 13;
			// 
			// CheckRadar
			// 
			this.CheckRadar.AutoSize = true;
			this.CheckRadar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CheckRadar.FlatAppearance.BorderSize = 3;
			this.CheckRadar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CheckRadar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CheckRadar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CheckRadar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CheckRadar.Location = new System.Drawing.Point(9, 16);
			this.CheckRadar.Name = "CheckRadar";
			this.CheckRadar.Size = new System.Drawing.Size(97, 19);
			this.CheckRadar.TabIndex = 15;
			this.CheckRadar.Text = "Reveal Radar";
			this.CheckRadar.UseCompatibleTextRendering = true;
			this.CheckRadar.UseVisualStyleBackColor = true;
			this.CheckRadar.CheckedChanged += new System.EventHandler(this.CheckRadar_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(35, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 18);
			this.label1.TabIndex = 16;
			this.label1.Text = "FOV";
			this.label1.UseCompatibleTextRendering = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(272, 357);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblMisc);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.lblAim);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.lblVisuals);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlAim);
			this.Controls.Add(this.pnlVis);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.lblMain);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "DWext";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.pnlVis.ResumeLayout(false);
			this.pnlVis.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Label lblMain;
		private System.Windows.Forms.Button btnDownFOV;
		private System.Windows.Forms.Button btnUpFOV;
		private System.Windows.Forms.Panel pnlVis;
		private System.Windows.Forms.Label lblVisuals;
		private System.Windows.Forms.Label lblAim;
		private System.Windows.Forms.Panel pnlAim;
		private System.Windows.Forms.Label lblMisc;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.TextBox txtFOV;
		public System.Windows.Forms.CheckBox checkBhop;
		private System.Windows.Forms.Label lblStatus;
		public System.Windows.Forms.CheckBox CheckRadar;
		private System.Windows.Forms.Label label1;
	}
}

