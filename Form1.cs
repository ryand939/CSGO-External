﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DWext
{
	public partial class Form1 : Form
	{
		Thread radarThread;
		Thread BunnyHopThread;


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			memory.ManageMemory.Initialize("csgo");
			Offsets.client = memory.ManageMemory.GetModuleAdress("client_panorama");
			Offsets.engine = memory.ManageMemory.GetModuleAdress("engine");
			int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
			init_thread();
		}
		private void init_thread()
		{
			radarThread = new Thread(new ThreadStart(radar.Radar));

			BunnyHopThread = new Thread(new ThreadStart(Bunnyhop.Bhop));
		}
		private void txtFOV_TextChanged(object sender, EventArgs e)
		{
			FOVChanger.FOV();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			BunnyHopThread.Abort();
			radarThread.Abort();
			Environment.Exit(0);
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			int forceJump = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwForceJump);
			int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
			int flagJump = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_fFlags);
			memory.ManageMemory.WriteMemory<int>(Offsets.client + Offsets.dwForceJump, 5);

		}

		private void btnUpFOV_Click(object sender, EventArgs e)
		{
			try
			{
				txtFOV.Text = (Convert.ToInt32(txtFOV.Text) + 5).ToString();
			}
			catch
			{
				txtFOV.Text = "5";
			}

		}

		private void btnDownFOV_Click(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(txtFOV.Text) - 5) != 0)
				{
					txtFOV.Text = (Convert.ToInt32(txtFOV.Text) - 5).ToString();
				}
			}
			catch
			{
				txtFOV.Text = "5";
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}




		// paint stuff
		private void label1_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 11, FontStyle.Bold);
			e.Graphics.DrawString(lblMain.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(179, 226, 46)), -1, -1, StringFormat.GenericDefault);
		}
		private void lblAim_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblAim.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(240, 240, 240)), 0, -1, StringFormat.GenericDefault);
		}
		private void lblVisuals_Paint(object sender, PaintEventArgs e)
		{
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblVisuals.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(240, 240, 240)), 0, -1, StringFormat.GenericDefault);
		}
		private void lblMisc_Paint(object sender, PaintEventArgs e)
		{
			
			Font drawBoldFont = new Font("Verdana", 9, FontStyle.Bold);
			e.Graphics.DrawString(lblMisc.Text, drawBoldFont,
			new SolidBrush(Color.FromArgb(240,240,240)), 0, -1, StringFormat.GenericDefault);

		}
		private void pnlAim_Paint(object sender, PaintEventArgs e)
		{
			var borderStyleTopLeft = ButtonBorderStyle.Outset;
			var borderStyleBottomRight = ButtonBorderStyle.Inset;
			var borderWidth = 2; //default
			var borderColor = Color.Black;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, pnlAim.Width, pnlAim.Height),
								borderColor,//left
								borderWidth,
								borderStyleTopLeft,
								borderColor,//top
								borderWidth,
								borderStyleTopLeft,
								borderColor,//right
								borderWidth,
								borderStyleBottomRight,
								borderColor,//left
								borderWidth,
								borderStyleBottomRight);
		}
		private void pnlVis_Paint(object sender, PaintEventArgs e)
		{
			var borderStyleTopLeft = ButtonBorderStyle.Outset;
			var borderStyleBottomRight = ButtonBorderStyle.Inset;
			var borderWidth = 2; //default
			var borderColor = Color.Black;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, pnlVis.Width, pnlVis.Height),
								borderColor,//left
								borderWidth,
								borderStyleTopLeft,
								borderColor,//top
								borderWidth,
								borderStyleTopLeft,
								borderColor,//right
								borderWidth,
								borderStyleBottomRight,
								borderColor,//left
								borderWidth,
								borderStyleBottomRight);

		}
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			var borderColor = Color.Black;
            var borderStyle = ButtonBorderStyle.Outset;
            var borderWidth = 4;

            ControlPaint.DrawBorder(
                                e.Graphics,
                                new Rectangle(0,0,this.Width,this.Height),
                                borderColor,
                                borderWidth,
                                borderStyle,
                                borderColor,
                                borderWidth,
                                borderStyle,
                                borderColor,
                                borderWidth,
                                borderStyle = ButtonBorderStyle.Inset, //right side
                                borderColor,
                                borderWidth,
                                borderStyle = ButtonBorderStyle.Inset); //bottom side
		}
		private void btnQuit_Paint(object sender, PaintEventArgs e)
		{
			var borderColor = Color.Black;
			var borderStyle = ButtonBorderStyle.Outset;
			var borderWidth = 2;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, btnQuit.Width, btnQuit.Height),
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset, //right side
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset); //bottom side

		}
		private void btnUpFOV_Paint(object sender, PaintEventArgs e)
		{
			var borderColor = Color.Black;
			var borderStyle = ButtonBorderStyle.Outset;
			var borderWidth = 2;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, btnUpFOV.Width, btnUpFOV.Height),
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset, //right side
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset); //bottom side
		}
		private void btnDownFOV_Paint(object sender, PaintEventArgs e)
		{
			var borderColor = Color.Black;
			var borderStyle = ButtonBorderStyle.Outset;
			var borderWidth = 2;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, btnDownFOV.Width, btnDownFOV.Height),
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle,
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset, //right side
								borderColor,
								borderWidth,
								borderStyle = ButtonBorderStyle.Inset); //bottom side
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			var borderStyleTopLeft = ButtonBorderStyle.Outset;
			var borderStyleBottomRight = ButtonBorderStyle.Inset;
			var borderWidth = 2; //default
			var borderColor = Color.Black;

			ControlPaint.DrawBorder(
								e.Graphics,
								new Rectangle(0, 0, panel1.Width, panel1.Height),
								borderColor,//left
								borderWidth,
								borderStyleTopLeft,
								borderColor,//top
								borderWidth,
								borderStyleTopLeft,
								borderColor,//right
								borderWidth,
								borderStyleBottomRight,
								borderColor,//left
								borderWidth,
								borderStyleBottomRight);
		}

		private void checkBhop_CheckedChanged(object sender, EventArgs e)
		{
			if(BunnyHopThread.IsAlive == false)
			{
				BunnyHopThread.Start();
			}
		}

		private void checkBhop_MouseEnter(object sender, EventArgs e)
		{
			lblStatus.Text = "[CHECK]: Perfect [SHADED]: Legit";
		}

		private void checkBhop_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";
		}

		private void CheckRadar_CheckedChanged(object sender, EventArgs e)
		{
			if (radarThread.IsAlive == false)
			{
				radarThread.Start();
			}
		}
	}
}

