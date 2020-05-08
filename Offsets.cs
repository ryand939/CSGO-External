using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWext
{
	class Offsets
	{
		public static int client;
		public static int engine;

		
		public const Int32 dwLocalPlayer = 0xD2FB94;
		public const Int32 dwEntityList = 0x4D43AE4;
		public const Int32 dwForceForward = 0x31750D0;
		public const Int32 dwForceAttack = 0x317507C;
		public const Int32 dwForceJump = 0x51ED780;
		public const Int32 dwGlowObjectManager = 0x528B8B8;
	}
	class netvars
	{
		public const Int32 m_iHealth = 0x100;
		public const Int32 m_iTeamNum = 0xF4;
		public const Int32 m_bSpotted = 0x93D;
		public const Int32 m_bDormant = 0xED;
		public const Int32 m_iFOV = 0x31E4;
		public const Int32 m_iFOVStart = 0x31E8;
		public const Int32 m_iDefaultFOV = 0x332C;
		public const Int32 m_bIsScoped = 0x3914;
		public const Int32 m_fFlags = 0x104;
		public const Int32 m_flFlashDuration = 0xA410;
		public const Int32 m_iGlowIndex = 0xA428;

	}
}
