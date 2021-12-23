using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class GameDataManager
	{
		public enum InGameDataMode
		{
			Normal,
			Multi,
			Local,
			LocalDebug
		}

		public enum InGamePlayType
		{
			Single = 1,
			Multi
		}

		public enum InGameOddsPlaceType
		{
			Host = 1,
			Guest,
			Fever
		}

		public enum EventBoostEffectType
		{
			None,
			EventBoostDamage
		}

		public class TotalDropInfo
		{
			public int totalMana
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int totalCoin
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int pouchNormal
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int pouchGold
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int weaponNormal
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int weaponGold
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int amuletNormal
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int amuletGold
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void Reset()
			{
			}

			public void Set(int mana, int coin, int pouchNormal, int pouchGold, int weaponNormal, int weaponGold, int amuletNormal, int amuletGold)
			{
			}

			public void CopyTo(TotalDropInfo other)
			{
			}
		}

		public class PlayerRecord
		{
			public string dungeonKey;

			public bool isClear;

			public float clearTime;

			public int reactionObjCount;

			public int downCount;

			public int trapCount;

			public int badStatusCount;

			public int maxComboCount;

			public int dragonTransformCount;

			public int damageCount;

			public int waveCount;

			public int turnCount;

			public int dragonPillarCount;

			public int skillCount;

			public int guardBrokenCount;

			public int breakCount;

			public int giveDamage;

			public int clearState;

			public int visitPrivateHouse;

			public int protectionDamage;

			public int remainingTime;

			public int lowerDrawbridgeCount;

			public int gradePoint;

			public int rebornCount;

			public int rebornProcessCount;

			public long totalPlayDamage;

			public List<int> liveUnitNoList;

			public List<int>[] brokenObjIdList;

			public List<int>[] smashEnemyIdList;

			public Dictionary<int, int>[] smashCountEnemyIdList;

			public List<int>[] noCountEnemyIdList;

			public List<int>[] popupLimitEnemyIdList;

			public int[] totalDamageList;

			public int[] skillDamageList;

			public int[] dotDamageList;

			public int[] criticalDamageList;

			public int[] enchantDamageList;

			public int[] totalDragonDamageList;

			public int[] skillDragonDamageList;

			public int[] dotDragonDamageList;

			public int[] criticalDragonDamageList;

			public int[] enchantDragonDamageList;

			public int battleRoyalRanking;

			public int battleRoyalKillCount;

			public int battleRoyalAssistCount;

			public void Reset(int areaCount)
			{
			}
		}

		public const int prologueBossAreaIndex = 4;

		public const int prologueCheckPointAreaIndex_1 = 1;

		public const int prologueCheckPointAreaIndex_2 = 3;

		public const int prologueCheckPointAreaIndex_3 = 5;

		public const int MaxEventPassiveCount = 15;

		public const long TotalDamageMax = 99999999999999L;

		public const float bonusFactor = 100f;

		public const int maxWeaponPassiveAbilityOneUnitMaxNum = 10;

		public static int questId;

		public static ulong supportUserId;

		public static QuestPrepareData[] clearPartyDatas;

		public static InGameDataMode inGameDataMode;

		private const int MaximumAreaNumber = 6;

		private int currentAreaIdx;

		private GameSettingData gameSetting;

		private GameQuestData gameQuest;

		private GameWallData gameWall;

		private GameBattleRoyalData gameBattleRoyalData;

		private bool IsDmode;

		private DmodeGameDataManager dmodeGameData;

		public static TotalDropInfo totalDrop;

		private static TotalDropInfo savedTotalDrop;

		private EventDataElement activeEventData;

		private List<EventPassiveElement> eventPassiveList;

		private Dictionary<int, OddsData> areaOddsList;

		private const int TotalScoringEnemyPointMax = 999999999;

		private const int TotalScoringEnemySmashMax = 9999;

		private Dictionary<int, int> scoringEnemyPointList;

		private Dictionary<int, int> scoringEnemyParamPointList;

		private int totalScoringPoint;

		private int totalScoringEnemySmash;

		public GameSettingData GameSetting => null;

		public DmodeGameDataManager Dmode => null;

		public PlayerRecord playerRecord
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string DungeonKey => null;

		public int UIRepeatState
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PartyUnitList[][] full_party_unit_lists
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool IsUseInGameApi()
		{
			return default(bool);
		}

		public void Initialize()
		{
		}

		public void InitializeTutorialStep()
		{
		}

		public int GetTutorialStepFromAreaIndex(int targetIdx)
		{
			return default(int);
		}

		public int GetTutorialStepPrologueEnd()
		{
			return default(int);
		}

		public void InitializeBotMultiTutorial()
		{
		}

		public void InitializeGuest()
		{
		}

		public void InitializeBattleRoyal()
		{
		}

		public void InitializeQuestScoringEnemy(int questId)
		{
		}

		private void SaveFullPartyUnitList()
		{
		}

		public void Release()
		{
		}

		public void Clear(bool isRetry)
		{
		}

		public static void ClearTotalDrop(bool isRetry)
		{
		}

		public static void SaveTotalDrop()
		{
		}

		public static void ClearStaticParam(bool isRetry)
		{
		}

		public bool IsPrologue()
		{
			return default(bool);
		}

		public bool IsWallQuest()
		{
			return default(bool);
		}

		public bool IsBattleRoyal()
		{
			return default(bool);
		}

		public bool IsPartySwitch()
		{
			return default(bool);
		}

		public void SetProloguePartyDragon(int level)
		{
		}

		public bool IsTestQuest()
		{
			return default(bool);
		}

		public void SetUIRepeatState(bool flg)
		{
		}

		public bool IsPlayableRepeat()
		{
			return default(bool);
		}

		public bool IsFirstRepeat()
		{
			return default(bool);
		}

		public int GetRepeatCount()
		{
			return default(int);
		}

		public string GetRepeatKey()
		{
			return null;
		}

		public int GetRepeatState()
		{
			return default(int);
		}

		public int GetRequestRepeatState()
		{
			return default(int);
		}

		public int GetWalkerSkill2Level()
		{
			return default(int);
		}

		public int GetPartyCharaNum(InGameDef.SwitchPartyNoList no = InGameDef.SwitchPartyNoList.PartyNo1)
		{
			return default(int);
		}

		public bool IsFirstTimeQuest()
		{
			return default(bool);
		}

		public bool IsClearedFirstChapterFinalQuest()
		{
			return default(bool);
		}

		public bool IsFeverTimeFromServer()
		{
			return default(bool);
		}

		public bool IsUnlimitSystemReborn()
		{
			return default(bool);
		}

		public int GetSystemRebornLimit()
		{
			return default(int);
		}

		public bool IsRemainSystemRebornCount()
		{
			return default(bool);
		}

		public bool IsBotMultiTutorial()
		{
			return default(bool);
		}

		public bool IsReceivableCarryBonus()
		{
			return default(bool);
		}

		public bool IsParamOverwriteQuest()
		{
			return default(bool);
		}

		public bool IsOrderPartyQuest()
		{
			return default(bool);
		}

		public ulong[] GetFirstClearViewerIdList()
		{
			return null;
		}

		private int getSmashEnemyIdx(int areaIdx, int enemyIdx)
		{
			return default(int);
		}

		public bool IsPopupEnemy(int areaIdx, int enemyIdx)
		{
			return default(bool);
		}

		public bool IsChangeEnemy(int areaIdx, int enemyIdx)
		{
			return default(bool);
		}

		public int GetChangeEnemyParamId(int areaIdx, int enemyIdx)
		{
			return default(int);
		}

		public bool IsEnemyOverLimitCoin(int areaIdx, int enemyIdx)
		{
			return default(bool);
		}

		public bool IsEnemyOverLimitMana(int areaIdx, int enemyIdx)
		{
			return default(bool);
		}

		public List<EntityData> GetEnemyDrop(int areaIdx, int enemyIdx)
		{
			return null;
		}

		public bool IsRedPouchDrop(int areaIdx, int enemyIdx, int entityIdx)
		{
			return default(bool);
		}

		public bool IsDropEnemyPiece(int areaIdx, int enemyIdx)
		{
			return default(bool);
		}

		public int GetEnemyMana(int areaIdx, int enemyIdx)
		{
			return default(int);
		}

		public int GetEnemyCoin(int areaIdx, int enemyIdx)
		{
			return default(int);
		}

		public List<EntityData> GetObjDrop(int areaIdx, int objId)
		{
			return null;
		}

		public bool IsRareTreasure(int areaIdx, int objId)
		{
			return default(bool);
		}

		public List<EntityData> GetQuestGradeBonusDrop(int areaIdx, int gradePoint)
		{
			return null;
		}

		public int GetQuestGradeNumber(int areaIdx, int gradePoint)
		{
			return default(int);
		}

		public int GetQuestGradeOfPoint(int areaIdx, int gradePoint)
		{
			return default(int);
		}

		public bool IsExistsOddData(int areaIdx)
		{
			return default(bool);
		}

		public bool IsRegisterTutorialStep()
		{
			return default(bool);
		}

		public bool SetSmashEnemy(int areaIdx, int enemyIdx, bool excludeAddedIdx)
		{
			return default(bool);
		}

		public void SetNoCountEnemy(int areaIdx, int enemyIdx)
		{
		}

		public void SetPopupLimitEnemy(int areaIdx, int enemyIdx)
		{
		}

		public void RemovePopupLimitEnemy(int areaIdx, int enemyIdx)
		{
		}

		public int GetTotalScoringEnemyPoint()
		{
			return default(int);
		}

		public int GetTotalScoringEnemySmash()
		{
			return default(int);
		}

		public void SetSmashScoringEnemy(int enemyParamId)
		{
		}

		public int GetScoringEnemyPoint(int enemyParamId)
		{
			return default(int);
		}

		public void SetBreakObject(int areaIdx, int objId)
		{
		}

		public void TouchReactionObject(int objId)
		{
		}

		public void SetQuestClear()
		{
		}

		public void CountupDownCount()
		{
		}

		public void SetPlayerDead(CharacterSelector selector)
		{
		}

		public void CountupTrapCount()
		{
		}

		public void CountupBadStatus()
		{
		}

		public void CountupDamageCount()
		{
		}

		public void SetMaxComboCount(int combo_count)
		{
		}

		public void CountupDragonTransform()
		{
		}

		public int GetDragonTransformCount()
		{
			return default(int);
		}

		public void SetClearTime(float time)
		{
		}

		public void SetWaveCount(int wave)
		{
		}

		public void SetTurnCount(int turn)
		{
		}

		public void CountupDragonPillarCount()
		{
		}

		public void CountupSkillCount()
		{
		}

		public void CountupGuardBrokenCount()
		{
		}

		public void CountupBreakCount()
		{
		}

		public void SetMaxGiveDamage(int damage)
		{
		}

		public void SetGradePoint(int point)
		{
		}

		public void CountupSystemRebornCount()
		{
		}

		public void AddTotalDamage(int damageVlue)
		{
		}

		public long GetTotalDamage()
		{
			return default(long);
		}

		public void CountupSystemRebornProcessCount()
		{
		}

		public int GetSystemRebornCount()
		{
			return default(int);
		}

		public int GetSystemRebornProcessCount()
		{
			return default(int);
		}

		public void setClearState(int state)
		{
		}

		public void CountupVisitPrivateHouse()
		{
		}

		public void setProtectionDamage(int damage)
		{
		}

		public void setRemainingTime(float time)
		{
		}

		public void CountupLowerDrawbridgeCount()
		{
		}

		public void SetLiveUnitNoList(int unit_no)
		{
		}

		public void SetDamageRecord(int idx, int total, int skill, int dot, int critical, int enchant)
		{
		}

		public void SetDragonDamageRecord(int idx, int total, int skill, int dot, int critical, int enchant)
		{
		}

		public void SetBattleRoyalRecord(int ranking, int killCount, int assistCount)
		{
		}

		public int FindQuestId()
		{
			return default(int);
		}

		public int GetCurrentAreaIdx()
		{
			return default(int);
		}

		public int[] GetTreasureRecordEnemy(int areaIdx)
		{
			return null;
		}

		public int[] GetTreasureRecordEnemySmashCountList(int areaIdx)
		{
			return null;
		}

		public int[] GetTreasureRecordDropObj(int areaIdx)
		{
			return null;
		}

		public void SerializeOddsData()
		{
		}

		public HeroParam CreateHeroParam(GameSettingData.PartyUnit unit)
		{
			return null;
		}

		public HeroParam CreateHeroParam(int idx, InGameDef.SwitchPartyNoList no = InGameDef.SwitchPartyNoList.PartyNo1)
		{
			return null;
		}

		public HeroParam CreateSupporterParam()
		{
			return null;
		}

		public HeroParam CreateGuestParam()
		{
			return null;
		}

		public int[] GetUnionAbilityIds(int[] abilityCrestIds, int[] ability1Levels, int[] ability2Levels)
		{
			return null;
		}

		private EventDataElement GetActiveEventData(int questId)
		{
			return null;
		}

		public bool GetActiveEventCharaAbility(int charaId, ref int eventCharaAbilityId1, ref int eventCharaAbilityId2)
		{
			return default(bool);
		}

		public void ConvertPassiveIdToNumList(ref int[] target)
		{
		}

		public List<GameEventPassive> ConvertEventPassiveList(int[] target)
		{
			return null;
		}

		private void InitEventPassive()
		{
		}

		public int GetQuestId()
		{
			return default(int);
		}

		public string GetDungeonAreaName(int areaIdx)
		{
			return null;
		}

		public string GetDungeonScenePath(int areaIdx)
		{
			return null;
		}

		public int GetDungeonAreaCount()
		{
			return default(int);
		}

		public bool IsMissionClear(int idx)
		{
			return default(bool);
		}

		public bool IsMissionClear()
		{
			return default(bool);
		}

		public int GetQuestWallId()
		{
			return default(int);
		}

		public int GetQuestWallLevel()
		{
			return default(int);
		}

		public void InitializeDummyCommon()
		{
		}

		public void InitializeDummySceneFromAreaData()
		{
		}

		public QuestDataElement GetQuestDataFromAreaData(string areaName, out int hitAreaIndex)
		{
			return null;
		}

		public void InitializeDummyLocal()
		{
		}

		public void InitializeDummy()
		{
		}

		public void SetDummyRandomDungeon(int randomAreaId)
		{
		}

		private void ApplyPartyUnitLimitation()
		{
		}

		private void InitializeLiveUnitNoList()
		{
		}
	}
}
