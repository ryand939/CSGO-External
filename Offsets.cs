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


		public const Int32 dwLocalPlayer = 0xD39BEC;
		public const Int32 dwEntityList = 0x4D4E21C;
		public const Int32 dwForceForward = 0x317F7A4;
		public const Int32 dwForceAttack = 0x317F750;
		public const Int32 dwForceJump = 0x51F7EB4;
		public const Int32 dwGlowObjectManager = 0x5296060;
		public const Int32 dwClientState_ViewAngles = 0x4D88;
		public const Int32 dwClientState_State = 0x108;
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
        public const Int32 m_bIsScoped = 0x3928;
		public const Int32 m_fFlags = 0x104;
        public const Int32 m_flFlashDuration = 0xA420;
        public const Int32 m_iGlowIndex = 0xA438;
		public const Int32 m_iObserverMode = 0x3378;
		public const Int32 m_aimPunchAngle = 0x302C;
		public const Int32 m_iShotsFired = 0xA390;
		public const Int32 m_iCrosshairId = 0xB3E4;

	}
}
