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

		
		public const Int32 dwLocalPlayer = 0xD30B84;
		public const Int32 dwEntityList = 0x4D449F4;
		public const Int32 dwForceForward = 0x3175FB0;
		public const Int32 dwForceAttack = 0x3175F98;
		public const Int32 dwSetClanTag = 0x89E00;
		public const Int32 dwForceJump = 0x51EE650;
	}
	class netvars
	{
		public const Int32 m_iHealth = 0x100;
		public const Int32 m_iTeamNum = 0xF4;
		public const Int32 m_bSpotted = 0x93D;
		public const Int32 m_bDormant = 0xED;
		public const Int32 m_iFOV = 0x31E4;
		public const Int32 m_iFOVStart = 0x31E8;
		public const Int32 m_bIsScoped = 0x3914;
		public const Int32 m_iDefaultFOV = 0x332C;
		public const Int32 m_fFlags = 0x104;
		public const Int32 m_flFlashDuration = 0xA410;

	}
}
