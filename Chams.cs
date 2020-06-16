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
	class Chams
	{
		public static ManualResetEvent waitHandle = new ManualResetEvent(false);
		public static void chams()
		{
			menu form = (menu)Application.OpenForms["menu"];
			CheckState state = form.CheckRadar.CheckState;
            int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
            while (true)
			{
				if (form.checkChams.Checked)
                {
                    int LocalPlayerTeam = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iTeamNum);
                    for (int i = 1; i < 32; i++)
                    {
                        int entityList = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwEntityList + i * 0x10);
                        int entityTeam = memory.ManageMemory.ReadMemory<int>(entityList + netvars.m_iTeamNum);

                        if (entityTeam == LocalPlayerTeam)
                        {
                            memory.ManageMemory.WriteMemory<byte>(entityList + 0x70, 12);
                            memory.ManageMemory.WriteMemory<byte>(entityList + 0x71, 105);
                            memory.ManageMemory.WriteMemory<byte>(entityList + 0x72, 245);
                        }
                        else
                        {
                            memory.ManageMemory.WriteMemory<byte>(entityList + 0x70, 255);
                            memory.ManageMemory.WriteMemory<byte>(entityList + 0x71, 0);
                            memory.ManageMemory.WriteMemory<byte>(entityList + 0x72, 0);
                        }

                    }
                    Thread.Sleep(5000);
                }
                if (CheckState.Unchecked == form.CheckRadar.CheckState)
                {
                    waitHandle.WaitOne();
                }           }
		}
	}
}
