/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
					public static Func<SortRawData, int> __9__22_0;
					public static Func<SortRawData, WeaponType> __9__22_1;
					public static Func<SortRawData, int> __9__22_2;
					public static Func<SortRawData, Rarity> __9__22_3;
					public static Func<SortRawData, int> __9__22_4;
					public static Func<SortRawData, int> __9__22_5;
					public static Func<SortRawData, ulong> __9__22_6;
					public static Func<SortRawData, WeaponType> __9__22_7;
					public static Func<SortRawData, Rarity> __9__22_8;
					public static Func<SortRawData, int> __9__22_9;
					public static Func<SortRawData, int> __9__22_10;
					public static Func<SortRawData, ulong> __9__22_11;
					public static Func<SortRawData, int> __9__22_12;
					public static Func<SortRawData, WeaponType> __9__22_13;
					public static Func<SortRawData, int> __9__22_14;
					public static Func<SortRawData, Rarity> __9__22_15;
					public static Func<SortRawData, int> __9__22_16;
					public static Func<SortRawData, int> __9__22_17;
					public static Func<SortRawData, ulong> __9__22_18;
					public static Func<SortRawData, WeaponType> __9__22_19;
					public static Func<SortRawData, Rarity> __9__22_20;
					public static Func<SortRawData, int> __9__22_21;
					public static Func<SortRawData, int> __9__22_22;
					public static Func<SortRawData, ulong> __9__22_23;
					public static Func<SortRawData, WeaponType> __9__22_24;
					public static Func<SortRawData, int> __9__22_25;
					public static Func<SortRawData, Rarity> __9__22_26;
					public static Func<SortRawData, int> __9__22_27;
					public static Func<SortRawData, int> __9__22_28;
					public static Func<SortRawData, ulong> __9__22_29;
					public static Func<SortRawData, WeaponType> __9__22_30;
					public static Func<SortRawData, int> __9__22_31;
					public static Func<SortRawData, Rarity> __9__22_32;
					public static Func<SortRawData, int> __9__22_33;
					public static Func<SortRawData, int> __9__22_34;
					public static Func<SortRawData, ulong> __9__22_35;
					public static Func<SortRawData, WeaponType> __9__22_112;
					public static Func<SortRawData, Rarity> __9__22_113;
					public static Func<SortRawData, int> __9__22_114;
					public static Func<SortRawData, int> __9__22_115;
					public static Func<SortRawData, ulong> __9__22_116;
					public static Func<SortRawData, int> __9__22_36;
					public static Func<SortRawData, WeaponType> __9__22_37;
					public static Func<SortRawData, Rarity> __9__22_38;
					public static Func<SortRawData, int> __9__22_39;
					public static Func<SortRawData, int> __9__22_40;
					public static Func<SortRawData, ulong> __9__22_41;
					public static Func<SortRawData, int> __9__22_42;
					public static Func<SortRawData, WeaponType> __9__22_43;
					public static Func<SortRawData, Rarity> __9__22_44;
					public static Func<SortRawData, int> __9__22_45;
					public static Func<SortRawData, int> __9__22_46;
					public static Func<SortRawData, ulong> __9__22_47;
					public static Func<SortRawData, int> __9__22_48;
					public static Func<SortRawData, WeaponType> __9__22_49;
					public static Func<SortRawData, Rarity> __9__22_50;
					public static Func<SortRawData, int> __9__22_51;
					public static Func<SortRawData, int> __9__22_52;
					public static Func<SortRawData, ulong> __9__22_53;
					public static Func<SortRawData, int> __9__22_54;
					public static Func<SortRawData, WeaponType> __9__22_55;
					public static Func<SortRawData, Rarity> __9__22_56;
					public static Func<SortRawData, int> __9__22_57;
					public static Func<SortRawData, int> __9__22_58;
					public static Func<SortRawData, ulong> __9__22_59;
					public static Func<SortRawData, int> __9__22_60;
					public static Func<SortRawData, WeaponType> __9__22_61;
					public static Func<SortRawData, Rarity> __9__22_62;
					public static Func<SortRawData, int> __9__22_63;
					public static Func<SortRawData, int> __9__22_64;
					public static Func<SortRawData, ulong> __9__22_65;
					public static Func<SortRawData, int> __9__22_66;
					public static Func<SortRawData, WeaponType> __9__22_67;
					public static Func<SortRawData, Rarity> __9__22_68;
					public static Func<SortRawData, int> __9__22_69;
					public static Func<SortRawData, int> __9__22_70;
					public static Func<SortRawData, ulong> __9__22_71;
					public static Func<SortRawData, int> __9__22_72;
					public static Func<SortRawData, WeaponType> __9__22_73;
					public static Func<SortRawData, Rarity> __9__22_74;
					public static Func<SortRawData, int> __9__22_75;
					public static Func<SortRawData, int> __9__22_76;
					public static Func<SortRawData, ulong> __9__22_77;
					public static Func<SortRawData, int> __9__22_78;
					public static Func<SortRawData, WeaponType> __9__22_79;
					public static Func<SortRawData, Rarity> __9__22_80;
					public static Func<SortRawData, int> __9__22_81;
					public static Func<SortRawData, int> __9__22_82;
					public static Func<SortRawData, ulong> __9__22_83;
					public static Func<SortRawData, int> __9__22_84;
					public static Func<SortRawData, int> __9__22_85;
					public static Func<SortRawData, WeaponType> __9__22_86;
					public static Func<SortRawData, Rarity> __9__22_87;
					public static Func<SortRawData, int> __9__22_88;
					public static Func<SortRawData, int> __9__22_89;
					public static Func<SortRawData, ulong> __9__22_90;
					public static Func<SortRawData, int> __9__22_91;
					public static Func<SortRawData, int> __9__22_92;
					public static Func<SortRawData, WeaponType> __9__22_93;
					public static Func<SortRawData, Rarity> __9__22_94;
					public static Func<SortRawData, int> __9__22_95;
					public static Func<SortRawData, int> __9__22_96;
					public static Func<SortRawData, ulong> __9__22_97;
					public static Func<SortRawData, int> __9__22_98;
					public static Func<SortRawData, int> __9__22_99;
					public static Func<SortRawData, WeaponType> __9__22_100;
					public static Func<SortRawData, Rarity> __9__22_101;
					public static Func<SortRawData, int> __9__22_102;
					public static Func<SortRawData, int> __9__22_103;
					public static Func<SortRawData, ulong> __9__22_104;
					public static Func<SortRawData, int> __9__22_105;
					public static Func<SortRawData, int> __9__22_106;
					public static Func<SortRawData, WeaponType> __9__22_107;
					public static Func<SortRawData, Rarity> __9__22_108;
					public static Func<SortRawData, int> __9__22_109;
					public static Func<SortRawData, int> __9__22_110;
					public static Func<SortRawData, ulong> __9__22_111;
					public static Func<SortRawData, int> __9__23_0;
					public static Func<SortRawData, int> __9__23_1;
					public static Func<SortRawData, WeaponType> __9__23_2;
					public static Func<SortRawData, Rarity> __9__23_3;
					public static Func<SortRawData, int> __9__23_4;
					public static Func<SortRawData, int> __9__23_5;
					public static Func<SortRawData, ulong> __9__23_6;
					public static Func<SortRawData, int> __9__23_7;
					public static Func<SortRawData, WeaponType> __9__23_8;
					public static Func<SortRawData, Rarity> __9__23_9;
					public static Func<SortRawData, int> __9__23_10;
					public static Func<SortRawData, int> __9__23_11;
					public static Func<SortRawData, ulong> __9__23_12;
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
					public static Func<SortRawData, ulong> __9__25_2;
					public static Func<SortRawData, int> __9__25_3;
					public static Func<SortRawData, ulong> __9__25_4;
					public static Func<SortRawData, int> __9__26_0;
					public static Func<SortRawData, int> __9__26_1;
					public static Func<SortRawData, WeaponType> __9__26_2;
					public static Func<SortRawData, Rarity> __9__26_3;
					public static Func<SortRawData, int> __9__26_4;
					public static Func<SortRawData, int> __9__26_5;
					public static Func<SortRawData, ulong> __9__26_6;
					public static Func<SortRawData, int> __9__26_7;
					public static Func<SortRawData, WeaponType> __9__26_8;
					public static Func<SortRawData, Rarity> __9__26_9;
					public static Func<SortRawData, int> __9__26_10;
					public static Func<SortRawData, int> __9__26_11;
					public static Func<SortRawData, ulong> __9__26_12;
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
					public static Func<SortRawData, Rarity> __9__29_0;
					public static Func<SortRawData, Rarity> __9__29_1;
					public static Func<SortRawData, WeaponType> __9__29_2;
					public static Func<SortRawData, int> __9__29_3;
					public static Func<SortRawData, int> __9__29_4;
					public static Func<SortRawData, ulong> __9__29_5;
					public static Func<SortRawData, Rarity> __9__29_6;
					public static Func<SortRawData, WeaponType> __9__29_7;
					public static Func<SortRawData, int> __9__29_8;
					public static Func<SortRawData, int> __9__29_9;
					public static Func<SortRawData, ulong> __9__29_10;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__34_0;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__34_1;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__34_2;
					public static Func<Tuple<AbilityDataElement, ElementalType>, int> __9__34_3;
					public static Func<SortRawData, string> __9__34_6;
					public static Func<SortRawData, int> __9__34_7;
					public static Func<SortRawData, ElementalType> __9__34_8;
					public static Func<SortRawData, WeaponType> __9__34_9;
					public static Func<SortRawData, Rarity> __9__34_10;
					public static Func<SortRawData, int> __9__34_11;
					public static Func<SortRawData, int> __9__34_12;
					public static Func<SortRawData, ulong> __9__34_13;
					public static Func<SortRawData, string> __9__34_14;
					public static Func<SortRawData, int> __9__34_15;
					public static Func<SortRawData, ElementalType> __9__34_16;
					public static Func<SortRawData, WeaponType> __9__34_17;
					public static Func<SortRawData, Rarity> __9__34_18;
					public static Func<SortRawData, int> __9__34_19;
					public static Func<SortRawData, int> __9__34_20;
					public static Func<SortRawData, ulong> __9__34_21;
					public static Comparison<AbilityCrestFeatureGroupElement> __9__35_0;
					public static Func<SortRawData, int> __9__35_2;
					public static Func<SortRawData, string> __9__35_3;
					public static Func<SortRawData, int> __9__35_4;
					public static Func<SortRawData, int> __9__36_0;
					public static Func<SortRawData, int> __9__36_1;
					public static Func<SortRawData, int> __9__36_2;
					public static Func<SortRawData, WeaponType> __9__36_3;
					public static Func<SortRawData, Rarity> __9__36_4;
					public static Func<SortRawData, int> __9__36_5;
					public static Func<SortRawData, int> __9__36_6;
					public static Func<SortRawData, ulong> __9__36_7;
					public static Func<SortRawData, int> __9__37_0;
					public static Func<SortRawData, int> __9__37_1;
	
					// Constructors
					static __c();
					public __c();
	
					// Methods
					internal int _ApplySortRawData_b__22_0(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_1(SortRawData p);
					internal int _ApplySortRawData_b__22_2(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_3(SortRawData p);
					internal int _ApplySortRawData_b__22_4(SortRawData p);
					internal int _ApplySortRawData_b__22_5(SortRawData p);
					internal ulong _ApplySortRawData_b__22_6(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_7(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_8(SortRawData p);
					internal int _ApplySortRawData_b__22_9(SortRawData p);
					internal int _ApplySortRawData_b__22_10(SortRawData p);
					internal ulong _ApplySortRawData_b__22_11(SortRawData p);
					internal int _ApplySortRawData_b__22_12(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_13(SortRawData p);
					internal int _ApplySortRawData_b__22_14(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_15(SortRawData p);
					internal int _ApplySortRawData_b__22_16(SortRawData p);
					internal int _ApplySortRawData_b__22_17(SortRawData p);
					internal ulong _ApplySortRawData_b__22_18(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_19(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_20(SortRawData p);
					internal int _ApplySortRawData_b__22_21(SortRawData p);
					internal int _ApplySortRawData_b__22_22(SortRawData p);
					internal ulong _ApplySortRawData_b__22_23(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_24(SortRawData p);
					internal int _ApplySortRawData_b__22_25(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_26(SortRawData p);
					internal int _ApplySortRawData_b__22_27(SortRawData p);
					internal int _ApplySortRawData_b__22_28(SortRawData p);
					internal ulong _ApplySortRawData_b__22_29(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_30(SortRawData p);
					internal int _ApplySortRawData_b__22_31(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_32(SortRawData p);
					internal int _ApplySortRawData_b__22_33(SortRawData p);
					internal int _ApplySortRawData_b__22_34(SortRawData p);
					internal ulong _ApplySortRawData_b__22_35(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_112(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_113(SortRawData p);
					internal int _ApplySortRawData_b__22_114(SortRawData p);
					internal int _ApplySortRawData_b__22_115(SortRawData p);
					internal ulong _ApplySortRawData_b__22_116(SortRawData p);
					internal int _ApplySortRawData_b__22_36(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_37(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_38(SortRawData p);
					internal int _ApplySortRawData_b__22_39(SortRawData p);
					internal int _ApplySortRawData_b__22_40(SortRawData p);
					internal ulong _ApplySortRawData_b__22_41(SortRawData p);
					internal int _ApplySortRawData_b__22_42(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_43(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_44(SortRawData p);
					internal int _ApplySortRawData_b__22_45(SortRawData p);
					internal int _ApplySortRawData_b__22_46(SortRawData p);
					internal ulong _ApplySortRawData_b__22_47(SortRawData p);
					internal int _ApplySortRawData_b__22_48(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_49(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_50(SortRawData p);
					internal int _ApplySortRawData_b__22_51(SortRawData p);
					internal int _ApplySortRawData_b__22_52(SortRawData p);
					internal ulong _ApplySortRawData_b__22_53(SortRawData p);
					internal int _ApplySortRawData_b__22_54(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_55(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_56(SortRawData p);
					internal int _ApplySortRawData_b__22_57(SortRawData p);
					internal int _ApplySortRawData_b__22_58(SortRawData p);
					internal ulong _ApplySortRawData_b__22_59(SortRawData p);
					internal int _ApplySortRawData_b__22_60(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_61(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_62(SortRawData p);
					internal int _ApplySortRawData_b__22_63(SortRawData p);
					internal int _ApplySortRawData_b__22_64(SortRawData p);
					internal ulong _ApplySortRawData_b__22_65(SortRawData p);
					internal int _ApplySortRawData_b__22_66(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_67(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_68(SortRawData p);
					internal int _ApplySortRawData_b__22_69(SortRawData p);
					internal int _ApplySortRawData_b__22_70(SortRawData p);
					internal ulong _ApplySortRawData_b__22_71(SortRawData p);
					internal int _ApplySortRawData_b__22_72(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_73(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_74(SortRawData p);
					internal int _ApplySortRawData_b__22_75(SortRawData p);
					internal int _ApplySortRawData_b__22_76(SortRawData p);
					internal ulong _ApplySortRawData_b__22_77(SortRawData p);
					internal int _ApplySortRawData_b__22_78(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_79(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_80(SortRawData p);
					internal int _ApplySortRawData_b__22_81(SortRawData p);
					internal int _ApplySortRawData_b__22_82(SortRawData p);
					internal ulong _ApplySortRawData_b__22_83(SortRawData p);
					internal int _ApplySortRawData_b__22_84(SortRawData p);
					internal int _ApplySortRawData_b__22_85(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_86(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_87(SortRawData p);
					internal int _ApplySortRawData_b__22_88(SortRawData p);
					internal int _ApplySortRawData_b__22_89(SortRawData p);
					internal ulong _ApplySortRawData_b__22_90(SortRawData p);
					internal int _ApplySortRawData_b__22_91(SortRawData p);
					internal int _ApplySortRawData_b__22_92(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_93(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_94(SortRawData p);
					internal int _ApplySortRawData_b__22_95(SortRawData p);
					internal int _ApplySortRawData_b__22_96(SortRawData p);
					internal ulong _ApplySortRawData_b__22_97(SortRawData p);
					internal int _ApplySortRawData_b__22_98(SortRawData p);
					internal int _ApplySortRawData_b__22_99(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_100(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_101(SortRawData p);
					internal int _ApplySortRawData_b__22_102(SortRawData p);
					internal int _ApplySortRawData_b__22_103(SortRawData p);
					internal ulong _ApplySortRawData_b__22_104(SortRawData p);
					internal int _ApplySortRawData_b__22_105(SortRawData p);
					internal int _ApplySortRawData_b__22_106(SortRawData p);
					internal WeaponType _ApplySortRawData_b__22_107(SortRawData p);
					internal Rarity _ApplySortRawData_b__22_108(SortRawData p);
					internal int _ApplySortRawData_b__22_109(SortRawData p);
					internal int _ApplySortRawData_b__22_110(SortRawData p);
					internal ulong _ApplySortRawData_b__22_111(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__23_0(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__23_1(SortRawData p);
					internal WeaponType _ApplySortRawDataAtkPlus_b__23_2(SortRawData p);
					internal Rarity _ApplySortRawDataAtkPlus_b__23_3(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__23_4(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__23_5(SortRawData p);
					internal ulong _ApplySortRawDataAtkPlus_b__23_6(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__23_7(SortRawData p);
					internal WeaponType _ApplySortRawDataAtkPlus_b__23_8(SortRawData p);
					internal Rarity _ApplySortRawDataAtkPlus_b__23_9(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__23_10(SortRawData p);
					internal int _ApplySortRawDataAtkPlus_b__23_11(SortRawData p);
					internal ulong _ApplySortRawDataAtkPlus_b__23_12(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__24_0(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__24_1(SortRawData p);
					internal WeaponType _ApplySortRawDataHpPlus_b__24_2(SortRawData p);
					internal Rarity _ApplySortRawDataHpPlus_b__24_3(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__24_4(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__24_5(SortRawData p);
					internal ulong _ApplySortRawDataHpPlus_b__24_6(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__24_7(SortRawData p);
					internal WeaponType _ApplySortRawDataHpPlus_b__24_8(SortRawData p);
					internal Rarity _ApplySortRawDataHpPlus_b__24_9(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__24_10(SortRawData p);
					internal int _ApplySortRawDataHpPlus_b__24_11(SortRawData p);
					internal ulong _ApplySortRawDataHpPlus_b__24_12(SortRawData p);
					internal int _ApplySortRawDataGetTime_b__25_0(SortRawData p);
					internal int _ApplySortRawDataGetTime_b__25_1(SortRawData p);
					internal ulong _ApplySortRawDataGetTime_b__25_2(SortRawData p);
					internal int _ApplySortRawDataGetTime_b__25_3(SortRawData p);
					internal ulong _ApplySortRawDataGetTime_b__25_4(SortRawData p);
					internal int _ApplySortRawDataAtk_b__26_0(SortRawData p);
					internal int _ApplySortRawDataAtk_b__26_1(SortRawData p);
					internal WeaponType _ApplySortRawDataAtk_b__26_2(SortRawData p);
					internal Rarity _ApplySortRawDataAtk_b__26_3(SortRawData p);
					internal int _ApplySortRawDataAtk_b__26_4(SortRawData p);
					internal int _ApplySortRawDataAtk_b__26_5(SortRawData p);
					internal ulong _ApplySortRawDataAtk_b__26_6(SortRawData p);
					internal int _ApplySortRawDataAtk_b__26_7(SortRawData p);
					internal WeaponType _ApplySortRawDataAtk_b__26_8(SortRawData p);
					internal Rarity _ApplySortRawDataAtk_b__26_9(SortRawData p);
					internal int _ApplySortRawDataAtk_b__26_10(SortRawData p);
					internal int _ApplySortRawDataAtk_b__26_11(SortRawData p);
					internal ulong _ApplySortRawDataAtk_b__26_12(SortRawData p);
					internal int _ApplySortRawDataHp_b__27_0(SortRawData p);
					internal int _ApplySortRawDataHp_b__27_1(SortRawData p);
					internal WeaponType _ApplySortRawDataHp_b__27_2(SortRawData p);
					internal Rarity _ApplySortRawDataHp_b__27_3(SortRawData p);
					internal int _ApplySortRawDataHp_b__27_4(SortRawData p);
					internal int _ApplySortRawDataHp_b__27_5(SortRawData p);
					internal ulong _ApplySortRawDataHp_b__27_6(SortRawData p);
					internal int _ApplySortRawDataHp_b__27_7(SortRawData p);
					internal WeaponType _ApplySortRawDataHp_b__27_8(SortRawData p);
					internal Rarity _ApplySortRawDataHp_b__27_9(SortRawData p);
					internal int _ApplySortRawDataHp_b__27_10(SortRawData p);
					internal int _ApplySortRawDataHp_b__27_11(SortRawData p);
					internal ulong _ApplySortRawDataHp_b__27_12(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__28_0(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__28_1(SortRawData p);
					internal WeaponType _ApplySortRawDataBattlePower_b__28_2(SortRawData p);
					internal Rarity _ApplySortRawDataBattlePower_b__28_3(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__28_4(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__28_5(SortRawData p);
					internal ulong _ApplySortRawDataBattlePower_b__28_6(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__28_7(SortRawData p);
					internal WeaponType _ApplySortRawDataBattlePower_b__28_8(SortRawData p);
					internal Rarity _ApplySortRawDataBattlePower_b__28_9(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__28_10(SortRawData p);
					internal int _ApplySortRawDataBattlePower_b__28_11(SortRawData p);
					internal ulong _ApplySortRawDataBattlePower_b__28_12(SortRawData p);
					internal Rarity _ApplySortRawDataRarity_b__29_0(SortRawData p);
					internal Rarity _ApplySortRawDataRarity_b__29_1(SortRawData p);
					internal WeaponType _ApplySortRawDataRarity_b__29_2(SortRawData p);
					internal int _ApplySortRawDataRarity_b__29_3(SortRawData p);
					internal int _ApplySortRawDataRarity_b__29_4(SortRawData p);
					internal ulong _ApplySortRawDataRarity_b__29_5(SortRawData p);
					internal Rarity _ApplySortRawDataRarity_b__29_6(SortRawData p);
					internal WeaponType _ApplySortRawDataRarity_b__29_7(SortRawData p);
					internal int _ApplySortRawDataRarity_b__29_8(SortRawData p);
					internal int _ApplySortRawDataRarity_b__29_9(SortRawData p);
					internal ulong _ApplySortRawDataRarity_b__29_10(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__34_0(Tuple<AbilityDataElement, ElementalType> p);
					internal int _ApplySortRawDataAbilityList_b__34_1(Tuple<AbilityDataElement, ElementalType> p);
					internal int _ApplySortRawDataAbilityList_b__34_2(Tuple<AbilityDataElement, ElementalType> p);
					internal int _ApplySortRawDataAbilityList_b__34_3(Tuple<AbilityDataElement, ElementalType> p);
					internal string _ApplySortRawDataAbilityList_b__34_6(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__34_7(SortRawData p);
					internal ElementalType _ApplySortRawDataAbilityList_b__34_8(SortRawData p);
					internal WeaponType _ApplySortRawDataAbilityList_b__34_9(SortRawData p);
					internal Rarity _ApplySortRawDataAbilityList_b__34_10(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__34_11(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__34_12(SortRawData p);
					internal ulong _ApplySortRawDataAbilityList_b__34_13(SortRawData p);
					internal string _ApplySortRawDataAbilityList_b__34_14(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__34_15(SortRawData p);
					internal ElementalType _ApplySortRawDataAbilityList_b__34_16(SortRawData p);
					internal WeaponType _ApplySortRawDataAbilityList_b__34_17(SortRawData p);
					internal Rarity _ApplySortRawDataAbilityList_b__34_18(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__34_19(SortRawData p);
					internal int _ApplySortRawDataAbilityList_b__34_20(SortRawData p);
					internal ulong _ApplySortRawDataAbilityList_b__34_21(SortRawData p);
					internal int _ApplySortRawDataCategory_b__35_0(AbilityCrestFeatureGroupElement a, AbilityCrestFeatureGroupElement b);
					internal int _ApplySortRawDataCategory_b__35_2(SortRawData p);
					internal string _ApplySortRawDataCategory_b__35_3(SortRawData p);
					internal int _ApplySortRawDataCategory_b__35_4(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__36_0(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__36_1(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__36_2(SortRawData p);
					internal WeaponType _ApplySortRawDataPieceNum_b__36_3(SortRawData p);
					internal Rarity _ApplySortRawDataPieceNum_b__36_4(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__36_5(SortRawData p);
					internal int _ApplySortRawDataPieceNum_b__36_6(SortRawData p);
					internal ulong _ApplySortRawDataPieceNum_b__36_7(SortRawData p);
					internal int _ApplySortRawDataUnionAbility_b__37_0(SortRawData p);
					internal int _ApplySortRawDataUnionAbility_b__37_1(SortRawData p);
				}
	
				[Serializable]
				[CompilerGenerated]
				private sealed class __c__30<TKey>
				{
					// Fields
					public static readonly __c__30<TKey> __9;
					public static Func<SortRawData, int> __9__30_0;
					public static Func<SortRawData, string> __9__30_1;
					public static Func<SortRawData, int> __9__30_2;
	
					// Constructors
					static __c__30();
					public __c__30();
	
					// Methods
					internal int _SortAbilityCrest_b__30_0(SortRawData p);
					internal string _SortAbilityCrest_b__30_1(SortRawData p);
					internal int _SortAbilityCrest_b__30_2(SortRawData p);
				}
	
				[CompilerGenerated]
				private sealed class __c__DisplayClass34_0
				{
					// Fields
					public Tuple<AbilityDataElement, ElementalType> newData;
	
					// Constructors
					public __c__DisplayClass34_0();
	
					// Methods
					internal bool _ApplySortRawDataAbilityList_b__4(Tuple<AbilityDataElement, ElementalType> p);
				}
	
				[CompilerGenerated]
				private sealed class __c__DisplayClass34_1
				{
					// Fields
					public Tuple<AbilityDataElement, ElementalType> newData;
	
					// Constructors
					public __c__DisplayClass34_1();
	
					// Methods
					internal bool _ApplySortRawDataAbilityList_b__5(Tuple<AbilityDataElement, ElementalType> p);
				}
	
				[CompilerGenerated]
				private sealed class __c__DisplayClass35_0
				{
					// Fields
					public SortRawData rawData;
	
					// Constructors
					public __c__DisplayClass35_0();
	
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
				private int SortElementFunc(SortRawData p);
				private int SortElementDescendingFunc(SortRawData p);
				private int SortSameElementFunc(SortRawData p);
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
			BattleRoyalCharaSkin = 40
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
		public void ApplySortAndFilterForSelfInBox(CommonIconListController controller, ulong[] idArray, GiftType giftType, CommonIconListType iconListType = CommonIconListType.None, Func<List<ulong>, List<ulong>> filteredResultCustomizeAction = null);
		public void ApplySortAndFilter(List<ulong> idList, GiftType giftType, Preset preset);
		public void LoadPreset(Preset preset, GiftType giftType, ElementalType charaElement = ElementalType.NONE);
		private void SetSortTypeDefault(Preset preset, GiftType giftType);
		private void ConvertToValidSortType(Preset preset, GiftType giftType);
		public void SaveAsPreset(Preset preset, GiftType giftType = GiftType.NONE);
		private static void ClearSavedFilterCondition();
		public void ClearSavedFilterCondition(Preset preset);
		public static bool IsListPreset(Preset preset);
	}
}
