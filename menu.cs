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
		Thread triggerThread;
		Thread chamsThread;


		bool menuHide = false;
		bool thirdPerson = false;
		bool showColorPicker = false;


		GlobalKeyboardHook gkh = new GlobalKeyboardHook();
		overlay overlay = new overlay();
		colorpicker colorpickerform = new colorpicker();




		public menu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			//very bad VVVVVVV
			Control.CheckForIllegalCrossThreadCalls = false;
			// very bad CODE BAD ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
			// FIX SOMEHOW

			memory.ManageMemory.Initialize("csgo");
			Offsets.client = memory.ManageMemory.GetModuleAdress("client");
			Offsets.engine = memory.ManageMemory.GetModuleAdress("engine");
			Console.WriteLine(Offsets.client.ToString());
			Console.WriteLine(Offsets.engine.ToString());
			gkh.hook();
			gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
			gkh.HookedKeys.Add(Keys.Delete);
			gkh.HookedKeys.Add(Keys.C);
			init_thread();
			colorpickerform.Location = new Point(this.Location.X + 277, this.Location.Y);
		}

		public void gkh_KeyDown(object sender, KeyEventArgs e)
		{
			Thread.Sleep(100);
			// invert menuHide bool
			if (e.KeyCode == Keys.Delete)
			{
				menuHide = !menuHide;
				if (menuHide)
				{
					this.Hide();
					showColorPicker = false;
					colorpickerform.Hide();
				}
				else
				{
					this.Show();

				}
			}
			if (e.KeyCode == Keys.C)
			{
				int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
				thirdPerson = !thirdPerson;
				if (thirdPerson)
				{
					// forces the observer mode netvar to 1, which is third person
					memory.ManageMemory.WriteMemory<int>(LocalPlayer + netvars.m_iObserverMode, 1);
					Console.WriteLine(netvars.m_iObserverMode.ToString());
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

			glowThread = new Thread(() => Glow.DrawGlow(colorpickerform));
			//glowThread = new Thread(new ThreadStart(Glow.DrawGlow));

			triggerThread = new Thread(new ThreadStart(Triggerbot.triggerbot));

			chamsThread = new Thread(new ThreadStart(Chams.chams));
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
			if (glowThread.IsAlive == false)
			{
				glowThread.Start();
			}
			if (checkGlow.Checked == true)
			{
				Glow.waitHandle.Set();
				Glow.waitHandle.Reset();
			}

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
			glowThread.Abort();
			triggerThread.Abort();
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

		private void checkGlow_MouseEnter(object sender, EventArgs e)
		{
			lblStatus.Text = "Creates a glow outline on all players";
		}

		private void checkTrigger_CheckedChanged(object sender, EventArgs e)
		{
			if (triggerThread.IsAlive == false)
			{
				triggerThread.Start();
			}
			if (checkTrigger.Checked == true)
			{
				Triggerbot.waitHandle.Set();
				Triggerbot.waitHandle.Reset();
			}
		}

		private void checkGlow_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";
		}

		private void checkTeamTarget_MouseEnter(object sender, EventArgs e)
		{
			lblStatus.Text = "Aimbot properties will be applied to teammates";
		}

		private void checkTeamTarget_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";
		}

		private void checkTrigger_MouseEnter(object sender, EventArgs e)
		{
			lblStatus.Text = $"Automatically shoot at enemies{colorpickerform.trackRed.Value}";
		}

		private void checkTrigger_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";
		}

		private void lblMain_MouseEnter(object sender, EventArgs e)
		{
			lblStatus.Text = "DAERWARE EXTERNAL - An ICS4U final project";
		}

		private void lblMain_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";
		}

		private void checkChams_CheckedChanged(object sender, EventArgs e)
		{
			if (chamsThread.IsAlive == false)
			{
				chamsThread.Start();
			}
			if (checkTrigger.Checked == true)
			{
				Chams.waitHandle.Set();
				Chams.waitHandle.Reset();
			}
		}

		private void checkChams_MouseEnter(object sender, EventArgs e)
		{
			lblStatus.Text = "Use shaded models";
		}

		private void checkChams_MouseLeave(object sender, EventArgs e)
		{
			lblStatus.Text = "";
		}

		private void checkOverlay_CheckedChanged(object sender, EventArgs e)
		{
			if(checkOverlay.Checked == true)
			{
				overlay.Show();
			}
			else
			{
				overlay.Hide();
			}
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			showColorPicker = !showColorPicker;

			if(showColorPicker)// is true
			{
				colorpickerform.Location = new Point(this.Location.X + 277, this.Location.Y);
				colorpickerform.Show();
			}
			else
			{
				colorpickerform.Hide();
			}
		}

		private void menu_LocationChanged(object sender, EventArgs e)
		{
			colorpickerform.Location = new Point(this.Location.X + 277, this.Location.Y);
		}
	}
}

