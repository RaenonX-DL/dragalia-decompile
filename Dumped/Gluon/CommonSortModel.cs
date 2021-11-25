using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class CommonSortModel
	{
		[Serializable]
		public class Condition
		{
			[Serializable]
			public class FilterCondition
			{
				[Serializable]
				public class AbilityTypeFilter
				{
					public enum AbilityTypeForFilter
					{
						None = 0,
						PoisonResist = 10201,
						BurnResist = 10202,
						FreezeResist = 10203,
						ParalysisResist = 10204,
						DarkResist = 10205,
						SwoonResist = 10206,
						CurseResist = 10207,
						SlowModeResist = 10209,
						SleepResist = 10210,
						TribeKiller = 10401,
						TribeAnti = 10501,
						StatusUp = 10199,
						Others = 19901,
						EventSpecific = 19801,
						MemoryEventSpecific = 19899,
						Debuff = 10699,
						AttackUp = 10101,
						DefenseUp = 10102,
						RecoveryUp = 10103,
						SupportUp = 10104,
						FireElemResist = 10301,
						WaterElemResist = 10302,
						WindElemResist = 10303,
						LightElemResist = 10304,
						DarkElemResist = 10305,
						AttackAttackUp = 20101,
						AttackCriticalUp = 20102,
						AttackCriticalDamage = 20103,
						AttackBusrtAttack = 20104,
						AttackOthers = 20105,
						DefendDefenseUp = 20201,
						DefendDamageDown = 20202,
						DefendShield = 20203,
						DefendOthers = 20204,
						SkillSkillBoost = 20301,
						SkillSkillDamage = 20302,
						SkillFirstGauge = 20303,
						SkillHealPowerUp = 20304,
						SkillIncreaseTime = 20305,
						SkillOthers = 20306,
						DragonizeDamageUp = 20401,
						DragonizeChangingTime = 20402,
						DragonizeGaugeBoost = 20403,
						HealHeal = 20501,
						EventEventSpecific = 20601,
						EventMemoryEventSpecific = 20699,
						RegistRegistAbnormal = 20701,
						RegistCutAbnormal = 20702,
						OthersOthers = 20801
					}

					private static List<AbilityTypeForFilter> filterList;

					[SerializeField]
					private List<bool> filterFlagList;

					static AbilityTypeFilter()
					{
					}

					public AbilityTypeFilter MakeClone()
					{
						return null;
					}

					public void ChangeAllState(bool value)
					{
					}

					public bool IsAllOn()
					{
						return default(bool);
					}

					public bool IsAllOff()
					{
						return default(bool);
					}

					public bool CheckIsFlagOn(AbilityTypeForFilter type)
					{
						return default(bool);
					}

					public void SetFlag(AbilityTypeForFilter type, bool value)
					{
					}

					public bool ShouldRawValueListPass(List<AbilityTypeForFilter> rawValueList)
					{
						return default(bool);
					}

					private bool DoesFilterPass(List<AbilityTypeForFilter> rawValueList, AbilityTypeForFilter filter)
					{
						return default(bool);
					}

					private bool ShouldAbilityListPass(List<int> abilityIdList, GiftType giftType)
					{
						return default(bool);
					}

					public bool ShouldCharacterPass(int masterId, int[] abilityLevels, bool ability2Enabled = true, bool ability3Enabled = true)
					{
						return default(bool);
					}

					public bool ShouldDragonPass(int masterId, int[] abilityLevels, bool ability2Enabled = true)
					{
						return default(bool);
					}

					public bool ShouldAmuletPass(int masterId, bool ability2Enabled = true, bool ability3Enabled = true)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class ObtainedItemFilter
				{
					public bool showObtainedItem;

					public ObtainedItemFilter MakeClone()
					{
						return null;
					}

					public bool ShouldCharacterPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldDragonPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldCrestPass(int masterId)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class ElementalFilter
				{
					public bool fire;

					public bool water;

					public bool wind;

					public bool light;

					public bool dark;

					public bool noElement;

					public ElementalFilter MakeClone()
					{
						return null;
					}

					public void ChangeAllState(bool value, bool shouldIgnoreNoElement = false)
					{
					}

					public bool IsAllOn(bool shouldIgnoreNoElement = false)
					{
						return default(bool);
					}

					public bool IsAllOff(bool shouldIgnoreNoElement = false)
					{
						return default(bool);
					}

					public bool ShouldRawValuePass(ElementalType type)
					{
						return default(bool);
					}

					public bool ShouldCharacterPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldDragonPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldWeaponPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldWeaponSkinPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldAmuletPass(int masterId)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class WeaponTypeFilter
				{
					public bool swd;

					public bool kat;

					public bool dag;

					public bool axe;

					public bool lan;

					public bool bow;

					public bool rod;

					public bool can;

					public bool gun;

					[NonSerialized]
					public bool ignoreWeaponFilterForWeapon;

					public WeaponTypeFilter MakeClone()
					{
						return null;
					}

					public void ChangeAllState(bool value)
					{
					}

					public bool IsAllOn()
					{
						return default(bool);
					}

					public bool IsAllOff()
					{
						return default(bool);
					}

					public void SetRawValue(bool isOn, WeaponType weaponType)
					{
					}

					public bool ShouldRawValuePass(WeaponType type)
					{
						return default(bool);
					}

					public bool ShouldCharacterPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldWeaponPass(int masterId)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class WeaponUpgradableFilter
				{
					public bool upgradable;

					public WeaponUpgradableFilter MakeClone()
					{
						return null;
					}

					public void ChangeAllState(bool value)
					{
					}

					public bool IsAllOn()
					{
						return default(bool);
					}

					public bool IsAllOff()
					{
						return default(bool);
					}

					public bool ShouldWeaponPass(int masterId)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class ExAbilityTypeFilter
				{
					public enum ExAbilityTypeForFilter
					{
						None = 0,
						Others = 19901,
						AttackUp = 10101,
						DefenseUp = 10102,
						RecoveryUp = 10103,
						SupportUp = 10104
					}

					public bool others;

					public bool attackUp;

					public bool defenseUp;

					public bool recoveryUp;

					public bool supportUp;

					public ExAbilityTypeFilter MakeClone()
					{
						return null;
					}

					public void ChangeAllState(bool value)
					{
					}

					public bool IsAllOn()
					{
						return default(bool);
					}

					public bool IsAllOff()
					{
						return default(bool);
					}

					public bool CheckIsFlagOn(ExAbilityTypeForFilter type)
					{
						return default(bool);
					}

					public bool ShouldRawValueListPass(List<ExAbilityTypeForFilter> rawValueList)
					{
						return default(bool);
					}

					public bool ShouldExAbilityListPass(int abilityId)
					{
						return default(bool);
					}

					public bool ShouldCharacterPass(int masterId, int abilityLevel)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class CharaSkillTypeFilter
				{
					public enum CharaSkillTypeForFilter
					{
						None,
						AttackUp,
						DefenseUp,
						RecoveryUp,
						SupportUp,
						Others
					}

					public bool others;

					public bool attackUp;

					public bool defenseUp;

					public bool recoveryUp;

					public bool supportUp;

					public CharaSkillTypeFilter MakeClone()
					{
						return null;
					}

					public void ChangeAllState(bool value)
					{
					}

					public bool IsAllOn()
					{
						return default(bool);
					}

					public bool IsAllOff()
					{
						return default(bool);
					}

					public bool CheckIsFlagOn(CharaSkillTypeForFilter type)
					{
						return default(bool);
					}

					public bool ShouldRawValueListPass(List<CharaSkillTypeForFilter> rawValueList)
					{
						return default(bool);
					}

					public bool ShouldCharaSkillListPass(int skillId)
					{
						return default(bool);
					}

					public bool ShouldCharacterPass(int masterId)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class HpPlusParamFilter
				{
					public bool isHpPlus;

					public bool isAll;

					public HpPlusParamFilter MakeClone()
					{
						return null;
					}

					public bool ShouldRawValuePass(CommonSortSettingToggle.SortPlusParamType type)
					{
						return default(bool);
					}

					public bool ShouldUnitPass(int plusVal)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class AtkPlusParamFilter
				{
					public bool isAtkPlus;

					public bool isAll;

					public AtkPlusParamFilter MakeClone()
					{
						return null;
					}

					public bool ShouldRawValuePass(CommonSortSettingToggle.SortPlusParamType type)
					{
						return default(bool);
					}

					public bool ShouldUnitPass(int plusVal)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class UnionAbilityFilter
				{
					public bool[] unionAbilityList;

					public UnionAbilityFilter MakeClone()
					{
						return null;
					}

					public void ChangeAllState(bool value)
					{
					}

					public bool IsAllOn()
					{
						return default(bool);
					}

					public bool IsAllOff()
					{
						return default(bool);
					}

					public bool ShouldRawValuePass(int unionAbilityId)
					{
						return default(bool);
					}

					public bool ShouldAmuletPass(int abilityCrestId)
					{
						return default(bool);
					}
				}

				public ObtainedItemFilter obtainedItemFilter;

				public ElementalFilter elementalFilter;

				public WeaponTypeFilter weaponTypeFilter;

				public UnionAbilityFilter unionAbilityFilter;

				public AbilityTypeFilter abilityTypeFilter;

				public ExAbilityTypeFilter exAbilityTypeFilter;

				public CharaSkillTypeFilter charaSkillTypeFilter;

				public WeaponUpgradableFilter weaponUpgradableFilter;

				public HpPlusParamFilter hpPlusParamFilter;

				public AtkPlusParamFilter atkPlusParamFilter;

				public FilterCondition MakeClone()
				{
					return null;
				}

				public void ClearAllFilters()
				{
				}

				public List<ulong> ApplyFilterForSelfInBox(List<ulong> idList, GiftType giftType)
				{
					return null;
				}

				public List<ulong> ApplyFilter(List<ulong> idList, GiftType giftType)
				{
					return null;
				}

				public List<ulong> ApplyFilterForAlbumDragon(List<ulong> idList)
				{
					return null;
				}
			}

			[Serializable]
			public class SortCondition
			{
				public enum SortType
				{
					None,
					Elemental,
					WeaponType,
					Rarity,
					Ability,
					ExAbility,
					CharaType,
					Level,
					ManaCircle,
					Hp,
					Atk,
					BattlePower,
					GetTime,
					Reliability,
					LimitBreak,
					SkillType,
					SkillCost,
					HpPlusVal,
					AtkPlusVal,
					PieceNum,
					UnionAbility,
					Category
				}

				public enum SortOrder
				{
					None,
					Ascending,
					Descending
				}

				public class SectionInfo
				{
					public int abilityId;

					public string title;

					public List<ulong> itemList;

					public List<int> decoDisplayNum;
				}

				public class SortRawData
				{
					public ElementalType elemental;

					public WeaponType weaponType;

					public Rarity rarity;

					public List<int> abilityIdList;

					public int exAbilityId;

					public UnitType charaType;

					public int level;

					public int buildupCount;

					public int manaCircle;

					public int hp;

					public int atk;

					public int battlePower;

					public int getTime;

					public int reliability;

					public int limitBreak;

					public int hpPlusVal;

					public int atkPlusVal;

					public int skillType;

					public int editSkillCost;

					public int unionSortId;

					public int crestCategoryId;

					public int crestAbilityPriority;

					public string crestAbilityEffect;

					public bool isFavorite;

					public int masterId;

					public ulong id;

					public bool HasSortTargetAbility(SortType sortType, int abilityId)
					{
						return default(bool);
					}
				}

				public SortType sortType;

				public SortOrder sortOrder;

				public GiftType giftType;

				public ElementalType charaElement;

				public bool isPriorMatchElement;

				public bool isPriorFavorite;

				public SortCondition MakeClone()
				{
					return null;
				}

				public List<SectionInfo> ApplySortSelfChara(List<ulong> idList)
				{
					return null;
				}

				public List<SectionInfo> ApplySortForChara(List<ulong> idList)
				{
					return null;
				}

				public List<SectionInfo> ApplySortSelfWeapon(List<ulong> idList)
				{
					return null;
				}

				public List<SectionInfo> ApplySortForSkinWeapon(List<ulong> idList)
				{
					return null;
				}

				private List<SectionInfo> ApplySortSelfDragon(List<ulong> idList)
				{
					return null;
				}

				private List<SectionInfo> ApplySortForDragon(List<ulong> idList)
				{
					return null;
				}

				public List<SectionInfo> ApplySortSelfAmulet(List<ulong> idList)
				{
					return null;
				}

				private static string GetCrestAbilityEffectPriorString(AbilityDataElement abilityData)
				{
					return null;
				}

				public List<SectionInfo> ApplySortForAmulet(List<ulong> idList)
				{
					return null;
				}

				private int GetReliability(int masterId)
				{
					return default(int);
				}

				public List<SectionInfo> ApplySortSelfInBox(List<ulong> idList, GiftType giftType)
				{
					return null;
				}

				public List<SectionInfo> ApplySort(List<ulong> idList, GiftType giftType)
				{
					return null;
				}

				public List<SectionInfo> ApplySortRawData(List<SortRawData> rawDataList)
				{
					return null;
				}

				private void ApplySortRawDataAtkPlus(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}

				private void ApplySortRawDataHpPlus(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}

				private void ApplySortRawDataGetTime(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}

				private void ApplySortRawDataAtk(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}

				private void ApplySortRawDataHp(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}

				private void ApplySortRawDataBattlePower(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}

				private void ApplySortRawDataRarity(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}

				private List<SortRawData> SortAbilityCrest<TKey>(List<SortRawData> rawDataList, Func<SortRawData, TKey> ascendOrder, [Optional] Func<SortRawData, TKey> descendOrder)
				{
					return null;
				}

				private int SortSamePriorFunc(SortRawData p)
				{
					return default(int);
				}

				private int SortElementFunc(SortRawData p)
				{
					return default(int);
				}

				private int SortElementDescendingFunc(SortRawData p)
				{
					return default(int);
				}

				private int SortSameElementFunc(SortRawData p)
				{
					return default(int);
				}

				private int SortSameFavoriteFunc(SortRawData p)
				{
					return default(int);
				}

				private void ApplySortRawDataAbilityList(List<SortRawData> rawDataList, SectionInfo mainSectionInfo, List<SectionInfo> resultList)
				{
				}

				private void ApplySortRawDataCategory(List<SortRawData> rawDataList, SectionInfo mainSectionInfo, List<SectionInfo> resultList)
				{
				}

				private void ApplySortRawDataPieceNum(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}

				private void ApplySortRawDataUnionAbility(List<SortRawData> rawDataList, SectionInfo mainSectionInfo)
				{
				}
			}

			public FilterCondition filterCondition;

			public SortCondition sortCondition;

			public Preset usingPreset;

			public Condition MakeClone()
			{
				return null;
			}
		}

		public enum Preset
		{
			AutoCommon,
			AutoInfoListCommon,
			CharaCommon,
			DragonCommon,
			WeaponCommon,
			WeaponInfoList,
			AmuletCommon,
			DragonPetting,
			GrowthChara,
			GrowthCharaAwake,
			GrowthCharaManaCircle,
			GrowthDragon,
			GrowthDragonLimitBreak,
			GrowthWeapon,
			GrowthWeaponLimitBreak,
			GrowthAmulet,
			GrowthAmuletLimitBreak,
			TradeAmulet,
			DreamSelectChara,
			DreamSelectDragon,
			AmuletExchangePickUp,
			AmuletExchangeStar5,
			AmuletExchangeStar4,
			AmuletExchangeStar3,
			AmuletInfoList,
			GrowthAmuletList,
			GrowthAmuletLimitBreakList,
			GrowthHpResetAmuletList,
			GrowthAtkResetAmuletList,
			SkinWeapon,
			GrowthCharaHpReset,
			GrowthCharaAtkReset,
			GrowthDragonHpReset,
			GrowthDragonAtkReset,
			GrowthWeaponHpReset,
			GrowthWeaponAtkReset,
			GrowthAmuletHpReset,
			GrowthAmuletAtkReset,
			EquipSkill,
			CharaLimitedElemental,
			DragonLimitedElemental,
			BattleRoyalCharaSkin,
			AlbumChara,
			AlbumDragon,
			SelectTicketChara,
			SelectTicketDragon,
			ExchangeSummonChara,
			ExchangeSummonDragon,
			ExcludeSummonChara,
			ExcludeSummonDragon
		}

		public enum DecoDisplayType
		{
			Level,
			ManaCircle,
			PlusVal,
			Hp,
			Atk,
			Def
		}

		private static bool isFirstAccess;

		public const int unionAbilityNum = 16;

		private static CommonSortModel instance;

		public Condition condition;

		public const ulong emptySpaceIconId = ulong.MaxValue;

		public Func<CommonListCustomSortData, CommonListCustomSortData> customSortAction;

		private const string prefsTemplateType = "SortPreset_{0}_Type";

		private const string prefsTemplateOrder = "SortPreset_{0}_Order";

		private const string prefsTemplateFilter = "SortFilterCommon_{0}";

		private const string prefsTemplatePriorElement = "SortPreset_{0}_PriorElement";

		private const string prefsTemplatePriorFavorite = "SortPreset_{0}_PriorFavorite";

		public static CommonSortModel Instance => null;

		public static bool IsInstanceEmpty => default(bool);

		public static void DeleteInstance()
		{
		}

		private CommonSortModel()
		{
		}

		static CommonSortModel()
		{
		}

		public bool IsAnyFilterOn()
		{
			return default(bool);
		}

		public bool IsAscending()
		{
			return default(bool);
		}

		public string GetSortButtonDisplayText()
		{
			return null;
		}

		public void ClearAllFilters()
		{
		}

		public int PreviewFilterResultCount(ulong[] idList, GiftType giftType, [Optional] Condition.FilterCondition filterCondition, bool useSelfSortAndFilter = true)
		{
			return default(int);
		}

		public int PreviewFilterDragonAlbumResultCount(ulong[] idList, Condition.FilterCondition filterCondition)
		{
			return default(int);
		}

		public void ApplySortAndFilterForSelfInBox(CommonIconListController controller, ulong[] idArray, GiftType giftType, CommonIconListType iconListType = CommonIconListType.None, [Optional] Func<List<ulong>, List<ulong>> filteredResultCustomizeAction)
		{
		}

		public void ApplySortAndFilter(List<ulong> idList, GiftType giftType, Preset preset)
		{
		}

		public void LoadPreset(Preset preset, GiftType giftType, ElementalType charaElement = ElementalType.NONE, bool isFromPartyScene = false)
		{
		}

		public void ApplyRawFilterForLimitedWeapon(List<WeaponType> limitedWeaponTypeList)
		{
		}

		private void SetSortTypeDefault(Preset preset, GiftType giftType)
		{
		}

		private void ConvertToValidSortType(Preset preset, GiftType giftType)
		{
		}

		public void SaveAsPreset(Preset preset, GiftType giftType = GiftType.NONE, bool isFromPartyScene = false)
		{
		}

		private static void ClearSavedFilterCondition()
		{
		}

		public void ClearSavedFilterCondition(Preset preset)
		{
		}

		public static bool IsListPreset(Preset preset)
		{
			return default(bool);
		}
	}
}
