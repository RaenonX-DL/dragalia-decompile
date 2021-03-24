/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class BattleRoyalUtil
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BattleRoyalEventCycleElement, DateTime> __9__1_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal DateTime _GetCurrentOrNextCycle_b__1_0(BattleRoyalEventCycleElement x);
		}
	
		// Methods
		public static bool IsBattleRoyal(int eventId);
		public static bool GetCurrentOrNextCycle(DateTime now, out BattleRoyalEventCycleElement cycleElement);
		public static bool GetCurrentOrNextCycleDateTime(DateTime now, out DateTime startDT, out DateTime endDT);
	}
}
