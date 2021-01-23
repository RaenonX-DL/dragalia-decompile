/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonModel : SummonModelBase
	{
		// Fields
		private static SummonModel instance;
		private SummonTopItemData _itemData;
		public const string summonPrefabCommonPath = "Prefabs/OutGame/SummonShop/";
		public SummonTopData topData;
		public SummonTopItemData.ButtonType drawingSummonButtonType;
		public SummonType drawingSummonType;
		public int drawingSummonId;
		public int drawingSummonGroupId;
		public int useMultiSingleTicketCount;
		public int summonPoint;
		public static bool isInStage;
		public int currentStagePlayingIndex;
		public Rarity overallMaxRarity;
		public SummonTopItemView.SummonTopItemTabType lastSelectedSummonType;
		public static bool isExchangeSummonPointLoginCheck;
		public StageEffectType stageEffectType;
		public StagePredictionEffectType predictionEffectType;
		public int upgradeIndex;
	
		// Properties
		public static SummonModel Instance { get; }
		public SummonTopItemData itemData { get; }
		public override int singlePrice { get; }
		public override int multiPrice { get; }
	
		// Nested types
		public enum StageEffectType
		{
			None = -1,
			R = 0,
			SR = 1,
			SSR = 2,
			SSSR = 3
		}
	
		public enum StagePredictionEffectType
		{
			None = 0,
			Pigeon = 1,
			TriPigeon = 2,
			Fafnir = 3,
			GemLight = 4
		}
	
		public class Util
		{
			// Fields
			private const string imagesAtlasAssetsAssetTemplate = "Images/OutGame/Summon/Top/{0:D6}/Images";
			private const string localizedAtlasAssetsAssetTemplate = "Images/OutGame/Summon/Top/{0:D6}/Localized";
			public const string startDashAtlasPath = "Images/OutGame/Summon/Top/StartDash/Atlas";
			public const string imagesAtlasPattern = "^(Images/OutGame/Summon/Top/[0-9]*/Images)";
			public const string localizedAtlasPattern = "^(Images/OutGame/Summon/Top/[0-9]*/Localized)";
			public const string illustrationImageNameTemplate = "Summon_Character_Illust_{0:D2}";
			public const string coverBGImageName = "Summon_Top_BG";
			public const string coverUnitImageName = "Summon_Top_Character";
			public const string coverCardImageName = "Summon_Top_Card";
			public const string topBannerImageName = "Summon_Top_Banner";
			public const string topLogoImageName = "Summon_Top_logo";
			public const string commentImageNameTemplate = "Summon_Character_Comment_{0:D2}";
			public const string skillImageNameTemplate = "Summon_Character_Skill_{0:D2}";
			public const string bottomInfoImageNameTemplate = "Summon_Character_Info_{0:D2}";
			public const string csBannerName = "Summon_Switch_Banner";
	
			// Constructors
			public Util();
	
			// Methods
			public static void GetImageAtlasAssetsPath(int summonId, out string assetPath);
			public static void GetLocalizedAtlasAssetsPath(int summonId, out string assetPath);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public int summonGroupId;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal SummonTopItemData _GetAnyTopItemDataBySummonGroupId_b__0(List<SummonTopItemData> itemDataList);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public int summonId;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal SummonTopItemData _GetTopItemDataBySummonId_b__0(List<SummonTopItemData> itemDataList);
		}
	
		// Constructors
		private SummonModel();
		static SummonModel();
	
		// Methods
		public static void DeleteInstance();
		public void ClearItemData();
		public override bool CanReSummon();
		public void RecordDrawingSummonInfo(SummonTopItemData.ButtonType buttonType, int summonId);
		public override int GetTicketCount(bool multi);
		public override bool IsSingle();
		public static string GetSingleTicketName();
		public static string GetMultiTicketName();
		public static string GetStartDashTicketName(SummonType type);
		public static int GetTicketOwnedCount(SummonType type);
		public static SummonList GetSummonDataManagerItemBySummonId(int summonId);
		public static bool IsCsSummon(int summonId);
		public static bool IsFreeSummonPeriod(int summonId);
		private static bool IsFreeSummonRestCount(AtgenUserSummonList summonList);
		private static bool IsBeginnerFreeSummonRestCount(AtgenUserSummonList summonList);
		private static SummonList[] GameDataToArray(DataManager.GameData<SummonList> gameDataList);
		public SummonTopItemData GetAnyTopItemDataBySummonGroupId(int summonGroupId);
		public int GetAnyDrawnPlatinumSummonId();
		public SummonTopItemData GetTopItemDataBySummonId(int summonId = -1);
		public bool CheckDrawingSufficiency(int summonId, SummonTopItemData.ButtonType buttonType, bool checkForPaidStone);
		public int[] GetSummonIdListFromSummonGroup(int summonGroupId);
		public static bool IsLimitSummonCount(SummonDataElement summon);
		public static int GetCsSummonComplateTime(int summonId);
		public static int GetSummonPoint(int summonId);
		public static int GetSummonExchangePoint(int summonId);
		public static string GetSummonExchangeItemAname();
		public static string GetSummonExchangeItemBname();
	}
}
