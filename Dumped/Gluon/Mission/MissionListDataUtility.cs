using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using Gluon.Master;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon.Mission
{
	public class MissionListDataUtility
	{
		private struct DailyMissionData
		{
			public DailyMissionList mission;

			public MissionDailyDataElement element;
		}

		private struct PeriodMissionData
		{
			public PeriodMissionList mission;

			public MissionPeriodDataElement element;
		}

		private struct NormalMissionData
		{
			public NormalMissionList mission;

			public MissionNormalDataElement element;
		}

		private struct MainStoryMissionData
		{
			public MainStoryMissionList mission;

			public MissionMainStoryDataElement element;
		}

		private struct MemoryEventMissionData
		{
			public MemoryEventMissionList mission;

			public MissionMemoryEventDataElement element;
		}

		private struct SpecialMissionData
		{
			public SpecialMissionList mission;

			public MissionSpecialDataElement element;
		}

		private struct BeginnerMissionData
		{
			public BeginnerMissionList mission;

			public MissionBeginnerDataElement element;
		}

		private struct DrillMissionData
		{
			public DrillMissionList mission;

			public MissionDrillDataElement element;
		}

		private struct AlbumMissionData
		{
			public AlbumMissionList mission;

			public MissionAlbumDataElement element;
		}

		private const int normalCaptionGroupId = 999999;

		public const int albumCaptionGroupId = 1000000;

		public static CurrentMainStoryMission CurrentMainStoryMission => null;

		public static int CurrentMainStoryMissionGroupId => default(int);

		public static List<MissionTableViewData> GetDailyMissionList(DataManager.GameData<DailyMissionList> gameDataMissionList, bool isShowHistory = false, [Optional] UnityAction reloadCallback)
		{
			return null;
		}

		public static bool IsUnusableFunction(MissionTransportType type)
		{
			return default(bool);
		}

		private static string MissionDailyDateText(int dayNo)
		{
			return null;
		}

		public static List<MissionTableViewData> GetPeriodMissionList(DataManager.GameData<PeriodMissionList> gameDataMissionList, bool isShowHistory = false, [Optional] UnityAction reloadCallback)
		{
			return null;
		}

		public static List<MissionTableViewData> GetNormalMissionList(DataManager.GameData<NormalMissionList> gameDataMissionList, DataManager.GameData<MainStoryMissionList> gameDataStoryMissionList, DataManager.GameData<MemoryEventMissionList> gameDataMemoryEventMissionList, DataManager.GameData<AlbumMissionList> gameDataAlbumMissionList, bool isShowHistory = false)
		{
			return null;
		}

		public static List<MissionTableViewData> GetMissionDrillList(int groupId, DataManager.GameData<DrillMissionList> gameDataMissionList)
		{
			return null;
		}

		private static MissionTableViewData GetMissionDrillCompleteViewData(MissionDrillGroupElement missionDrillGroup, MissionTableViewData.State state)
		{
			return null;
		}

		private static List<MissionTableViewData> GetMissionDrillList(int groupId)
		{
			return null;
		}

		private static List<MissionTableViewData> CreateMissionTableViewDataList(List<DrillMissionData> missionList, bool isFirstMissionLocked)
		{
			return null;
		}

		public static List<MissionTableViewData> GetSpecialMissionList(DataManager.GameData<SpecialMissionList> gameDataMissionList, bool isShowHistory = false, bool isPurchased = false)
		{
			return null;
		}

		public static List<MissionTableViewData> GetBeginnerMissionList(DataManager.GameData<BeginnerMissionList> gameDataMissionList, bool isShowHistory = false, [Optional] UnityAction reloadCallback)
		{
			return null;
		}

		private static string GetCaptionName(MissionTableViewData.Category category, int groupId = 0)
		{
			return null;
		}

		public static bool CheckPickupMission()
		{
			return default(bool);
		}

		public static void UpdateMissionBadge(Badge badge, GameObject pickupBadgeGO)
		{
		}

		public static QuestEntryConditionList GetUserQuestEntryConditionList(int entryConditionId)
		{
			return null;
		}
	}
}
