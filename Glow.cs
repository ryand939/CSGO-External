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
	class Glow
	{
        public static ManualResetEvent waitHandle = new ManualResetEvent(false);
        public static void DrawGlow()
        {        
            menu form = (menu)Application.OpenForms["menu"];
            CheckState state = form.CheckRadar.CheckState;
            float r = 0f; float b = 1f; float g = 0f; float a = 1f; // friendly
            float r_e = 1f; float b_e = 0f; float g_e = 0f; // enemy


            while (true)
            {
                if (form.checkGlow.Checked)
                    {
                        // glb 
                        int gp = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwGlowObjectManager);

                    int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
                    int LocalPlayerTeam = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iTeamNum);
                    if (form.checkGlow.Checked)
                    {
                        for (int i = 0; i < 32; i++)
                        {


                            int g_cp = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwEntityList + i * 0x10);
                            bool g_cpd = memory.ManageMemory.ReadMemory<bool>(g_cp + netvars.m_bDormant);
                            int g_cpgi = memory.ManageMemory.ReadMemory<int>(g_cp + netvars.m_iGlowIndex);
                            int ent_team = memory.ManageMemory.ReadMemory<int>(g_cp + netvars.m_iTeamNum);
                            if (g_cpd == true || ent_team == 0)
                                continue;
                            else
                            {
                                if (LocalPlayerTeam == ent_team)
                                {
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x4)), r);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x8)), g);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0xC)), b);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x10)), a);
                                    memory.ManageMemory.WriteMemory<bool>((gp + ((g_cpgi * 0x38) + 0x24)), true);
                                    memory.ManageMemory.WriteMemory<bool>((gp + ((g_cpgi * 0x38) + 0x25)), false);
                                }
                                else
                                {
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x4)), r_e);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x8)), g_e);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0xC)), b_e);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x10)), a);
                                    memory.ManageMemory.WriteMemory<bool>((gp + ((g_cpgi * 0x38) + 0x24)), true);
                                    memory.ManageMemory.WriteMemory<bool>((gp + ((g_cpgi * 0x38) + 0x25)), false);
                                }
                            }
                        }
                        

                        }
                }
                // If unchecked in menu, break out of loop
                if (CheckState.Unchecked == form.checkGlow.CheckState)
                {
                    waitHandle.WaitOne();
                }
                Thread.Sleep(5);


		}
	}
}
}
