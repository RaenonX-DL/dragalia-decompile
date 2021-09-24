/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultModel
	{
		// Fields
		private static QuestResultModel instance;
		public const string prefabPath = "Prefabs/OutGame/QuestResult/";
		public const string prefabPopupPath = "Popup/";
		public const string topPagePrefabPath = "Prefabs/OutGame/QuestResult/QuestResultTopPage";
		public const string newEnrollmentPagePagePrefabPath = "Prefabs/OutGame/QuestResult/Popup/QuestResultNewEnrollmentPopup";
		public const string questSkipTicketClearFlashPopupPrefabPath = "Prefabs/OutGame/QuestResult/Popup/QuestSkipTicketClearFlashPopup";
		public const string rankingPrefabPath = "Prefabs/OutGame/QuestResult/QuestResultRanking";
		public const string levelUpFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_quest_result_lvup";
		public const string rewardOpenFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_icon_flash";
		public const string rareGlowFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_icon_glow";
		public const string convertToDewFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_QuestResultEldwaterDropEffect";
		public const string gaugeBurstFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_quest_result_gauge_burst";
		public const string charaLvUpFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_quest_result_charaexp_lvup";
		public const string emblemFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_quest_result_emblem";
		public const string rewardAchievementFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_rewardAchievement";
		public const string medalFlowFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_medal_flow";
		public const string gaugeEffectFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_gauge_effect";
		public const string glitterBurstFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_glitter_burst";
		public const string noteReactionFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_note_reaction";
		public const string raidFriendlyMaxFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_raid_friendly_max";
		public const string newEnrollment = "Prefabs/OutGame/QuestResult/pf_newCharacterEnrollment";
		public const string newEnrollmentRarity2 = "Prefabs/OutGame/QuestResult/pf_newDragonEnrollment_rarity2";
		public const string newEnrollmentRarity3 = "Prefabs/OutGame/QuestResult/pf_newDragonEnrollment_rarity3";
		public const string newEnrollmentRarity4 = "Prefabs/OutGame/QuestResult/pf_newDragonEnrollment_rarity4";
		public const string newEnrollmentRarity5 = "Prefabs/OutGame/QuestResult/pf_newDragonEnrollment_rarity5";
		public const string newEnrollmentAbilityCrest1 = "Prefabs/OutGame/QuestResult/pf_newAbilityCrestEnrollment1";
		public const string headerCharacter = "Prefabs/OutGame/QuestResult/pf_quest_result_header_charactor";
		public const string buildEventCellCheckerFlashPath = "Prefabs/OutGame/QuestResult/pf_facility_event_result_check";
		public const string emotionNoteFlashPrefabPath = "Prefabs/OutGame/Story/Emotion/pf_03";
		public const string bonusFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_bonus_effect";
		public const string tapToNextFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_tap_to_next";
		public const string rankingClearTimeFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_number_clear_time";
		public const string rankingRankFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_number_ranking";
		public const string rankingSuperiorRankFlashPrefabPath = "Prefabs/OutGame/QuestResult/pf_number_ranking_superior";
		public const string battleRoyalRankFlashPrefabPath = "Prefabs/OutGame/EventQuest/BattleRoyal/pf_BattleRoyalRankNumber";
		public const int reBattleCount = 40;
		public TopPageModel topModel;
		public FirstClearModel firstClearModel;
		public PlayerLevelupModel playerLevelUpModel;
		public FriendApplyModel friendApplyModel;
		public List<MatchingService.Player> matchingPlayerModel;
		public FirstMeetingModel firstMeetingModel;
		public DirectOverEntityModel directOverEntityModel;
		public QuestResultDownLoadAssetModel assetDownloadModel;
		public QuestBonus questBonusModel;
		public TimeAttackRanking timeAttackRankingData;
		public TotalDamageEventRankingData totalDamageEventRankingData;
		public CarryBonus carryBonus;
		public ScoringEnemyPointListData scoringEnemyPointListData;
		public bool rebattleCanFlag;
		public static bool isSkipTicketClearContinuous;
		public static bool isSkipTicketClear;
		public BattleRoyalResultModel battleRoyalResultModel;
	
		// Properties
		public static QuestResultModel Instance { get; }
	
		// Nested types
		public enum PanelType
		{
			Top = 0,
			FriendApply = 1
		}
	
		public enum RewardItemPlaceType
		{
			Normal = 0,
			Host = 1,
			Guest = 2,
			FeverTimeDrop = 3,
			Bonus = 9
		}
	
		public class TopPageModel
		{
			// Fields
			public const int questMissionMaxCount = 3;
			public const int questCharacterMaxCount = 4;
			public const int enemyPieceUpdateStage1 = 30;
			public const int enemyPieceUpdateStage2 = 60;
			public const int rareEnemyPieceUpdateStage1 = 1;
			public const int rareEnemyPieceUpdateStage2 = 2;
			public const int enemyPieceCompleteCount = 100;
			public const int rareEnemyPieceCompleteCount = 3;
			public CharaFriendshipList charaFriendship;
			private int _rebornMaxCount;
			public int rebornRemainCount;
			public int questId;
			public string questSectionName;
			public string questName;
			public QuestSelectScene.Difficulty questDifficulty;
			public bool isGroupSkip;
			public MissionClearInfo[] missionClearInfoList;
			public int gainPlayerExp;
			public int gainCharacterExp;
			public int beforePlayerExp;
			public int afterPlayerExp;
			public CharacterInfo[] characterList;
			public CharacterInfo[] characterList2;
			public int gainMana;
			public int gainGold;
			public Dictionary<float, List<RewardItemInfo>> treasureItemTable;
			public List<RewardItemInfo> treasureItemList;
			public List<RewardItemInfo> rebornRewardList;
			public List<RewardItemInfo> randomDungenMedalList;
			public List<RewardItemInfo> hostRewardList;
			public int play_type;
			public int playerLevelUpFStone;
			private static readonly float treasureTableDefaultFactorKey;
			public bool isManaUp;
			public float manaUpRate;
			public bool isRupiUp;
			public float rupiUpRate;
			public bool isItemDropUp;
			public float itemDropUpRate;
			public QuestPrepareData[] questPrepareData;
	
			// Properties
			public int rebornMaxCount { get; }
	
			// Nested types
			public class MissionClearInfo
			{
				// Fields
				public int index;
				public QuestMissionCompleteType type;
				public int num;
				public string comment;
				public bool cleared;
				public bool firstClear;
	
				// Constructors
				public MissionClearInfo();
			}
	
			public class CharacterInfo
			{
				// Fields
				public int id;
				public int gainExp;
				public int beforeExp;
				public int afterExp;
				public int beforeLevel;
				public int afterLevel;
				public int additionalMaxLevel;
				public int rarity;
	
				// Constructors
				public CharacterInfo();
			}
	
			public class RewardItemInfo
			{
				// Fields
				public GiftType giftType;
				public int id;
				public int quantity;
				public int place;
				public bool isEnemyPiece;
				public int maxQuantity;
				public bool showUpdate;
				public bool showComplete;
				public int beforeQuantity;
				public int afterQuantity;
				public bool isFirst;
				public PorchRarity porchRarity;
				public int rarity;
				public IconColorType iconColorType;
				public bool excludeFromRateUpList;
				public GiftType convertedEntityType;
				public int convertedEntityId;
				public int convertedEntityQuantity;
	
				// Nested types
				public enum IconColorType
				{
					NormalIcon = 0,
					GoldIcon = 1,
					RedIcon = 2
				}
	
				public enum PorchRarity
				{
					Normal = 1,
					Rare = 2,
					SuperRare = 3
				}
	
				// Constructors
				public RewardItemInfo(GiftType giftType, int id, int quantity);
				public RewardItemInfo(GiftType giftType, int id, int quantity, int place);
	
				// Methods
				public static RewardItemInfo AstralPiece(int quantity);
				public bool IsNewGet(int entity_id, int entity_type);
				public static PorchRarity GetPorchRarity(int entity_id, GiftType giftType);
				public static int GetRarity(int entity_id, GiftType giftType);
				private IconColorType GetIconColorType(int place, PorchRarity porchRarity);
			}
	
			public enum SortGiftType
			{
				EventItem = 0,
				Other = 1,
				Material = 2,
				DragonGift = 3,
				Weapon = 4,
				Amulet = 5,
				AstralItem = 6,
				GatherItem = 7
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Func<RewardItemInfo, bool> __9__47_0;
				public static Func<RewardItemInfo, int> __9__47_1;
				public static Func<RewardItemInfo, RewardItemInfo.PorchRarity> __9__47_2;
				public static Func<RewardItemInfo, int> __9__47_3;
				public static Func<RewardItemInfo, int> __9__47_4;
				public static Func<RewardItemInfo, bool> __9__47_5;
				public static Func<RewardItemInfo, bool> __9__47_12;
				public static Func<RewardItemInfo, int> __9__47_13;
				public static Func<RewardItemInfo, RewardItemInfo.PorchRarity> __9__47_14;
				public static Func<RewardItemInfo, int> __9__47_15;
				public static Func<RewardItemInfo, int> __9__47_16;
				public static Func<RewardItemInfo, bool> __9__47_17;
				public static Func<RewardItemInfo, bool> __9__47_6;
				public static Func<RewardItemInfo, int> __9__47_7;
				public static Func<RewardItemInfo, RewardItemInfo.PorchRarity> __9__47_8;
				public static Func<RewardItemInfo, int> __9__47_9;
				public static Func<RewardItemInfo, int> __9__47_10;
				public static Func<RewardItemInfo, bool> __9__47_11;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _LoadData_b__47_0(RewardItemInfo rec);
				internal int _LoadData_b__47_1(RewardItemInfo rec);
				internal RewardItemInfo.PorchRarity _LoadData_b__47_2(RewardItemInfo rect);
				internal int _LoadData_b__47_3(RewardItemInfo rec);
				internal int _LoadData_b__47_4(RewardItemInfo rec);
				internal bool _LoadData_b__47_5(RewardItemInfo rec);
				internal bool _LoadData_b__47_12(RewardItemInfo rec);
				internal int _LoadData_b__47_13(RewardItemInfo rec);
				internal RewardItemInfo.PorchRarity _LoadData_b__47_14(RewardItemInfo rect);
				internal int _LoadData_b__47_15(RewardItemInfo rec);
				internal int _LoadData_b__47_16(RewardItemInfo rec);
				internal bool _LoadData_b__47_17(RewardItemInfo rec);
				internal bool _LoadData_b__47_6(RewardItemInfo rec);
				internal int _LoadData_b__47_7(RewardItemInfo rec);
				internal RewardItemInfo.PorchRarity _LoadData_b__47_8(RewardItemInfo rect);
				internal int _LoadData_b__47_9(RewardItemInfo rec);
				internal int _LoadData_b__47_10(RewardItemInfo rec);
				internal bool _LoadData_b__47_11(RewardItemInfo rec);
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass50_0
			{
				// Fields
				public ConvertedEntityList convertedEntity;
	
				// Constructors
				public __c__DisplayClass50_0();
	
				// Methods
				internal bool _ConvertDuplicateAbilityCrestToDewPoint_b__0(RewardItemInfo item);
			}
	
			// Constructors
			public TopPageModel();
			static TopPageModel();
	
			// Methods
			public static void GetEnemyPieceCountStage(int beforeValue, int afterValue, int maxCount, out bool bUpdated, out bool bCompleted);
			public void LoadDataForBattleRoyal();
			public void LoadData();
			private List<RewardItemInfo> SummarizeTreasureItem(List<RewardItemInfo> treasureList);
			private void SetUpFisrtFlagDupilicateItem(List<RewardItemInfo> treasureList);
			private void ConvertDuplicateAbilityCrestToDewPoint(List<RewardItemInfo> treasureList);
			private void AddNewMarkAbilityCrest(List<RewardItemInfo> treasureList);
			public static int GetSortGiftType(GiftType giftType);
		}
	
		public class FirstClearModel
		{
			// Fields
			public List<FirstClearItemInfo> firstClearItemList;
			public List<FirstClearItemInfo> firstClearCharaList;
			public List<FirstClearItemInfo> firstClearDragonList;
	
			// Nested types
			public enum RewardOriginType
			{
				None = 0,
				FirstClear = 1,
				MissionClear = 2,
				MissionComplete = 3,
				StoryFirstClear = 4
			}
	
			public class FirstClearItemInfo
			{
				// Fields
				public GiftType giftType;
				public int id;
				public int level;
				public int quantity;
				public RewardOriginType originType;
				public int limitBreakLevel;
	
				// Constructors
				public FirstClearItemInfo();
			}
	
			// Constructors
			public FirstClearModel();
	
			// Methods
			public void LoadData();
		}
	
		public class BattleRoyalResultModel
		{
			// Properties
			public bool isBattleRoyalMode { get; }
			public int rank { get; }
			public int kill { get; }
			public int assist { get; }
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass8_0
			{
				// Fields
				public int cycleId;
				public int prevPoint;
				public int currPoint;
	
				// Constructors
				public __c__DisplayClass8_0();
	
				// Methods
				internal bool _GetCycleRewardList_b__0(EventCyclePointRewardElement x);
				internal bool _GetCycleRewardList_b__2(EventCyclePointRewardElement x);
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Func<EventCyclePointRewardElement, int> __9__8_1;
				public static Func<EventCyclePointRewardElement, QuestBonus.QuestBonusInfo> __9__8_3;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal int _GetCycleRewardList_b__8_1(EventCyclePointRewardElement x);
				internal QuestBonus.QuestBonusInfo _GetCycleRewardList_b__8_3(EventCyclePointRewardElement x);
			}
	
			// Constructors
			public BattleRoyalResultModel();
	
			// Methods
			public List<QuestBonus.QuestBonusInfo> GetCycleRewardList(int cycleId, int prevPoint, int currPoint);
		}
	
		public class QuestBonus
		{
			// Fields
			public bool isCharangeBonus;
			public QuestResetIntervalType bonusType;
			public List<QuestBonusInfo> questBonusInfoList;
			public float bonusFactor;
	
			// Nested types
			public class QuestBonusInfo
			{
				// Fields
				public GiftType giftType;
				public int id;
				public int quantity;
	
				// Constructors
				public QuestBonusInfo();
			}
	
			// Constructors
			public QuestBonus();
	
			// Methods
			public void LoadDataFromReservedData(int eventId);
			public void LoadData();
		}
	
		public class PlayerLevelupModel
		{
			// Fields
			public int beforePlayerLevel;
			public int afterPlayerLevel;
			public bool isLevelUp;
			public int beforeFriendCount;
			public int afterFriendCount;
			public int beforeStaminaCount;
			public int afterStaminaCount;
			public List<PlantEnhanceInfo> plantEnhanceList;
	
			// Nested types
			public class PlantEnhanceInfo
			{
				// Fields
				public int plantType;
				public int plantParentType;
				public PlantEnhanceType enhanceType;
				public int beforeNum;
				public int afterNum;
				public int beforeLevel;
				public int afterLevel;
	
				// Nested types
				public enum PlantEnhanceType
				{
					None = 0,
					NewPlantAvailable = 1,
					PlantNumUp = 2,
					PlantMaxLevelUp = 4,
					PlantNumUpAndMaxLevelUp = 6
				}
	
				// Constructors
				public PlantEnhanceInfo();
			}
	
			private class LevelBasedPlantDetailInfo
			{
				// Fields
				public Dictionary<int, int> availableRank;
	
				// Constructors
				public LevelBasedPlantDetailInfo();
	
				// Methods
				public int GetCurrentLevelMaxLevelDetail(int afterPlayerLevel, out int maxLevel);
				public int GetCurrentLevelMinLevelDetail(int id);
			}
	
			// Constructors
			public PlayerLevelupModel();
	
			// Methods
			public void LoadData();
			private void LoadPlantEnhance();
		}
	
		public class FriendApplyModel
		{
			// Fields
			public const int rebattleCountDown = 10;
			public int friendCount;
			public int friendMaxCount;
			public int firstMetCount;
			public int firstMetStoneCount;
			public bool canRebattle;
			public List<SingleFriendApplyInfo> supportList;
	
			// Nested types
			public class SingleFriendApplyInfo
			{
				// Fields
				public CommonFriendListCellData friendCellData;
				public bool bFirstMet;
				public ulong viewerId;
	
				// Constructors
				public SingleFriendApplyInfo();
			}
	
			// Constructors
			public FriendApplyModel();
	
			// Methods
			public void LoadData();
			public static void CreateSupportList(UserSupportList[] helperList, AtgenHelperDetailList[] helperDetailList, ref List<SingleFriendApplyInfo> supportList);
		}
	
		public class FirstMeetingModel
		{
			// Fields
			public int headCount;
			public int id;
			public GiftType type;
			public int quantity;
	
			// Constructors
			public FirstMeetingModel();
	
			// Methods
			public void Load();
		}
	
		public class CarryBonus
		{
			// Fields
			public List<QuestBonus.QuestBonusInfo> carryItems;
	
			// Constructors
			public CarryBonus();
	
			// Methods
			public void Load();
		}
	
		public class DirectOverEntityModel
		{
			// Fields
			public List<DirectOverEntity> overDiscardEntityList;
			public List<DirectOverEntity> overPresentEntityList;
	
			// Nested types
			public class DirectOverEntity
			{
				// Fields
				public GiftType giftType;
				public int id;
				public int quantity;
	
				// Constructors
				public DirectOverEntity(GiftType giftType, int id, int quantity);
			}
	
			// Constructors
			public DirectOverEntityModel();
	
			// Methods
			public void Load();
			public void Clear();
			public void Append();
		}
	
		public class QuestResultDownLoadAssetModel
		{
			// Fields
			public List<QuestResultDownLoadAsset> questResultDownLoadAssetList;
	
			// Nested types
			public struct QuestResultDownLoadAsset
			{
				// Fields
				public GiftType giftType;
				public int id;
	
				// Constructors
				public QuestResultDownLoadAsset(GiftType giftType, int id);
			}
	
			// Constructors
			public QuestResultDownLoadAssetModel();
	
			// Methods
			public void Load();
		}
	
		public class ScoringEnemyPointListData
		{
			// Fields
			public List<EnemyPointListData> scoringEnemyList;
			public bool isScoringEnemyList;
	
			// Nested types
			public struct EnemyPointListData
			{
				// Fields
				public int scoringEnemyId;
				public int count;
				public int point;
			}
	
			// Constructors
			public ScoringEnemyPointListData();
	
			// Methods
			public void LoadDataForEarn();
		}
	
		// Constructors
		private QuestResultModel();
		static QuestResultModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsQuestResultDebug();
		public void LoadData();
		public bool IsRaidFriendshipMax();
		public int GetRandomEventRewardValue(out int bonusValue);
		public static int GetDropItemCount(GiftType giftType, int id);
		public int GetOverDiscardCount(GiftType giftType, int id);
		public int GetOverPresentCount(GiftType giftType, int id);
	}
}
