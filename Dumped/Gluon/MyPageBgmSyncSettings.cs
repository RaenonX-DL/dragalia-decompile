using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class MyPageBgmSyncSettings : MonoBehaviour
	{
		private class LimitedAreaGroup
		{
			public bool startDateSet;

			public bool endDateSet;

			public DateTime startDate;

			public DateTime endDate;

			public int groupId;

			public int sortId;

			public int eventId;

			public int periodType;
		}

		[Serializable]
		public class MapSetting
		{
			public float endTime;

			public MyPageTransitionController.MapGroup mapGroup;

			public MyPageTransitionController.DayTimeType dayTime;

			public MyPageTransitionController.MoveMapType moveMapType;

			public MyPageTransitionController.MoveMapSeasonType moveMapSeasonType;

			public MyPageTransitionController.SkitMapType skitMapType;

			public MyPageTransitionController.SkitMapSeasonType skitMapSeasonType;

			public MyPageTransitionController.FortOptionType fortOptionType;

			public MyPageTransitionController.SeasonFortOptionType seasonFortOptionType;

			public MyPageTransitionController.ForestOptionType forestOptionType;

			public MyPageTransitionController.BuildingType walkingBuilding;

			public int seasonIndex;

			public bool isLimitedAreaOnMaster;

			public int step;

			public int areaId;

			public float initialGroundRotation;

			public float initialCharaRotation;

			public int GetNumOfBuildings()
			{
				return default(int);
			}

			public bool IsRunning()
			{
				return default(bool);
			}
		}

		[Serializable]
		public class Entry
		{
			public bool foldout;

			public int number;

			public MyPageTransitionController.QuestType questType;

			public int questId;

			public string beginDateStr;

			public string endDateStr;

			public string bgmLabel;

			public float rotationSpeedWalking;

			public float rotationSpeedRunning;

			public float motionPlaySpeed;

			public int numOfMapSetting;

			public MapSetting[] mapSettings;

			public MapSetting[] mapSettingsBackup;

			public int currentMapSettingIndex;

			public bool forceEvent;

			public void ResetMapSetting()
			{
			}

			public MapSetting GetCurrentMapSetting()
			{
				return null;
			}

			public MapSetting AdvanceMapSetting()
			{
				return null;
			}

			public MapSetting SetCurrentMapIndex(int index)
			{
				return null;
			}

			public bool ApplyEventSetting(int forceAreaId)
			{
				return default(bool);
			}
		}

		private static List<LimitedAreaGroup> limitedAreaGroupList;

		public MyPageTransitionController.QuestType zeshiaQuestType;

		public int zeshiaQuestId;

		public Entry[] entries;

		public Entry[] entryiesBackup;

		public int numOfEntries;

		public static void PreCalcEventSetting()
		{
		}

		public Entry CalcCurrentEntry(int forceAreaId = 0)
		{
			return null;
		}

		private bool IsEntryWithinValidPeriod(Entry entry)
		{
			return default(bool);
		}
	}
}
