using System.Runtime.CompilerServices;

namespace Gluon
{
	public class MyPageTransitionController
	{
		public enum MapGroup
		{
			MoveMap,
			SkitMap
		}

		public enum DayTimeType
		{
			Noon,
			Evening,
			Night
		}

		public enum MoveMapType
		{
			Fort,
			Forest,
			SeasonFort,
			SeasonForest
		}

		public enum MoveMapSeasonType
		{
			Halloween,
			Winter,
			Xmas,
			Sakura,
			Beach,
			Anniversary1st
		}

		public enum SkitMapType
		{
			Camp,
			Tavern,
			Shop,
			Inn,
			Throne,
			Treasure,
			MountainFire,
			MountainWind,
			MountainLight,
			MountainDark,
			MountainWater,
			SeasonSkit
		}

		public enum SkitMapSeasonType
		{
			Sakura,
			Beach,
			Halloween,
			HalloweenTavern,
			HalloweenShop,
			HalloweenInn,
			WinterInn,
			XmasThrone,
			XmasTavern,
			XmasShop,
			XmasInn,
			NewYear,
			ChineseNewYear,
			Anniversary1st,
			Anniversary2nd,
			Anniversary3rd,
			Hunter
		}

		public enum FortOptionType
		{
			StoneBridge,
			Gate,
			Building,
			Run
		}

		public enum SeasonFortOptionType
		{
			Work,
			Run
		}

		public enum ForestOptionType
		{
			WoodBridge,
			Run
		}

		public enum BuildingType
		{
			None,
			Tavern,
			Shop,
			Inn
		}

		public enum QuestType
		{
			Quest,
			Story
		}

		public const int moveMapCountOfDayTime = 3;

		public const int moveMapCountOfLevel = 12;

		public const int moveMapCountOfDaytime = 4;

		public const int moveMapCountOfFort = 36;

		public const int moveMapCountOfForest = 12;

		public const int moveMapCountOfFortAndForest = 48;

		public const int moveMapMaxFortLevel = 3;

		public MyPageScene scene
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MapGroup currentMapGroup
		{
			[CompilerGenerated]
			get
			{
				return default(MapGroup);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MoveMapType currentMoveMapType
		{
			[CompilerGenerated]
			get
			{
				return default(MoveMapType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MoveMapSeasonType currentMoveMapSeasonType
		{
			[CompilerGenerated]
			get
			{
				return default(MoveMapSeasonType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int moveMapSeasonIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SkitMapType currentSkitMapType
		{
			[CompilerGenerated]
			get
			{
				return default(SkitMapType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SkitMapSeasonType currentSkitMapSeasonType
		{
			get
			{
				return default(SkitMapSeasonType);
			}
			set
			{
			}
		}

		public int skitMapSeasonIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DayTimeType currentDayTimeType
		{
			[CompilerGenerated]
			get
			{
				return default(DayTimeType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FortOptionType currentFortOptionType
		{
			[CompilerGenerated]
			get
			{
				return default(FortOptionType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ForestOptionType currentForestOptionType
		{
			[CompilerGenerated]
			get
			{
				return default(ForestOptionType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BuildingType currentBuildingType
		{
			[CompilerGenerated]
			get
			{
				return default(BuildingType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isRunningMoveMap
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isFortAvailable
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int fortLevel
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetDataFromBgmSyncSetting(MyPageBgmSyncSettings.MapSetting mapSetting)
		{
		}

		public void SetDataFromBgmSyncSettingMoveMap(MyPageBgmSyncSettings.MapSetting mapSetting)
		{
		}

		public void SetDataFromBgmSyncSettingSkitMap(MyPageBgmSyncSettings.MapSetting mapSetting)
		{
		}

		public void ReloadFortLevel()
		{
		}

		public int GetMoveMapGroundIndex()
		{
			return default(int);
		}

		public void SetMoveMapByIndex(int index, int buildingIndex)
		{
		}

		private void SetMoveMapFortByIndex(int index)
		{
		}

		private void SetMoveMapForestByIndex(int index)
		{
		}

		private void SetMoveMapSeasonByIndex(int index)
		{
		}

		public bool HasWindmill()
		{
			return default(bool);
		}

		public string GetBgSceneName(MapGroup mapGroup)
		{
			return null;
		}

		public int GetMoveMapBgIndex()
		{
			return default(int);
		}

		public int GetMoveMapBuildingIndex()
		{
			return default(int);
		}

		public int GetSkitMapIndex()
		{
			return default(int);
		}

		public void SetSkitMapByIndex(int index)
		{
		}
	}
}
