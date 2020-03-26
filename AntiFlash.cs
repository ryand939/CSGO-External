using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DWext
{
	class AntiFlash
	{
		public static ManualResetEvent waitHandle = new ManualResetEvent(false);
		public static void Antiflash()
		{
			menu form = (menu)Application.OpenForms["menu"];
			CheckState state = form.checkBhop.CheckState;
			int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
			while (true)
			{
				memory.ManageMemory.WriteMemory<int>(LocalPlayer + netvars.m_flFlashDuration, 0);
				if(CheckState.Unchecked == form.checkFlashRemoval.CheckState)
				{
					waitHandle.WaitOne();
				}
				Thread.Sleep(200);
			}

		}

		
	}
}
