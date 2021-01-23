/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventTopPageRaid : EventTopPageBase
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject raidTradeButton;
		[SerializeField]
		private Image raidTradeImageNormal;
		[SerializeField]
		private Image raidTradeImagePressed;
		[SerializeField]
		private Badge raidTradeBadge;
		private const string raidDailyMissionPUPrefsTemplate = "RaidEVDailyMissionPU_{0}_{1}";
		public const string raidTradeImageNormalName = "Btn_Trade_01_Normal";
		public const string raidTradeImagePressedName = "Btn_Trade_01_Pressed";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__7_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnPageBecomeActive_b__7_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public string checkPrefsDone;
			public string checkPrefsToday;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _OnBeginningPopupShown_b__0(bool doNotDisturb);
		}
	
		// Constructors
		public EventTopPageRaid();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		protected override void OnBeginningPopupShown();
		private bool ShouldDisableRaidTradeButton();
		public void OnRaidTradeButtonPressed();
	}
}
