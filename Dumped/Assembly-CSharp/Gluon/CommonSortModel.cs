/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonSortModel
	{
		// Fields
		private static bool isFirstAccess;
		public const int unionAbilityNum = 11;
		private static CommonSortModel instance;
		public Condition condition;
		public const ulong emptySpaceIconId = 18446744073709551615;
		public Func<CommonListCustomSortData, CommonListCustomSortData> customSortAction;
		private const string prefsTemplateType = "SortPreset_{0}_Type";
		private const string prefsTemplateOrder = "SortPreset_{0}_Order";
		private const string prefsTemplateFilter = "SortFilterCommon_{0}";
		private const string prefsTemplatePriorElement = "SortPreset_{0}_PriorElement";
		private const string prefsTemplatePriorFavorite = "SortPreset_{0}_PriorFavorite";
	
		// Properties
		public static CommonSortModel Instance { get; }
		public static bool IsInstanceEmpty { get; }
	
		// Nested types
		[Serializable]
		public class Condition
		{
			// Fields
			public FilterCondition filterCondition;
			public SortCondition sortCondition;
			public Preset usingPreset;
	
			// Nested types
			[Serializable]
			public class FilterCondition
			{
				// Fields
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
	
				// Nested types
				[Serializable]
				public class AbilityTypeFilter
				{
					// Fields
					private static List<AbilityTypeForFilter> filterList;
					[SerializeField]
					private List<bool> filterFlagList;
	
					// Nested types
					public enum AbilityTypeForFilter
					{
						None = 0,
						AttackUp = 10101,
						DefenseUp = 10102,
						RecoveryUp = 10103,
						SupportUp = 10104,
						StatusUp = 10199,
						PoisonResist = 10201,
						BurnResist = 10202,
						FreezeResist = 10203,
						ParalysisResist = 10204,
						DarkResist = 10205,
						SwoonResist = 10206,
						CurseResist = 10207,
						SlowModeResist = 10209,
						SleepResist = 10210,
						FireElemResist = 10301,
						WaterElemResist = 10302,
						WindElemResist = 10303,
						LightElemResist = 10304,
						DarkElemResist = 10305,
						TribeKiller = 10401,
						TribeAnti = 10501,
						Debuff = 10699,
						EventSpecific = 19801,
						MemoryEventSpecific = 19899,
						Others = 19901,
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
	
					[CompilerGenerated]
					private sealed class __c__DisplayClass6_0
					{
						// Fields
						public bool value;
	
						// Constructors
						public __c__DisplayClass6_0();
	
						// Methods
						internal bool _ChangeAllState_b__0(bool p);
					}
	
					[Serializable]
					[CompilerGenerated]
					private sealed class __c
					{
						// Fields
						public static readonly __c __9;
						public static Func<bool, bool> __9__7_0;
						public static Func<bool, bool> __9__8_0;
	
						// Constructors
						static __c();
						public __c();
	
						// Methods
						internal bool _IsAllOn_b__7_0(bool p);
						internal bool _IsAllOff_b__8_0(bool p);
					}
	
					// Constructors
					static AbilityTypeFilter();
					public AbilityTypeFilter();
	
					// Methods
					public AbilityTypeFilter MakeClone();
					public void ChangeAllState(bool value);
					public bool IsAllOn();
					public bool IsAllOff();
					public bool CheckIsFlagOn(AbilityTypeForFilter type);
					public void SetFlag(AbilityTypeForFilter type, bool value);
					public bool ShouldRawValueListPass(List<AbilityTypeForFilter> rawValueList);
					private bool DoesFilterPass(List<AbilityTypeForFilter> rawValueList, AbilityTypeForFilter filter);
					private bool ShouldAbilityListPass(List<int> abilityIdList, GiftType giftType);
					public bool ShouldCharacterPass(int masterId, int[] abilityLevels, bool ability2Enabled = true, bool ability3Enabled = true);
					public bool ShouldDragonPass(int masterId, int[] abilityLevels, bool ability2Enabled = true);
					public bool ShouldAmuletPass(int masterId, bool ability2Enabled = true, bool ability3Enabled = true);
				}
	
				[Serializable]
				public class ObtainedItemFilter
				{
					// Fields
					public bool showObtainedItem;
	
					// Constructors
					public ObtainedItemFilter();
	
					// Methods
					public ObtainedItemFilter MakeClone();
					public bool ShouldCharacterPass(int masterId);
					public bool ShouldDragonPass(int masterId);
					public bool ShouldCrestPass(int masterId);
				}
	
				[Serializable]
				public class ElementalFilter
				{
					// Fields
					public bool fire;
					public bool water;
					public bool wind;
					public bool light;
					public bool dark;
					public bool noElement;
	
					// Constructors
					public ElementalFilter();
	
					// Methods
					public ElementalFilter MakeClone();
					public void ChangeAllState(bool value, bool shouldIgnoreNoElement = false);
					public bool IsAllOn(bool shouldIgnoreNoElement = false);
					public bool IsAllOff(bool shouldIgnoreNoElement = false);
					public bool ShouldRawValuePass(ElementalType type);
					public bool ShouldCharacterPass(int masterId);
					public bool ShouldDragonPass(int masterId);
					public bool ShouldWeaponPass(int masterId);
					public bool ShouldWeaponSkinPass(int masterId);
					public bool ShouldAmuletPass(int masterId);
				}
	
				[Serializable]
				public class WeaponTypeFilter
				{
					// Fields
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
	
					// Constructors
					public WeaponTypeFilter();
	
					// Methods
					public WeaponTypeFilter MakeClone();
					public void ChangeAllState(bool value);
					public bool IsAllOn();
					public bool IsAllOff();
					public void SetRawValue(bool isOn, WeaponType weaponType);
					public bool ShouldRawValuePass(WeaponType type);
					public bool ShouldCharacterPass(int masterId);
					public bool ShouldWeaponPass(int masterId);
				}
	
				[Serializable]
				public class WeaponUpgradableFilter
				{
					// Fields
					public bool upgradable;
	
					// Constructors
					public WeaponUpgradableFilter();
	
					// Methods
					public WeaponUpgradableFilter MakeClone();
					public void ChangeAllState(bool value);
					public bool IsAllOn();
					public bool IsAllOff();
					public bool ShouldWeaponPass(int masterId);
				}
	
				[Serializable]
				public class ExAbilityTypeFilter
				{
					// Fields
					public bool others;
					public bool attackUp;
					public bool defenseUp;
					public bool recoveryUp;
					public bool supportUp;
	
					// Nested types
					public enum ExAbilityTypeForFilter
					{
						None = 0,
						AttackUp = 10101,
						DefenseUp = 10102,
						RecoveryUp = 10103,
						SupportUp = 10104,
						Others = 19901
					}
	
					// Constructors
					public ExAbilityTypeFilter();
	
					// Methods
					public ExAbilityTypeFilter MakeClone();
					public void ChangeAllState(bool value);
					public bool IsAllOn();
					public bool IsAllOff();
					public bool CheckIsFlagOn(ExAbilityTypeForFilter type);
					public bool ShouldRawValueListPass(List<ExAbilityTypeForFilter> rawValueList);
					public bool ShouldExAbilityListPass(int abilityId);
					public bool ShouldCharacterPass(int masterId, int abilityLevel);
				}
	
				[Serializable]
				public class CharaSkillTypeFilter
				{
					// Fields
					public bool others;
					public bool attackUp;
					public bool defenseUp;
					public bool recoveryUp;
					public bool supportUp;
	
					// Nested types
					public enum CharaSkillTypeForFilter
					{
						None = 0,
						AttackUp = 1,
						DefenseUp = 2,
						RecoveryUp = 3,
						SupportUp = 4,
						Others = 5
					}
	
					// Constructors
					public CharaSkillTypeFilter();
	
					// Methods
					public CharaSkillTypeFilter MakeClone();
					public void ChangeAllState(bool value);
					public bool IsAllOn();
					public bool IsAllOff();
					public bool CheckIsFlagOn(CharaSkillTypeForFilter type);
					public bool ShouldRawValueListPass(List<CharaSkillTypeForFilter> rawValueList);
					public bool ShouldCharaSkillListPass(int skillId);
					public bool ShouldCharacterPass(int masterId);
				}
	
				[Serializable]
				public class HpPlusParamFilter
				{
					// Fields
					public bool isHpPlus;
					public bool isAll;
	
					// Constructors
					public HpPlusParamFilter();
	
					// Methods
					public HpPlusParamFilter MakeClone();
					public bool ShouldRawValuePass(CommonSortSettingToggle.SortPlusParamType type);
					public bool ShouldUnitPass(int plusVal);
				}
	
				[Serializable]
				public class AtkPlusParamFilter
				{
					// Fields
					public bool isAtkPlus;
					public bool isAll;
	
					// Constructors
					public AtkPlusParamFilter();
	
					// Methods
					public AtkPlusParamFilter MakeClone();
					public bool ShouldRawValuePass(CommonSortSettingToggle.SortPlusParamType type);
					public bool ShouldUnitPass(int plusVal);
				}
	
				[Serializable]
				public class UnionAbilityFilter
				{
					// Fields
					public bool[] unionAbilityList;
	
					// Nested types
					[Serializable]
					[CompilerGenerated]
					private sealed class __c
					{
						// Fields
						public static readonly __c __9;
						public static Func<bool, bool> __9__4_0;
						public static Func<bool, bool> __9__5_0;
	
						// Constructors
						static __c();
						public __c();
	
						// Methods
						internal bool _IsAllOn_b__4_0(bool e);
						internal bool _IsAllOff_b__5_0(bool e);
					}
	
					// Constructors
					public UnionAbilityFilter();
	
					// Methods
					public UnionAbilityFilter MakeClone();
					public void ChangeAllState(bool value);
					public bool IsAllOn();
					public bool IsAllOff();
					public bool ShouldRawValuePass(int unionAbilityId);
					public bool ShouldAmuletPass(int abilityCrestId);
				}
	
				// Constructors
				public FilterCondition();
	
				// Methods
				public FilterCondition MakeClone();
				public void ClearAllFilters();
				public List<ulong> ApplyFilterForSelfInBox(List<ulong> idList, GiftType giftType);
				public List<ulong> ApplyFilter(List<ulong> idList, GiftType giftType);
				public List<ulong> ApplyFilterForAlbumDragon(List<ulong> idList);
			}
	
			[Serializable]
			public class SortCondition
			{
				// Fields
				public SortType sortType;
				public SortOrder sortOrder;
				public GiftType giftType;
				public ElementalType charaElement;
				public bool isPriorMatchElement;
				public bool isPriorFavorite;
	
				// Nested types
				public enum SortType
				{
					None = 0,
					Elemental = 1,
					WeaponType = 2,
					Rarity = 3,
					Ability = 4,
					ExAbility = 5,
					CharaType = 6,
					Level = 7,
					ManaCircle = 8,
					Hp = 9,
					Atk = 10,
					BattlePower = 11,
					GetTime = 12,
					Reliability = 13,
					LimitBreak = 14,
					SkillType = 15,
					SkillCost = 16,
					HpPlusVal = 17,
					AtkPlusVal = 18,
					PieceNum = 19,
					UnionAbility = 20,
					Category = 21
				}
	
				public enum SortOrder
				{
					None = 0,
					Ascending = 1,
					Descending = 2
				}
	
				public class SectionInfo
				{
					// Fields
					public int abilityId;
					public string title;
					public List<ulong> itemList;
					public List<int> decoDisplayNum;
	
					// Constructors
					public SectionInfo();
				}
	
				public class SortRawData
				{
					// Fields
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
	
					// Constructors
					public SortRawData();
	
					// Methods
					public bool HasSortTargetAbility(SortType sortType, int abilityId);
				}
	
				[Serializable]
				[CompilerGenerated]
				private sealed class __c
				{
					// Fields
					public static readonly __c __9;
					public static Func<SortRawData, int> __9__23_0;
					public static Func<SortRawData, WeaponType> __9__23_1;
					public static Func<SortRawData, int> __9__23_2;
					public static Func<SortRawData, Rarity> __9__23_3;
					public static Func<SortRawData, int> __9__23_4;
					public static Func<SortRawData, int> __9__23_5;
					public static Func<SortRawData, ulong> __9__23_6;
					public static Func<SortRawData, WeaponType> __9__23_7;
					public static Func<SortRawData, Rarity> __9__23_8;
					public static Func<SortRawData, int> __9__23_9;
					public static Func<SortRawData, int> __9__23_10;
					public static Func<SortRawData, ulong> __9__23_11;
					public static Func<SortRawData, int> __9__23_12;
					public static Func<SortRawData, WeaponType> __9__23_13;
					public static Func<SortRawData, int> __9__23_14;
					public static Func<SortRawData, Rarity> __9__23_15;
					public static Func<SortRawData, int> __9__23_16;
					public static Func<SortRawData, int> __9__23_17;
					public static Func<SortRawData, ulong> __9__23_18;
					public static Func<SortRawData, WeaponType> __9__23_19;
					public static Func<SortRawData, Rarity> __9__23_20;
					public static Func<SortRawData, int> __9__23_21;
					public static Func<SortRawData, int> __9__23_22;
					public static Func<SortRawData, ulong> __9__23_23;
					public static Func<SortRawData, WeaponType> __9__23_24;
					public static Func<SortRawData, int> __9__23_25;
					public static Func<SortRawData, Rarity> __9__23_26;
					public static Func<SortRawData, int> __9__23_27;
					public static Func<SortRawData, int> __9__23_28;
					public static Func<SortRawData, ulong> __9__23_29;
					public static Func<SortRawData, WeaponType> __9__23_30;
					public static Func<SortRawData, int> __9__23_31;
					public static Func<SortRawData, Rarity> __9__23_32;
					public static Func<SortRawData, int> __9__23_33;
					public static Func<SortRawData, int> __9__23_34;
					public static Func<SortRawData, ulong> __9__23_35;
					public static Func<SortRawData, WeaponType> __9__23_112;
					public static Func<SortRawData, Rarity> __9__23_113;
					public static Func<SortRawData, int> __9__23_114;
					public static Func<SortRawData, int> __9__23_115;
					public static Func<SortRawData, ulong> __9__23_116;
					public static Func<SortRawData, int> __9__23_36;
					public static Func<SortRawData, WeaponType> __9__23_37;
					public static Func<SortRawData, Rarity> __9__23_38;
					public static Func<SortRawData, int> __9__23_39;
					public static Func<SortRawData, int> __9__23_40;
					public static Func<SortRawData, ulong> __9__23_41;
					public static Func<SortRawData, int> __9__23_42;
					public static Func<SortRawData, WeaponType> __9__23_43;
					public static Func<SortRawData, Rarity> __9__23_44;
					public static Func<SortRawData, int> __9__23_45;
					public static Func<SortRawData, int> __9__23_46;
					public static Func<SortRawData, ulong> __9__23_47;
					public static Func<SortRawData, int> __9__23_48;
					public static Func<SortRawData, WeaponType> __9__23_49;
					public static Func<SortRawData, Rarity> __9__23_50;
					public static Func<SortRawData, int> __9__23_51;
					public static Func<SortRawData, int> __9__23_52;
					public static Func<SortRawData, ulong> __9__23_53;
					public static Func<SortRawData, int> __9__23_54;
					public static Func<SortRawData, WeaponType> __9__23_55;
					public static Func<SortRawData, Rarity> __9__23_56;
					public static Func<SortRawData, int> __9__23_57;
					public static Func<SortRawData, int> __9__23_58;
					public static Func<SortRawData, ulong> __9__23_59;
					public static Func<SortRawData, int> __9__23_60;
					public static Func<SortRawData, WeaponType> __9__23_61;
					public static Func<SortRawData, Rarity> __9__23_62;
					public static Func<SortRawData, int> __9__23_63;
					public static Func<SortRawData, int> __9__23_64;
					public static Func<SortRawData, ulong> __9__23_65;
					public static Func<SortRawData, int> __9__23_66;
					public static Func<SortRawData, WeaponType> __9__23_67;
					public static Func<SortRawData, Rarity> __9__23_68;
					public static Func<SortRawData, int> __9__23_69;
					public static Func<SortRawData, int> __9__23_70;
					public static Func<SortRawData, ulong> __9__23_71;
					public static Func<SortRawData, int> __9__23_72;
					public static Func<SortRawData, WeaponType> __9__23_73;
					public static Func<SortRawData, Rarity> __9__23_74;
					public static Func<SortRawData, int> __9__23_75;
					public static Func<SortRawData, int> __9__23_76;
					public static Func<SortRawData, ulong> __9__23_77;
					public static Func<SortRawData, int> __9__23_78;
					public static Func<SortRawData, WeaponType> __9__23_79;
					public static Func<SortRawData, Rarity> __9__23_80;
					public static Func<SortRawData, int> __9__23_81;
					public static Func<SortRawData, int> __9__23_82;
					public static Func<SortRawData, ulong> __9__23_83;
					public static Func<SortRawData, int> __9__23_84;
					public static Func<SortRawData, int> __9__23_85;
					public static Func<SortRawData, WeaponType> __9__23_86;
					public static Func<SortRawData, Rarity> __9__23_87;
					public static Func<SortRawData, int> __9__23_88;
					public static Func<SortRawData, int> __9__23_89;
					public static Func<SortRawData, ulong> __9__23_90;
					public static Func<SortRawData, int> __9__23_91;
					public static Func<SortRawData, int> __9__23_92;
					public static Func<SortRawData, WeaponType> __9__23_93;
					public static Func<SortRawData, Rarity> __9__23_94;
					public static Func<SortRawData, int> __9__23_95;
					public static Func<SortRawData, int> __9__23_96;
					public static Func<SortRawData, ulong> __9__23_97;
					public static Func<SortRawData, int> __9__23_98;
					public static Func<SortRawData, int> __9__23_99;
					public static Func<SortRawData, WeaponType> __9__23_100;
					public static Func<SortRawData, Rarity> __9__23_101;
					public static Func<SortRawData, int> __9__23_102;
					public static Func<SortRawData, int> __9__23_103;
					public static Func<SortRawData, ulong> __9__23_104;
					public static Func<SortRawData, int> __9__23_105;
					public static Func<SortRawData, int> __9__23_106;
					public static Func<SortRawData, WeaponType> __9__23_107;
					public static Func<SortRawData, Rarity> __9__23_108;
					public static Func<SortRawData, int> __9__23_109;
					public static Func<SortRawData, int> __9__23_110;
					public static Func<SortRawData, ulong> __9__23_111;
					public static Func<SortRawData, int> __9__24_0;
					public static Func<SortRawData, int> __9__24_1;
					public static Func<SortRawData, WeaponType> __9__24_2;
					public static Func<SortRawData, Rarity> __9__24_3;
					public static Func<SortRawData, int> __9__24_4;
					public static Func<SortRawData, int> __9__24_5;
					public static Func<SortRawData, ulong> __9__24_6;
					public static Func<SortRawData, int> __9__24_7;
					public static Func<SortRawData, WeaponType> __9__24_8;
					public static Func<SortRawData, Rarity> __9__24_9;
					public static Func<SortRawData, int> __9__24_10;
					public static Func<SortRawData, int> __9__24_11;
					public static Func<SortRawData, ulong> __9__24_12;
					public static Func<SortRawData, int> __9__25_0;
					public static Func<SortRawData, int> __9__25_1;
					public static Func<SortRawData, WeaponType> __9__25_2;
					public static Func<SortRawData, Rarity> __9__25_3;
					public static Func<SortRawData, int> __9__25_4;
					public static Func<SortRawData, int> __9__25_5;
					public static Func<SortRawData, ulong> __9__25_6;
					public static Func<SortRawData, int> __9__25_7;
					public static Func<SortRawData, WeaponType> __9__25_8;
					public static Func<SortRawData, Rarity> __9__25_9;
					public static Func<SortRawData, int> __9__25_10;
					public static Func<SortRawData, int> __9__25_11;
					public static Func<SortRawData, ulong> __9__25_12;
					public static Func<SortRawData, int> __9__26_0;
					public static Func<SortRawData, int> __9__26_1;
					public static Func<SortRawData, ulong> __9__26_2;
					public static Func<SortRawData, int> __9__26_3;
					public static Func<SortRawData, ulong> __9__26_4;
					public static Func<SortRawData, int> __9__27_0;
					public static Func<SortRawData, int> __9__27_1;
					public static Func<SortRawData, WeaponType> __9__27_2;
					public static Func<SortRawData, Rarity> __9__27_3;
					public static Func<SortRawData, int> __9__27_4;
					public static Func<SortRawData, int> __9__27_5;
					public static Func<SortRawData, ulong> __9__27_6;
					public static Func<SortRawData, int> __9__27_7;
					public static Func<SortRawData, WeaponType> __9__27_8;
					public static Func<SortRawData, Rarity> __9__27_9;
					public static Func<SortRawData, int> __9__27_10;
					public static Func<SortRawData, int> __9__27_11;
					public static Func<SortRawData, ulong> __9__27_12;
					public static Func<SortRawData, int> __9__28_0;
					public static Func<SortRawData, int> __9__28_1;
					public static Func<SortRawData, WeaponType> __9__28_2;
					public static Func<SortRawData, Rarity> __9__28_3;
					public static Func<SortRawData, int> __9__28_4;
					public static Func<SortRawData, int> __9__28_5;
					public static Func<SortRawData, ulong> __9__28_6;
					public static Func<SortRawData, int> __9__28_7;
					public static Func<SortRawData, WeaponType> __9__28_8;
					public static Func<SortRawData, Rarity> __9__28_9;
					public static Func<SortRawData, int> __9__28_10;
					public static Func<SortRawData, int> __9__28_11;
					public static Func<SortRawData, ulong> __9__28_12;
					public static Func<SortRawData, int> __9__29_0;
					public static Func<SortRawData, int> __9__29_1;
					public static Func<SortRawData, WeaponType> __9__29_2;
					public static Func<SortRawData, Rarity> __9__29_3;
					public static Func<SortRawData, int> __9__29_4;
					public static Func<SortRawData, int> __9__29_5;
					public static Func<SortRawData, ulong> __9__29_6;
					public static Func<SortRawData, int> __9__29_7;
					public static Func<SortRawData, WeaponType> __9__29_8;
					public static Func<SortRawData, Rarity> __9__29_9;
					public static Func<SortRawData, int> __9__29_10;
					public static Func<SortRawData, int> __9__29_11;
					public static Func<SortRawData, ulong> __9__29_12;
					public static Func<SortRawData, Rarity> __9__30_0;
					public static Func<SortRawData, Rarity> __9__30_1;
					public static Func<SortRawData, WeaponType> __9__30_2;
					public static Func<SortRawData, int> __9__30_3;
					public static Func<SortRawData, int> __9__30_4;
					public static Func<SortRawData, ulong> __9__30_5;
					public static Func<SortRawData, Rarity> __9__30_6;
					public static Func<SortRawData, WeaponType> __9__30_7;
					public static Func<SortRawData, int> __9__30_8;
					public static Func<SortRawData, int> __9__30_9;
					public static Func<SortRawData, ulong> __9__30_10;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__37_0;
					public static Func<Tuple<AbilityDataElement, ElementalType>, string> __9__37_1;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__37_2;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__37_3;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__37_4;
					public static Func<Tuple<AbilityDataElement, ElementalType>, string> __9__37_5;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__37_6;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__37_7;
					public static Func<SortRawData, string> __9__37_10;
					public static Func<SortRawData, int> __9__37_11;
					public static Func<SortRawData, ElementalType> __9__37_12;
					public static Func<SortRawData, WeaponType> __9__37_13;
					public static Func<SortRawData, Rarity> __9__37_14;
					public static Func<SortRawData, int> __9__37_15;
					public static Func<SortRawData, int> __9__37_16;
					public static Func<SortRawData, ulong> __9__37_17;
					public static Func<SortRawData, string> __9__37_18;
					public static Func<SortRawData, int> __9__37_19;
					public static Func<SortRawData, ElementalType> __9__37_20;
					public static Func<SortRawData, WeaponType> __9__37_21;
					public static Func<SortRawData, Rarity> __9__37_22;
					public static Func<SortRawData, int> __9__37_23;
					public static Func<SortRawData, int> __9__37_24;
					public static Func<SortRawData, ulong> __9__37_25;
					public static Comparison<AbilityCrestFeatureGroupElement> __9__38_0;
					public static Func<SortRawData, int> __9__38_2;
					public static Func<SortRawData, string> __9__38_3;
					public static Func<SortRawData, int> __9__38_4;
					public static Func<SortRawData, int> __9__39_0;
					public static Func<SortRawData, int> __9__39_1;
					public static Func<SortRawData, int> __9__39_2;
					public static Func<SortRawData, WeaponType> __9__39_3;
					public static Func<SortRawData, Rarity> __9__39_4;
					public static Func<SortRawData, int> __9__39_5;
					public static Func<SortRawData, int> __9__39_6;
					public static Func<SortRawData, ulong> __9__39_7;
					public static Func<SortRawData, int> __9__40_0;
					public static Func<SortRawData, int> __9__40_1;
	
					// Constructors
					static __c();
					public __c();
	
					// Methods
					internal int _ApplySortRawData_b__23_0(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_1(SortRawData p);
					internal int _ApplySortRawData_b__23_2(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_3(SortRawData p);
					internal int _ApplySortRawData_b__23_4(SortRawData p);
					internal int _ApplySortRawData_b__23_5(SortRawData p);
					internal ulong _ApplySortRawData_b__23_6(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_7(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_8(SortRawData p);
					internal int _ApplySortRawData_b__23_9(SortRawData p);
					internal int _ApplySortRawData_b__23_10(SortRawData p);
					internal ulong _ApplySortRawData_b__23_11(SortRawData p);
					internal int _ApplySortRawData_b__23_12(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_13(SortRawData p);
					internal int _ApplySortRawData_b__23_14(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_15(SortRawData p);
					internal int _ApplySortRawData_b__23_16(SortRawData p);
					internal int _ApplySortRawData_b__23_17(SortRawData p);
					internal ulong _ApplySortRawData_b__23_18(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_19(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_20(SortRawData p);
					internal int _ApplySortRawData_b__23_21(SortRawData p);
					internal int _ApplySortRawData_b__23_22(SortRawData p);
					internal ulong _ApplySortRawData_b__23_23(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_24(SortRawData p);
					internal int _ApplySortRawData_b__23_25(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_26(SortRawData p);
					internal int _ApplySortRawData_b__23_27(SortRawData p);
					internal int _ApplySortRawData_b__23_28(SortRawData p);
					internal ulong _ApplySortRawData_b__23_29(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_30(SortRawData p);
					internal int _ApplySortRawData_b__23_31(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_32(SortRawData p);
					internal int _ApplySortRawData_b__23_33(SortRawData p);
					internal int _ApplySortRawData_b__23_34(SortRawData p);
					internal ulong _ApplySortRawData_b__23_35(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_112(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_113(SortRawData p);
					internal int _ApplySortRawData_b__23_114(SortRawData p);
					internal int _ApplySortRawData_b__23_115(SortRawData p);
					internal ulong _ApplySortRawData_b__23_116(SortRawData p);
					internal int _ApplySortRawData_b__23_36(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_37(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_38(SortRawData p);
					internal int _ApplySortRawData_b__23_39(SortRawData p);
					internal int _ApplySortRawData_b__23_40(SortRawData p);
					internal ulong _ApplySortRawData_b__23_41(SortRawData p);
					internal int _ApplySortRawData_b__23_42(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_43(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_44(SortRawData p);
					internal int _ApplySortRawData_b__23_45(SortRawData p);
					internal int _ApplySortRawData_b__23_46(SortRawData p);
					internal ulong _ApplySortRawData_b__23_47(SortRawData p);
					internal int _ApplySortRawData_b__23_48(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_49(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_50(SortRawData p);
					internal int _ApplySortRawData_b__23_51(SortRawData p);
					internal int _ApplySortRawData_b__23_52(SortRawData p);
					internal ulong _ApplySortRawData_b__23_53(SortRawData p);
					internal int _ApplySortRawData_b__23_54(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_55(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_56(SortRawData p);
					internal int _ApplySortRawData_b__23_57(SortRawData p);
					internal int _ApplySortRawData_b__23_58(SortRawData p);
					internal ulong _ApplySortRawData_b__23_59(SortRawData p);
					internal int _ApplySortRawData_b__23_60(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_61(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_62(SortRawData p);
					internal int _ApplySortRawData_b__23_63(SortRawData p);
					internal int _ApplySortRawData_b__23_64(SortRawData p);
					internal ulong _ApplySortRawData_b__23_65(SortRawData p);
					internal int _ApplySortRawData_b__23_66(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_67(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_68(SortRawData p);
					internal int _ApplySortRawData_b__23_69(SortRawData p);
					internal int _ApplySortRawData_b__23_70(SortRawData p);
					internal ulong _ApplySortRawData_b__23_71(SortRawData p);
					internal int _ApplySortRawData_b__23_72(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_73(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_74(SortRawData p);
					internal int _ApplySortRawData_b__23_75(SortRawData p);
					internal int _ApplySortRawData_b__23_76(SortRawData p);
					internal ulong _ApplySortRawData_b__23_77(SortRawData p);
					internal int _ApplySortRawData_b__23_78(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_79(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_80(SortRawData p);
					internal int _ApplySortRawData_b__23_81(SortRawData p);
					internal int _ApplySortRawData_b__23_82(SortRawData p);
					internal ulong _ApplySortRawData_b__23_83(SortRawData p);
					internal int _ApplySortRawData_b__23_84(SortRawData p);
					internal int _ApplySortRawData_b__23_85(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_86(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_87(SortRawData p);
					internal int _ApplySortRawData_b__23_88(SortRawData p);
					internal int _ApplySortRawData_b__23_89(SortRawData p);
					internal ulong _ApplySortRawData_b__23_90(SortRawData p);
					internal int _ApplySortRawData_b__23_91(SortRawData p);
					internal int _ApplySortRawData_b__23_92(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_93(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_94(SortRawData p);
					internal int _ApplySortRawData_b__23_95(SortRawData p);
					internal int _ApplySortRawData_b__23_96(SortRawData p);
					internal ulong _ApplySortRawData_b__23_97(SortRawData p);
					internal int _ApplySortRawData_b__23_98(SortRawData p);
					internal int _ApplySortRawData_b__23_99(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_100(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_101(SortRawData p);
					internal int _ApplySortRawData_b__23_102(SortRawData p);
					internal int _ApplySortRawData_b__23_103(SortRawData p);
					internal ulong _ApplySortRawData_b__23_104(SortRawData p);
					internal int _ApplySortRawData_b__23_105(SortRawData p);
					internal int _ApplySortRawData_b__23_106(SortRawData p);
					internal WeaponType _ApplySortRawData_b__23_107(SortRawData p);
					internal Rarity _ApplySortRawData_b__23_108(SortRawData p);
					internal int _ApplySortRawData_b__23_109(SortRawData p);
					internal int _ApplySortRawData_b__23_110(SortRawData p);
					internal ulong _ApplySortRawData_b__23_111(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__24_0(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__24_1(SortRawData p);
					internal WeaponType _ApplySortRawDataAtkPlus_b__24_2(SortRawData p);
					internal Rarity _ApplySortRawDataAtkPlus_b__24_3(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__24_4(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__24_5(SortRawData p);
					internal ulong _ApplySortRawDataAtkPlus_b__24_6(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__24_7(SortRawData p);
					internal WeaponType _ApplySortRawDataAtkPlus_b__24_8(SortRawData p);
					internal Rarity _ApplySortRawDataAtkPlus_b__24_9(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__24_10(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__24_11(SortRawData p);
					internal ulong _ApplySortRawDataAtkPlus_b__24_12(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__25_0(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__25_1(SortRawData p);
					internal WeaponType _ApplySortRawDataHpPlus_b__25_2(SortRawData p);
					internal Rarity _ApplySortRawDataHpPlus_b__25_3(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__25_4(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__25_5(SortRawData p);
					internal ulong _ApplySortRawDataHpPlus_b__25_6(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__25_7(SortRawData p);
					internal WeaponType _ApplySortRawDataHpPlus_b__25_8(SortRawData p);
					internal Rarity _ApplySortRawDataHpPlus_b__25_9(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__25_10(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__25_11(SortRawData p);
					internal ulong _ApplySortRawDataHpPlus_b__25_12(SortRawData p);
					internal int _ApplySortRawDataGetTime_b__26_0(SortRawData p);
					internal int _ApplySortRawDataGetTime_b__26_1(SortRawData p);
					internal ulong _ApplySortRawDataGetTime_b__26_2(SortRawData p);
					internal int _ApplySortRawDataGetTime_b__26_3(SortRawData p);
					internal ulong _ApplySortRawDataGetTime_b__26_4(SortRawData p);
					internal int _ApplySortRawDataAtk_b__27_0(SortRawData p);
					internal int _ApplySortRawDataAtk_b__27_1(SortRawData p);
					internal WeaponType _ApplySortRawDataAtk_b__27_2(SortRawData p);
					internal Rarity _ApplySortRawDataAtk_b__27_3(SortRawData p);
					internal int _ApplySortRawDataAtk_b__27_4(SortRawData p);
					internal int _ApplySortRawDataAtk_b__27_5(SortRawData p);
					internal ulong _ApplySortRawDataAtk_b__27_6(SortRawData p);
					internal int _ApplySortRawDataAtk_b__27_7(SortRawData p);
					internal WeaponType _ApplySortRawDataAtk_b__27_8(SortRawData p);
					internal Rarity _ApplySortRawDataAtk_b__27_9(SortRawData p);
					internal int _ApplySortRawDataAtk_b__27_10(SortRawData p);
					internal int _ApplySortRawDataAtk_b__27_11(SortRawData p);
					internal ulong _ApplySortRawDataAtk_b__27_12(SortRawData p);
					internal int _ApplySortRawDataHp_b__28_0(SortRawData p);
					internal int _ApplySortRawDataHp_b__28_1(SortRawData p);
					internal WeaponType _ApplySortRawDataHp_b__28_2(SortRawData p);
					internal Rarity _ApplySortRawDataHp_b__28_3(SortRawData p);
					internal int _ApplySortRawDataHp_b__28_4(SortRawData p);
					internal int _ApplySortRawDataHp_b__28_5(SortRawData p);
					internal ulong _ApplySortRawDataHp_b__28_6(SortRawData p);
					internal int _ApplySortRawDataHp_b__28_7(SortRawData p);
					internal WeaponType _ApplySortRawDataHp_b__28_8(SortRawData p);
					internal Rarity _ApplySortRawDataHp_b__28_9(SortRawData p);
					internal int _ApplySortRawDataHp_b__28_10(SortRawData p);
					internal int _ApplySortRawDataHp_b__28_11(SortRawData p);
					internal ulong _ApplySortRawDataHp_b__28_12(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__29_0(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__29_1(SortRawData p);
					internal WeaponType _ApplySortRawDataBattlePower_b__29_2(SortRawData p);
					internal Rarity _ApplySortRawDataBattlePower_b__29_3(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__29_4(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__29_5(SortRawData p);
					internal ulong _ApplySortRawDataBattlePower_b__29_6(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__29_7(SortRawData p);
					internal WeaponType _ApplySortRawDataBattlePower_b__29_8(SortRawData p);
					internal Rarity _ApplySortRawDataBattlePower_b__29_9(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__29_10(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__29_11(SortRawData p);
					internal ulong _ApplySortRawDataBattlePower_b__29_12(SortRawData p);
					internal Rarity _ApplySortRawDataRarity_b__30_0(SortRawData p);
					internal Rarity _ApplySortRawDataRarity_b__30_1(SortRawData p);
					internal WeaponType _ApplySortRawDataRarity_b__30_2(SortRawData p);
					internal int _ApplySortRawDataRarity_b__30_3(SortRawData p);
					internal int _ApplySortRawDataRarity_b__30_4(SortRawData p);
					internal ulong _ApplySortRawDataRarity_b__30_5(SortRawData p);
					internal Rarity _ApplySortRawDataRarity_b__30_6(SortRawData p);
					internal WeaponType _ApplySortRawDataRarity_b__30_7(SortRawData p);
					internal int _ApplySortRawDataRarity_b__30_8(SortRawData p);
					internal int _ApplySortRawDataRarity_b__30_9(SortRawData p);
					internal ulong _ApplySortRawDataRarity_b__30_10(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__37_0(Tuple<AbilityDataElement, ElementalType> p);
					internal string _ApplySortRawDataAbilityList_b__37_1(Tuple<AbilityDataElement, ElementalType> p);
					internal int _ApplySortRawDataAbilityList_b__37_2(Tuple<AbilityDataElement, ElementalType> p);
					internal int _ApplySortRawDataAbilityList_b__37_3(Tuple<AbilityDataElement, ElementalType> p);
					internal int _ApplySortRawDataAbilityList_b__37_4(Tuple<AbilityDataElement, ElementalType> p);
					internal string _ApplySortRawDataAbilityList_b__37_5(Tuple<AbilityDataElement, ElementalType> p);
					internal int _ApplySortRawDataAbilityList_b__37_6(Tuple<AbilityDataElement, ElementalType> p);
					internal int _ApplySortRawDataAbilityList_b__37_7(Tuple<AbilityDataElement, ElementalType> p);
					internal string _ApplySortRawDataAbilityList_b__37_10(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__37_11(SortRawData p);
					internal ElementalType _ApplySortRawDataAbilityList_b__37_12(SortRawData p);
					internal WeaponType _ApplySortRawDataAbilityList_b__37_13(SortRawData p);
					internal Rarity _ApplySortRawDataAbilityList_b__37_14(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__37_15(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__37_16(SortRawData p);
					internal ulong _ApplySortRawDataAbilityList_b__37_17(SortRawData p);
					internal string _ApplySortRawDataAbilityList_b__37_18(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__37_19(SortRawData p);
					internal ElementalType _ApplySortRawDataAbilityList_b__37_20(SortRawData p);
					internal WeaponType _ApplySortRawDataAbilityList_b__37_21(SortRawData p);
					internal Rarity _ApplySortRawDataAbilityList_b__37_22(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__37_23(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__37_24(SortRawData p);
					internal ulong _ApplySortRawDataAbilityList_b__37_25(SortRawData p);
					internal int _ApplySortRawDataCategory_b__38_0(AbilityCrestFeatureGroupElement a, AbilityCrestFeatureGroupElement b);
					internal int _ApplySortRawDataCategory_b__38_2(SortRawData p);
					internal string _ApplySortRawDataCategory_b__38_3(SortRawData p);
					internal int _ApplySortRawDataCategory_b__38_4(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__39_0(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__39_1(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__39_2(SortRawData p);
					internal WeaponType _ApplySortRawDataPieceNum_b__39_3(SortRawData p);
					internal Rarity _ApplySortRawDataPieceNum_b__39_4(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__39_5(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__39_6(SortRawData p);
					internal ulong _ApplySortRawDataPieceNum_b__39_7(SortRawData p);
					internal int _ApplySortRawDataUnionAbility_b__40_0(SortRawData p);
					internal int _ApplySortRawDataUnionAbility_b__40_1(SortRawData p);
				}
	
				[Serializable]
				[CompilerGenerated]
				private sealed class __c__31<TKey>
				{
					// Fields
					public static readonly __c__31<TKey> __9;
					public static Func<SortRawData, int> __9__31_0;
					public static Func<SortRawData, string> __9__31_1;
					public static Func<SortRawData, int> __9__31_2;
	
					// Constructors
					static __c__31();
					public __c__31();
	
					// Methods
					internal int _SortAbilityCrest_b__31_0(SortRawData p);
					internal string _SortAbilityCrest_b__31_1(SortRawData p);
					internal int _SortAbilityCrest_b__31_2(SortRawData p);
				}
	
				[CompilerGenerated]
				private sealed class __c__DisplayClass37_0
				{
					// Fields
					public Tuple<AbilityDataElement, ElementalType> newData;
	
					// Constructors
					public __c__DisplayClass37_0();
	
					// Methods
					internal bool _ApplySortRawDataAbilityList_b__8(Tuple<AbilityDataElement, ElementalType> p);
				}
	
				[CompilerGenerated]
				private sealed class __c__DisplayClass37_1
				{
					// Fields
					public Tuple<AbilityDataElement, ElementalType> newData;
	
					// Constructors
					public __c__DisplayClass37_1();
	
					// Methods
					internal bool _ApplySortRawDataAbilityList_b__9(Tuple<AbilityDataElement, ElementalType> p);
				}
	
				[CompilerGenerated]
				private sealed class __c__DisplayClass38_0
				{
					// Fields
					public SortRawData rawData;
	
					// Constructors
					public __c__DisplayClass38_0();
	
					// Methods
					internal bool _ApplySortRawDataCategory_b__1(AbilityCrestFeatureGroupElement p);
				}
	
				// Constructors
				public SortCondition();
	
				// Methods
				public SortCondition MakeClone();
				public List<SectionInfo> ApplySortSelfChara(List<ulong> idList);
				public List<SectionInfo> ApplySortForChara(List<ulong> idList);
				public List<SectionInfo> ApplySortSelfWeapon(List<ulong> idList);
				public List<SectionInfo> ApplySortForSkinWeapon(List<ulong> idList);
				private List<SectionInfo> ApplySortSelfDragon(List<ulong> idList);
				private List<SectionInfo> ApplySortForDragon(List<ulong> idList);
				public List<SectionInfo> ApplySortSelfAmulet(List<ulong> idList);
				private static string GetCrestAbilityEffectPriorString(AbilityDataElement abilityData);
				public List<SectionInfo> ApplySortForAmulet(List<ulong> idList);
				private int GetReliability(int masterId);
				public List<SectionInfo> ApplySortSelfInBox(List<ulong> idList, GiftType giftType);
				public List<SectionInfo> ApplySort(List<ulong> idList, GiftType giftType);
				public List<SectionInfo> ApplySortRawData(List<SortRawData> rawDataList);
				private void ApplySortRawDataAtkPlus(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
				private void ApplySortRawDataHpPlus(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
				private void ApplySortRawDataGetTime(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
				private void ApplySortRawDataAtk(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
				private void ApplySortRawDataHp(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
				private void ApplySortRawDataBattlePower(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
				private void ApplySortRawDataRarity(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
				private List<SortRawData> SortAbilityCrest<TKey>(List<SortRawData> rawDataList, Func<SortRawData, TKey> ascendOrder, Func<SortRawData, TKey> descendOrder = null);
				private int SortSamePriorFunc(SortRawData p);
				private int SortElementFunc(SortRawData p);
				private int SortElementDescendingFunc(SortRawData p);
				private int SortSameElementFunc(SortRawData p);
				private int SortSameFavoriteFunc(SortRawData p);
				private void ApplySortRawDataAbilityList(List<SortRawData> rawDataList, SectionInfo mainSectionInfo, List<SectionInfo> resultList);
				private void ApplySortRawDataCategory(List<SortRawData> rawDataList, SectionInfo mainSectionInfo, List<SectionInfo> resultList);
				private void ApplySortRawDataPieceNum(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
				private void ApplySortRawDataUnionAbility(List<SortRawData> rawDataList, SectionInfo mainSectionInfo);
			}
	
			// Constructors
			public Condition();
	
			// Methods
			public Condition MakeClone();
		}
	
		public enum Preset
		{
			AutoCommon = 0,
			AutoInfoListCommon = 1,
			CharaCommon = 2,
			DragonCommon = 3,
			WeaponCommon = 4,
			WeaponInfoList = 5,
			AmuletCommon = 6,
			DragonPetting = 7,
			GrowthChara = 8,
			GrowthCharaAwake = 9,
			GrowthCharaManaCircle = 10,
			GrowthDragon = 11,
			GrowthDragonLimitBreak = 12,
			GrowthWeapon = 13,
			GrowthWeaponLimitBreak = 14,
			GrowthAmulet = 15,
			GrowthAmuletLimitBreak = 16,
			TradeAmulet = 17,
			DreamSelectChara = 18,
			DreamSelectDragon = 19,
			AmuletExchangePickUp = 20,
			AmuletExchangeStar5 = 21,
			AmuletExchangeStar4 = 22,
			AmuletExchangeStar3 = 23,
			AmuletInfoList = 24,
			GrowthAmuletList = 25,
			GrowthAmuletLimitBreakList = 26,
			GrowthHpResetAmuletList = 27,
			GrowthAtkResetAmuletList = 28,
			SkinWeapon = 29,
			GrowthCharaHpReset = 30,
			GrowthCharaAtkReset = 31,
			GrowthDragonHpReset = 32,
			GrowthDragonAtkReset = 33,
			GrowthWeaponHpReset = 34,
			GrowthWeaponAtkReset = 35,
			GrowthAmuletHpReset = 36,
			GrowthAmuletAtkReset = 37,
			EquipSkill = 38,
			CharaLimitedElemental = 39,
			DragonLimitedElemental = 40,
			BattleRoyalCharaSkin = 41,
			AlbumChara = 42,
			AlbumDragon = 43,
			SelectTicketChara = 44,
			SelectTicketDragon = 45,
			ExchangeSummonChara = 46,
			ExchangeSummonDragon = 47
		}
	
		public enum DecoDisplayType
		{
			Level = 0,
			ManaCircle = 1,
			PlusVal = 2,
			Hp = 3,
			Atk = 4,
			Def = 5
		}
	
		// Constructors
		private CommonSortModel();
		static CommonSortModel();
	
		// Methods
		public static void DeleteInstance();
		public bool IsAnyFilterOn();
		public bool IsAscending();
		public string GetSortButtonDisplayText();
		public void ClearAllFilters();
		public int PreviewFilterResultCount(ulong[] idList, GiftType giftType, Condition.FilterCondition filterCondition = null, bool useSelfSortAndFilter = true);
		public int PreviewFilterDragonAlbumResultCount(ulong[] idList, Condition.FilterCondition filterCondition);
		public void ApplySortAndFilterForSelfInBox(CommonIconListController controller, ulong[] idArray, GiftType giftType, CommonIconListType iconListType = CommonIconListType.None, Func<List<ulong>, List<ulong>> filteredResultCustomizeAction = null);
		public void ApplySortAndFilter(List<ulong> idList, GiftType giftType, Preset preset);
		public void LoadPreset(Preset preset, GiftType giftType, ElementalType charaElement = ElementalType.NONE, bool isFromPartyScene = false);
		public void ApplyRawFilterForLimitedWeapon(List<WeaponType> limitedWeaponTypeList);
		private void SetSortTypeDefault(Preset preset, GiftType giftType);
		private void ConvertToValidSortType(Preset preset, GiftType giftType);
		public void SaveAsPreset(Preset preset, GiftType giftType = GiftType.NONE, bool isFromPartyScene = false);
		private static void ClearSavedFilterCondition();
		public void ClearSavedFilterCondition(Preset preset);
		public static bool IsListPreset(Preset preset);
	}
}
