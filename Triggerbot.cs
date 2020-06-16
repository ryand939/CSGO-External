using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;

namespace DWext
{
    class Triggerbot
    {
        public static ManualResetEvent waitHandle = new ManualResetEvent(false);

        public static void triggerbot()
        {
            menu form = (menu)Application.OpenForms["menu"];
            CheckState state = form.checkTrigger.CheckState;
            int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
            int LocalPlayerTeam = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iTeamNum);

            while (true)
            {
                if (form.checkTrigger.Checked)
                {
                    int CrosshairID = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iCrosshairId);
                    if (CrosshairID > 0 && CrosshairID < 64) // if the person in cross is a person in the server
                    {
                        int EntityListPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwEntityList + (CrosshairID - 1) * 0x10);
                        int crossTeam = memory.ManageMemory.ReadMemory<int>(EntityListPlayer + netvars.m_iTeamNum);
                        int crossHealth = memory.ManageMemory.ReadMemory<int>(EntityListPlayer + netvars.m_iHealth);
                        if ((LocalPlayerTeam != crossTeam || form.checkTeamTarget.Checked) && crossHealth > 0) // if the person in cross is on the other team, and they are alive
                        {
                            memory.ManageMemory.WriteMemory<int>(Offsets.client + Offsets.dwForceAttack, 1);
                            Thread.Sleep(1);
                            memory.ManageMemory.WriteMemory<int>(Offsets.client + Offsets.dwForceAttack, 4); // forces attack (shoots) then resets the force attack state
                            Thread.Sleep(10);
                        }

                    }
                }
                // If unchecked in menu, break out of loop
                if (CheckState.Unchecked == form.checkTrigger.CheckState)
                {
                    waitHandle.WaitOne();
                }
            }
        }
    }
}
