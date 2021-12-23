using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Http;
using NPF.NPFWrapper;

namespace Gluon
{
	public class DataManager
	{
		public class BasicInfo
		{
			public string uuid;

			public ulong viewer_id;

			public string session_id;

			public string resource_version;

			private string separated_viewer_id_str;

			public string GetSeparatedViewerIdString()
			{
				return null;
			}
		}

		public class GameData<T> where T : class
		{
			private Func<T, ulong> getId;

			private Dictionary<ulong, int> idToIndex;

			private T[] Array
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

			public T this[int i]
			{
				get
				{
					return null;
				}
				private set
				{
				}
			}

			public int Length => default(int);

			public GameData(Func<T, int> func)
			{
			}

			public GameData(Func<T, ulong> func)
			{
			}

			public T GetById(ulong id)
			{
				return null;
			}

			public T GetById(int id)
			{
				return null;
			}

			private void SetById(ulong id, T value)
			{
			}

			public bool SetById(T value)
			{
				return default(bool);
			}

			public void Import(T[] array)
			{
			}

			public void Append(List<T> newList)
			{
			}

			public ulong GetId(int index)
			{
				return default(ulong);
			}

			public void Clear()
			{
			}
		}

		public class GDUserData : UserData
		{
			public int max_chara_num;

			public int is_shop_notification;

			public int is_view_start_dash;

			public int is_view_dream_select;

			public int achievement_cnt;

			public int present_cnt;

			public int friend_apply;

			public int friend_count;

			public int stamina_single_recover_second;

			public int stamina_multi_user_max;

			public int stamina_multi_system_max;

			public int quest_skip_point_system_max;

			public int quest_skip_point_use_limit_max;

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

			public int is_receive_event_damage_reward;

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

			public string deploy_hash;

			public int max_party_power
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int paid_diamond
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int free_diamond
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int fort_level => default(int);

			public int fort_craft_level => default(int);

			public void Import(UserData data)
			{
			}
		}

		public class LastStatus
		{
			public int result;

			public int success_type;

			public int skill_levelup;

			public int servertime;
		}

		public BasicInfo basicInfo;

		private static DataManager instance;

		public List<QuestScheduleDataWrapper> questScheduleDataWrapperList;

		public GameData<BuildList> buildList;

		public GameData<CharaList> charaList;

		public GameData<DragonList> dragonList;

		public GameData<AmuletList> amuletList;

		public GameData<TalismanList> talismanList;

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

		public GameData<UserSummonList> userSummonList;

		public OddsRateList oddsRateList;

		public AtgenCsSummonList csSummonList;

		public GameData<SummonList> summonList;

		public GameData<SummonList> campaignSummonList;

		public GameData<SummonList> platinumSummonList;

		public GameData<SummonList> charaSsrSummonList;

		public GameData<SummonList> dragonSsrSummonList;

		public GameData<SummonList> campaignSsrSummonList;

		public GameData<SummonList> charaSsrUpdateSummonList;

		public GameData<SummonList> dragonSsrUpdateSummonList;

		public GameData<SummonList> excludeSummonList;

		public GameData<AtgenResultPrizeList> resultPrizeList;

		public SummonPrizeOddsRateList summonPrizeOddsRateList;

		public GameData<SummonHistoryList> summonHistoryList;

		public GameData<SummonPointList> summonPointList;

		public GameData<AtgenSummonPointTradeList> summonPointTradeList;

		public RedoableSummonOddsRateList redoableSummonOddsRateList;

		public UserRedoableSummonData userRedoableSummonData;

		public GameData<AtgenDuplicateEntityList> summonExcludeUnitList;

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

		public GameData<AtgenLoginLotteryRewardList> loginLotteryRewardList;

		public GameData<LotteryTicketList> lotteryTicketList;

		public GameData<AtgenLotteryResultList> lotteryResultList;

		public LotteryOddsRateList lotteryOddsRateList;

		public GameData<ExchangeTicketList> exchangeTicketList;

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

		public GameData<AtgenDuplicateEntityList> selectUnitList;

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

		public GameData<AtgenCharaHonorList> charaHonorList;

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

		public GameData<SearchClearPartyCharaList> searchQuestClearPartyCharaList;

		public GameData<SearchClearPartyList> searchQuestClearPartyList;

		public DmodeInfo dmodeInfo;

		public GameData<DmodeCharaList> dmodeCharaList;

		public GameData<DmodeStoryList> dmodeStoryList;

		public GameData<DmodeServitorPassiveList> dmodeServitorPassiveList;

		public DmodeExpedition dmodeExpedition;

		public DmodeDungeonInfo dmodeDungeonInfo;

		public DmodeIngameData dmodeIngameData;

		public DmodeFloorData dmodeFloorData;

		public DmodeIngameResult dmodeIngameResult;

		public GameData<AtgenBuildEventRewardEntityList> dmodeStoryRewardList;

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

		public GameData<AtgenEventDamageRewardList> eventDamageRewardList;

		public GameData<AtgenEventDamageHistoryList> eventDamageHistoryList;

		public AtgenEventDamageData eventDamageData;

		public EventDamageRanking eventDamageRanking;

		public RaidEventUserList raidEventUserData;

		public GameData<RaidEventRewardList> raidEventRewardList;

		public GameData<CharaFriendshipList> charaFriendshipList;

		public GameData<EventAbilityCharaList> eventAbilityCharaList;

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

		public EarnEventUserList earnEventUserData;

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

		public AtgenNAccountInfo nAccountInfo;

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

		public int clearTime
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

		private string UuidKey => null;

		private string ViewerIdKey => null;

		public static DataManager Instance => null;

		private string UuidPath => null;

		public int allDragonDiamond => default(int);

		public void UpdateScheduleDataWrapper()
		{
		}

		public void SaveUuid(string uuid)
		{
		}

		public void SaveViewerId(ulong viewerId)
		{
		}

		public bool HasViewerId()
		{
			return default(bool);
		}

		public void ClearId()
		{
		}

		private void UpdateByDataList<T>(T[] dataList, GameData<T> destList) where T : class
		{
		}

		private void UpdateByDeleteList<T1, T>(T1[] deleteList, Func<T1, ulong> getId, GameData<T> destList) where T : class
		{
		}

		public void UpdateByDeleteDataList(DeleteDataList deleteDataList)
		{
		}

		public void UpdateByEntityResult(EntityResult entityResult)
		{
		}

		public int GetEquipWeaponId(int slot, int idx)
		{
			return default(int);
		}

		public void ReleaseInGameData()
		{
		}

		public void ReleaseInGameResult()
		{
		}

		public void UpdateUserFortLevel()
		{
		}

		public void ResetUserFortLevel()
		{
		}

		public int GetFortLevel()
		{
			return default(int);
		}

		public int GetFortCraftLevel()
		{
			return default(int);
		}

		public void AfterUpdateByUpdateDataList()
		{
		}

		public void LoadDragonDiamond(Action<int> onSuccess, [Optional] Action<NPFErrorParam> onFailed)
		{
		}

		public void UpdateByResponse(AbilityCrestBuildupPieceResponse res)
		{
		}

		public void UpdateByResponse(AbilityCrestBuildupPlusCountResponse res)
		{
		}

		public void UpdateByResponse(AbilityCrestGetAbilityCrestSetListResponse res)
		{
		}

		public void UpdateByResponse(AbilityCrestResetPlusCountResponse res)
		{
		}

		public void UpdateByResponse(AbilityCrestSetAbilityCrestSetResponse res)
		{
		}

		public void UpdateByResponse(AbilityCrestSetFavoriteResponse res)
		{
		}

		public void UpdateByResponse(AbilityCrestTradeGetListResponse res)
		{
		}

		public void UpdateByResponse(AbilityCrestTradeTradeResponse res)
		{
		}

		public void UpdateByResponse(AbilityCrestUpdateAbilityCrestSetNameResponse res)
		{
		}

		public void UpdateByResponse(AlbumIndexResponse res)
		{
		}

		public void UpdateByResponse(AmuletBuildupResponse res)
		{
		}

		public void UpdateByResponse(AmuletLimitBreakResponse res)
		{
		}

		public void UpdateByResponse(AmuletResetPlusCountResponse res)
		{
		}

		public void UpdateByResponse(AmuletSellResponse res)
		{
		}

		public void UpdateByResponse(AmuletSetLockResponse res)
		{
		}

		public void UpdateByResponse(AmuletTradeGetListResponse res)
		{
		}

		public void UpdateByResponse(AmuletTradeTradeResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalEventEntryResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalEventReceiveEventCyclePointRewardResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalEventReleaseCharaSkinResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalFailResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalGetBattleRoyalHistoryResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalRecordRoyalRecordMultiResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalStartMultiResponse res)
		{
		}

		public void UpdateByResponse(BattleRoyalStartRoyalMultiResponse res)
		{
		}

		public void UpdateByResponse(BuildEventEntryResponse res)
		{
		}

		public void UpdateByResponse(BuildEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(BuildEventReceiveBuildPointRewardResponse res)
		{
		}

		public void UpdateByResponse(BuildEventReceiveDailyBonusResponse res)
		{
		}

		public void UpdateByResponse(CartoonLatestResponse res)
		{
		}

		public void UpdateByResponse(CastleStoryReadResponse res)
		{
		}

		public void UpdateByResponse(CharaAwakeResponse res)
		{
		}

		public void UpdateByResponse(CharaBuildupResponse res)
		{
		}

		public void UpdateByResponse(CharaBuildupManaResponse res)
		{
		}

		public void UpdateByResponse(CharaBuildupPlatinumResponse res)
		{
		}

		public void UpdateByResponse(CharaGetCharaUnitSetResponse res)
		{
		}

		public void UpdateByResponse(CharaGetListResponse res)
		{
		}

		public void UpdateByResponse(CharaLimitBreakResponse res)
		{
		}

		public void UpdateByResponse(CharaLimitBreakAndBuildupManaResponse res)
		{
		}

		public void UpdateByResponse(CharaResetPlusCountResponse res)
		{
		}

		public void UpdateByResponse(CharaSetCharaUnitSetResponse res)
		{
		}

		public void UpdateByResponse(CharaUnlockEditSkillResponse res)
		{
		}

		public void UpdateByResponse(Clb01EventEntryResponse res)
		{
		}

		public void UpdateByResponse(Clb01EventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(Clb01EventReceiveClb01PointRewardResponse res)
		{
		}

		public void UpdateByResponse(CollectEventEntryResponse res)
		{
		}

		public void UpdateByResponse(CollectEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(CombatEventEntryResponse res)
		{
		}

		public void UpdateByResponse(CombatEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(CombatEventReceiveEventLocationRewardResponse res)
		{
		}

		public void UpdateByResponse(CombatEventReceiveEventPointRewardResponse res)
		{
		}

		public void UpdateByResponse(CraftAssembleResponse res)
		{
		}

		public void UpdateByResponse(CraftCreateResponse res)
		{
		}

		public void UpdateByResponse(CraftDisassembleResponse res)
		{
		}

		public void UpdateByResponse(CraftResetNewResponse res)
		{
		}

		public void UpdateByResponse(DeployGetDeployVersionResponse res)
		{
		}

		public void UpdateByResponse(DmodeBuildupServitorPassiveResponse res)
		{
		}

		public void UpdateByResponse(DmodeDungeonFinishResponse res)
		{
		}

		public void UpdateByResponse(DmodeDungeonFloorResponse res)
		{
		}

		public void UpdateByResponse(DmodeDungeonFloorSkipResponse res)
		{
		}

		public void UpdateByResponse(DmodeDungeonRestartResponse res)
		{
		}

		public void UpdateByResponse(DmodeDungeonStartResponse res)
		{
		}

		public void UpdateByResponse(DmodeDungeonSystemHaltResponse res)
		{
		}

		public void UpdateByResponse(DmodeDungeonUserHaltResponse res)
		{
		}

		public void UpdateByResponse(DmodeEntryResponse res)
		{
		}

		public void UpdateByResponse(DmodeExpeditionFinishResponse res)
		{
		}

		public void UpdateByResponse(DmodeExpeditionForceFinishResponse res)
		{
		}

		public void UpdateByResponse(DmodeExpeditionStartResponse res)
		{
		}

		public void UpdateByResponse(DmodeGetDataResponse res)
		{
		}

		public void UpdateByResponse(DmodeReadStoryResponse res)
		{
		}

		public void UpdateByResponse(DragonBuildupResponse res)
		{
		}

		public void UpdateByResponse(DragonBuyGiftToSendResponse res)
		{
		}

		public void UpdateByResponse(DragonBuyGiftToSendMultipleResponse res)
		{
		}

		public void UpdateByResponse(DragonGetContactDataResponse res)
		{
		}

		public void UpdateByResponse(DragonLimitBreakResponse res)
		{
		}

		public void UpdateByResponse(DragonResetPlusCountResponse res)
		{
		}

		public void UpdateByResponse(DragonSellResponse res)
		{
		}

		public void UpdateByResponse(DragonSendGiftResponse res)
		{
		}

		public void UpdateByResponse(DragonSendGiftMultipleResponse res)
		{
		}

		public void UpdateByResponse(DragonSetLockResponse res)
		{
		}

		public void UpdateByResponse(DreamAdventureClearResponse res)
		{
		}

		public void UpdateByResponse(DreamAdventurePlayResponse res)
		{
		}

		public void UpdateByResponse(DungeonFailResponse res)
		{
		}

		public void UpdateByResponse(DungeonGetAreaOddsResponse res)
		{
		}

		public void UpdateByResponse(DungeonReceiveQuestBonusResponse res)
		{
		}

		public void UpdateByResponse(DungeonRecordRecordResponse res)
		{
		}

		public void UpdateByResponse(DungeonRecordRecordMultiResponse res)
		{
		}

		public void UpdateByResponse(DungeonRetryResponse res)
		{
		}

		public void UpdateByResponse(DungeonSkipStartResponse res)
		{
		}

		public void UpdateByResponse(DungeonSkipStartAssignUnitResponse res)
		{
		}

		public void UpdateByResponse(DungeonSkipStartMultipleQuestResponse res)
		{
		}

		public void UpdateByResponse(DungeonSkipStartMultipleQuestAssignUnitResponse res)
		{
		}

		public void UpdateByResponse(DungeonStartStartResponse res)
		{
		}

		public void UpdateByResponse(DungeonStartStartAssignUnitResponse res)
		{
		}

		public void UpdateByResponse(DungeonStartStartMultiResponse res)
		{
		}

		public void UpdateByResponse(DungeonStartStartMultiAssignUnitResponse res)
		{
		}

		public void UpdateByResponse(EarnEventEntryResponse res)
		{
		}

		public void UpdateByResponse(EarnEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(EarnEventReceiveEventPointRewardResponse res)
		{
		}

		public void UpdateByResponse(EmblemGetListResponse res)
		{
		}

		public void UpdateByResponse(EmblemSetResponse res)
		{
		}

		public void UpdateByResponse(EulaAgreeAgreeResponse res)
		{
		}

		public void UpdateByResponse(EulaGetVersionResponse res)
		{
		}

		public void UpdateByResponse(EulaGetVersionListResponse res)
		{
		}

		public void UpdateByResponse(EventDamageGetTotalDamageHistoryResponse res)
		{
		}

		public void UpdateByResponse(EventDamageReceiveDamageRewardResponse res)
		{
		}

		public void UpdateByResponse(EventStoryReadResponse res)
		{
		}

		public void UpdateByResponse(EventSummonExecResponse res)
		{
		}

		public void UpdateByResponse(EventSummonGetDataResponse res)
		{
		}

		public void UpdateByResponse(EventSummonResetResponse res)
		{
		}

		public void UpdateByResponse(EventTradeGetListResponse res)
		{
		}

		public void UpdateByResponse(EventTradeTradeResponse res)
		{
		}

		public void UpdateByResponse(ExHunterEventEntryResponse res)
		{
		}

		public void UpdateByResponse(ExHunterEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(ExHunterEventReceiveExHunterPointRewardResponse res)
		{
		}

		public void UpdateByResponse(ExRushEventEntryResponse res)
		{
		}

		public void UpdateByResponse(ExRushEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(ExchangeGetUnitListResponse res)
		{
		}

		public void UpdateByResponse(ExchangeSelectUnitResponse res)
		{
		}

		public void UpdateByResponse(FortAddCarpenterResponse res)
		{
		}

		public void UpdateByResponse(FortBuildAtOnceResponse res)
		{
		}

		public void UpdateByResponse(FortBuildCancelResponse res)
		{
		}

		public void UpdateByResponse(FortBuildEndResponse res)
		{
		}

		public void UpdateByResponse(FortBuildStartResponse res)
		{
		}

		public void UpdateByResponse(FortGetDataResponse res)
		{
		}

		public void UpdateByResponse(FortGetMultiIncomeResponse res)
		{
		}

		public void UpdateByResponse(FortLevelupAtOnceResponse res)
		{
		}

		public void UpdateByResponse(FortLevelupCancelResponse res)
		{
		}

		public void UpdateByResponse(FortLevelupEndResponse res)
		{
		}

		public void UpdateByResponse(FortLevelupStartResponse res)
		{
		}

		public void UpdateByResponse(FortMoveResponse res)
		{
		}

		public void UpdateByResponse(FortSetNewFortPlantResponse res)
		{
		}

		public void UpdateByResponse(FriendAllReplyDenyResponse res)
		{
		}

		public void UpdateByResponse(FriendApplyListResponse res)
		{
		}

		public void UpdateByResponse(FriendAutoSearchResponse res)
		{
		}

		public void UpdateByResponse(FriendDeleteResponse res)
		{
		}

		public void UpdateByResponse(FriendFriendIndexResponse res)
		{
		}

		public void UpdateByResponse(FriendFriendListResponse res)
		{
		}

		public void UpdateByResponse(FriendGetSupportCharaResponse res)
		{
		}

		public void UpdateByResponse(FriendGetSupportCharaDetailResponse res)
		{
		}

		public void UpdateByResponse(FriendIdSearchResponse res)
		{
		}

		public void UpdateByResponse(FriendReplyResponse res)
		{
		}

		public void UpdateByResponse(FriendRequestResponse res)
		{
		}

		public void UpdateByResponse(FriendRequestCancelResponse res)
		{
		}

		public void UpdateByResponse(FriendRequestListResponse res)
		{
		}

		public void UpdateByResponse(FriendSetSupportCharaResponse res)
		{
		}

		public void UpdateByResponse(GuildChatGetNewMessageListResponse res)
		{
		}

		public void UpdateByResponse(GuildChatGetOldMessageListResponse res)
		{
		}

		public void UpdateByResponse(GuildChatPostMessageStampResponse res)
		{
		}

		public void UpdateByResponse(GuildChatPostMessageTextResponse res)
		{
		}

		public void UpdateByResponse(GuildChatPostReportResponse res)
		{
		}

		public void UpdateByResponse(GuildDisbandResponse res)
		{
		}

		public void UpdateByResponse(GuildDropMemberResponse res)
		{
		}

		public void UpdateByResponse(GuildEstablishResponse res)
		{
		}

		public void UpdateByResponse(GuildGetGuildApplyDataResponse res)
		{
		}

		public void UpdateByResponse(GuildGetGuildMemberDataResponse res)
		{
		}

		public void UpdateByResponse(GuildIndexResponse res)
		{
		}

		public void UpdateByResponse(GuildInviteGetGuildInviteReceiveDataResponse res)
		{
		}

		public void UpdateByResponse(GuildInviteGetGuildInviteSendDataResponse res)
		{
		}

		public void UpdateByResponse(GuildInviteInviteCancelResponse res)
		{
		}

		public void UpdateByResponse(GuildInviteInviteReplyResponse res)
		{
		}

		public void UpdateByResponse(GuildInviteInviteReplyAllDenyResponse res)
		{
		}

		public void UpdateByResponse(GuildInviteInviteSendResponse res)
		{
		}

		public void UpdateByResponse(GuildJoinResponse res)
		{
		}

		public void UpdateByResponse(GuildJoinReplyResponse res)
		{
		}

		public void UpdateByResponse(GuildJoinReplyAllDenyResponse res)
		{
		}

		public void UpdateByResponse(GuildJoinRequestResponse res)
		{
		}

		public void UpdateByResponse(GuildJoinRequestCancelResponse res)
		{
		}

		public void UpdateByResponse(GuildPostReportResponse res)
		{
		}

		public void UpdateByResponse(GuildResignResponse res)
		{
		}

		public void UpdateByResponse(GuildSearchAutoSearchResponse res)
		{
		}

		public void UpdateByResponse(GuildSearchGetGuildDetailResponse res)
		{
		}

		public void UpdateByResponse(GuildSearchIdSearchResponse res)
		{
		}

		public void UpdateByResponse(GuildSearchNameSearchResponse res)
		{
		}

		public void UpdateByResponse(GuildUpdateGuildPositionTypeResponse res)
		{
		}

		public void UpdateByResponse(GuildUpdateGuildSettingResponse res)
		{
		}

		public void UpdateByResponse(GuildUpdateUserSettingResponse res)
		{
		}

		public void UpdateByResponse(InquiryAggregationResponse res)
		{
		}

		public void UpdateByResponse(InquiryDetailResponse res)
		{
		}

		public void UpdateByResponse(InquiryReplyResponse res)
		{
		}

		public void UpdateByResponse(InquirySendResponse res)
		{
		}

		public void UpdateByResponse(InquiryTopResponse res)
		{
		}

		public void UpdateByResponse(ItemGetListResponse res)
		{
		}

		public void UpdateByResponse(ItemUseRecoveryStaminaResponse res)
		{
		}

		public void UpdateByResponse(LoadIndexResponse res)
		{
		}

		public void UpdateByResponse(LoginIndexResponse res)
		{
		}

		public void UpdateByResponse(LoginPenaltyConfirmResponse res)
		{
		}

		public void UpdateByResponse(LoginVerifyJwsResponse res)
		{
		}

		public void UpdateByResponse(LotteryGetOddsDataResponse res)
		{
		}

		public void UpdateByResponse(LotteryLotteryExecResponse res)
		{
		}

		public void UpdateByResponse(LotteryResultResponse res)
		{
		}

		public void UpdateByResponse(MaintenanceGetTextResponse res)
		{
		}

		public void UpdateByResponse(MatchingCheckPenaltyUserResponse res)
		{
		}

		public void UpdateByResponse(MatchingGetRoomListResponse res)
		{
		}

		public void UpdateByResponse(MatchingGetRoomListByGuildResponse res)
		{
		}

		public void UpdateByResponse(MatchingGetRoomListByLocationResponse res)
		{
		}

		public void UpdateByResponse(MatchingGetRoomListByQuestIdResponse res)
		{
		}

		public void UpdateByResponse(MatchingGetRoomNameResponse res)
		{
		}

		public void UpdateByResponse(MazeEventEntryResponse res)
		{
		}

		public void UpdateByResponse(MazeEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(MazeEventReceiveMazePointRewardResponse res)
		{
		}

		public void UpdateByResponse(MemoryEventActivateResponse res)
		{
		}

		public void UpdateByResponse(MissionGetDrillMissionListResponse res)
		{
		}

		public void UpdateByResponse(MissionGetMissionListResponse res)
		{
		}

		public void UpdateByResponse(MissionReceiveAlbumRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionReceiveBeginnerRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionReceiveDailyRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionReceiveDrillRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionReceiveMainStoryRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionReceiveMemoryEventRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionReceiveNormalRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionReceivePeriodRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionReceiveSpecialRewardResponse res)
		{
		}

		public void UpdateByResponse(MissionUnlockDrillMissionGroupResponse res)
		{
		}

		public void UpdateByResponse(MissionUnlockMainStoryGroupResponse res)
		{
		}

		public void UpdateByResponse(MypageInfoResponse res)
		{
		}

		public void UpdateByResponse(OptionGetOptionResponse res)
		{
		}

		public void UpdateByResponse(OptionSetOptionResponse res)
		{
		}

		public void UpdateByResponse(PartyIndexResponse res)
		{
		}

		public void UpdateByResponse(PartySetMainPartyNoResponse res)
		{
		}

		public void UpdateByResponse(PartySetPartySettingResponse res)
		{
		}

		public void UpdateByResponse(PartyUpdatePartyNameResponse res)
		{
		}

		public void UpdateByResponse(PlatformAchievementGetPlatformAchievementListResponse res)
		{
		}

		public void UpdateByResponse(PresentGetHistoryListResponse res)
		{
		}

		public void UpdateByResponse(PresentGetPresentListResponse res)
		{
		}

		public void UpdateByResponse(PresentReceiveResponse res)
		{
		}

		public void UpdateByResponse(PushNotificationUpdateSettingResponse res)
		{
		}

		public void UpdateByResponse(QuestDropListResponse res)
		{
		}

		public void UpdateByResponse(QuestGetQuestClearPartyResponse res)
		{
		}

		public void UpdateByResponse(QuestGetQuestClearPartyMultiResponse res)
		{
		}

		public void UpdateByResponse(QuestGetSupportUserListResponse res)
		{
		}

		public void UpdateByResponse(QuestOpenTreasureResponse res)
		{
		}

		public void UpdateByResponse(QuestReadStoryResponse res)
		{
		}

		public void UpdateByResponse(QuestSearchQuestClearPartyResponse res)
		{
		}

		public void UpdateByResponse(QuestSearchQuestClearPartyCharaResponse res)
		{
		}

		public void UpdateByResponse(QuestSearchQuestClearPartyCharaMultiResponse res)
		{
		}

		public void UpdateByResponse(QuestSearchQuestClearPartyMultiResponse res)
		{
		}

		public void UpdateByResponse(QuestSetQuestClearPartyResponse res)
		{
		}

		public void UpdateByResponse(QuestSetQuestClearPartyMultiResponse res)
		{
		}

		public void UpdateByResponse(RaidEventEntryResponse res)
		{
		}

		public void UpdateByResponse(RaidEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(RaidEventReceiveRaidPointRewardResponse res)
		{
		}

		public void UpdateByResponse(RedoableSummonFixExecResponse res)
		{
		}

		public void UpdateByResponse(RedoableSummonGetDataResponse res)
		{
		}

		public void UpdateByResponse(RedoableSummonPreExecResponse res)
		{
		}

		public void UpdateByResponse(RepeatEndResponse res)
		{
		}

		public void UpdateByResponse(ShopChargeCancelResponse res)
		{
		}

		public void UpdateByResponse(ShopGetBonusResponse res)
		{
		}

		public void UpdateByResponse(ShopGetDreamSelectUnitListResponse res)
		{
		}

		public void UpdateByResponse(ShopGetListResponse res)
		{
		}

		public void UpdateByResponse(ShopGetProductListResponse res)
		{
		}

		public void UpdateByResponse(ShopItemSummonExecResponse res)
		{
		}

		public void UpdateByResponse(ShopItemSummonOddResponse res)
		{
		}

		public void UpdateByResponse(ShopMaterialShopPurchaseResponse res)
		{
		}

		public void UpdateByResponse(ShopNormalShopPurchaseResponse res)
		{
		}

		public void UpdateByResponse(ShopPreChargeCheckResponse res)
		{
		}

		public void UpdateByResponse(ShopSpecialShopPurchaseResponse res)
		{
		}

		public void UpdateByResponse(SimpleEventEntryResponse res)
		{
		}

		public void UpdateByResponse(SimpleEventGetEventDataResponse res)
		{
		}

		public void UpdateByResponse(StampGetStampResponse res)
		{
		}

		public void UpdateByResponse(StampSetEquipStampResponse res)
		{
		}

		public void UpdateByResponse(StoryReadResponse res)
		{
		}

		public void UpdateByResponse(StorySkipSkipResponse res)
		{
		}

		public void UpdateByResponse(SuggestionGetCategoryListResponse res)
		{
		}

		public void UpdateByResponse(SuggestionSetResponse res)
		{
		}

		public void UpdateByResponse(SummonExcludeGetListResponse res)
		{
		}

		public void UpdateByResponse(SummonExcludeGetOddsDataResponse res)
		{
		}

		public void UpdateByResponse(SummonExcludeRequestResponse res)
		{
		}

		public void UpdateByResponse(SummonGetOddsDataResponse res)
		{
		}

		public void UpdateByResponse(SummonGetSummonHistoryResponse res)
		{
		}

		public void UpdateByResponse(SummonGetSummonListResponse res)
		{
		}

		public void UpdateByResponse(SummonGetSummonPointTradeResponse res)
		{
		}

		public void UpdateByResponse(SummonRequestResponse res)
		{
		}

		public void UpdateByResponse(SummonSummonPointTradeResponse res)
		{
		}

		public void UpdateByResponse(TalismanSellResponse res)
		{
		}

		public void UpdateByResponse(TalismanSetLockResponse res)
		{
		}

		public void UpdateByResponse(TimeAttackRankingGetDataResponse res)
		{
		}

		public void UpdateByResponse(TimeAttackRankingReceiveTierRewardResponse res)
		{
		}

		public void UpdateByResponse(ToolAuthResponse res)
		{
		}

		public void UpdateByResponse(ToolGetMaintenanceTimeResponse res)
		{
		}

		public void UpdateByResponse(ToolReauthResponse res)
		{
		}

		public void UpdateByResponse(ToolSignupResponse res)
		{
		}

		public void UpdateByResponse(TrackRecordUpdateProgressResponse res)
		{
		}

		public void UpdateByResponse(TransitionTransitionByNAccountResponse res)
		{
		}

		public void UpdateByResponse(TreasureTradeGetListResponse res)
		{
		}

		public void UpdateByResponse(TreasureTradeGetListAllResponse res)
		{
		}

		public void UpdateByResponse(TreasureTradeTradeResponse res)
		{
		}

		public void UpdateByResponse(TutorialUpdateFlagsResponse res)
		{
		}

		public void UpdateByResponse(TutorialUpdateStepResponse res)
		{
		}

		public void UpdateByResponse(UpdateNamechangeResponse res)
		{
		}

		public void UpdateByResponse(UpdateResetNewResponse res)
		{
		}

		public void UpdateByResponse(UserGetNAccountInfoResponse res)
		{
		}

		public void UpdateByResponse(UserLinkedNAccountResponse res)
		{
		}

		public void UpdateByResponse(UserOptInSettingResponse res)
		{
		}

		public void UpdateByResponse(UserRecoverStaminaByStoneResponse res)
		{
		}

		public void UpdateByResponse(UserWithdrawalResponse res)
		{
		}

		public void UpdateByResponse(VersionGetResourceVersionResponse res)
		{
		}

		public void UpdateByResponse(WalkerSendGiftMultipleResponse res)
		{
		}

		public void UpdateByResponse(WallFailResponse res)
		{
		}

		public void UpdateByResponse(WallGetMonthlyRewardResponse res)
		{
		}

		public void UpdateByResponse(WallGetWallClearPartyResponse res)
		{
		}

		public void UpdateByResponse(WallReceiveMonthlyRewardResponse res)
		{
		}

		public void UpdateByResponse(WallRecordRecordResponse res)
		{
		}

		public void UpdateByResponse(WallSetWallClearPartyResponse res)
		{
		}

		public void UpdateByResponse(WallStartStartResponse res)
		{
		}

		public void UpdateByResponse(WallStartStartAssignUnitResponse res)
		{
		}

		public void UpdateByResponse(WeaponBodyBuildupPieceResponse res)
		{
		}

		public void UpdateByResponse(WeaponBodyCraftResponse res)
		{
		}

		public void UpdateByResponse(WeaponBuildupResponse res)
		{
		}

		public void UpdateByResponse(WeaponLimitBreakResponse res)
		{
		}

		public void UpdateByResponse(WeaponResetPlusCountResponse res)
		{
		}

		public void UpdateByResponse(WeaponSellResponse res)
		{
		}

		public void UpdateByResponse(WeaponSetLockResponse res)
		{
		}

		public void UpdateByResponse(WebviewVersionUrlListResponse res)
		{
		}

		public void UpdateByUpdateDataList(UpdateDataList updateDataList)
		{
		}
	}
}
