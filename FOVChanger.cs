using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DWext
{
	class FOVChanger
	{

		public static void FOV()
		{
			menu form = (menu)Application.OpenForms["menu"];
			int LocalPlayer = memory.ManageMemory.ReadMemory<int>(Offsets.client + Offsets.dwLocalPlayer);
			int defaultFOV = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iDefaultFOV);
			int defaultScopedFOV = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iDefaultFOV);

			// create bool to see if the user entered a valid number
			bool isNumeric = int.TryParse(form.txtFOV.Text, out _);

			// if the user entered a number, and it is < 150 (no need to change fov OVER 150), proceed to change FOV
			if(form.txtFOV.Text != "" && isNumeric && Convert.ToInt32(form.txtFOV.Text) <= 150)
			{
				bool isScoped = memory.ManageMemory.ReadMemory<bool>(LocalPlayer + netvars.m_bIsScoped);
				if (isScoped)
				{

					memory.ManageMemory.WriteMemory<int>(LocalPlayer + netvars.m_iDefaultFOV, defaultFOV);
				}
				else
				{
					int currentFov = memory.ManageMemory.ReadMemory<int>(LocalPlayer + netvars.m_iDefaultFOV);
					Console.WriteLine($"fov: {currentFov}");
					memory.ManageMemory.WriteMemory<int>(LocalPlayer + netvars.m_iDefaultFOV, Convert.ToInt32(form.txtFOV.Text));
				}
			}

			

			


		}

	}
}
