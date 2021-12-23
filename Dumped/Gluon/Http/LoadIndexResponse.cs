namespace Gluon.Http
{
	public class LoadIndexResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserData user_data;

			public PartyPowerData party_power_data;

			public PartyList[] party_list;

			public CharaList[] chara_list;

			public DragonList[] dragon_list;

			public QuestList[] quest_list;

			public QuestEventList[] quest_event_list;

			public MaterialList[] material_list;

			public AstralItemList[] astral_item_list;

			public WeaponList[] weapon_list;

			public AlbumWeaponList[] album_weapon_list;

			public AmuletList[] amulet_list;

			public WeaponSkinList[] weapon_skin_list;

			public WeaponBodyList[] weapon_body_list;

			public WeaponPassiveAbilityList[] weapon_passive_ability_list;

			public AbilityCrestList[] ability_crest_list;

			public TalismanList[] talisman_list;

			public DragonReliabilityList[] dragon_reliability_list;

			public DragonGiftList[] dragon_gift_list;

			public AlbumDragonData[] album_dragon_list;

			public EquipStampList[] equip_stamp_list;

			public UnitStoryList[] unit_story_list;

			public CastleStoryList[] castle_story_list;

			public QuestStoryList[] quest_story_list;

			public QuestTreasureList[] quest_treasure_list;

			public QuestWallList[] quest_wall_list;

			public QuestCarryList[] quest_carry_list;

			public QuestEntryConditionList[] quest_entry_condition_list;

			public FortBonusList fort_bonus_list;

			public BuildList[] build_list;

			public CraftList[] craft_list;

			public UserSummonList[] user_summon_list;

			public SummonTicketList[] summon_ticket_list;

			public SummonPointList[] summon_point_list;

			public LotteryTicketList[] lottery_ticket_list;

			public ExchangeTicketList[] exchange_ticket_list;

			public GatherItemList[] gather_item_list;

			public FortPlantList[] fort_plant_list;

			public UserGuildData user_guild_data;

			public GuildData guild_data;

			public PresentNotice present_notice;

			public FriendNotice friend_notice;

			public MissionNotice mission_notice;

			public GuildNotice guild_notice;

			public ShopNotice shop_notice;

			public AlbumPassiveNotice album_passive_notice;

			public FunctionalMaintenanceList[] functional_maintenance_list;

			public TreasureTradeList[] treasure_trade_all_list;

			public UserTreasureTradeList[] user_treasure_trade_list;

			public ShopPurchaseList[] special_shop_purchase;

			public int stamina_single_recover_second;

			public int stamina_multi_user_max;

			public int stamina_multi_system_max;

			public int quest_skip_point_system_max;

			public int quest_skip_point_use_limit_max;

			public int spec_upgrade_time;

			public int server_time;

			public int quest_bonus_stack_base_time;

			public AtgenQuestBonus[] quest_bonus;

			public AtgenMultiServer multi_server;

			public AtgenWalkerData walker_data;
		}

		public CommonResponse data;
	}
}
