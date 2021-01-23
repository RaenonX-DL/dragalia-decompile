/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerGuardReactionInChargeController
	{
		// Fields
		private bool isWait;
		private float[] damageCutRate;
		private int[] actionId;
		private PlayerCharacter player;
	
		// Constructors
		public PlayerGuardReactionInChargeController(PlayerCharacter player);
	
		// Methods
		public void Reset();
		public bool IsWait();
		public void StartWait(float[] rate, int[] ids);
		public void StopWait();
		public float GetDamageCutRateOnWait(int invincibleBreakLv);
		public int GetActionIdOnWait(int invincibleBreakLv);
		public void Exec(int invincibleBreakLv);
	}
}
