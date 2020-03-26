using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace DWext
{
	class Bunnyhop
	{
		// dll import for GetAsyncKeyState
		[DllImport("user32.dll")]
		public static extern int GetAsyncKeyState(int key);


		public static void Bhop()
		{
			Form1 form = (Form1)Application.OpenForms["Form1"];
			int flagJump;
			int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
			int forceJump = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwForceJump);

			while (true) 
			{
				while(GetAsyncKeyState(32) > 0 && form.checkBhop.Checked == true)
				{
					int delay;
					flagJump = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_fFlags);
					CheckState state = form.checkBhop.CheckState;

					// check the status of the checkbox
					if (CheckState.Checked == form.checkBhop.CheckState)
					{
						delay = 10;
					}
					else if(CheckState.Indeterminate == form.checkBhop.CheckState)
					{
						delay = 50;
					}
					else 
					{
						delay = 1000;
					}

					// check if the user is on the ground currently, send jump accordingly
					if (flagJump == 257)
					{
						memory.ManageMemory.WriteMemory<int>(Offsets.client + Offsets.dwForceJump, 5);
					}
					else
					{
						memory.ManageMemory.WriteMemory<int>(Offsets.client + Offsets.dwForceJump, 4);
					}
					Thread.Sleep(delay);
				}

				//if the checkbox is empty, stop checking if space is held
				if (CheckState.Unchecked == form.checkBhop.CheckState)
				{
					continue;
				}

				Thread.Sleep(200);
			}


		}

		
	}
}
