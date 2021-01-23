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
	public class CommonParamCalculate
	{
		// Nested types
		public abstract class Common<T>
			where T : Common<T>, new()
		{
			// Fields
			private static readonly T instance;
			private static readonly float weaponBodyElementalBonus;
	
			// Properties
			public static T Instance { get; }
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c<T> __9;
				public static Func<CommonPartyPowerCalculateAbilityCrestData, bool> __9__7_0;
				public static Func<CommonPartyPowerCalculateAbilityCrestData, bool> __9__7_1;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _GetAmuletAbilityParam_b__7_0(CommonPartyPowerCalculateAbilityCrestData item);
				internal bool _GetAmuletAbilityParam_b__7_1(CommonPartyPowerCalculateAbilityCrestData item);
			}
	
			// Constructors
			protected Common();
			static Common();
	
			// Methods
			public static CommonCharaAbilityPlusParam GetCharaAbilityParam(CommonPartyPowerCalculateData charaData);
			public static CommonCharaAbilityPlusParam GetCharaBuffReferenceAbilityParam(CommonPartyPowerCalculateData charaData, float totalAbilityHpPlus);
			private static void RegistAmuletAbility(ref AbilityLimitCalculation calc, CommonPartyPowerCalculateData charaData, int typeNo, int num);
			public static CommonCharaAbilityPlusParam GetAmuletAbilityParam(CommonPartyPowerCalculateData charaData);
			protected abstract void AddAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, ref CommonCharaAbilityPlusParam param);
			protected static void AddAbilityParameter(float rate, int variousId, ref CommonCharaAbilityPlusParam param);
			protected abstract void AddBuffReferenceAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, float totalAbilityHpPlus, ref CommonCharaAbilityPlusParam param);
			protected static void AddAmuletAbilityParameter(CommonPartyPowerCalculateData charaData, ref CommonCharaAbilityPlusParam param, int typeNo, int num);
			public static bool CheckAbilityCondition(int charaId, WeaponType weaponType);
			public static bool CheckAbilityCondition(int targetUnitType, int ownerUnitType, int charaId, int dragonId, ElementalType elementalType);
			protected static ElementalType GetElementalType(int unitType, int charaId, int dragonId);
			public static CommonCharaAbilityPlusParam GetWeaponAbilityParam(CommonPartyPowerCalculateData charaData);
			public static CommonCharaAbilityPlusParam GetDragonAbilityParam(CommonPartyPowerCalculateData charaData);
			public static int GetDefaultWeaponSkinId(int weapon_body_id, int limit_over_count);
			public static int[] GetWeaponBodyBuildupAddMaxValueCheckPointList(int rarity);
			public static int GetWeaponBodyHp(int weaponBodyId, int buildupCount, ElementalType charaElement = ElementalType.NONE);
			public static int GetWeaponBodyAtk(int weaponBodyId, int buildupCount, ElementalType charaElement = ElementalType.NONE);
			public static int GetAbilityCrestHp(int abilityCrestId, int buildupCount, int plus = 0);
			public static int GetAbilityCrestAtk(int abilityCrestId, int buildupCount, int plus = 0);
			public static int GetWeaponBodySkillNo(int weaponBodyId, int limitOverCount);
			public static int GetWeaponBodySkillLevel(int weaponBodyId, int limitBreakCount, int limitOverCount, int skillNo = -1);
			public static int GetWeaponBodyAbilityLevel(int weaponBodyId, int limitOverCount, int ability_no);
			public static int GetAbilityCrestAbilityLevel(int abilityCrestId, int limitBreakCount, int abilityNo);
		}
	
		public class InGame : Common<InGame>
		{
			// Constructors
			public InGame();
	
			// Methods
			protected override void AddAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, ref CommonCharaAbilityPlusParam param);
			protected override void AddBuffReferenceAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, float totalAbilityHpPlus, ref CommonCharaAbilityPlusParam param);
		}
	
		public class OutGame : Common<OutGame>
		{
			// Fields
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
	
			// Nested types
			public enum EventBonusStatus
			{
				None = 0,
				NoEffect = 1,
				Effective = 2
			}
	
			public enum ManaCircleTextColor
			{
				White = 0,
				Yellow = 1,
				Aqua = 2
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Func<EventBonusPopup.EventBonusAbilityInfo, bool> __9__73_0;
				public static Func<char, bool> __9__85_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _IsEventBonusAbilityOn_b__73_0(EventBonusPopup.EventBonusAbilityInfo x);
				internal bool _GetCharacterMaxManaCircleCount_b__85_0(char c);
			}
	
			// Constructors
			public OutGame();
			static OutGame();
	
			// Methods
			public static int GetCharaAtkParam(int masterDataId, int level, int plus = 0, int rarity = 3);
			public static int GetCharaHpParam(int masterDataId, int level, int plus = 0, int rarity = 3);
			private static int CalcGrowthParameterBase(int current_level, int max_rarity_limit_level, int current_rarity_min_value, int max_rarity_min_value, int max_rarity_max_value);
			private static int CalcGrowthParameterByAdditionalPhase(int current_level, int before_phase_max_level, int current_phase_max_level, int max_additional_value);
			public static int GetCharaDefParam(int masterDataId, int level, int plus = 0, int rarity = 3);
			public static int GetCharaGrowDefParam(int masterDataId, int level, int plus = 0, int rarity = 0);
			public static int GetDragonAtkParam(int masterDataId, int level, int plus = 0, ElementalType charaElement = ElementalType.NONE);
			public static int GetDragonDefParam(int masterDataId, int level, int plus = 0);
			public static int GetDragonHpParam(int masterDataId, int level, int plus = 0, ElementalType charaElement = ElementalType.NONE);
			public static int GetWeaponDefParam(int masterDataId, int level, int plus = 0);
			public static int GetAmuletAtkParam(int masterDataId, int level, int plus = 0);
			public static int GetAmuletHpParam(int masterDataId, int level, int plus = 0);
			public static int GetFortBonusCharaHpParam(int charaKeyId, int charaHp = 0);
			public static float GetFortBonusHpParam(int charaKeyId);
			public static int GetFortBonusCharaAtkParam(int charaKeyId, int charaAtk = 0);
			public static float GetFortBonusAtkParam(int charaKeyId);
			public static int GetFortBonusCharaDefParam(int charaKeyId);
			public static float GetFortBonusDefParam(int charaKeyId);
			public static int GetFortBonusCharaHpParam(int charaId, int charaHp, FortBonusList fortBonus);
			public static int GetFortBonusCharaAtkParam(int charaId, int charaAttack, FortBonusList fortBonus);
			public static CommonCharaAbilityPlusParam GetCharaExAbilityParam(CommonPartyPowerCalculateData[] partyData, int index);
			protected override void AddAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, ref CommonCharaAbilityPlusParam param);
			protected override void AddBuffReferenceAbilityParameter(int abilityId, int ownerUnitType, CommonPartyPowerCalculateData charaData, float totalAbilityHpPlus, ref CommonCharaAbilityPlusParam param);
			private void AddBuffReferenceAbilityParameter(int ownerUnitType, CommonPartyPowerCalculateData charaData, AbilityDataElement masterAbilityData, int performanceIdx, float totalAbilityHpPlus, ref CommonCharaAbilityPlusParam param);
			public static CommonCharaAbilityPlusParam GetStatusPlusParam();
			public static CommonCharaExAbilityData[] GetPartyExAbilityDatas(PartyList partyList);
			public static CommonCharaExAbilityData[] GetPartyExAbilityDatas(CommonPartyPowerCalculateData[] partyData);
			public static bool CheckExAbilityCondition(int targetUnitType, ElementalType targetElement, int charaId);
			public static CommonCharaExAbilityData[] GetPartyExAbility2Datas(CommonPartyPowerCalculateData[] partyData);
			public static CommonPartyPowerCalculateData[] ConvertPartyPowerCalculateData(PartyList partyInfo);
			public static void ConvertPartyPowerCalculateData(PartySettingList settingInfo, CommonPartyPowerCalculateData outData);
			public static void ConvertPartyPowerCalculateData(int charaId, int weaponBodyId, ulong dragonKeyId, int skill3CharaId, int skill4CharaId, int type1crest1, int type1crest2, int type1crest3, int type2crest1, int type2crest2, CommonPartyPowerCalculateData outData);
			public static MatchingRoomDetailData[] CreateMatchingRoomDetailData(PartyList partyInfo);
			public static int GetPartyPowerParam(PartyList partyInfo, int eventId = 0);
			public static int GetCharacterPowerParam(PartySettingList partySetting);
			public static int GetPartyPowerParam(CommonPartyPowerCalculateData[] partyDatas, int eventId = 0);
			public static float GetCharacterPowerParam(CommonPartyPowerCalculateData partyData, out float totalUnitAtk, out float totalUnitHp);
			public static float GetRaidBoostPowerParam(int eventId, float totalPartyAtk, float totalPartyHp);
			public static float GetUnionBonusPartyPowerParam(int type1crest1Id, int type1crest2Id, int type1crest3Id, int type2crest1Id, int type2crest2Id);
			public static float GetExAbilityPartyPower(CommonPartyPowerCalculateData charaData);
			public static float GetAbilityPartyPower(CommonPartyPowerCalculateData charaData);
			public static float GetCommonAbilityPartyPower(int[] abilityIdList);
			public static int GetCharaPartyPower(ulong keyId, int charaHp = 0, int charaAtk = 0);
			public static int GetWeaponPartyPower(ulong keyId, int weaponHp = 0, int weaponAtk = 0);
			public static int GetDragonPartyPower(ulong keyId, int dragonLv = 0, int dragonHpPlus = 0, int dragonAtkPlus = 0);
			public static int GetCrestPartyPower(ulong keyId, int crestHp = 0, int crestAtk = 0);
			public static UserLevelElement GetPlayerLevelElementByExp(int exp, out int remainExp, int startLevel = 1);
			public static CharaLevelElement GetCharaLevelElementByExp(int exp, out int remainExp, int maxLevel = 100, int startLevel = 1);
			public static DragonLevelElement GetDragonLevelElementByExp(int exp, out int remainExp, int maxLevel = 100, int startLevel = 1);
			public static AmuletLevelElement GetAmuletLevelElementByExp(int exp, out int remainExp, int maxLevel = 100, int startLevel = 1);
			public static WeaponLevelElement GetWeaponLevelElementByExp(int exp, out int remainExp, int maxLevel = 100, int startLevel = 1);
			public static MatchingRoomPlayerData GetMatchingRoomPlayerData(int eventId);
			public static MatchingRoomPlayerData GetMatchingRoomPlayerDataByIndex(int partyIndex);
			public static float[] GetDragonFortBonusRelativeParam(int dragonId, FortBonusList fortBonusList = null);
			public static int[] GetDragonFortBonusParam(int masterDataId, int level, int hpPlus = 0, int atkPlus = 0, ElementalType charaElement = ElementalType.NONE, FortBonusList fortBonus = null);
			public static bool IsPartyEventBonusAbilityOn(PartyList partyInfo, out List<EventBonusPopup.EventBonusCharaInfo> effectiveCharaList, int questId = -1);
			public static bool IsRaidBoostOn(int questId, RaidBoostPopup.RaidBoostModel.CellData[] boostList = null, RaidBoostPopup.RaidBoostModel.CellData[] rareBoost = null);
			public static bool IsEventBonusAbilityOn(UnitDetailDataWithEquip[] dataList, out List<EventBonusPopup.EventBonusCharaInfo> effectiveCharaList, int questId = -1);
			private static List<EventBonusPopup.EventBonusAbilityInfo> GetEventEffectiveAbilityList(int questId, List<EventBonusPopup.EventBonusAbilityInfo> abilityList);
			public static int GetEventIdFromQuestId(int questId);
			public static bool IsTargetEventOn(int questId = -1, bool includeMemoryEvent = true);
			public static bool IsFortEventBonusOn(int questId = -1);
			public static bool IsTreasureTimeOn(int questId = -1);
			private static int CeilToInt(float fparam, float digits = 3f);
			public static int GetCharacterLimitLevel(CharaList userData);
			public static int GetCharacterLimitLevel(CharaRarityElement rarityData, int additionalMaxLevel);
			public static int GetCharacterMaxLimitLevel(CharaDataElement masterCharaData);
			public static int GetCharacterMaxSkillLevel(bool isFirstSkill, int charaId);
			public static int GetCharacterMaxManaCircleCount(int masterId, int rarity);
			public static int GetCharacterMaxManaCircleCount(int rarity, CharaDataElement masterCharaData);
			public static ManaCircleTextColor GetManaCircleTextColor(int masterId, int rarity, int manaCircleCount, int limitBreak);
			public static ManaCircleTextColor GetWeaponBuildUpCountTextColor(int weaponBodyId, int buildupCount, int limitBreak);
			public static ManaCircleTextColor GetCrestBuildUpCountTextColor(int id, int buildupCount, int limitBreak);
			public static List<CommonUnionAbilityData> GetEnabledUnionAbilityList(PartySettingList partySettingList);
		}
	
		// Constructors
		public CommonParamCalculate();
	}
}
