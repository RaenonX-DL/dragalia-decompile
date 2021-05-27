/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Http;
using Gluon.Master;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public class MissionListDataUtility
	{
		// Fields
		private const int normalCaptionGroupId = 999999;
		public const int albumCaptionGroupId = 1000000;
	
		// Properties
		public static CurrentMainStoryMission CurrentMainStoryMission { get; }
		public static int CurrentMainStoryMissionGroupId { get; }
	
		// Nested types
		private struct DailyMissionData
		{
			// Fields
			public DailyMissionList mission;
			public MissionDailyDataElement element;
		}
	
		private struct PeriodMissionData
		{
			// Fields
			public PeriodMissionList mission;
			public MissionPeriodDataElement element;
		}
	
		private struct NormalMissionData
		{
			// Fields
			public NormalMissionList mission;
			public MissionNormalDataElement element;
		}
	
		private struct MainStoryMissionData
		{
			// Fields
			public MainStoryMissionList mission;
			public MissionMainStoryDataElement element;
		}
	
		private struct MemoryEventMissionData
		{
			// Fields
			public MemoryEventMissionList mission;
			public MissionMemoryEventDataElement element;
		}
	
		private struct SpecialMissionData
		{
			// Fields
			public SpecialMissionList mission;
			public MissionSpecialDataElement element;
		}
	
		private struct BeginnerMissionData
		{
			// Fields
			public BeginnerMissionList mission;
			public MissionBeginnerDataElement element;
		}
	
		private struct DrillMissionData
		{
			// Fields
			public DrillMissionList mission;
			public MissionDrillDataElement element;
		}
	
		private struct AlbumMissionData
		{
			// Fields
			public AlbumMissionList mission;
			public MissionAlbumDataElement element;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public int currentEventId;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal bool _GetDailyMissionList_b__0(MissionTableViewData x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<MissionTableViewData, int> __9__15_1;
			public static Func<MissionTableViewData, bool> __9__15_2;
			public static Func<MissionTableViewData, MissionTableViewData.State> __9__15_3;
			public static Func<MissionTableViewData, int> __9__15_4;
			public static Predicate<MissionTableViewData> __9__15_5;
			public static Func<MissionTableViewData, int> __9__18_1;
			public static Func<MissionTableViewData, bool> __9__18_2;
			public static Func<MissionTableViewData, MissionTableViewData.State> __9__18_3;
			public static Func<MissionTableViewData, int> __9__18_4;
			public static Func<MissionTableViewData, int> __9__19_0;
			public static Func<MissionTableViewData, bool> __9__19_1;
			public static Func<MissionTableViewData, MissionTableViewData.State> __9__19_2;
			public static Func<MissionTableViewData, int> __9__19_3;
			public static Func<DrillMissionData, int> __9__20_0;
			public static Func<MissionTableViewData, bool> __9__20_1;
			public static Func<MissionDrillDataElement, DrillMissionData> __9__22_1;
			public static Func<DrillMissionData, int> __9__22_2;
			public static Func<MissionTableViewData, int> __9__24_0;
			public static Func<MissionTableViewData, int> __9__24_1;
			public static Func<MissionTableViewData, bool> __9__24_2;
			public static Func<MissionTableViewData, MissionTableViewData.State> __9__24_3;
			public static Func<MissionTableViewData, int> __9__24_4;
			public static Func<MissionTableViewData, int> __9__25_1;
			public static Func<MissionTableViewData, bool> __9__25_2;
			public static Func<MissionTableViewData, MissionTableViewData.State> __9__25_3;
			public static Func<MissionTableViewData, int> __9__25_4;
			public static Func<SpecialShopElement, string> __9__26_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetDailyMissionList_b__15_1(MissionTableViewData x);
			internal bool _GetDailyMissionList_b__15_2(MissionTableViewData x);
			internal MissionTableViewData.State _GetDailyMissionList_b__15_3(MissionTableViewData x);
			internal int _GetDailyMissionList_b__15_4(MissionTableViewData x);
			internal bool _GetDailyMissionList_b__15_5(MissionTableViewData x);
			internal int _GetPeriodMissionList_b__18_1(MissionTableViewData x);
			internal bool _GetPeriodMissionList_b__18_2(MissionTableViewData x);
			internal MissionTableViewData.State _GetPeriodMissionList_b__18_3(MissionTableViewData x);
			internal int _GetPeriodMissionList_b__18_4(MissionTableViewData x);
			internal int _GetNormalMissionList_b__19_0(MissionTableViewData x);
			internal bool _GetNormalMissionList_b__19_1(MissionTableViewData x);
			internal MissionTableViewData.State _GetNormalMissionList_b__19_2(MissionTableViewData x);
			internal int _GetNormalMissionList_b__19_3(MissionTableViewData x);
			internal int _GetMissionDrillList_b__20_0(DrillMissionData e);
			internal bool _GetMissionDrillList_b__20_1(MissionTableViewData e);
			internal DrillMissionData _GetMissionDrillList_b__22_1(MissionDrillDataElement e);
			internal int _GetMissionDrillList_b__22_2(DrillMissionData e);
			internal int _GetSpecialMissionList_b__24_0(MissionTableViewData x);
			internal int _GetSpecialMissionList_b__24_1(MissionTableViewData x);
			internal bool _GetSpecialMissionList_b__24_2(MissionTableViewData x);
			internal MissionTableViewData.State _GetSpecialMissionList_b__24_3(MissionTableViewData x);
			internal int _GetSpecialMissionList_b__24_4(MissionTableViewData x);
			internal int _GetBeginnerMissionList_b__25_1(MissionTableViewData x);
			internal bool _GetBeginnerMissionList_b__25_2(MissionTableViewData x);
			internal MissionTableViewData.State _GetBeginnerMissionList_b__25_3(MissionTableViewData x);
			internal int _GetBeginnerMissionList_b__25_4(MissionTableViewData x);
			internal string _GetCaptionName_b__26_1(SpecialShopElement x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public int currentEventId;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal bool _GetPeriodMissionList_b__0(MissionTableViewData x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public int groupId;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal bool _GetMissionDrillList_b__0(MissionDrillDataElement e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public int currentEventId;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal bool _GetBeginnerMissionList_b__0(MissionTableViewData x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public int groupId;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal bool _GetCaptionName_b__0(SpecialShopElement x);
		}
	
		// Constructors
		public MissionListDataUtility();
	
		// Methods
		public static List<MissionTableViewData> GetDailyMissionList(DataManager.GameData<DailyMissionList> gameDataMissionList, bool isShowHistory = false, UnityAction reloadCallback = null);
		public static bool IsUnusableFunction(MissionTransportType type);
		private static string MissionDailyDateText(int dayNo);
		public static List<MissionTableViewData> GetPeriodMissionList(DataManager.GameData<PeriodMissionList> gameDataMissionList, bool isShowHistory = false, UnityAction reloadCallback = null);
		public static List<MissionTableViewData> GetNormalMissionList(DataManager.GameData<NormalMissionList> gameDataMissionList, DataManager.GameData<MainStoryMissionList> gameDataStoryMissionList, DataManager.GameData<MemoryEventMissionList> gameDataMemoryEventMissionList, DataManager.GameData<AlbumMissionList> gameDataAlbumMissionList, bool isShowHistory = false);
		public static List<MissionTableViewData> GetMissionDrillList(int groupId, DataManager.GameData<DrillMissionList> gameDataMissionList);
		private static MissionTableViewData GetMissionDrillCompleteViewData(MissionDrillGroupElement missionDrillGroup, MissionTableViewData.State state);
		private static List<MissionTableViewData> GetMissionDrillList(int groupId);
		private static List<MissionTableViewData> CreateMissionTableViewDataList(List<DrillMissionData> missionList, bool isFirstMissionLocked);
		public static List<MissionTableViewData> GetSpecialMissionList(DataManager.GameData<SpecialMissionList> gameDataMissionList, bool isShowHistory = false, bool isPurchased = false);
		public static List<MissionTableViewData> GetBeginnerMissionList(DataManager.GameData<BeginnerMissionList> gameDataMissionList, bool isShowHistory = false, UnityAction reloadCallback = null);
		private static string GetCaptionName(MissionTableViewData.Category category, int groupId = 0);
		public static bool CheckPickupMission();
		public static void UpdateMissionBadge(Badge badge, GameObject pickupBadgeGO);
		public static QuestEntryConditionList GetUserQuestEntryConditionList(int entryConditionId);
	}
}
