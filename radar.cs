using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace DWext
{
	class radar
	{
		public static void Radar()
		{
			Form1 form = (Form1)Application.OpenForms["Form1"];
			CheckState state = form.CheckRadar.CheckState;

			// Check the status of the radar checkbox
			while (true)
			{
				if (form.CheckRadar.Checked)
				{

					int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);

					// Get what team the LocalPlayer is on
					int LocalPlayerTeam = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iTeamNum);

					// Loop through all possible entities in the server
					for (int x = 0; x < 32;x++)
					{

						// For the current player
						int currentPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwEntityList + x * 0x10);

						// Check what team they are on, CT or T
						int currentPlayerTeam = memory.ManageMemory.ReadMemory<int>(currentPlayer + netvars.m_iTeamNum);

						// Check if they are dormant (if false, radar can not pick them up)
						bool isDormant = memory.ManageMemory.ReadMemory<bool>(currentPlayer + netvars.m_bDormant);

						// If dormant, break out of loop and check later
						if (isDormant)
						{
							continue;
						} 

						// If currentPlayer is on the opposite team, force them to be spotted. This will put them on radar.
						if (LocalPlayerTeam != currentPlayerTeam)
						{
							memory.ManageMemory.WriteMemory<bool>(currentPlayer + netvars.m_bSpotted, true);
						}


					}
					Thread.Sleep(500);
				}

				// If unchecked in menu, break out of loop
				if (CheckState.Unchecked == form.CheckRadar.CheckState)
				{
					continue;
				}

				Thread.Sleep(500);
			}
		}
	}
}
