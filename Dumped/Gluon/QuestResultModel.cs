using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class QuestResultModel
	{
		public enum PanelType
		{
			Top,
			FriendApply
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
			public class MissionClearInfo
			{
				public int index;

				public QuestMissionCompleteType type;

				public int num;

				public string comment;

				public bool cleared;

				public bool firstClear;
			}

			public class CharacterInfo
			{
				public int id;

				public int gainExp;

				public int beforeExp;

				public int afterExp;

				public int beforeLevel;

				public int afterLevel;

				public int additionalMaxLevel;

				public int rarity;
			}

			public class RewardItemInfo
			{
				public enum IconColorType
				{
					NormalIcon,
					GoldIcon,
					RedIcon
				}

				public enum PorchRarity
				{
					Normal = 1,
					Rare,
					SuperRare
				}

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

				public RewardItemInfo(GiftType giftType, int id, int quantity)
				{
				}

				public RewardItemInfo(GiftType giftType, int id, int quantity, int place)
				{
				}

				public static RewardItemInfo AstralPiece(int quantity)
				{
					return null;
				}

				public bool IsNewGet(int entity_id, int entity_type)
				{
					return default(bool);
				}

				public static PorchRarity GetPorchRarity(int entity_id, GiftType giftType)
				{
					return default(PorchRarity);
				}

				public static int GetRarity(int entity_id, GiftType giftType)
				{
					return default(int);
				}

				private IconColorType GetIconColorType(int place, PorchRarity porchRarity)
				{
					return default(IconColorType);
				}
			}

			public enum SortGiftType
			{
				EventItem,
				Other,
				Material,
				DragonGift,
				Weapon,
				Amulet,
				AstralItem,
				GatherItem
			}

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

			public int rebornMaxCount => default(int);

			public static void GetEnemyPieceCountStage(int beforeValue, int afterValue, int maxCount, out bool bUpdated, out bool bCompleted)
			{
			}

			public void LoadDataForBattleRoyal()
			{
			}

			public void LoadData()
			{
			}

			private List<RewardItemInfo> SummarizeTreasureItem(List<RewardItemInfo> treasureList)
			{
				return null;
			}

			private void SetUpFisrtFlagDupilicateItem(List<RewardItemInfo> treasureList)
			{
			}

			private void ConvertDuplicateAbilityCrestToDewPoint(List<RewardItemInfo> treasureList)
			{
			}

			private void AddNewMarkAbilityCrest(List<RewardItemInfo> treasureList)
			{
			}

			public static int GetSortGiftType(GiftType giftType)
			{
				return default(int);
			}
		}

		public class FirstClearModel
		{
			public enum RewardOriginType
			{
				None,
				FirstClear,
				MissionClear,
				MissionComplete,
				StoryFirstClear
			}

			public class FirstClearItemInfo
			{
				public GiftType giftType;

				public int id;

				public int level;

				public int quantity;

				public RewardOriginType originType;

				public int limitBreakLevel;
			}

			public List<FirstClearItemInfo> firstClearItemList;

			public List<FirstClearItemInfo> firstClearCharaList;

			public List<FirstClearItemInfo> firstClearDragonList;

			public void LoadData()
			{
			}
		}

		public class BattleRoyalResultModel
		{
			public bool isBattleRoyalMode => default(bool);

			public int rank => default(int);

			public int kill => default(int);

			public int assist => default(int);

			public List<QuestBonus.QuestBonusInfo> GetCycleRewardList(int cycleId, int prevPoint, int currPoint)
			{
				return null;
			}
		}

		public class QuestBonus
		{
			public class QuestBonusInfo
			{
				public GiftType giftType;

				public int id;

				public int quantity;
			}

			public bool isCharangeBonus;

			public QuestResetIntervalType bonusType;

			public List<QuestBonusInfo> questBonusInfoList;

			public float bonusFactor;

			public void LoadDataFromReservedData(int eventId)
			{
			}

			public void LoadData()
			{
			}
		}

		public class PlayerLevelupModel
		{
			public class PlantEnhanceInfo
			{
				public enum PlantEnhanceType
				{
					None = 0,
					NewPlantAvailable = 1,
					PlantNumUp = 2,
					PlantMaxLevelUp = 4,
					PlantNumUpAndMaxLevelUp = 6
				}

				public int plantType;

				public int plantParentType;

				public PlantEnhanceType enhanceType;

				public int beforeNum;

				public int afterNum;

				public int beforeLevel;

				public int afterLevel;
			}

			private class LevelBasedPlantDetailInfo
			{
				public Dictionary<int, int> availableRank;

				public int GetCurrentLevelMaxLevelDetail(int afterPlayerLevel, out int maxLevel)
				{
					return default(int);
				}

				public int GetCurrentLevelMinLevelDetail(int id)
				{
					return default(int);
				}
			}

			public int beforePlayerLevel;

			public int afterPlayerLevel;

			public bool isLevelUp;

			public int beforeFriendCount;

			public int afterFriendCount;

			public int beforeStaminaCount;

			public int afterStaminaCount;

			public List<PlantEnhanceInfo> plantEnhanceList;

			public void LoadData()
			{
			}

			private void LoadPlantEnhance()
			{
			}
		}

		public class FriendApplyModel
		{
			public class SingleFriendApplyInfo
			{
				public CommonFriendListCellData friendCellData;

				public bool bFirstMet;

				public ulong viewerId;
			}

			public const int rebattleCountDown = 10;

			public int friendCount;

			public int friendMaxCount;

			public int firstMetCount;

			public int firstMetStoneCount;

			public bool canRebattle;

			public List<SingleFriendApplyInfo> supportList;

			public void LoadData()
			{
			}

			public static void CreateSupportList(UserSupportList[] helperList, AtgenHelperDetailList[] helperDetailList, ref List<SingleFriendApplyInfo> supportList)
			{
			}
		}

		public class FirstMeetingModel
		{
			public int headCount;

			public int id;

			public GiftType type;

			public int quantity;

			public void Load()
			{
			}
		}

		public class CarryBonus
		{
			public List<QuestBonus.QuestBonusInfo> carryItems;

			public void Load()
			{
			}
		}

		public class DirectOverEntityModel
		{
			public class DirectOverEntity
			{
				public GiftType giftType;

				public int id;

				public int quantity;

				public DirectOverEntity(GiftType giftType, int id, int quantity)
				{
				}
			}

			public List<DirectOverEntity> overDiscardEntityList;

			public List<DirectOverEntity> overPresentEntityList;

			public void Load()
			{
			}

			public void Clear()
			{
			}

			public void Append()
			{
			}
		}

		public class QuestResultDownLoadAssetModel
		{
			public struct QuestResultDownLoadAsset
			{
				public GiftType giftType;

				public int id;

				public QuestResultDownLoadAsset(GiftType giftType, int id)
				{
				}
			}

			public List<QuestResultDownLoadAsset> questResultDownLoadAssetList;

			public void Load()
			{
			}
		}

		public class ScoringEnemyPointListData
		{
			public struct EnemyPointListData
			{
				public int scoringEnemyId;

				public int count;

				public int point;
			}

			public List<EnemyPointListData> scoringEnemyList;

			public bool isScoringEnemyList;

			public void LoadDataForEarn()
			{
			}
		}

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

		public static QuestResultModel Instance => null;

		public static void DeleteInstance()
		{
		}

		private QuestResultModel()
		{
		}

		static QuestResultModel()
		{
		}

		public static bool IsQuestResultDebug()
		{
			return default(bool);
		}

		public void LoadData()
		{
		}

		public bool IsRaidFriendshipMax()
		{
			return default(bool);
		}

		public int GetRandomEventRewardValue(out int bonusValue)
		{
			return default(int);
		}

		public static int GetDropItemCount(GiftType giftType, int id)
		{
			return default(int);
		}

		public int GetOverDiscardCount(GiftType giftType, int id)
		{
			return default(int);
		}

		public int GetOverPresentCount(GiftType giftType, int id)
		{
			return default(int);
		}
	}
}
