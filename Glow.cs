using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DWext
{
	class Glow
	{
		public static ManualResetEvent waitHandle = new ManualResetEvent(false);
		public static void DrawGlow()
		{
			menu form = (menu)Application.OpenForms["menu"];
			CheckState state = form.CheckRadar.CheckState;

			int currentPlayer;
			int currentPlayerTeam;
			int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
			int LocalPlayerTeam = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iTeamNum);

			while (true)
			{
				for(int x = 0; x < 32; x++)
				{
					currentPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwEntityList + x * 0x10);
					currentPlayerTeam = memory.ManageMemory.ReadMemory<int>(currentPlayer + netvars.m_iTeamNum);

					if(LocalPlayerTeam == currentPlayerTeam)
					{

					}
				}





				if(CheckState.Unchecked == form.checkGlow.CheckState)
				{
					waitHandle.WaitOne();
				}
			}


		}
	}
}
