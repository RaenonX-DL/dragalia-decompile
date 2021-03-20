/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GameDataManager
	{
		// Fields
		public const int prologueBossAreaIndex = 4;
		public const int prologueCheckPointAreaIndex_1 = 1;
		public const int prologueCheckPointAreaIndex_2 = 3;
		public const int prologueCheckPointAreaIndex_3 = 5;
		public const int MaxEventPassiveCount = 15;
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
		public static TotalDropInfo totalDrop;
		private static TotalDropInfo savedTotalDrop;
		private EventDataElement activeEventData;
		private List<EventPassiveElement> eventPassiveList;
		private Dictionary<int, OddsData> areaOddsList;
		[CompilerGenerated]
		private PlayerRecord _playerRecord_k__BackingField;
		[CompilerGenerated]
		private int _UIRepeatState_k__BackingField;
		[CompilerGenerated]
		private PartyUnitList[] _full_party_unit_list_k__BackingField;
	
		// Properties
		public GameSettingData GameSetting { get; }
		public PlayerRecord playerRecord { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string DungeonKey { get; }
		public int UIRepeatState { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PartyUnitList[] full_party_unit_list { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum InGameDataMode
		{
			Normal = 0,
			Multi = 1,
			Local = 2,
			LocalDebug = 3
		}
	
		public enum InGamePlayType
		{
			Single = 1,
			Multi = 2
		}
	
		public enum InGameOddsPlaceType
		{
			Host = 1,
			Guest = 2,
			Fever = 3
		}
	
		public enum EventBoostEffectType
		{
			None = 0,
			EventBoostDamage = 1
		}
	
		public class TotalDropInfo
		{
			// Fields
			[CompilerGenerated]
			private int _totalMana_k__BackingField;
			[CompilerGenerated]
			private int _totalCoin_k__BackingField;
			[CompilerGenerated]
			private int _pouchNormal_k__BackingField;
			[CompilerGenerated]
			private int _pouchGold_k__BackingField;
			[CompilerGenerated]
			private int _weaponNormal_k__BackingField;
			[CompilerGenerated]
			private int _weaponGold_k__BackingField;
			[CompilerGenerated]
			private int _amuletNormal_k__BackingField;
			[CompilerGenerated]
			private int _amuletGold_k__BackingField;
	
			// Properties
			public int totalMana { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int totalCoin { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int pouchNormal { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int pouchGold { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int weaponNormal { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int weaponGold { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int amuletNormal { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int amuletGold { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public TotalDropInfo();
	
			// Methods
			public void Reset();
			public void Set(int mana, int coin, int pouchNormal, int pouchGold, int weaponNormal, int weaponGold, int amuletNormal, int amuletGold);
			public void CopyTo(TotalDropInfo other);
		}
	
		public class PlayerRecord
		{
			// Fields
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
	
			// Constructors
			public PlayerRecord();
	
			// Methods
			public void Reset(int areaCount);
		}
	
		// Constructors
		public GameDataManager();
		static GameDataManager();
	
		// Methods
		public static bool IsUseInGameApi();
		public void Initialize();
		public void InitializeTutorialStep();
		public int GetTutorialStepFromAreaIndex(int targetIdx);
		public int GetTutorialStepPrologueEnd();
		public void InitializeBotMultiTutorial();
		public void InitializeGuest();
		public void InitializeBattleRoyal();
		public void Release();
		public void Clear(bool isRetry);
		public static void ClearTotalDrop(bool isRetry);
		public static void SaveTotalDrop();
		public static void ClearStaticParam(bool isRetry);
		public bool IsPrologue();
		public bool IsWallQuest();
		public bool IsBattleRoyal();
		public void SetProloguePartyDragon(int level);
		public bool IsTestQuest();
		public void SetUIRepeatState(bool flg);
		public bool IsPlayableRepeat();
		public bool IsFirstRepeat();
		public int GetRepeatCount();
		public string GetRepeatKey();
		public int GetRepeatState();
		public int GetRequestRepeatState();
		public int GetWalkerReliabilityLevel();
		public int GetWalkerSkill2Level();
		public int GetPartyCharaNum();
		public bool IsFirstTimeQuest();
		public bool IsClearedFirstChapterFinalQuest();
		public bool IsFeverTimeFromServer();
		public int GetRebornLimit();
		public bool IsBotMultiTutorial();
		public bool IsReceivableCarryBonus();
		public bool IsParamOverwriteQuest();
		public bool IsOrderPartyQuest();
		public ulong[] GetFirstClearViewerIdList();
		private int getSmashEnemyIdx(int areaIdx, int enemyIdx);
		public bool IsPopupEnemy(int areaIdx, int enemyIdx);
		public bool IsChangeEnemy(int areaIdx, int enemyIdx);
		public int GetChangeEnemyParamId(int areaIdx, int enemyIdx);
		public bool IsEnemyOverLimitCoin(int areaIdx, int enemyIdx);
		public bool IsEnemyOverLimitMana(int areaIdx, int enemyIdx);
		public List<EntityData> GetEnemyDrop(int areaIdx, int enemyIdx);
		public bool IsRedPouchDrop(int areaIdx, int enemyIdx, int entityIdx);
		public bool IsDropEnemyPiece(int areaIdx, int enemyIdx);
		public int GetEnemyMana(int areaIdx, int enemyIdx);
		public int GetEnemyCoin(int areaIdx, int enemyIdx);
		public List<EntityData> GetObjDrop(int areaIdx, int objId);
		public bool IsRareTreasure(int areaIdx, int objId);
		public List<EntityData> GetQuestGradeBonusDrop(int areaIdx, int gradePoint);
		public int GetQuestGradeNumber(int areaIdx, int gradePoint);
		public int GetQuestGradeOfPoint(int areaIdx, int gradePoint);
		public bool IsExistsOddData(int areaIdx);
		public bool IsRegisterTutorialStep();
		public bool SetSmashEnemy(int areaIdx, int enemyIdx, bool excludeAddedIdx);
		public void SetNoCountEnemy(int areaIdx, int enemyIdx);
		public void SetPopupLimitEnemy(int areaIdx, int enemyIdx);
		public void SetBreakObject(int areaIdx, int objId);
		public void TouchReactionObject(int objId);
		public void SetQuestClear();
		public void CountupDownCount();
		public void CountupTrapCount();
		public void CountupBadStatus();
		public void CountupDamageCount();
		public void SetMaxComboCount(int combo_count);
		public void CountupDragonTransform();
		public int GetDragonTransformCount();
		public void SetClearTime(float time);
		public void SetWaveCount(int wave);
		public void SetTurnCount(int turn);
		public void CountupDragonPillarCount();
		public void CountupSkillCount();
		public void CountupGuardBrokenCount();
		public void CountupBreakCount();
		public void SetMaxGiveDamage(int damage);
		public void SetGradePoint(int point);
		public void CountupRebornCount();
		public int GetRebornCount();
		public void setClearState(int state);
		public void CountupVisitPrivateHouse();
		public void setProtectionDamage(int damage);
		public void setRemainingTime(float time);
		public void CountupLowerDrawbridgeCount();
		public void SetDamageRecord(int idx, int total, int skill, int dot, int critical, int enchant);
		public void SetDragonDamageRecord(int idx, int total, int skill, int dot, int critical, int enchant);
		public void SetBattleRoyalRecord(int ranking, int killCount, int assistCount);
		public int FindQuestId();
		public int GetCurrentAreaIdx();
		public int[] GetTreasureRecordEnemy(int areaIdx);
		public int[] GetTreasureRecordEnemySmashCountList(int areaIdx);
		public int[] GetTreasureRecordDropObj(int areaIdx);
		public void SerializeOddsData();
		public HeroParam CreateHeroParam(GameSettingData.PartyUnit unit);
		public HeroParam CreateHeroParam(int idx);
		public HeroParam CreateSupporterParam();
		public HeroParam CreateGuestParam();
		public int[] GetUnionAbilityIds(int[] abilityCrestIds);
		private EventDataElement GetActiveEventData(int questId);
		public bool GetActiveEventCharaAbility(int charaId, ref int eventCharaAbilityId1, ref int eventCharaAbilityId2);
		public void ConvertPassiveIdToNumList(ref int[] target);
		public List<GameEventPassive> ConvertEventPassiveList(int[] target);
		private void InitEventPassive();
		public int GetQuestId();
		public string GetDungeonAreaName(int areaIdx);
		public string GetDungeonScenePath(int areaIdx);
		public int GetDungeonAreaCount();
		public bool IsMissionClear(int idx);
		public bool IsMissionClear();
		public int GetQuestWallId();
		public int GetQuestWallLevel();
		public void InitializeDummyCommon();
		public void InitializeDummySceneFromAreaData();
		public QuestDataElement GetQuestDataFromAreaData(string areaName, out int hitAreaIndex);
		public void InitializeDummyLocal();
		public void InitializeDummy();
		public void SetDummyRandomDungeon(int randomAreaId);
		private void ApplyPartyUnitLimitation();
	}
}
