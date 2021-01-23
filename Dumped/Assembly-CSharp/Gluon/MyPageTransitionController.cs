/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageTransitionController
	{
		// Fields
		public const int moveMapCountOfDayTime = 3;
		public const int moveMapCountOfLevel = 12;
		public const int moveMapCountOfDaytime = 4;
		public const int moveMapCountOfFort = 36;
		public const int moveMapCountOfForest = 12;
		public const int moveMapCountOfFortAndForest = 48;
		public const int moveMapMaxFortLevel = 3;
		[CompilerGenerated]
		private MyPageScene _scene_k__BackingField;
		[CompilerGenerated]
		private MapGroup _currentMapGroup_k__BackingField;
		[CompilerGenerated]
		private MoveMapType _currentMoveMapType_k__BackingField;
		[CompilerGenerated]
		private MoveMapSeasonType _currentMoveMapSeasonType_k__BackingField;
		[CompilerGenerated]
		private int _moveMapSeasonIndex_k__BackingField;
		[CompilerGenerated]
		private SkitMapType _currentSkitMapType_k__BackingField;
		[CompilerGenerated]
		private int _skitMapSeasonIndex_k__BackingField;
		[CompilerGenerated]
		private DayTimeType _currentDayTimeType_k__BackingField;
		[CompilerGenerated]
		private FortOptionType _currentFortOptionType_k__BackingField;
		[CompilerGenerated]
		private ForestOptionType _currentForestOptionType_k__BackingField;
		[CompilerGenerated]
		private BuildingType _currentBuildingType_k__BackingField;
		[CompilerGenerated]
		private bool _isRunningMoveMap_k__BackingField;
		[CompilerGenerated]
		private bool _isFortAvailable_k__BackingField;
		[CompilerGenerated]
		private int _fortLevel_k__BackingField;
	
		// Properties
		public MyPageScene scene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public MapGroup currentMapGroup { [CompilerGenerated] get; [CompilerGenerated] set; }
		public MoveMapType currentMoveMapType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public MoveMapSeasonType currentMoveMapSeasonType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int moveMapSeasonIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SkitMapType currentSkitMapType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SkitMapSeasonType currentSkitMapSeasonType { get; set; }
		public int skitMapSeasonIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public DayTimeType currentDayTimeType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FortOptionType currentFortOptionType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ForestOptionType currentForestOptionType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public BuildingType currentBuildingType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isRunningMoveMap { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFortAvailable { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int fortLevel { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum MapGroup
		{
			MoveMap = 0,
			SkitMap = 1
		}
	
		public enum DayTimeType
		{
			Noon = 0,
			Evening = 1,
			Night = 2
		}
	
		public enum MoveMapType
		{
			Fort = 0,
			Forest = 1,
			SeasonFort = 2,
			SeasonForest = 3
		}
	
		public enum MoveMapSeasonType
		{
			Halloween = 0,
			Winter = 1,
			Xmas = 2,
			Sakura = 3,
			Beach = 4,
			Anniversary1st = 5
		}
	
		public enum SkitMapType
		{
			Camp = 0,
			Tavern = 1,
			Shop = 2,
			Inn = 3,
			Throne = 4,
			Treasure = 5,
			MountainFire = 6,
			MountainWind = 7,
			MountainLight = 8,
			MountainDark = 9,
			MountainWater = 10,
			SeasonSkit = 11
		}
	
		public enum SkitMapSeasonType
		{
			Sakura = 0,
			Beach = 1,
			Halloween = 2,
			HalloweenTavern = 3,
			HalloweenShop = 4,
			HalloweenInn = 5,
			WinterInn = 6,
			XmasThrone = 7,
			XmasTavern = 8,
			XmasShop = 9,
			XmasInn = 10,
			NewYear = 11,
			ChineseNewYear = 12,
			Anniversary1st = 13,
			Anniversary2nd = 14,
			Hunter = 15
		}
	
		public enum FortOptionType
		{
			StoneBridge = 0,
			Gate = 1,
			Building = 2,
			Run = 3
		}
	
		public enum SeasonFortOptionType
		{
			Work = 0,
			Run = 1
		}
	
		public enum ForestOptionType
		{
			WoodBridge = 0,
			Run = 1
		}
	
		public enum BuildingType
		{
			None = 0,
			Tavern = 1,
			Shop = 2,
			Inn = 3
		}
	
		public enum QuestType
		{
			Quest = 0,
			Story = 1
		}
	
		// Constructors
		public MyPageTransitionController();
	
		// Methods
		public void SetDataFromBgmSyncSetting(MyPageBgmSyncSettings.MapSetting mapSetting);
		public void SetDataFromBgmSyncSettingMoveMap(MyPageBgmSyncSettings.MapSetting mapSetting);
		public void SetDataFromBgmSyncSettingSkitMap(MyPageBgmSyncSettings.MapSetting mapSetting);
		public void ReloadFortLevel();
		public int GetMoveMapGroundIndex();
		public void SetMoveMapByIndex(int index, int buildingIndex);
		private void SetMoveMapFortByIndex(int index);
		private void SetMoveMapForestByIndex(int index);
		private void SetMoveMapSeasonByIndex(int index);
		public bool HasWindmill();
		public string GetBgSceneName(MapGroup mapGroup);
		public int GetMoveMapBgIndex();
		public int GetMoveMapBuildingIndex();
		public int GetSkitMapIndex();
		public void SetSkitMapByIndex(int index);
	}
}
