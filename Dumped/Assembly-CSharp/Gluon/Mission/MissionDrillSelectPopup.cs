/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Master;
using Gluon.Mission.ListView;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public class MissionDrillSelectPopup : MissionSelectPopupBase
	{
		// Fields
		[SerializeField]
		private MissionDrillStepProgressUI stepProgress;
		private int currentMissionDrillGroupId;
		private List<MissionDrillGroupElement> missionDrillGroupList;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<MissionTableViewData, bool> __9__3_0;
			public static Func<MissionDrillGroupElement, int> __9__7_0;
			public static Func<MissionDrillGroupElement, string> __9__10_0;
			public static Func<MissionTableViewData, bool> __9__13_0;
			public static Func<MissionTableViewData, bool> __9__15_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _UpdateBadge_b__3_0(MissionTableViewData e);
			internal int _Start_b__7_0(MissionDrillGroupElement e);
			internal string _InitializeTabButton_b__10_0(MissionDrillGroupElement e);
			internal bool _SwitchMissionTab_b__13_0(MissionTableViewData e);
			internal bool _ScrollToNotClearedMission_b__15_0(MissionTableViewData e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public MissionDrillGroupElement currentMissionDrillGroup;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal bool _Start_b__1(MissionDrillGroupElement e);
		}
	
		// Constructors
		public MissionDrillSelectPopup();
	
		// Methods
		protected override void UpdateBadge();
		public static bool ShouldEnableMissionBadge();
		private static MissionDrillSelectPopup CreateSub(Size size = Size.L, BottomButtons bottomButtons = BottomButtons.CancelOk, bool showBlackLayer = true, bool showStartAnimation = true);
		public static MissionDrillSelectPopup Create();
		protected override void Start();
		protected override TabCategory GetSelectedMissionCategory();
		protected override void SetVisibleNoCellEntry(bool isNoEntry);
		public override void InitializeTabButton();
		protected override void InitializeMissionTab();
		private bool IsUnlockedGroup(int tabIndex);
		public override void SwitchMissionTab();
		protected override void OpenDetailPopup(int indexInList, int dataIndex);
		private void ScrollToNotClearedMission();
		protected override void SetCellDatas();
		public override void ReloadWithRequestGetList();
		[CompilerGenerated]
		private void _InitializeTabButton_b__10_1(int index);
		[CompilerGenerated]
		private void _OpenDetailPopup_b__14_0();
		[CompilerGenerated]
		private void _OpenDetailPopup_b__14_1();
	}
}
