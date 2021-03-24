/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageBgmSyncSettings : MonoBehaviour
	{
		// Fields
		private static List<LimitedAreaGroup> limitedAreaGroupList;
		public MyPageTransitionController.QuestType zeshiaQuestType;
		public int zeshiaQuestId;
		public Entry[] entries;
		public Entry[] entryiesBackup;
		public int numOfEntries;
	
		// Nested types
		private class LimitedAreaGroup
		{
			// Fields
			public bool startDateSet;
			public bool endDateSet;
			public DateTime startDate;
			public DateTime endDate;
			public int groupId;
			public int sortId;
			public int eventId;
			public int periodType;
	
			// Constructors
			public LimitedAreaGroup();
		}
	
		[Serializable]
		public class MapSetting
		{
			// Fields
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
	
			// Constructors
			public MapSetting();
	
			// Methods
			public int GetNumOfBuildings();
			public bool IsRunning();
		}
	
		[Serializable]
		public class Entry
		{
			// Fields
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
	
			// Constructors
			public Entry();
	
			// Methods
			public void ResetMapSetting();
			public MapSetting GetCurrentMapSetting();
			public MapSetting AdvanceMapSetting();
			public MapSetting SetCurrentMapIndex(int index);
			public bool ApplyEventSetting(int forceAreaId);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<LimitedAreaGroup> __9__9_0;
			public static Comparison<Entry> __9__10_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _PreCalcEventSetting_b__9_0(LimitedAreaGroup a, LimitedAreaGroup b);
			internal int _CalcCurrentEntry_b__10_0(Entry a, Entry b);
		}
	
		// Constructors
		public MyPageBgmSyncSettings();
		static MyPageBgmSyncSettings();
	
		// Methods
		public static void PreCalcEventSetting();
		public Entry CalcCurrentEntry(int forceAreaId = 0);
		private bool IsEntryWithinValidPeriod(Entry entry);
	}
}
