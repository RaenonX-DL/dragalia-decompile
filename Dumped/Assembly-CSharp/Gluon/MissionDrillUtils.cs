/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class MissionDrillUtils
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<MissionDrillGroupElement, bool> __9__0_0;
			public static Action<ErrorType, int> __9__1_1;
			public static Func<MissionDrillGroupElement, int> __9__2_0;
			public static Action<ErrorType, int> __9__2_2;
			public static Action __9__3_0;
			public static Func<MissionDrillGroupElement, int> __9__5_0;
			public static Func<DrillTalkElement, bool> __9__11_0;
			public static Func<DrillTalkElement, bool> __9__12_0;
			public static Func<MissionDrillDataElement, int> __9__13_1;
			public static Func<MissionDrillDataElement, int> __9__14_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _IsMissionDrillOpened_b__0_0(MissionDrillGroupElement e);
			internal void _RequestGetDrillMissionList_b__1_1(ErrorType errorType, int resultCode);
			internal int _RequestUnlockFirstMissionGroup_b__2_0(MissionDrillGroupElement e);
			internal void _RequestUnlockFirstMissionGroup_b__2_2(ErrorType errorType, int resultCode);
			internal void _GoToMissionDrillScene_b__3_0();
			internal int _GetNextMissionDrillGroup_b__5_0(MissionDrillGroupElement e);
			internal bool _GetCommonDrillTalk_b__11_0(DrillTalkElement drillTalk);
			internal bool _GetReceivableMissionDrillTalk_b__12_0(DrillTalkElement drillTalk);
			internal int _GetFirstMissionDrillData_b__13_1(MissionDrillDataElement e);
			internal int _GetPrevMissionDrillData_b__14_1(MissionDrillDataElement e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _RequestGetDrillMissionList_b__0(MissionGetDrillMissionListResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _RequestUnlockFirstMissionGroup_b__1(MissionUnlockDrillMissionGroupResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public MissionDrillGroupElement currentMissionDrillGroup;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal bool _GetNextMissionDrillGroup_b__1(MissionDrillGroupElement e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public int groupId;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal bool _IsAllClearedMissionGroup_b__0(MissionDrillDataElement e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public MissionDrillGroupElement group;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal bool _GetCurrentCompleteTalk_b__0(DrillTalkElement drillTalk);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public MissionDrillGroupElement group;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal bool _GetCurrentNextTalk_b__0(DrillTalkElement drillTalk);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public int groupId;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal bool _GetFirstMissionDrillData_b__0(MissionDrillDataElement e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public MissionDrillDataElement missionDrill;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal bool _GetPrevMissionDrillData_b__0(MissionDrillDataElement e);
			internal bool _GetPrevMissionDrillData_b__2(MissionDrillDataElement e);
		}
	
		// Methods
		public static bool IsMissionDrillOpened();
		public static void RequestGetDrillMissionList(Action successCallback);
		private static void RequestUnlockFirstMissionGroup(Action successCallback);
		public static void GoToMissionDrillScene();
		public static MissionDrillGroupElement GetCurrentMissionDrillGroup();
		public static MissionDrillGroupElement GetNextMissionDrillGroup();
		public static bool IsAllClearedCurrentMission();
		public static bool IsAllClearedMissionGroup(int groupId);
		public static bool IsReceivedCompleteReward(int groupId);
		public static DrillTalkElement GetCurrentCompleteTalk();
		public static DrillTalkElement GetCurrentNextTalk();
		public static DrillTalkElement GetCommonDrillTalk();
		public static DrillTalkElement GetReceivableMissionDrillTalk();
		public static MissionDrillDataElement GetFirstMissionDrillData(int groupId);
		public static MissionDrillDataElement GetPrevMissionDrillData(int missionId);
	}
}
