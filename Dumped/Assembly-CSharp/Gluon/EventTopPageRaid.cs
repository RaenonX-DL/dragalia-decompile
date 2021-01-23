/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventTopPageRaid : EventTopPageBase
	{
		// Fields
		private const string raidDailyMissionPUPrefsTemplate = "RaidEVDailyMissionPU_{0}_{1}";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__1_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnPageBecomeActive_b__1_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public string checkPrefsDone;
			public string checkPrefsToday;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _OnBeginningPopupShown_b__0(bool doNotDisturb);
		}
	
		// Constructors
		public EventTopPageRaid();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		protected override void OnBeginningPopupShown();
		public void OnRaidTradeButtonPressed();
	}
}
