using System;

namespace Gluon.Http
{
	public class DebugApi
	{
		private static Action onCallbackDelegate;

		public static void AddAbilityCrest(Action onCallback, int ability_crest_id)
		{
		}

		public static void AbilityCrestAddAll(Action onCallback, int grant_force)
		{
		}

		public static void AmuletAddAll(Action onCallback, int grant_force)
		{
		}

		public static void AddAmulet(Action onCallback, int amulet_id)
		{
		}

		public static void AddAstralItem(Action onCallback, int item_id, int count = 1)
		{
		}

		public static void AddAstralItemAll(Action onCallback, int count = 1)
		{
		}

		public static void UpdateAstralItem(Action onCallback, int item_id, int count = 1)
		{
		}

		public static void AllRelease(Action onCallback, int event_id)
		{
		}

		public static void CharaAddAll(Action onCallback, int grant_force)
		{
		}

		public static void AddChara(Action onCallback, int chara_id)
		{
		}

		public static void UpdateUnlockEditSkillAll(Action onCallback)
		{
		}

		public static void CombatEventUpdateEventDataAll(Action onCallback, int event_id, int add_point)
		{
		}

		public static void GetGeohash(Action onCallback, float latitude, float longitude)
		{
		}

		public static void GetDebugTime(Action onCallback)
		{
		}

		public static void ResetUserLoginLotteryTime(Action onCallback)
		{
		}

		public static void UpdateDmodeFloorSkipCount(Action onCallback, int floor_skip_count)
		{
		}

		public static void UpdateDmodePoint(Action onCallback, int dmode_point_1, int dmode_point_2)
		{
		}

		public static void UpdateDmodeRecoverCount(Action onCallback, int recovery_count)
		{
		}

		public static void UpdateDmodeServitorPassiveMax(Action onCallback)
		{
		}

		public static void DragonAddAll(Action onCallback, int grant_force)
		{
		}

		public static void AddDragon(Action onCallback, int dragon_id)
		{
		}

		public static void ResetDragonGiftShop(Action onCallback)
		{
		}

		public static void UpdateCountContact(Action onCallback, int count = 1)
		{
		}

		public static void UpdateDragonReliabilityAll(Action onCallback, int reliability_type)
		{
		}

		public static void Start(Action onCallback, int quest_id, int play_type, int party_no, int[] party_no_list, int bet_count, int repeat_state, ulong support_viewer_id, RepeatSetting repeat_setting)
		{
		}

		public static void StartAssignUnit(Action onCallback, int quest_id, int play_type, PartySettingList[] request_party_setting_list, int bet_count, int repeat_state, ulong support_viewer_id, RepeatSetting repeat_setting)
		{
		}

		public static void Record(Action onCallback, AtgenDebugDamageRecordLog damage_record_log)
		{
		}

		public static void EarnEventUpdateEventDataAll(Action onCallback, int event_id, int add_point)
		{
		}

		public static void Add(Action onCallback, int period_id)
		{
		}

		public static void Reset(Action onCallback, int period_id)
		{
		}

		public static void UpdateFortLevel(Action onCallback, int plant_id, int level)
		{
		}

		public static void UpdateUser(Action onCallback, int last_attend_time, int penalty_end_time)
		{
		}

		public static void HunterEventUpdateEventDataAll(Action onCallback, int event_id, int add_point)
		{
		}

		public static void AddItem(Action onCallback, int item_id, int count = 1)
		{
		}

		public static void AddMaterial(Action onCallback, int material_id, int count = 1)
		{
		}

		public static void GetPartyList(Action onCallback)
		{
		}

		public static void PartySetting(Action onCallback, DebugPartySettingList[] party_setting_list)
		{
		}

		public static void SetMaxPartyPower(Action onCallback, int party_power)
		{
		}

		public static void Callback(Action onCallback, string sku)
		{
		}

		public static void SetPresent(Action onCallback, int entity_type, int entity_id, int entity_quantity, bool is_limit)
		{
		}

		public static void ClearAll(Action onCallback)
		{
		}

		public static void ClearQuest(Action onCallback, int quest_id, int quest_type)
		{
		}

		public static void ClearQuestEventCount(Action onCallback, int quest_event_id)
		{
		}

		public static void DeleteAll(Action onCallback)
		{
		}

		public static void ReadStory(Action onCallback, int quest_story_id)
		{
		}

		public static void UpdateQuestIsAppearAll(Action onCallback)
		{
		}

		public static void RaidEventUpdateEventDataAll(Action onCallback, int event_id, int add_point)
		{
		}

		public static void AddSummonTicketAll(Action onCallback, int count = 1)
		{
		}

		public static void AddTicket(Action onCallback, int ticket_id, int count = 1)
		{
		}

		public static void UpdateSummonScoreAll(Action onCallback, int summon_score, int summon_count)
		{
		}

		public static void AddFreeStone(Action onCallback, int free_stone)
		{
		}

		public static void GetDiamond(Action onCallback, string baas_user_id)
		{
		}

		public static void IncreaseCoin(Action onCallback, int coin)
		{
		}

		public static void IncreaseCrystal(Action onCallback, int crystal)
		{
		}

		public static void IncreaseDewPoint(Action onCallback, int dew)
		{
		}

		public static void IncreaseDiamond(Action onCallback, string baas_user_id, int diamond)
		{
		}

		public static void IncreaseQuestSkipPoint(Action onCallback, int point)
		{
		}

		public static void RecoverStaminaMulti(Action onCallback, int stamina)
		{
		}

		public static void RecoverStaminaSingle(Action onCallback, int stamina)
		{
		}

		public static void UpdateCrystal(Action onCallback, int crystal)
		{
		}

		public static void UpdateDewPoint(Action onCallback, int dew)
		{
		}

		public static void UpdateManaPoint(Action onCallback, int mana_point)
		{
		}

		public static void UpdateQuestSkipPoint(Action onCallback, int point)
		{
		}

		public static void UpdateTutorialFlags(Action onCallback, int tutorial_flags)
		{
		}

		public static void UpdateTutorialStatus(Action onCallback, int tutorial_status)
		{
		}

		public static void UserExp(Action onCallback, int exp)
		{
		}

		public static void UserRank(Action onCallback, int rank)
		{
		}

		public static void WeaponAddAll(Action onCallback, int grant_force, int rarity)
		{
		}

		public static void AddWeapon(Action onCallback, int weapon_id)
		{
		}

		public static void WeaponBodyAddAll(Action onCallback, int grant_force, int rarity)
		{
		}

		public static void AddWeaponBody(Action onCallback, int weapon_body_id)
		{
		}

		public static void WeaponSkinAddAll(Action onCallback, int grant_force, int rarity)
		{
		}

		public static void AddWeaponSkin(Action onCallback, int weapon_skin_id)
		{
		}

		public static void Test1()
		{
		}

		public static void Test2()
		{
		}

		public static void Test3()
		{
		}

		public static void Test4()
		{
		}

		public static void Test5()
		{
		}

		public static void Test6()
		{
		}

		public static void Test7()
		{
		}

		public static void Test8()
		{
		}

		public static void Test9()
		{
		}

		public static void Test10()
		{
		}

		public static void Test11()
		{
		}
	}
}
