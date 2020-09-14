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
        public static void DrawGlow(colorpicker colorpicker)
        {       
            
            menu form = (menu)Application.OpenForms["menu"];
            CheckState state = form.CheckRadar.CheckState;            
           float r; float b; float g; 
           float r_e; float b_e; float g_e; // enemy
            
            float a = 1f; // Alpha
            
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
                                    //Console.WriteLine($"rgb({colorpicker.trackRed.Value},{colorpicker.trackGreen.Value},{colorpicker.trackBlue.Value})");
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x4)), ((float)colorpicker.trackRed.Value)/255);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x8)), ((float)colorpicker.trackGreen.Value)/255);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0xC)), ((float)colorpicker.trackBlue.Value)/255);
                                    memory.ManageMemory.WriteMemory<float>((gp + ((g_cpgi * 0x38) + 0x10)), a);
                                    memory.ManageMemory.WriteMemory<bool>((gp + ((g_cpgi * 0x38) + 0x24)), true);
                                    memory.ManageMemory.WriteMemory<bool>((gp + ((g_cpgi * 0x38) + 0x25)), false);
                                }
                                else // player is an enemy
                                {
                                    if (colorpicker.checkHealthBasedE.Checked)
                                    {
                                        int entHealth = memory.ManageMemory.ReadMemory<int>(g_cp + netvars.m_iHealth); // get health/100
                                        Console.WriteLine(entHealth);
                                        g_e = (float)entHealth/100; // get percent that green needs to be ex health 70 -> 70/100 = .7
                                        r_e = 1 - ((float)entHealth/100); // get percent red needs to be
                                        b_e = 0;
									}
									else
									{
                                        r_e = ((float)colorpicker.trackRedEnemy.Value) / 255;
                                        g_e = ((float)colorpicker.trackGreenEnemy.Value) / 255;
                                        b_e = ((float)colorpicker.trackBlueEnemy.Value) / 255;
                                    }
                                    //Console.WriteLine($"rgb({(float)r_e},{(float)g_e},{(float)b_e})");
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
                Thread.Sleep(0);


		}
	}
}
}
