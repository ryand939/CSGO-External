using System;
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
	public partial class menu : Form
	{

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int GetAsyncKeyState(int key);



		Thread radarThread;
		Thread BunnyHopThread;
		Thread antiFlashThread;
		Thread glowThread;

		bool menuHide = false;
		bool thirdPerson = false;

		public menu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			memory.ManageMemory.Initialize("csgo");
			Offsets.client = memory.ManageMemory.GetModuleAdress("client_panorama");
			Offsets.engine = memory.ManageMemory.GetModuleAdress("engine"); 

			init_thread();

			GlobalKeyboardHook gkh = new GlobalKeyboardHook();
			gkh.hook();
			gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
			gkh.HookedKeys.Add(Keys.Delete);
			gkh.HookedKeys.Add(Keys.C);
		}

		public void gkh_KeyDown(object sender, KeyEventArgs e)
		{
			Thread.Sleep(100);
			Console.WriteLine("key press");
			Console.WriteLine(thirdPerson);
			int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
			// invert menuHide bool
			if (e.KeyCode == Keys.Delete)
			{
				menuHide = !menuHide;
				if (menuHide)
				{
					this.Hide();
				}
				else
				{
					this.Show();

				}
			}
			if (e.KeyCode == Keys.C)
			{
				thirdPerson = !thirdPerson;
				if (thirdPerson)
				{
					// forces the observer mode netvar to 1, which is third person
					memory.ManageMemory.WriteMemory<int>(LocalPlayer + netvars.m_iObserverMode, 1);
				}
				else
				{
					// forces the observer mode netvar to 0, which is first person
					memory.ManageMemory.WriteMemory<int>(LocalPlayer + netvars.m_iObserverMode, 0);
				}
			}
		}

		private void init_thread()
		{
			radarThread = new Thread(new ThreadStart(radar.Radar));

			BunnyHopThread = new Thread(new ThreadStart(Bunnyhop.Bhop));
			
			antiFlashThread = new Thread(new ThreadStart(AntiFlash.Antiflash));

			glowThread = new Thread(new ThreadStart(Glow.DrawGlow));
		}
		private void txtFOV_TextChanged(object sender, EventArgs e)
		{
			FOVChanger.FOV();
		}


		private void button1_Click_1(object sender, EventArgs e)
		{
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





		private void checkBhop_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBhop.Checked == true && BunnyHopThread.IsAlive == false)
			{
				BunnyHopThread.Start();
			}

			if(checkBhop.Checked == true)
			{
				Bunnyhop.waitHandle.Set();
				Bunnyhop.waitHandle.Reset();
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
			if(CheckRadar.Checked == true)
			{
				radar.waitHandle.Set();
				radar.waitHandle.Reset();
			}
		}
		private void checkFlashRemoval_CheckedChanged(object sender, EventArgs e)
		{

			if (antiFlashThread.IsAlive == false)
			{
				antiFlashThread.Start();
			}
			if (checkFlashRemoval.Checked == true)
			{
				AntiFlash.waitHandle.Set();
				AntiFlash.waitHandle.Reset();
			}
		}
		private void checkGlow_CheckedChanged(object sender, EventArgs e)
		{

		}


		private void btnDownFOV_MouseEnter(object sender, EventArgs e)
		{
			lblStatus.Text = "Edit your field of view";
		}

		private void btnDownFOV_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";
		}

		private void CheckRadar_MouseEnter(object sender, EventArgs e)
		{
			lblStatus.Text = "Reveal hidden enemies on radar";
		}

		private void CheckRadar_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";
		}
		// Quit button press
		private void button1_Click(object sender, EventArgs e)
		{
			antiFlashThread.Abort();
			BunnyHopThread.Abort();
			radarThread.Abort();
			Environment.Exit(0);
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void lblFlashRemoval_MouseEnter(object sender, EventArgs e)
		{

			lblStatus.Text = "Removes flash bang screen effect";
		}

		private void lblFlashRemoval_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";

		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
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

	}
}

