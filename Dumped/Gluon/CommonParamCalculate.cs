using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class CommonParamCalculate
	{
		public abstract class Common<T> where T : Common<T>, new()
		{
			private static readonly T instance;

			private static readonly float weaponBodyElementalBonus;

			public static T Instance => null;

			public static CommonCharaAbilityPlusParam GetCharaAbilityParam(CommonPartyPowerCalculateData charaData)
			{
				return null;
			}

			public static CommonCharaAbilityPlusParam GetCharaBuffReferenceAbilityParam(CommonPartyPowerCalculateData charaData, float totalAbilityHpPlus)
			{
				return null;
			}

			private static void RegistAmuletAbility(ref AbilityLimitCalculation calc, CommonPartyPowerCalculateData charaData, int typeNo, int num)
			{
			}

			public static CommonCharaAbilityPlusParam GetAmuletAbilityParam(CommonPartyPowerCalculateData charaData)
			{
				return null;
			}

			protected abstract void AddAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, ref CommonCharaAbilityPlusParam param);

			protected static void AddAbilityParameter(float rate, int variousId, ref CommonCharaAbilityPlusParam param)
			{
			}

			protected abstract void AddBuffReferenceAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, float totalAbilityHpPlus, ref CommonCharaAbilityPlusParam param);

			protected static void AddAmuletAbilityParameter(CommonPartyPowerCalculateData charaData, ref CommonCharaAbilityPlusParam param, int typeNo, int num)
			{
			}

			public static bool CheckAbilityCondition(int charaId, WeaponType weaponType)
			{
				return default(bool);
			}

			public static bool CheckAbilityCondition(int targetUnitType, int ownerUnitType, int charaId, int dragonId, ElementalType elementalType)
			{
				return default(bool);
			}

			protected static ElementalType GetElementalType(int unitType, int charaId, int dragonId)
			{
				return default(ElementalType);
			}

			public static CommonCharaAbilityPlusParam GetWeaponAbilityParam(CommonPartyPowerCalculateData charaData)
			{
				return null;
			}

			public static CommonCharaAbilityPlusParam GetDragonAbilityParam(CommonPartyPowerCalculateData charaData)
			{
				return null;
			}

			public static int GetDefaultWeaponSkinId(int weapon_body_id, int limit_over_count)
			{
				return default(int);
			}

			public static int[] GetWeaponBodyBuildupAddMaxValueCheckPointList(int rarity)
			{
				return null;
			}

			public static int GetWeaponBodyHp(int weaponBodyId, int buildupCount, ElementalType charaElement = ElementalType.NONE)
			{
				return default(int);
			}

			public static int GetWeaponBodyAtk(int weaponBodyId, int buildupCount, ElementalType charaElement = ElementalType.NONE)
			{
				return default(int);
			}

			public static int GetAbilityCrestHp(int abilityCrestId, int buildupCount, int plus = 0)
			{
				return default(int);
			}

			public static int GetAbilityCrestAtk(int abilityCrestId, int buildupCount, int plus = 0)
			{
				return default(int);
			}

			public static int GetWeaponBodySkillNo(int weaponBodyId, int limitOverCount)
			{
				return default(int);
			}

			public static int GetWeaponBodySkillLevel(int weaponBodyId, int limitBreakCount, int limitOverCount, int skillNo = -1)
			{
				return default(int);
			}

			public static int GetWeaponBodyAbilityLevel(int weaponBodyId, int limitOverCount, int ability_no)
			{
				return default(int);
			}

			public static int GetAbilityCrestAbilityLevel(int abilityCrestId, int limitBreakCount, int abilityNo)
			{
				return default(int);
			}
		}

		public class InGame : Common<InGame>
		{
			protected override void AddAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, ref CommonCharaAbilityPlusParam param)
			{
			}

			protected override void AddBuffReferenceAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, float totalAbilityHpPlus, ref CommonCharaAbilityPlusParam param)
			{
			}
		}

		public class OutGame : Common<OutGame>
		{
			public enum EventBonusStatus
			{
				None,
				NoEffect,
				Effective
			}

			public enum ManaCircleTextColor
			{
				White,
				Yellow,
				Aqua
			}

			public const float partyPowerAtkWeight = 1f;

			public const float partyPowerHpWeight = 1f;

			public const float exAbilityPowerWeight = 1f;

			public const float exAbility2PowerWeight = 1f;

			public const float abilityPowerWeight = 1f;

			public const float dragonReliabilityPowerWeight = 10f;

			private static readonly float elementalBonus;

			public const float bustAttackPowerWeight = 60f;

			public const float comboPowerWeight = 200f;

			public const float charaSkillPowerWeight = 100f;

			public const float weaponSkillPowerWeight = 50f;

			public const float dragonSkillPowerWeight = 50f;

			public const float shareSkillPower = 100f;

			private const int LevelPhase1MaxLevel = 80;

			private const int LevelPhase2MaxLevel = 100;

			public static int GetCharaAtkParam(int masterDataId, int level, int plus = 0, int rarity = 3)
			{
				return default(int);
			}

			public static int GetCharaHpParam(int masterDataId, int level, int plus = 0, int rarity = 3)
			{
				return default(int);
			}

			private static int CalcGrowthParameterBase(int current_level, int max_rarity_limit_level, int current_rarity_min_value, int max_rarity_min_value, int max_rarity_max_value)
			{
				return default(int);
			}

			private static int CalcGrowthParameterByAdditionalPhase(int current_level, int before_phase_max_level, int current_phase_max_level, int max_additional_value)
			{
				return default(int);
			}

			public static int GetCharaDefParam(int masterDataId, int level, int plus = 0, int rarity = 3)
			{
				return default(int);
			}

			public static int GetCharaGrowDefParam(int masterDataId, int level, int plus = 0, int rarity = 0)
			{
				return default(int);
			}

			public static int GetDragonAtkParam(int masterDataId, int level, int plus = 0, ElementalType charaElement = ElementalType.NONE)
			{
				return default(int);
			}

			public static int GetDragonDefParam(int masterDataId, int level, int plus = 0)
			{
				return default(int);
			}

			public static int GetDragonHpParam(int masterDataId, int level, int plus = 0, ElementalType charaElement = ElementalType.NONE)
			{
				return default(int);
			}

			public static int GetWeaponDefParam(int masterDataId, int level, int plus = 0)
			{
				return default(int);
			}

			public static int GetAmuletAtkParam(int masterDataId, int level, int plus = 0)
			{
				return default(int);
			}

			public static int GetAmuletHpParam(int masterDataId, int level, int plus = 0)
			{
				return default(int);
			}

			public static int GetFortBonusCharaHpParam(int charaKeyId, int charaHp = 0)
			{
				return default(int);
			}

			public static int GetAlbumBonusCharaHpParam(int charaKeyId, int charaHp = 0)
			{
				return default(int);
			}

			public static float GetFortBonusHpParam(int charaKeyId)
			{
				return default(float);
			}

			public static float GetAlbumBonusHpParam(int charaKeyId)
			{
				return default(float);
			}

			public static int GetFortBonusCharaAtkParam(int charaKeyId, int charaAtk = 0)
			{
				return default(int);
			}

			public static int GetAlbumBonusCharaAtkParam(int charaKeyId, int charaAtk = 0)
			{
				return default(int);
			}

			public static float GetFortBonusAtkParam(int charaKeyId)
			{
				return default(float);
			}

			public static float GetAlbumBonusAtkParam(int charaKeyId)
			{
				return default(float);
			}

			public static int GetFortBonusCharaDefParam(int charaKeyId)
			{
				return default(int);
			}

			public static int GetAlbumBonusCharaDefParam(int charaKeyId)
			{
				return default(int);
			}

			public static float GetFortBonusDefParam(int charaKeyId)
			{
				return default(float);
			}

			public static int GetFortBonusCharaHpParam(int charaId, int charaHp, FortBonusList fortBonus)
			{
				return default(int);
			}

			public static int GetFortBonusCharaAtkParam(int charaId, int charaAttack, FortBonusList fortBonus)
			{
				return default(int);
			}

			public static int GetAlbumBonusCharaHpParam(int charaId, int charaHp, FortBonusList fortBonus)
			{
				return default(int);
			}

			public static int GetAlbumBonusCharaAtkParam(int charaId, int charaAttack, FortBonusList fortBonus)
			{
				return default(int);
			}

			public static CommonCharaAbilityPlusParam GetCharaExAbilityParam(CommonPartyPowerCalculateData[] partyData, int index)
			{
				return null;
			}

			protected override void AddAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, ref CommonCharaAbilityPlusParam param)
			{
			}

			protected override void AddBuffReferenceAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, float totalAbilityHpPlus, ref CommonCharaAbilityPlusParam param)
			{
			}

			private void AddBuffReferenceAbilityParameter(int ownerUnitType, CommonPartyPowerCalculateData charaData, AbilityDataElement masterAbilityData, int performanceIdx, float totalAbilityHpPlus, ref CommonCharaAbilityPlusParam param)
			{
			}

			public static CommonCharaAbilityPlusParam GetStatusPlusParam()
			{
				return null;
			}

			public static CommonCharaExAbilityData[] GetPartyExAbilityDatas(PartyList partyList)
			{
				return null;
			}

			public static CommonCharaExAbilityData[] GetPartyExAbilityDatas(CommonPartyPowerCalculateData[] partyData)
			{
				return null;
			}

			public static CommonCharaExAbilityData[] GetPartyExAbilityDatas(List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas)
			{
				return null;
			}

			public static bool CheckExAbilityCondition(int targetUnitType, ElementalType targetElement, int charaId)
			{
				return default(bool);
			}

			public static CommonCharaExAbilityData[] GetPartyExAbility2Datas(CommonPartyPowerCalculateData[] partyData)
			{
				return null;
			}

			public static CommonCharaExAbilityData[] GetPartyExAbility2Datas(List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas)
			{
				return null;
			}

			public static CommonPartyPowerCalculateData[] ConvertPartyPowerCalculateData(PartyList partyInfo)
			{
				return null;
			}

			public static void ConvertPartyPowerCalculateData(PartySettingList settingInfo, CommonPartyPowerCalculateData outData)
			{
			}

			public static void ConvertPartyPowerCalculateData(int charaId, int weaponBodyId, ulong dragonKeyId, int skill3CharaId, int skill4CharaId, int type1crest1, int type1crest2, int type1crest3, int type2crest1, int type2crest2, int type3crest1, int type3crest2, CommonPartyPowerCalculateData outData)
			{
			}

			public static MatchingRoomDetailData[] CreateMatchingRoomDetailData(PartyList partyInfo)
			{
				return null;
			}

			private static MatchingRoomDetailData CreateCharaDetailData(PartySettingList settingInfo)
			{
				return null;
			}

			public static int GetPartyPowerParam(PartyList partyInfo, int eventId = 0)
			{
				return default(int);
			}

			public static int GetCharacterPowerParam(PartySettingList partySetting)
			{
				return default(int);
			}

			public static int GetPartyPowerParam(CommonPartyPowerCalculateData[] partyDatas, int eventId = 0)
			{
				return default(int);
			}

			public static float GetCharacterPowerParam(CommonPartyPowerCalculateData partyData, out float totalUnitAtk, out float totalUnitHp)
			{
				return default(float);
			}

			public static float GetRaidBoostPowerParam(int eventId, float totalPartyAtk, float totalPartyHp)
			{
				return default(float);
			}

			public static float GetUnionBonusPartyPowerParam(int type1crest1Id, int type1crest1Lv, int type1crest2Id, int type1crest2Lv, int type1crest3Id, int type1crest3Lv, int type2crest1Id, int type2crest1Lv, int type2crest2Id, int type2crest2Lv, int type3crest1Id, int type3crest1Lv, int type3crest2Id, int type3crest2Lv)
			{
				return default(float);
			}

			public static float GetExAbilityPartyPower(CommonPartyPowerCalculateData charaData)
			{
				return default(float);
			}

			public static float GetAbilityPartyPower(CommonPartyPowerCalculateData charaData)
			{
				return default(float);
			}

			public static float GetCommonAbilityPartyPower(int[] abilityIdList)
			{
				return default(float);
			}

			public static int GetCharaPartyPower(ulong keyId, int charaHp = 0, int charaAtk = 0)
			{
				return default(int);
			}

			public static int GetWeaponPartyPower(ulong keyId, int weaponHp = 0, int weaponAtk = 0)
			{
				return default(int);
			}

			public static int GetDragonPartyPower(ulong keyId, int dragonLv = 0, int dragonHpPlus = 0, int dragonAtkPlus = 0)
			{
				return default(int);
			}

			public static int GetCrestPartyPower(ulong keyId, int crestHp = 0, int crestAtk = 0)
			{
				return default(int);
			}

			public static UserLevelElement GetPlayerLevelElementByExp(int exp, out int remainExp, int startLevel = 1)
			{
				return null;
			}

			public static CharaLevelElement GetCharaLevelElementByExp(int exp, out int remainExp, int maxLevel = 100, int startLevel = 1)
			{
				return null;
			}

			public static DragonLevelElement GetDragonLevelElementByExp(int exp, out int remainExp, int maxLevel = 100, int startLevel = 1)
			{
				return null;
			}

			public static AmuletLevelElement GetAmuletLevelElementByExp(int exp, out int remainExp, int maxLevel = 100, int startLevel = 1)
			{
				return null;
			}

			public static WeaponLevelElement GetWeaponLevelElementByExp(int exp, out int remainExp, int maxLevel = 100, int startLevel = 1)
			{
				return null;
			}

			public static MatchingRoomPlayerData GetMatchingRoomPlayerData(int eventId, int questId)
			{
				return null;
			}

			private static List<MatchingRoomPlayerData.CharaSimpleSyncData> CreateCharaSimpleSyncDatas(CommonPartyPowerCalculateData[] convertData)
			{
				return null;
			}

			public static MatchingRoomPlayerData GetMatchingRoomPlayerDataByIndex(int partyIndex)
			{
				return null;
			}

			public static float[] GetDragonFortBonusRelativeParam(int dragonId, [Optional] FortBonusList fortBonusList)
			{
				return null;
			}

			public static int[] GetDragonFortBonusParam(int masterDataId, int level, int hpPlus = 0, int atkPlus = 0, ElementalType charaElement = ElementalType.NONE, [Optional] FortBonusList fortBonus)
			{
				return null;
			}

			public static float[] GetDragonAlbumBonusRelativeParam(int dragonId, [Optional] FortBonusList fortBonusList)
			{
				return null;
			}

			public static int[] GetDragonAlbumBonusParam(int masterDataId, int level, int hpPlus = 0, int atkPlus = 0, ElementalType charaElement = ElementalType.NONE, [Optional] FortBonusList fortBonus)
			{
				return null;
			}

			public static bool IsPartyEventBonusAbilityOn(PartyList partyInfo, out List<EventBonusPopup.EventBonusCharaInfo> effectiveCharaList, int questId = -1)
			{
				return default(bool);
			}

			public static bool IsRaidBoostOn(int questId, [Optional] RaidBoostPopup.RaidBoostModel.CellData[] boostList, [Optional] RaidBoostPopup.RaidBoostModel.CellData[] rareBoost)
			{
				return default(bool);
			}

			public static bool IsEventBonusAbilityOn(UnitDetailDataWithEquip[] dataList, out List<EventBonusPopup.EventBonusCharaInfo> effectiveCharaList, int questId = -1)
			{
				return default(bool);
			}

			private static List<EventBonusPopup.EventBonusAbilityInfo> GetEventEffectiveAbilityList(int questId, List<EventBonusPopup.EventBonusAbilityInfo> abilityList)
			{
				return null;
			}

			public static int GetEventIdFromQuestId(int questId)
			{
				return default(int);
			}

			public static bool IsTargetEventOn(int questId = -1, bool includeMemoryEvent = true)
			{
				return default(bool);
			}

			public static bool IsFortEventBonusOn(int questId = -1)
			{
				return default(bool);
			}

			public static bool IsTreasureTimeOn(int questId = -1)
			{
				return default(bool);
			}

			private static int CeilToInt(float fparam, float digits = 3f)
			{
				return default(int);
			}

			public static int GetCharacterLimitLevel(CharaList userData)
			{
				return default(int);
			}

			public static int GetCharacterLimitLevel(CharaRarityElement rarityData, int additionalMaxLevel)
			{
				return default(int);
			}

			public static int GetCharacterMaxLimitLevel(CharaDataElement masterCharaData)
			{
				return default(int);
			}

			public static int GetCharacterMaxSkillLevel(bool isFirstSkill, int charaId)
			{
				return default(int);
			}

			public static int GetCharacterMaxManaCircleCount(int masterId, int rarity)
			{
				return default(int);
			}

			public static int GetCharacterMaxManaCircleCount(int rarity, CharaDataElement masterCharaData)
			{
				return default(int);
			}

			public static int CalcReleaseManaPieceCount(int charaId, int releaseMCCount, ManaPieceType manaPieceType)
			{
				return default(int);
			}

			public static ManaCircleTextColor GetManaCircleTextColor(int masterId, int rarity, int manaCircleCount, int limitBreak)
			{
				return default(ManaCircleTextColor);
			}

			public static ManaCircleTextColor GetWeaponBuildUpCountTextColor(int weaponBodyId, int buildupCount, int limitBreak)
			{
				return default(ManaCircleTextColor);
			}

			public static ManaCircleTextColor GetCrestBuildUpCountTextColor(int id, int buildupCount, int limitBreak)
			{
				return default(ManaCircleTextColor);
			}

			public static ManaCircleTextColor GetDragonLevelTextColor(int id, int level, int limitBreak)
			{
				return default(ManaCircleTextColor);
			}

			public static ManaCircleTextColor GetCharaLevelTextColor(int id, int level, int rarity, int additionalMaxLevel)
			{
				return default(ManaCircleTextColor);
			}

			public static List<CommonUnionAbilityData> GetEnabledUnionAbilityList(PartySettingList partySettingList)
			{
				return null;
			}
		}
	}
}
