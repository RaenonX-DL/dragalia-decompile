/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gluon.Http;
using NPF.NPFWrapper;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DataManager
	{
		// Fields
		public BasicInfo basicInfo;
		private static DataManager instance;
		public List<QuestScheduleDataWrapper> questScheduleDataWrapperList;
		public GameData<BuildList> buildList;
		public GameData<CharaList> charaList;
		public GameData<DragonList> dragonList;
		public GameData<AmuletList> amuletList;
		public GameData<WeaponSkinList> weaponSkinList;
		public GameData<WeaponBodyList> weaponBodyList;
		public GameData<WeaponPassiveAbilityList> weaponPassiveAbilityList;
		public GameData<AbilityCrestList> abilityCrestList;
		public GameData<AbilityCrestSetList> abilityCrestSetList;
		public GameData<CharaUnitSetList> charaUnitSetList;
		public GameData<DragonGiftList> dragonGiftList;
		public GameData<DragonReliabilityList> dragonReliabilityList;
		public GameData<AtgenShopGiftList> shopGiftList;
		public GameData<EmblemList> emblemList;
		public GameData<EquipStampList> equipStampList;
		public DiamondData diamondData;
		public PartyPowerData partyPowerData;
		public GameData<AtgenExchangeSummomPointList> exchangeSummomPointList;
		public GameData<TreasureTradeList> treasureTradeList;
		public GameData<TreasureTradeList> treasureTradeAllList;
		public GameData<UserTreasureTradeList> userTreasureTradeList;
		public GameData<EventTradeList> eventTradeList;
		public UserEventItemData userEventItemData;
		public GameData<AtgenUserEventTradeList> userEventTradeList;
		public GameData<AmuletTradeList> amuletTradeList;
		public GameData<UserAmuletTradeList> userAmuletTradeList;
		public GameData<AbilityCrestTradeList> abilityCrestTradeList;
		public GameData<UserAbilityCrestTradeList> userAbilityCrestTradeList;
		public FortBonusList fortBonusList;
		public FortDetail fortDetail;
		public GameData<FortPlantList> fortPlantList;
		public GameData<CraftList> craftList;
		public GameData<UnitStoryList> unitStoryList;
		public GameData<QuestStoryList> questStoryList;
		public GameData<CastleStoryList> castleStoryList;
		public GameData<EventStoryList> eventStoryList;
		public GameData<AtgenAddCoinList> addCoinList;
		public GameData<AtgenHarvestBuildList> harvestBuildList;
		public GameData<AtgenAddStaminaList> addStaminaList;
		public AtgenProductionRp productionDf;
		public AtgenProductionRp productionRp;
		public AtgenProductionRp productionSt;
		public GameData<AtgenAddHarvestList> addHarvestList;
		public GameData<AtgenUserSummonList> userSummonList;
		public OddsRateList oddsRateList;
		public GameData<SummonList> campaignSummonList;
		public AtgenCsSummonList csSummonList;
		public GameData<SummonList> startDashSummonList;
		public GameData<SummonList> summonList;
		public GameData<SummonList> platinumSummonList;
		public GameData<SummonList> charaSsrSummonList;
		public GameData<SummonList> dragonSsrSummonList;
		public GameData<AtgenResultPrizeList> resultPrizeList;
		public SummonPrizeOddsRateList summonPrizeOddsRateList;
		public GameData<SummonHistoryList> summonHistoryList;
		public GameData<SummonPointList> summonPointList;
		public GameData<AtgenSummonPointTradeList> summonPointTradeList;
		public RedoableSummonOddsRateList redoableSummonOddsRateList;
		public UserRedoableSummonData userRedoableSummonData;
		public GameData<AtgenBuildEventRewardEntityList> exchangeEntityList;
		public GameData<AtgenResultUnitList> resultUnitList;
		public AtgenBuildEventRewardEntityList tradeData;
		public GameData<ItemList> itemList;
		public GameData<MaterialList> materialList;
		public GameData<AstralItemList> astralItemList;
		public GameData<GatherItemList> gatherItemList;
		public GameData<MuseumList> museumList;
		public GameData<MuseumDragonList> museumDragonList;
		public GameData<EnemyBookList> enemyBookList;
		public GameData<AlbumWeaponList> albumWeaponList;
		public GameData<PartyList> partyList;
		public GameData<QuestList> questList;
		public GameData<QuestEventList> questEventList;
		public AtgenQuestDropInfo questDropInfo;
		public GameData<QuestTreasureList> questTreasureList;
		public GameData<QuestEventScheduleList> questEventScheduleList;
		public GameData<QuestScheduleDetailList> questScheduleDetailList;
		public GameData<AtgenBuildEventRewardEntityList> questTreasureRewardList;
		public GameData<AtgenLostUnitList> lostUnitList;
		public GameData<QuestCarryList> questCarryList;
		public GameData<QuestEntryConditionList> questEntryConditionList;
		public ulong[] deletePresentIdList;
		public ulong[] notReceivePresentIdList;
		public ulong[] receivePresentIdList;
		public ulong[] limitOverPresentIdList;
		public GameData<PresentHistoryList> presentHistoryList;
		public GameData<PresentDetailList> presentLimitList;
		public GameData<PresentDetailList> presentList;
		public GameData<RewardReliabilityList> rewardReliabilityList;
		public GameData<DragonRewardEntityList> returnGiftList;
		public GameData<AtgenDragonGiftRewardList> dragonGiftRewardList;
		public GameData<RoomList> roomList;
		public GameData<StampList> stampList;
		public GameData<SummonTicketList> summonTicketList;
		public GameData<RoomList> eventRoomList;
		public GameData<RoomList> eventFriendRoomList;
		public GameData<RoomList> friendRoomList;
		public AtgenRecoverData recoverData;
		public GameData<AtgenLoginBonusList> loginBonusList;
		public GameData<LotteryTicketList> lotteryTicketList;
		public GameData<AtgenLotteryResultList> lotteryResultList;
		public LotteryOddsRateList lotteryOddsRateList;
		public IngameData ingameData;
		public OddsInfo oddsInfo;
		public IngameResultData ingameResultData;
		public PartyInfo partyInfo;
		public RewardRecord rewardRecord;
		public IngameQuestData ingameQuestData;
		public AtgenBattleRoyalData battleRoyalData;
		public BattleRoyalResult battleRoyalResult;
		public BattleRoyalCycleUserRecord battleRoyalCycleUserRecord;
		public GameData<EventCycleRewardList> eventCycleRewardList;
		public GameData<AtgenBuildEventRewardEntityList> eventCycleRewardEntityList;
		public GameData<AtgenBattleRoyalHistoryList> battleRoyalHistoryList;
		public AtgenReceiveQuestBonus receiveQuestBonus;
		public RepeatData repeatData;
		public IngameWallData ingameWallData;
		public AtgenWallUnitInfo wallUnitInfo;
		public AtgenPlayWallDetail playWallDetail;
		[CompilerGenerated]
		private int _clearTime_k__BackingField;
		public GameData<AtgenDuplicateEntityList> duplicateEntityList;
		public GameData<AtgenQuestStoryRewardList> questStoryRewardList;
		public GameData<AtgenBuildEventRewardEntityList> unitStoryRewardList;
		public GameData<AtgenBuildEventRewardEntityList> castleStoryRewardList;
		public AtgenSupportReward supportReward;
		public GameData<UserSupportList> searchList;
		public GameData<UserSupportList> supportUserList;
		public GameData<UserSupportList> friendApply;
		public GameData<UserSupportList> friendList;
		public GameData<UserSupportList> userList;
		public GameData<UserSupportList> requestList;
		public GameData<AtgenSupportUserDetailList> supportUserDetailList;
		public SettingSupport settingSupport;
		public GameData<AtgenHelperDetailList> failHelperDetailList;
		public GameData<UserSupportList> failHelperList;
		public AtgenFailQuestDetail failQuestDetail;
		public GameData<QuestWallList> questWallList;
		public GameData<AtgenBuildEventRewardEntityList> wallClearRewardList;
		public AtgenWallDropReward wallDropReward;
		public GameData<PartySettingList> wallClearPartySettingList;
		public GameData<AtgenBuildEventRewardEntityList> wallMonthlyRewardList;
		public GameData<AtgenUserWallRewardList> userWallRewardList;
		public GameData<AtgenMonthlyWallReceiveList> monthlyWallReceiveList;
		public AtgenUserItemSummon userItemSummon;
		public GameData<AtgenItemSummonRateList> itemSummonRateList;
		public GameData<AtgenBuildEventRewardEntityList> itemSummonRewardList;
		public GameData<ShopPurchaseList> materialShopPurchase;
		public GameData<ShopPurchaseList> normalShopPurchase;
		public GameData<AtgenQuestBonus> questBonus;
		public GameData<ShopPurchaseList> specialShopPurchase;
		public GameData<AtgenStaminaBonus> staminaBonus;
		public GameData<AtgenStoneBonus> stoneBonus;
		public GameData<ProductList> productList;
		public GameData<AtgenBuildEventRewardEntityList> stoneBonusEntityList;
		public GameData<AtgenProductLockList> productLockList;
		public GameData<AtgenDuplicateEntityList> dreamSelectUnitList;
		public GuildData guildData;
		public UserGuildData userGuildData;
		public GameData<GuildMemberList> guildMemberList;
		public GameData<GuildChatMessageList> guildChatMessageList;
		public GameData<AtgenBuildEventRewardEntityList> attendBonusList;
		public GameData<GuildData> searchGuildList;
		public GameData<GuildData> autoSearchGuildList;
		public GameData<GuildApplyList> guildApplyList;
		public GameData<GuildInviteReceiveList> guildInviteReceiveList;
		public GameData<GuildInviteSendList> guildInviteSendList;
		public GameData<AtgenAlbumQuestPlayRecordList> albumQuestPlayRecordList;
		public GameData<AlbumDragonData> albumDragonList;
		public AlbumPassiveNotice albumPassiveUpdateResult;
		public GameData<DailyMissionList> dailyMissionList;
		public GameData<NormalMissionList> normalMissionList;
		public GameData<PeriodMissionList> periodMissionList;
		public GameData<BeginnerMissionList> beginnerMissionList;
		public GameData<SpecialMissionList> specialMissionList;
		public GameData<MainStoryMissionList> mainStoryMissionList;
		public GameData<MemoryEventMissionList> memoryEventMissionList;
		public GameData<DrillMissionList> drillMissionList;
		public GameData<AlbumMissionList> albumMissionList;
		public GameData<AtgenNotReceivedMissionIdListWithDayNo> notReceivedMissionIdListWithDayNo;
		public CurrentMainStoryMission currentMainStoryMission;
		public GameData<ConvertedEntityList> convertedEntityList;
		public GameData<AtgenBuildEventRewardEntityList> mainStoryMissionUnlockBonusList;
		public GameData<DrillMissionGroupList> drillMissionGroupList;
		public GameData<AtgenBuildEventRewardEntityList> drillMissionGroupCompleteRewardList;
		public GameData<PartySettingList> questClearPartySettingList;
		public GameData<PartySettingList> questMultiClearPartySettingList;
		public UserSupportList searchUser;
		public AtgenSupportUserDataDetail supportUserDataDetail;
		public AtgenBoxSummonData boxSummonData;
		public AtgenBoxSummonResult boxSummonResult;
		public PresentNotice presentNotice;
		public FriendNotice friendNotice;
		public MissionNotice missionNotice;
		public GuildNotice guildNotice;
		public ShopNotice shopNotice;
		public AlbumPassiveNotice albumPassiveNotice;
		public AtgenPenaltyData penaltyData;
		public OptionData optionData;
		public GameData<EventPassiveList> eventPassiveList;
		public GameData<AtgenBuildEventRewardEntityList> eventStoryRewardList;
		public RaidEventUserList raidEventUserData;
		public GameData<RaidEventRewardList> raidEventRewardList;
		public GameData<CharaFriendshipList> charaFriendshipList;
		public GameData<BuildEventRewardList> mazeEventRewardList;
		public GameData<AtgenBuildEventRewardEntityList> mazeEventRewardEntityList;
		public MazeEventUserList mazeEventUserData;
		public BuildEventUserList buildEventUserData;
		public GameData<BuildEventRewardList> buildEventRewardList;
		public GameData<AtgenBuildEventRewardEntityList> buildEventRewardEntityList;
		public GameData<AtgenBuildEventRewardEntityList> eventDailyBonusList;
		public AtgenEventFortData eventFortData;
		public CollectEventUserList collectEventUserData;
		public GameData<AtgenBuildEventRewardEntityList> clb01EventRewardEntityList;
		public GameData<BuildEventRewardList> clb01EventRewardList;
		public Clb01EventUserList clb01EventUserData;
		public GameData<Clb01EventUserList> clb01EventUserList;
		public ExRushEventUserList exRushEventUserData;
		public SimpleEventUserList simpleEventUserData;
		public GameData<BuildEventRewardList> exHunterEventRewardList;
		public ExHunterEventUserList exHunterEventUserData;
		public CombatEventUserList combatEventUserData;
		public GameData<BuildEventRewardList> eventRewardList;
		public GameData<AtgenBuildEventRewardEntityList> eventRewardEntityList;
		public GameData<AtgenBuildEventRewardEntityList> eventLocationRewardEntityList;
		public GameData<UserEventLocationRewardList> userEventLocationRewardList;
		public GameData<BattleRoyalEventItemList> battleRoyalEventItemList;
		public BattleRoyalEventUserRecord battleRoyalEventUserRecord;
		public GameData<BattleRoyalCharaSkinList> battleRoyalCharaSkinList;
		public TimeAttackRankingData timeAttackRankingData;
		public GameData<RankingTierRewardList> rankingTierRewardList;
		public GameData<AtgenBuildEventRewardEntityList> rankingTierRewardEntityList;
		public AtgenMultiServer multiServer;
		public AtgenLatest latest;
		public AtgenTransitionResultData transitionResultData;
		public GameData<AchievementList> achievementList;
		public AtgenVersionHash versionHash;
		public GameData<AtgenVersionHash> versionHashList;
		public RoomList roomData;
		public GameData<AtgenWebviewUrlList> webviewUrlList;
		public GameData<AtgenCommentList> commentList;
		public GameData<AtgenOpinionTypeList> opinionTypeList;
		public GameData<AtgenOpinionList> opinionList;
		public GameData<AtgenCategoryList> categoryList;
		public GameData<AtgenInquiryFaqList> inquiryFaqList;
		public GameData<AtgenBuildEventRewardEntityList> overDiscardEntityList;
		public GameData<AtgenBuildEventRewardEntityList> overPresentEntityList;
		public GameData<AtgenDuplicateEntityList> newGetEntityList;
		public GameData<FunctionalMaintenanceList> functionalMaintenanceList;
		public AtgenWalkerData walkerData;
		public GDUserData userData;
		public GameData<WeaponList> weaponList;
		public LastStatus lastStatus;
	
		// Properties
		public int clearTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private string UuidKey { get; }
		private string ViewerIdKey { get; }
		public static DataManager Instance { get; }
		private string UuidPath { get; }
		public int allDragonDiamond { get; }
	
		// Nested types
		public class BasicInfo
		{
			// Fields
			public string uuid;
			public ulong viewer_id;
			public string session_id;
			public string resource_version;
			private string separated_viewer_id_str;
	
			// Constructors
			public BasicInfo();
	
			// Methods
			public string GetSeparatedViewerIdString();
		}
	
		public class GameData<T>
			where T : class
		{
			// Fields
			private Func<T, ulong> getId;
			[CompilerGenerated]
			private T[] _Array_k__BackingField;
			private Dictionary<ulong, int> idToIndex;
	
			// Properties
			private T[] Array { [CompilerGenerated] get; [CompilerGenerated] set; }
			public T this[int i] { get => default; private set {} }
			public int Length { get; }
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass1_0
			{
				// Fields
				public Func<T, int> func;
	
				// Constructors
				public __c__DisplayClass1_0();
	
				// Methods
				internal ulong _.ctor_b__0(T arg);
			}
	
			// Constructors
			public GameData(Func<T, int> func);
			public GameData(Func<T, ulong> func);
	
			// Methods
			public T GetById(ulong id);
			public T GetById(int id);
			private void SetById(ulong id, T value);
			public bool SetById(T value);
			public void Import(T[] array);
			public void Append(List<T> newList);
			public ulong GetId(int index);
			public void Clear();
		}
	
		public class GDUserData : UserData
		{
			// Fields
			public int max_chara_num;
			public int is_shop_notification;
			public int is_view_start_dash;
			public int is_view_dream_select;
			public int achievement_cnt;
			public int present_cnt;
			public int friend_apply;
			public int friend_count;
			public int stamina_multi_user_max;
			public int stamina_multi_system_max;
			public int quest_skip_point_system_max;
			public int before_exchange_summon_item_quantity;
			public ulong build_id;
			public int build_start_date;
			public int build_end_date;
			public int levelup_start_date;
			public int levelup_end_date;
			public int remain_time;
			public int is_over_coin;
			public int is_over_material;
			public int current_fort_level;
			public int current_fort_craft_level;
			public int main_fort_level;
			public int main_fort_craft_level;
			public int contact_count;
			public int max_contact;
			public int remain_contact_heal_time;
			public int remain_contact_max_heal_time;
			public int is_favorite;
			public int dragon_contact_free_gift_count;
			public int daily_limit;
			public int result_summon_point;
			public int presage_effect_id;
			public int reversal_effect_index;
			public int[] presage_effect_list;
			public int add_max_dragon_quantity;
			public int add_max_weapon_quantity;
			public int add_max_amulet_quantity;
			public int quest_bonus_stack_base_time;
			public int is_purchase;
			public int is_quest_bonus;
			public int is_stamina_bonus;
			public int is_stone_bonus;
			public int is_update_guild_position_type;
			public int guild_invite_receive_count;
			public int result_state;
			public int before_free_stone;
			public int before_paid_stone;
			public bool is_first_time;
			public bool is_irrelevant;
			public string transaction_id;
			public int server_time;
			public ulong disconnected_viewer_id;
			public ulong registered_viewer_id;
			public int maintenance_start_time;
			public int maintenance_end_time;
			public string maintenance_text;
			public string room_name;
			public int target_quest_id;
			public int is_receivable_event_daily_bonus;
			public int speedrun_ranking_count;
			public ulong[] new_apply_viewer_id_list;
			public ulong[] new_friend_viewer_id_list;
			public int[] not_received_mission_id_list;
			public int[] need_entry_event_id_list;
			public int[] special_mission_purchased_group_id_list;
			public string cluster_name;
			public int is_friend;
			public string nonce;
			public bool is_required_agree;
			public int agreement_status;
			public int infancy_paid_diamond_limit;
			public string opinion_id;
			public int created_at;
			public int occurred_at;
			public string opinion_text;
			public int opinion_type;
			public int polling_interval;
			public int spec_upgrade_time;
			public int current_server_time;
	
			// Properties
			public int max_party_power { get; set; }
			public int paid_diamond { get; set; }
			public int free_diamond { get; set; }
			public int fort_level { get; }
			public int fort_craft_level { get; }
	
			// Constructors
			public GDUserData();
	
			// Methods
			public void Import(UserData data);
		}
	
		public class LastStatus
		{
			// Fields
			public int result;
			public int success_type;
			public int skill_levelup;
			public int servertime;
	
			// Constructors
			public LastStatus();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BuildList, ulong> __9__271_0;
			public static Func<CharaList, int> __9__271_1;
			public static Func<DragonList, ulong> __9__271_2;
			public static Func<AmuletList, ulong> __9__271_3;
			public static Func<WeaponSkinList, int> __9__271_4;
			public static Func<WeaponBodyList, int> __9__271_5;
			public static Func<WeaponPassiveAbilityList, int> __9__271_6;
			public static Func<AbilityCrestList, int> __9__271_7;
			public static Func<AbilityCrestSetList, int> __9__271_8;
			public static Func<CharaUnitSetList, int> __9__271_9;
			public static Func<DragonGiftList, int> __9__271_10;
			public static Func<DragonReliabilityList, int> __9__271_11;
			public static Func<AtgenShopGiftList, int> __9__271_12;
			public static Func<EmblemList, int> __9__271_13;
			public static Func<EquipStampList, int> __9__271_14;
			public static Func<AtgenExchangeSummomPointList, int> __9__271_15;
			public static Func<TreasureTradeList, int> __9__271_16;
			public static Func<TreasureTradeList, int> __9__271_17;
			public static Func<UserTreasureTradeList, int> __9__271_18;
			public static Func<EventTradeList, int> __9__271_19;
			public static Func<AtgenUserEventTradeList, int> __9__271_20;
			public static Func<AmuletTradeList, int> __9__271_21;
			public static Func<UserAmuletTradeList, int> __9__271_22;
			public static Func<AbilityCrestTradeList, int> __9__271_23;
			public static Func<UserAbilityCrestTradeList, int> __9__271_24;
			public static Func<FortPlantList, int> __9__271_25;
			public static Func<CraftList, int> __9__271_26;
			public static Func<UnitStoryList, int> __9__271_27;
			public static Func<QuestStoryList, int> __9__271_28;
			public static Func<CastleStoryList, int> __9__271_29;
			public static Func<EventStoryList, int> __9__271_30;
			public static Func<AtgenAddCoinList, ulong> __9__271_31;
			public static Func<AtgenHarvestBuildList, ulong> __9__271_32;
			public static Func<AtgenAddStaminaList, ulong> __9__271_33;
			public static Func<AtgenAddHarvestList, int> __9__271_34;
			public static Func<AtgenUserSummonList, int> __9__271_35;
			public static Func<SummonList, int> __9__271_36;
			public static Func<SummonList, int> __9__271_37;
			public static Func<SummonList, int> __9__271_38;
			public static Func<SummonList, int> __9__271_39;
			public static Func<SummonList, int> __9__271_40;
			public static Func<SummonList, int> __9__271_41;
			public static Func<AtgenResultPrizeList, int> __9__271_42;
			public static Func<SummonHistoryList, int> __9__271_43;
			public static Func<SummonPointList, int> __9__271_44;
			public static Func<AtgenSummonPointTradeList, int> __9__271_45;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_46;
			public static Func<AtgenResultUnitList, int> __9__271_47;
			public static Func<ItemList, int> __9__271_48;
			public static Func<MaterialList, int> __9__271_49;
			public static Func<AstralItemList, int> __9__271_50;
			public static Func<GatherItemList, int> __9__271_51;
			public static Func<MuseumList, int> __9__271_52;
			public static Func<MuseumDragonList, int> __9__271_53;
			public static Func<EnemyBookList, int> __9__271_54;
			public static Func<AlbumWeaponList, int> __9__271_55;
			public static Func<PartyList, int> __9__271_56;
			public static Func<QuestList, int> __9__271_57;
			public static Func<QuestEventList, int> __9__271_58;
			public static Func<QuestTreasureList, int> __9__271_59;
			public static Func<QuestEventScheduleList, int> __9__271_60;
			public static Func<QuestScheduleDetailList, int> __9__271_61;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_62;
			public static Func<AtgenLostUnitList, int> __9__271_63;
			public static Func<QuestCarryList, int> __9__271_64;
			public static Func<QuestEntryConditionList, int> __9__271_65;
			public static Func<PresentHistoryList, ulong> __9__271_66;
			public static Func<PresentDetailList, ulong> __9__271_67;
			public static Func<PresentDetailList, ulong> __9__271_68;
			public static Func<RewardReliabilityList, int> __9__271_69;
			public static Func<DragonRewardEntityList, int> __9__271_70;
			public static Func<AtgenDragonGiftRewardList, int> __9__271_71;
			public static Func<RoomList, int> __9__271_72;
			public static Func<StampList, int> __9__271_73;
			public static Func<SummonTicketList, ulong> __9__271_74;
			public static Func<RoomList, int> __9__271_75;
			public static Func<RoomList, int> __9__271_76;
			public static Func<RoomList, int> __9__271_77;
			public static Func<AtgenLoginBonusList, int> __9__271_78;
			public static Func<LotteryTicketList, int> __9__271_79;
			public static Func<AtgenLotteryResultList, int> __9__271_80;
			public static Func<EventCycleRewardList, int> __9__271_81;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_82;
			public static Func<AtgenBattleRoyalHistoryList, int> __9__271_83;
			public static Func<AtgenDuplicateEntityList, int> __9__271_84;
			public static Func<AtgenQuestStoryRewardList, int> __9__271_85;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_86;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_87;
			public static Func<UserSupportList, ulong> __9__271_88;
			public static Func<UserSupportList, ulong> __9__271_89;
			public static Func<UserSupportList, ulong> __9__271_90;
			public static Func<UserSupportList, ulong> __9__271_91;
			public static Func<UserSupportList, ulong> __9__271_92;
			public static Func<UserSupportList, ulong> __9__271_93;
			public static Func<AtgenSupportUserDetailList, ulong> __9__271_94;
			public static Func<AtgenHelperDetailList, ulong> __9__271_95;
			public static Func<UserSupportList, ulong> __9__271_96;
			public static Func<QuestWallList, int> __9__271_97;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_98;
			public static Func<PartySettingList, int> __9__271_99;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_100;
			public static Func<AtgenUserWallRewardList, int> __9__271_101;
			public static Func<AtgenMonthlyWallReceiveList, int> __9__271_102;
			public static Func<AtgenItemSummonRateList, int> __9__271_103;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_104;
			public static Func<ShopPurchaseList, int> __9__271_105;
			public static Func<ShopPurchaseList, int> __9__271_106;
			public static Func<AtgenQuestBonus, int> __9__271_107;
			public static Func<ShopPurchaseList, int> __9__271_108;
			public static Func<AtgenStaminaBonus, int> __9__271_109;
			public static Func<AtgenStoneBonus, int> __9__271_110;
			public static Func<ProductList, int> __9__271_111;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_112;
			public static Func<AtgenProductLockList, int> __9__271_113;
			public static Func<AtgenDuplicateEntityList, int> __9__271_114;
			public static Func<GuildMemberList, ulong> __9__271_115;
			public static Func<GuildChatMessageList, ulong> __9__271_116;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_117;
			public static Func<GuildData, int> __9__271_118;
			public static Func<GuildData, int> __9__271_119;
			public static Func<GuildApplyList, ulong> __9__271_120;
			public static Func<GuildInviteReceiveList, ulong> __9__271_121;
			public static Func<GuildInviteSendList, ulong> __9__271_122;
			public static Func<AtgenAlbumQuestPlayRecordList, int> __9__271_123;
			public static Func<AlbumDragonData, int> __9__271_124;
			public static Func<DailyMissionList, int> __9__271_125;
			public static Func<NormalMissionList, int> __9__271_126;
			public static Func<PeriodMissionList, int> __9__271_127;
			public static Func<BeginnerMissionList, int> __9__271_128;
			public static Func<SpecialMissionList, int> __9__271_129;
			public static Func<MainStoryMissionList, int> __9__271_130;
			public static Func<MemoryEventMissionList, int> __9__271_131;
			public static Func<DrillMissionList, int> __9__271_132;
			public static Func<AlbumMissionList, int> __9__271_133;
			public static Func<AtgenNotReceivedMissionIdListWithDayNo, int> __9__271_134;
			public static Func<ConvertedEntityList, int> __9__271_135;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_136;
			public static Func<DrillMissionGroupList, int> __9__271_137;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_138;
			public static Func<PartySettingList, int> __9__271_139;
			public static Func<PartySettingList, int> __9__271_140;
			public static Func<EventPassiveList, int> __9__271_141;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_142;
			public static Func<RaidEventRewardList, int> __9__271_143;
			public static Func<CharaFriendshipList, int> __9__271_144;
			public static Func<BuildEventRewardList, int> __9__271_145;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_146;
			public static Func<BuildEventRewardList, int> __9__271_147;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_148;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_149;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_150;
			public static Func<BuildEventRewardList, int> __9__271_151;
			public static Func<Clb01EventUserList, int> __9__271_152;
			public static Func<BuildEventRewardList, int> __9__271_153;
			public static Func<BuildEventRewardList, int> __9__271_154;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_155;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_156;
			public static Func<UserEventLocationRewardList, int> __9__271_157;
			public static Func<BattleRoyalEventItemList, int> __9__271_158;
			public static Func<BattleRoyalCharaSkinList, int> __9__271_159;
			public static Func<RankingTierRewardList, int> __9__271_160;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_161;
			public static Func<AchievementList, int> __9__271_162;
			public static Func<AtgenVersionHash, int> __9__271_163;
			public static Func<AtgenWebviewUrlList, int> __9__271_164;
			public static Func<AtgenCommentList, int> __9__271_165;
			public static Func<AtgenOpinionTypeList, int> __9__271_166;
			public static Func<AtgenOpinionList, int> __9__271_167;
			public static Func<AtgenCategoryList, int> __9__271_168;
			public static Func<AtgenInquiryFaqList, int> __9__271_169;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_170;
			public static Func<AtgenBuildEventRewardEntityList, int> __9__271_171;
			public static Func<AtgenDuplicateEntityList, int> __9__271_172;
			public static Func<FunctionalMaintenanceList, int> __9__271_173;
			public static Func<WeaponList, ulong> __9__271_174;
			public static Func<AtgenDeleteDragonList, ulong> __9__278_0;
			public static Func<AtgenDeleteWeaponList, ulong> __9__278_1;
			public static Func<AtgenDeleteAmuletList, ulong> __9__278_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal ulong _.ctor_b__271_0(BuildList e);
			internal int _.ctor_b__271_1(CharaList e);
			internal ulong _.ctor_b__271_2(DragonList e);
			internal ulong _.ctor_b__271_3(AmuletList e);
			internal int _.ctor_b__271_4(WeaponSkinList e);
			internal int _.ctor_b__271_5(WeaponBodyList e);
			internal int _.ctor_b__271_6(WeaponPassiveAbilityList e);
			internal int _.ctor_b__271_7(AbilityCrestList e);
			internal int _.ctor_b__271_8(AbilityCrestSetList e);
			internal int _.ctor_b__271_9(CharaUnitSetList e);
			internal int _.ctor_b__271_10(DragonGiftList e);
			internal int _.ctor_b__271_11(DragonReliabilityList e);
			internal int _.ctor_b__271_12(AtgenShopGiftList e);
			internal int _.ctor_b__271_13(EmblemList e);
			internal int _.ctor_b__271_14(EquipStampList e);
			internal int _.ctor_b__271_15(AtgenExchangeSummomPointList e);
			internal int _.ctor_b__271_16(TreasureTradeList e);
			internal int _.ctor_b__271_17(TreasureTradeList e);
			internal int _.ctor_b__271_18(UserTreasureTradeList e);
			internal int _.ctor_b__271_19(EventTradeList e);
			internal int _.ctor_b__271_20(AtgenUserEventTradeList e);
			internal int _.ctor_b__271_21(AmuletTradeList e);
			internal int _.ctor_b__271_22(UserAmuletTradeList e);
			internal int _.ctor_b__271_23(AbilityCrestTradeList e);
			internal int _.ctor_b__271_24(UserAbilityCrestTradeList e);
			internal int _.ctor_b__271_25(FortPlantList e);
			internal int _.ctor_b__271_26(CraftList e);
			internal int _.ctor_b__271_27(UnitStoryList e);
			internal int _.ctor_b__271_28(QuestStoryList e);
			internal int _.ctor_b__271_29(CastleStoryList e);
			internal int _.ctor_b__271_30(EventStoryList e);
			internal ulong _.ctor_b__271_31(AtgenAddCoinList e);
			internal ulong _.ctor_b__271_32(AtgenHarvestBuildList e);
			internal ulong _.ctor_b__271_33(AtgenAddStaminaList e);
			internal int _.ctor_b__271_34(AtgenAddHarvestList e);
			internal int _.ctor_b__271_35(AtgenUserSummonList e);
			internal int _.ctor_b__271_36(SummonList e);
			internal int _.ctor_b__271_37(SummonList e);
			internal int _.ctor_b__271_38(SummonList e);
			internal int _.ctor_b__271_39(SummonList e);
			internal int _.ctor_b__271_40(SummonList e);
			internal int _.ctor_b__271_41(SummonList e);
			internal int _.ctor_b__271_42(AtgenResultPrizeList e);
			internal int _.ctor_b__271_43(SummonHistoryList e);
			internal int _.ctor_b__271_44(SummonPointList e);
			internal int _.ctor_b__271_45(AtgenSummonPointTradeList e);
			internal int _.ctor_b__271_46(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_47(AtgenResultUnitList e);
			internal int _.ctor_b__271_48(ItemList e);
			internal int _.ctor_b__271_49(MaterialList e);
			internal int _.ctor_b__271_50(AstralItemList e);
			internal int _.ctor_b__271_51(GatherItemList e);
			internal int _.ctor_b__271_52(MuseumList e);
			internal int _.ctor_b__271_53(MuseumDragonList e);
			internal int _.ctor_b__271_54(EnemyBookList e);
			internal int _.ctor_b__271_55(AlbumWeaponList e);
			internal int _.ctor_b__271_56(PartyList e);
			internal int _.ctor_b__271_57(QuestList e);
			internal int _.ctor_b__271_58(QuestEventList e);
			internal int _.ctor_b__271_59(QuestTreasureList e);
			internal int _.ctor_b__271_60(QuestEventScheduleList e);
			internal int _.ctor_b__271_61(QuestScheduleDetailList e);
			internal int _.ctor_b__271_62(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_63(AtgenLostUnitList e);
			internal int _.ctor_b__271_64(QuestCarryList e);
			internal int _.ctor_b__271_65(QuestEntryConditionList e);
			internal ulong _.ctor_b__271_66(PresentHistoryList e);
			internal ulong _.ctor_b__271_67(PresentDetailList e);
			internal ulong _.ctor_b__271_68(PresentDetailList e);
			internal int _.ctor_b__271_69(RewardReliabilityList e);
			internal int _.ctor_b__271_70(DragonRewardEntityList e);
			internal int _.ctor_b__271_71(AtgenDragonGiftRewardList e);
			internal int _.ctor_b__271_72(RoomList e);
			internal int _.ctor_b__271_73(StampList e);
			internal ulong _.ctor_b__271_74(SummonTicketList e);
			internal int _.ctor_b__271_75(RoomList e);
			internal int _.ctor_b__271_76(RoomList e);
			internal int _.ctor_b__271_77(RoomList e);
			internal int _.ctor_b__271_78(AtgenLoginBonusList e);
			internal int _.ctor_b__271_79(LotteryTicketList e);
			internal int _.ctor_b__271_80(AtgenLotteryResultList e);
			internal int _.ctor_b__271_81(EventCycleRewardList e);
			internal int _.ctor_b__271_82(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_83(AtgenBattleRoyalHistoryList e);
			internal int _.ctor_b__271_84(AtgenDuplicateEntityList e);
			internal int _.ctor_b__271_85(AtgenQuestStoryRewardList e);
			internal int _.ctor_b__271_86(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_87(AtgenBuildEventRewardEntityList e);
			internal ulong _.ctor_b__271_88(UserSupportList e);
			internal ulong _.ctor_b__271_89(UserSupportList e);
			internal ulong _.ctor_b__271_90(UserSupportList e);
			internal ulong _.ctor_b__271_91(UserSupportList e);
			internal ulong _.ctor_b__271_92(UserSupportList e);
			internal ulong _.ctor_b__271_93(UserSupportList e);
			internal ulong _.ctor_b__271_94(AtgenSupportUserDetailList e);
			internal ulong _.ctor_b__271_95(AtgenHelperDetailList e);
			internal ulong _.ctor_b__271_96(UserSupportList e);
			internal int _.ctor_b__271_97(QuestWallList e);
			internal int _.ctor_b__271_98(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_99(PartySettingList e);
			internal int _.ctor_b__271_100(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_101(AtgenUserWallRewardList e);
			internal int _.ctor_b__271_102(AtgenMonthlyWallReceiveList e);
			internal int _.ctor_b__271_103(AtgenItemSummonRateList e);
			internal int _.ctor_b__271_104(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_105(ShopPurchaseList e);
			internal int _.ctor_b__271_106(ShopPurchaseList e);
			internal int _.ctor_b__271_107(AtgenQuestBonus e);
			internal int _.ctor_b__271_108(ShopPurchaseList e);
			internal int _.ctor_b__271_109(AtgenStaminaBonus e);
			internal int _.ctor_b__271_110(AtgenStoneBonus e);
			internal int _.ctor_b__271_111(ProductList e);
			internal int _.ctor_b__271_112(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_113(AtgenProductLockList e);
			internal int _.ctor_b__271_114(AtgenDuplicateEntityList e);
			internal ulong _.ctor_b__271_115(GuildMemberList e);
			internal ulong _.ctor_b__271_116(GuildChatMessageList e);
			internal int _.ctor_b__271_117(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_118(GuildData e);
			internal int _.ctor_b__271_119(GuildData e);
			internal ulong _.ctor_b__271_120(GuildApplyList e);
			internal ulong _.ctor_b__271_121(GuildInviteReceiveList e);
			internal ulong _.ctor_b__271_122(GuildInviteSendList e);
			internal int _.ctor_b__271_123(AtgenAlbumQuestPlayRecordList e);
			internal int _.ctor_b__271_124(AlbumDragonData e);
			internal int _.ctor_b__271_125(DailyMissionList e);
			internal int _.ctor_b__271_126(NormalMissionList e);
			internal int _.ctor_b__271_127(PeriodMissionList e);
			internal int _.ctor_b__271_128(BeginnerMissionList e);
			internal int _.ctor_b__271_129(SpecialMissionList e);
			internal int _.ctor_b__271_130(MainStoryMissionList e);
			internal int _.ctor_b__271_131(MemoryEventMissionList e);
			internal int _.ctor_b__271_132(DrillMissionList e);
			internal int _.ctor_b__271_133(AlbumMissionList e);
			internal int _.ctor_b__271_134(AtgenNotReceivedMissionIdListWithDayNo e);
			internal int _.ctor_b__271_135(ConvertedEntityList e);
			internal int _.ctor_b__271_136(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_137(DrillMissionGroupList e);
			internal int _.ctor_b__271_138(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_139(PartySettingList e);
			internal int _.ctor_b__271_140(PartySettingList e);
			internal int _.ctor_b__271_141(EventPassiveList e);
			internal int _.ctor_b__271_142(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_143(RaidEventRewardList e);
			internal int _.ctor_b__271_144(CharaFriendshipList e);
			internal int _.ctor_b__271_145(BuildEventRewardList e);
			internal int _.ctor_b__271_146(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_147(BuildEventRewardList e);
			internal int _.ctor_b__271_148(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_149(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_150(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_151(BuildEventRewardList e);
			internal int _.ctor_b__271_152(Clb01EventUserList e);
			internal int _.ctor_b__271_153(BuildEventRewardList e);
			internal int _.ctor_b__271_154(BuildEventRewardList e);
			internal int _.ctor_b__271_155(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_156(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_157(UserEventLocationRewardList e);
			internal int _.ctor_b__271_158(BattleRoyalEventItemList e);
			internal int _.ctor_b__271_159(BattleRoyalCharaSkinList e);
			internal int _.ctor_b__271_160(RankingTierRewardList e);
			internal int _.ctor_b__271_161(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_162(AchievementList e);
			internal int _.ctor_b__271_163(AtgenVersionHash e);
			internal int _.ctor_b__271_164(AtgenWebviewUrlList e);
			internal int _.ctor_b__271_165(AtgenCommentList e);
			internal int _.ctor_b__271_166(AtgenOpinionTypeList e);
			internal int _.ctor_b__271_167(AtgenOpinionList e);
			internal int _.ctor_b__271_168(AtgenCategoryList e);
			internal int _.ctor_b__271_169(AtgenInquiryFaqList e);
			internal int _.ctor_b__271_170(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_171(AtgenBuildEventRewardEntityList e);
			internal int _.ctor_b__271_172(AtgenDuplicateEntityList e);
			internal int _.ctor_b__271_173(FunctionalMaintenanceList e);
			internal ulong _.ctor_b__271_174(WeaponList e);
			internal ulong _UpdateByDeleteDataList_b__278_0(AtgenDeleteDragonList e);
			internal ulong _UpdateByDeleteDataList_b__278_1(AtgenDeleteWeaponList e);
			internal ulong _UpdateByDeleteDataList_b__278_2(AtgenDeleteAmuletList e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass277_0<T1, T>
			where T : class
		{
			// Fields
			public Func<T1, ulong> getId;
	
			// Constructors
			public __c__DisplayClass277_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass277_1<T1, T>
			where T : class
		{
			// Fields
			public ulong key_id;
			public __c__DisplayClass277_0<T1, T> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass277_1();
	
			// Methods
			internal bool _UpdateByDeleteList_b__0(T1 e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass290_0
		{
			// Fields
			public Action<int> onSuccess;
	
			// Constructors
			public __c__DisplayClass290_0();
	
			// Methods
			internal void _LoadDragonDiamond_b__0(int diaCount);
		}
	
		// Constructors
		public DataManager();
		static DataManager();
	
		// Methods
		public void UpdateScheduleDataWrapper();
		public void SaveUuid(string uuid);
		public void SaveViewerId(ulong viewerId);
		public bool HasViewerId();
		public void ClearId();
		private void UpdateByDataList<T>(T[] dataList, GameData<T> destList)
			where T : class;
		private void UpdateByDeleteList<T1, T>(T1[] deleteList, Func<T1, ulong> getId, GameData<T> destList)
			where T : class;
		public void UpdateByDeleteDataList(DeleteDataList deleteDataList);
		public void UpdateByEntityResult(EntityResult entityResult);
		public int GetEquipWeaponId(int slot, int idx);
		public void ReleaseInGameData();
		public void ReleaseInGameResult();
		public void UpdateUserFortLevel();
		public void ResetUserFortLevel();
		public int GetFortLevel();
		public int GetFortCraftLevel();
		public void AfterUpdateByUpdateDataList();
		public void LoadDragonDiamond(Action<int> onSuccess, Action<NPFErrorParam> onFailed = null);
		public void UpdateByResponse(AbilityCrestBuildupPieceResponse res);
		public void UpdateByResponse(AbilityCrestBuildupPlusCountResponse res);
		public void UpdateByResponse(AbilityCrestGetAbilityCrestSetListResponse res);
		public void UpdateByResponse(AbilityCrestResetPlusCountResponse res);
		public void UpdateByResponse(AbilityCrestSetAbilityCrestSetResponse res);
		public void UpdateByResponse(AbilityCrestSetFavoriteResponse res);
		public void UpdateByResponse(AbilityCrestTradeGetListResponse res);
		public void UpdateByResponse(AbilityCrestTradeTradeResponse res);
		public void UpdateByResponse(AbilityCrestUpdateAbilityCrestSetNameResponse res);
		public void UpdateByResponse(AlbumIndexResponse res);
		public void UpdateByResponse(AmuletBuildupResponse res);
		public void UpdateByResponse(AmuletLimitBreakResponse res);
		public void UpdateByResponse(AmuletResetPlusCountResponse res);
		public void UpdateByResponse(AmuletSellResponse res);
		public void UpdateByResponse(AmuletSetLockResponse res);
		public void UpdateByResponse(AmuletTradeGetListResponse res);
		public void UpdateByResponse(AmuletTradeTradeResponse res);
		public void UpdateByResponse(BattleRoyalEventEntryResponse res);
		public void UpdateByResponse(BattleRoyalEventGetEventDataResponse res);
		public void UpdateByResponse(BattleRoyalEventReceiveEventCyclePointRewardResponse res);
		public void UpdateByResponse(BattleRoyalEventReleaseCharaSkinResponse res);
		public void UpdateByResponse(BattleRoyalFailResponse res);
		public void UpdateByResponse(BattleRoyalGetBattleRoyalHistoryResponse res);
		public void UpdateByResponse(BattleRoyalRecordRoyalRecordMultiResponse res);
		public void UpdateByResponse(BattleRoyalStartMultiResponse res);
		public void UpdateByResponse(BattleRoyalStartRoyalMultiResponse res);
		public void UpdateByResponse(BuildEventEntryResponse res);
		public void UpdateByResponse(BuildEventGetEventDataResponse res);
		public void UpdateByResponse(BuildEventReceiveBuildPointRewardResponse res);
		public void UpdateByResponse(BuildEventReceiveDailyBonusResponse res);
		public void UpdateByResponse(CartoonLatestResponse res);
		public void UpdateByResponse(CastleStoryReadResponse res);
		public void UpdateByResponse(CharaAwakeResponse res);
		public void UpdateByResponse(CharaBuildupResponse res);
		public void UpdateByResponse(CharaBuildupManaResponse res);
		public void UpdateByResponse(CharaGetCharaUnitSetResponse res);
		public void UpdateByResponse(CharaGetListResponse res);
		public void UpdateByResponse(CharaLimitBreakResponse res);
		public void UpdateByResponse(CharaResetPlusCountResponse res);
		public void UpdateByResponse(CharaSetCharaUnitSetResponse res);
		public void UpdateByResponse(CharaUnlockEditSkillResponse res);
		public void UpdateByResponse(Clb01EventEntryResponse res);
		public void UpdateByResponse(Clb01EventGetEventDataResponse res);
		public void UpdateByResponse(Clb01EventReceiveClb01PointRewardResponse res);
		public void UpdateByResponse(CollectEventEntryResponse res);
		public void UpdateByResponse(CollectEventGetEventDataResponse res);
		public void UpdateByResponse(CombatEventEntryResponse res);
		public void UpdateByResponse(CombatEventGetEventDataResponse res);
		public void UpdateByResponse(CombatEventReceiveEventLocationRewardResponse res);
		public void UpdateByResponse(CombatEventReceiveEventPointRewardResponse res);
		public void UpdateByResponse(CraftAssembleResponse res);
		public void UpdateByResponse(CraftCreateResponse res);
		public void UpdateByResponse(CraftDisassembleResponse res);
		public void UpdateByResponse(CraftResetNewResponse res);
		public void UpdateByResponse(DragonBuildupResponse res);
		public void UpdateByResponse(DragonBuyGiftToSendResponse res);
		public void UpdateByResponse(DragonBuyGiftToSendMultipleResponse res);
		public void UpdateByResponse(DragonGetContactDataResponse res);
		public void UpdateByResponse(DragonLimitBreakResponse res);
		public void UpdateByResponse(DragonResetPlusCountResponse res);
		public void UpdateByResponse(DragonSellResponse res);
		public void UpdateByResponse(DragonSendGiftResponse res);
		public void UpdateByResponse(DragonSendGiftMultipleResponse res);
		public void UpdateByResponse(DragonSetLockResponse res);
		public void UpdateByResponse(DreamAdventureClearResponse res);
		public void UpdateByResponse(DreamAdventurePlayResponse res);
		public void UpdateByResponse(DungeonFailResponse res);
		public void UpdateByResponse(DungeonGetAreaOddsResponse res);
		public void UpdateByResponse(DungeonReceiveQuestBonusResponse res);
		public void UpdateByResponse(DungeonRecordRecordResponse res);
		public void UpdateByResponse(DungeonRecordRecordMultiResponse res);
		public void UpdateByResponse(DungeonRetryResponse res);
		public void UpdateByResponse(DungeonSkipStartResponse res);
		public void UpdateByResponse(DungeonSkipStartAssignUnitResponse res);
		public void UpdateByResponse(DungeonStartStartResponse res);
		public void UpdateByResponse(DungeonStartStartAssignUnitResponse res);
		public void UpdateByResponse(DungeonStartStartMultiResponse res);
		public void UpdateByResponse(DungeonStartStartMultiAssignUnitResponse res);
		public void UpdateByResponse(EmblemGetListResponse res);
		public void UpdateByResponse(EmblemSetResponse res);
		public void UpdateByResponse(EulaAgreeAgreeResponse res);
		public void UpdateByResponse(EulaGetVersionResponse res);
		public void UpdateByResponse(EulaGetVersionListResponse res);
		public void UpdateByResponse(EventStoryReadResponse res);
		public void UpdateByResponse(EventSummonExecResponse res);
		public void UpdateByResponse(EventSummonGetDataResponse res);
		public void UpdateByResponse(EventSummonResetResponse res);
		public void UpdateByResponse(EventTradeGetListResponse res);
		public void UpdateByResponse(EventTradeTradeResponse res);
		public void UpdateByResponse(ExHunterEventEntryResponse res);
		public void UpdateByResponse(ExHunterEventGetEventDataResponse res);
		public void UpdateByResponse(ExHunterEventReceiveExHunterPointRewardResponse res);
		public void UpdateByResponse(ExRushEventEntryResponse res);
		public void UpdateByResponse(ExRushEventGetEventDataResponse res);
		public void UpdateByResponse(FortAddCarpenterResponse res);
		public void UpdateByResponse(FortBuildAtOnceResponse res);
		public void UpdateByResponse(FortBuildCancelResponse res);
		public void UpdateByResponse(FortBuildEndResponse res);
		public void UpdateByResponse(FortBuildStartResponse res);
		public void UpdateByResponse(FortGetDataResponse res);
		public void UpdateByResponse(FortGetMultiIncomeResponse res);
		public void UpdateByResponse(FortLevelupAtOnceResponse res);
		public void UpdateByResponse(FortLevelupCancelResponse res);
		public void UpdateByResponse(FortLevelupEndResponse res);
		public void UpdateByResponse(FortLevelupStartResponse res);
		public void UpdateByResponse(FortMoveResponse res);
		public void UpdateByResponse(FortSetNewFortPlantResponse res);
		public void UpdateByResponse(FriendAllReplyDenyResponse res);
		public void UpdateByResponse(FriendApplyListResponse res);
		public void UpdateByResponse(FriendAutoSearchResponse res);
		public void UpdateByResponse(FriendDeleteResponse res);
		public void UpdateByResponse(FriendFriendIndexResponse res);
		public void UpdateByResponse(FriendFriendListResponse res);
		public void UpdateByResponse(FriendGetSupportCharaResponse res);
		public void UpdateByResponse(FriendGetSupportCharaDetailResponse res);
		public void UpdateByResponse(FriendIdSearchResponse res);
		public void UpdateByResponse(FriendReplyResponse res);
		public void UpdateByResponse(FriendRequestResponse res);
		public void UpdateByResponse(FriendRequestCancelResponse res);
		public void UpdateByResponse(FriendRequestListResponse res);
		public void UpdateByResponse(FriendSetSupportCharaResponse res);
		public void UpdateByResponse(GuildChatGetNewMessageListResponse res);
		public void UpdateByResponse(GuildChatGetOldMessageListResponse res);
		public void UpdateByResponse(GuildChatPostMessageStampResponse res);
		public void UpdateByResponse(GuildChatPostMessageTextResponse res);
		public void UpdateByResponse(GuildChatPostReportResponse res);
		public void UpdateByResponse(GuildDisbandResponse res);
		public void UpdateByResponse(GuildDropMemberResponse res);
		public void UpdateByResponse(GuildEstablishResponse res);
		public void UpdateByResponse(GuildGetGuildApplyDataResponse res);
		public void UpdateByResponse(GuildGetGuildMemberDataResponse res);
		public void UpdateByResponse(GuildIndexResponse res);
		public void UpdateByResponse(GuildInviteGetGuildInviteReceiveDataResponse res);
		public void UpdateByResponse(GuildInviteGetGuildInviteSendDataResponse res);
		public void UpdateByResponse(GuildInviteInviteCancelResponse res);
		public void UpdateByResponse(GuildInviteInviteReplyResponse res);
		public void UpdateByResponse(GuildInviteInviteReplyAllDenyResponse res);
		public void UpdateByResponse(GuildInviteInviteSendResponse res);
		public void UpdateByResponse(GuildJoinResponse res);
		public void UpdateByResponse(GuildJoinReplyResponse res);
		public void UpdateByResponse(GuildJoinReplyAllDenyResponse res);
		public void UpdateByResponse(GuildJoinRequestResponse res);
		public void UpdateByResponse(GuildJoinRequestCancelResponse res);
		public void UpdateByResponse(GuildPostReportResponse res);
		public void UpdateByResponse(GuildResignResponse res);
		public void UpdateByResponse(GuildSearchAutoSearchResponse res);
		public void UpdateByResponse(GuildSearchGetGuildDetailResponse res);
		public void UpdateByResponse(GuildSearchIdSearchResponse res);
		public void UpdateByResponse(GuildSearchNameSearchResponse res);
		public void UpdateByResponse(GuildUpdateGuildPositionTypeResponse res);
		public void UpdateByResponse(GuildUpdateGuildSettingResponse res);
		public void UpdateByResponse(GuildUpdateUserSettingResponse res);
		public void UpdateByResponse(InquiryAggregationResponse res);
		public void UpdateByResponse(InquiryDetailResponse res);
		public void UpdateByResponse(InquiryReplyResponse res);
		public void UpdateByResponse(InquirySendResponse res);
		public void UpdateByResponse(InquiryTopResponse res);
		public void UpdateByResponse(ItemGetListResponse res);
		public void UpdateByResponse(ItemUseRecoveryStaminaResponse res);
		public void UpdateByResponse(LoadIndexResponse res);
		public void UpdateByResponse(LoginIndexResponse res);
		public void UpdateByResponse(LoginPenaltyConfirmResponse res);
		public void UpdateByResponse(LoginVerifyJwsResponse res);
		public void UpdateByResponse(LotteryGetOddsDataResponse res);
		public void UpdateByResponse(LotteryLotteryExecResponse res);
		public void UpdateByResponse(LotteryResultResponse res);
		public void UpdateByResponse(MaintenanceGetTextResponse res);
		public void UpdateByResponse(MatchingCheckPenaltyUserResponse res);
		public void UpdateByResponse(MatchingGetRoomListResponse res);
		public void UpdateByResponse(MatchingGetRoomListByGuildResponse res);
		public void UpdateByResponse(MatchingGetRoomListByLocationResponse res);
		public void UpdateByResponse(MatchingGetRoomListByQuestIdResponse res);
		public void UpdateByResponse(MatchingGetRoomNameResponse res);
		public void UpdateByResponse(MazeEventEntryResponse res);
		public void UpdateByResponse(MazeEventGetEventDataResponse res);
		public void UpdateByResponse(MazeEventReceiveMazePointRewardResponse res);
		public void UpdateByResponse(MemoryEventActivateResponse res);
		public void UpdateByResponse(MissionGetDrillMissionListResponse res);
		public void UpdateByResponse(MissionGetMissionListResponse res);
		public void UpdateByResponse(MissionReceiveAlbumRewardResponse res);
		public void UpdateByResponse(MissionReceiveBeginnerRewardResponse res);
		public void UpdateByResponse(MissionReceiveDailyRewardResponse res);
		public void UpdateByResponse(MissionReceiveDrillRewardResponse res);
		public void UpdateByResponse(MissionReceiveMainStoryRewardResponse res);
		public void UpdateByResponse(MissionReceiveMemoryEventRewardResponse res);
		public void UpdateByResponse(MissionReceiveNormalRewardResponse res);
		public void UpdateByResponse(MissionReceivePeriodRewardResponse res);
		public void UpdateByResponse(MissionReceiveSpecialRewardResponse res);
		public void UpdateByResponse(MissionUnlockDrillMissionGroupResponse res);
		public void UpdateByResponse(MissionUnlockMainStoryGroupResponse res);
		public void UpdateByResponse(MypageInfoResponse res);
		public void UpdateByResponse(OptionGetOptionResponse res);
		public void UpdateByResponse(OptionSetOptionResponse res);
		public void UpdateByResponse(PartyIndexResponse res);
		public void UpdateByResponse(PartySetMainPartyNoResponse res);
		public void UpdateByResponse(PartySetPartySettingResponse res);
		public void UpdateByResponse(PartyUpdatePartyNameResponse res);
		public void UpdateByResponse(PlatformAchievementGetPlatformAchievementListResponse res);
		public void UpdateByResponse(PresentGetHistoryListResponse res);
		public void UpdateByResponse(PresentGetPresentListResponse res);
		public void UpdateByResponse(PresentReceiveResponse res);
		public void UpdateByResponse(PushNotificationUpdateSettingResponse res);
		public void UpdateByResponse(QuestDropListResponse res);
		public void UpdateByResponse(QuestGetQuestClearPartyResponse res);
		public void UpdateByResponse(QuestGetQuestClearPartyMultiResponse res);
		public void UpdateByResponse(QuestGetSupportUserListResponse res);
		public void UpdateByResponse(QuestOpenTreasureResponse res);
		public void UpdateByResponse(QuestReadStoryResponse res);
		public void UpdateByResponse(QuestSetQuestClearPartyResponse res);
		public void UpdateByResponse(QuestSetQuestClearPartyMultiResponse res);
		public void UpdateByResponse(RaidEventEntryResponse res);
		public void UpdateByResponse(RaidEventGetEventDataResponse res);
		public void UpdateByResponse(RaidEventReceiveRaidPointRewardResponse res);
		public void UpdateByResponse(RedoableSummonFixExecResponse res);
		public void UpdateByResponse(RedoableSummonGetDataResponse res);
		public void UpdateByResponse(RedoableSummonPreExecResponse res);
		public void UpdateByResponse(RepeatEndResponse res);
		public void UpdateByResponse(ShopChargeCancelResponse res);
		public void UpdateByResponse(ShopGetBonusResponse res);
		public void UpdateByResponse(ShopGetDreamSelectUnitListResponse res);
		public void UpdateByResponse(ShopGetListResponse res);
		public void UpdateByResponse(ShopGetProductListResponse res);
		public void UpdateByResponse(ShopItemSummonExecResponse res);
		public void UpdateByResponse(ShopItemSummonOddResponse res);
		public void UpdateByResponse(ShopMaterialShopPurchaseResponse res);
		public void UpdateByResponse(ShopNormalShopPurchaseResponse res);
		public void UpdateByResponse(ShopPreChargeCheckResponse res);
		public void UpdateByResponse(ShopSpecialShopPurchaseResponse res);
		public void UpdateByResponse(SimpleEventEntryResponse res);
		public void UpdateByResponse(SimpleEventGetEventDataResponse res);
		public void UpdateByResponse(StampGetStampResponse res);
		public void UpdateByResponse(StampSetEquipStampResponse res);
		public void UpdateByResponse(StoryReadResponse res);
		public void UpdateByResponse(StorySkipSkipResponse res);
		public void UpdateByResponse(SuggestionGetCategoryListResponse res);
		public void UpdateByResponse(SuggestionSetResponse res);
		public void UpdateByResponse(SummonGetOddsDataResponse res);
		public void UpdateByResponse(SummonGetSummonHistoryResponse res);
		public void UpdateByResponse(SummonGetSummonListResponse res);
		public void UpdateByResponse(SummonGetSummonPointTradeResponse res);
		public void UpdateByResponse(SummonRequestResponse res);
		public void UpdateByResponse(SummonSummonPointTradeResponse res);
		public void UpdateByResponse(TimeAttackRankingGetDataResponse res);
		public void UpdateByResponse(TimeAttackRankingReceiveTierRewardResponse res);
		public void UpdateByResponse(ToolAuthResponse res);
		public void UpdateByResponse(ToolGetMaintenanceTimeResponse res);
		public void UpdateByResponse(ToolReauthResponse res);
		public void UpdateByResponse(ToolSignupResponse res);
		public void UpdateByResponse(TrackRecordUpdateProgressResponse res);
		public void UpdateByResponse(TransitionTransitionByNAccountResponse res);
		public void UpdateByResponse(TreasureTradeGetListResponse res);
		public void UpdateByResponse(TreasureTradeGetListAllResponse res);
		public void UpdateByResponse(TreasureTradeTradeResponse res);
		public void UpdateByResponse(TutorialUpdateFlagsResponse res);
		public void UpdateByResponse(TutorialUpdateStepResponse res);
		public void UpdateByResponse(UpdateNamechangeResponse res);
		public void UpdateByResponse(UpdateResetNewResponse res);
		public void UpdateByResponse(UserLinkedNAccountResponse res);
		public void UpdateByResponse(UserOptInSettingResponse res);
		public void UpdateByResponse(UserRecoverStaminaByStoneResponse res);
		public void UpdateByResponse(UserWithdrawalResponse res);
		public void UpdateByResponse(VersionGetResourceVersionResponse res);
		public void UpdateByResponse(WalkerSendGiftMultipleResponse res);
		public void UpdateByResponse(WallFailResponse res);
		public void UpdateByResponse(WallGetMonthlyRewardResponse res);
		public void UpdateByResponse(WallGetWallClearPartyResponse res);
		public void UpdateByResponse(WallReceiveMonthlyRewardResponse res);
		public void UpdateByResponse(WallRecordRecordResponse res);
		public void UpdateByResponse(WallSetWallClearPartyResponse res);
		public void UpdateByResponse(WallStartStartResponse res);
		public void UpdateByResponse(WallStartStartAssignUnitResponse res);
		public void UpdateByResponse(WeaponBodyBuildupPieceResponse res);
		public void UpdateByResponse(WeaponBodyCraftResponse res);
		public void UpdateByResponse(WeaponBuildupResponse res);
		public void UpdateByResponse(WeaponLimitBreakResponse res);
		public void UpdateByResponse(WeaponResetPlusCountResponse res);
		public void UpdateByResponse(WeaponSellResponse res);
		public void UpdateByResponse(WeaponSetLockResponse res);
		public void UpdateByResponse(WebviewVersionUrlListResponse res);
		public void UpdateByUpdateDataList(UpdateDataList updateDataList);
	}
}
