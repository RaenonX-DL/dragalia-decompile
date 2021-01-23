/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailModel
	{
		// Fields
		private static UnitDetailModel instance;
		public UnitDetailType detailType;
		public UnityAction unitLockCallback;
		public UnityAction backButtonCallback;
		public UnityAction backButtonFastCallback;
		public string playerName;
		public bool showAmuletSwitchButton;
		public bool isShowLockButton;
		public int partyIndex;
		public bool isAddEditSkillPower;
		public const int equipableMaxCount = 4;
		public bool _showAllAmuletStories;
		public List<int> partyPassiveAbilityIdList;
		public DetailDataBase data;
		public CharaDetailData charaData;
		public WeaponDetailData weaponData;
		public DragonDetailData dragonData;
		public AmuletDetailData[] abilityCrestData1;
		public AmuletDetailData[] abilityCrestData2;
	
		// Properties
		public static UnitDetailModel Instance { get; }
		public bool showAllAmuletStories { get; private set; }
		public int battlePower { get; }
		public int normalizedSwitchableImageIndex { get; }
	
		// Nested types
		public enum UnitDetailType
		{
			None = 0,
			Character = 1,
			CharacterAndEquip = 2,
			Dragon = 3,
			Weapon = 4,
			Amulet = 5
		}
	
		public enum OriginType
		{
			None = 0,
			SelfInBox = 1,
			DefaultFromKeyId = 2,
			Support = 3,
			MatchingRoom = 4
		}
	
		[Serializable]
		public class DetailDataBase
		{
			// Fields
			public GiftType giftType;
			public OriginType originType;
			public int masterId;
			private ulong _keyId;
			protected ulong matchingKeyId;
			public bool useMatchingKeyId;
			public int level;
			public int baseMaxLevel;
			public int additionalMaxLevel;
			public int exp;
			public int buildupCount;
			public int maxHp;
			public int attack;
			public int defense;
			public int maxHpPositive;
			public int attackPositive;
			public int maxHpPositiveLimit;
			public int maxAttackPositiveLimit;
			public int plusVal;
			public int limitBreakLevel;
			public int limitOverLevel;
			public int equipableCount;
			public int pieceCount;
			public int[] equipUnionIds;
			public bool isLocked;
			public Rarity rarity;
			public ElementalType elementType;
			public WeaponType weaponType;
			public string name;
			public bool isVoiceLoadComplete;
			public bool isSeasonVoiceLoadComplete;
			public int equipableMaxCount;
			public SkillAbilityInfo[] skills;
			public SkillAbilityInfo[] abilities;
			public SkillAbilityInfo[] exAbilities;
			private bool forceDisableGrowthButton;
	
			// Properties
			protected ulong keyId { get; set; }
			public int maxLevel { get; }
			public virtual int battlePower { get; }
			public bool isSelfInBox { get; }
	
			// Nested types
			[Serializable]
			public class SkillAbilityInfo
			{
				// Fields
				public int id;
				public int level;
	
				// Constructors
				public SkillAbilityInfo();
	
				// Methods
				public SkillAbilityInfo MakeClone();
			}
	
			// Constructors
			public DetailDataBase();
	
			// Methods
			public void DisableGrowth();
			public void RuleOutInvalidEventAbilities();
			public virtual void FillWithSelfData(GiftType giftType, ulong keyId, int charaMasterId = 0);
			public void FillWithDefaultData(GiftType giftType, int masterId, int level, int hpPlus, int atkPlus, int limitBreak, int additionalMaxLevel);
			public void FillWithSupportData(GiftType giftType, SupportData supportData);
			protected virtual void FillWithSelfData();
			protected virtual void FillWithDefaultData();
			protected virtual void FillWithSupportData(SupportData supportData);
			public bool CanGrowth();
			public bool CanMoveOtherScene();
			public virtual bool CanPowerUp();
			public virtual bool CanAwaken();
			public virtual bool CanManaCircle();
			public virtual bool CanLimitBreak();
			public virtual bool CanGradeup();
			public virtual bool CanBuildUp();
			public virtual bool CanEquipableCount();
			public virtual void ConvertKeyIdToMatching();
			public ulong GetKeyIdForSelfInBox();
		}
	
		[Serializable]
		public class CharaDetailData : DetailDataBase
		{
			// Fields
			public int emblemId;
			public int maxHpBase;
			public int attackBase;
			public int defenseBase;
			public int manaCount;
			public UnitType charaType;
			public int fortMaxHpPlus;
			public int fortAttackPlus;
			public int fortDefensePlus;
			public int weaponMaxHpPlus;
			public int weaponAttackPlus;
			public int weaponDefensePlus;
			public int dragonMaxHpPlus;
			public int dragonAttackPlus;
			public int dragonDefensePlus;
			public int amuletMaxHpPlus;
			public int amuletAttackPlus;
			public int charaAbilityMaxHpPlus;
			public int charaAbilityAttackPlus;
			public int charaAbilityDefensePlus;
			public int allAbilityMaxHpPlus;
			public int allAbilityAttackPlus;
			public int allAbilityDefensePlus;
			public int sumMaxHpPositive;
			public int sumAtkPositive;
			public int sumMaxHpPositiveLimit;
			public int sumAtkPositiveLimit;
			public int burstAttackLevel;
			public int comboLevel;
			public bool isShareSkill;
			public int[] shareSkillId;
			public int[] shareSkillLevel;
			public int[] shareSkillMaxLevel;
			public AbilityConst.UnitType[] shareSkillType;
			public Rarity charaSpecRarity;
	
			// Properties
			public override int battlePower { get; }
			public int maxManaCount { get; }
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Func<char, bool> __9__60_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _get_maxManaCount_b__60_0(char c);
			}
	
			// Constructors
			public CharaDetailData();
	
			// Methods
			private void FillSelfEmblemId();
			public CharaDataElement GetMasterElement();
			private CharaList GetDataManagerElement();
			protected override void FillWithSelfData();
			public void FillWithSelfSkillData(int editSkill1CharaId, int editSkill2CharaId, ulong weaponKeyId);
			public void FillWithSelfSkillData(PartySettingList partyData, ulong weaponKeyId);
			private void FillMasterBasedParams(Rarity specificRarity, string playerName);
			public void ResetMatchingName();
			protected override void FillWithDefaultData();
			protected override void FillWithSupportData(SupportData supportData);
			public void FillAbilities(int[] levels);
			public void FillSkills(int[] levels);
			public void FillExAbilities(int[] levels);
			public void CalcSelfFortPlus();
			public void CalcDragonPlus(DragonDetailData dragonData);
			public void CalcWeaponPlus(WeaponDetailData weaponData);
			public void CalcAmuletPlus(AmuletDetailData[] amuletData, AmuletDetailData[] amuletData2);
			public void CalcAllAbilityPlus(DragonDetailData dragonData, WeaponDetailData weaponData, AmuletDetailData[] abilityCrestData, AmuletDetailData[] abilityCrestData2);
			public void CalcCharaAbilityPlus();
			public void CalcFinalStatus(bool isAllAbilityPlus = false);
			public int GetDefaultEquipWeaponId();
			public override bool CanManaCircle();
		}
	
		[Serializable]
		public class DragonDetailData : DetailDataBase
		{
			// Fields
			public int maxHpBase;
			public int attackBase;
			public int defenseBase;
			public int abilityLv1;
			public int abilityLv2;
			public int fortMaxHpPlus;
			public int fortAttackPlus;
			public int fortDefensePlus;
			public int reliabilityLevel;
			private ElementalType charaElement;
	
			// Properties
			public override int battlePower { get; }
	
			// Constructors
			public DragonDetailData();
	
			// Methods
			public override void FillWithSelfData(GiftType giftType, ulong keyId, int charaMasterId = 0);
			protected override void FillWithSelfData();
			protected override void FillWithDefaultData();
			public void SetCharaElement(int charaMasterId);
			protected override void FillWithSupportData(SupportData supportData);
			public void AdjustFortBonus(int fortDragonMaxHpPlus, int fortDragonAttackPlus, int fortDragonDefensePlus);
			private void FillMasterBasedParams();
			public void ResetMatchingName();
			public void CalcSelfFortPlus();
			public DragonDataElement GetMasterElement();
			public DragonLevelElement GetMasterLevelElement();
			private DragonList GetDataManagerElement();
			public void FillAbilities(int[] abilityLevels);
			public void FillSkills();
			public override bool CanLimitBreak();
			[CompilerGenerated]
			private bool _CanLimitBreak_b__26_0(GrowthBaseCommonData data);
		}
	
		[Serializable]
		public class WeaponDetailData : DetailDataBase
		{
			// Fields
			private ElementalType charaElement;
			[CompilerGenerated]
			private int _equipSkinWeaponId_k__BackingField;
			public int aWeaponSlotNum;
			public int bWeaponSlotNum;
			public List<int> passiveAbilityIdList;
	
			// Properties
			public override int battlePower { get; }
			public int equipSkinWeaponId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public WeaponDetailData();
	
			// Methods
			public override void FillWithSelfData(GiftType giftType, ulong keyId, int charaMasterId = 0);
			protected override void FillWithSelfData();
			protected override void FillWithDefaultData();
			public void SetCharaElement(int charaMasterId);
			protected override void FillWithSupportData(SupportData supportData);
			private void FillMasterBasedParams();
			public void ResetMatchingName();
			public WeaponBodyElement GetMasterElement();
			public WeaponSkinElement GetMasterSkinElement();
			public WeaponLevelElement GetMasterLevelElement();
			private WeaponBodyList GetDataManagerElement();
			public void FillSkills();
			public void FillAbilities();
			public void FillPassiveAbility(int[] releasedNoList);
			public override bool CanPowerUp();
			public override bool CanLimitBreak();
			public override bool CanBuildUp();
			public override bool CanEquipableCount();
			[CompilerGenerated]
			private bool _CanLimitBreak_b__25_0(GrowthBaseCommonData data);
		}
	
		[Serializable]
		public class AmuletDetailData : DetailDataBase
		{
			// Fields
			public int unionAbilityGroupId;
	
			// Properties
			public override int battlePower { get; }
	
			// Constructors
			public AmuletDetailData();
	
			// Methods
			protected override void FillWithSelfData();
			protected override void FillWithDefaultData();
			protected override void FillWithSupportData(SupportData supportData);
			private void FillMasterBasedParams();
			public void ResetMatchingName();
			public AbilityCrestElement GetMasterElement();
			private AbilityCrestList GetDataManagerElement();
			public void FillAbilities();
			public override bool CanPowerUp();
			public override bool CanLimitBreak();
			public override bool CanBuildUp();
			public override bool CanEquipableCount();
			[CompilerGenerated]
			private bool _CanLimitBreak_b__12_0(GrowthBaseCommonData data);
		}
	
		// Constructors
		private UnitDetailModel();
		static UnitDetailModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsInstanceEmpty();
		public static int CalculateBattlePower(UnitDetailType detailType, UnitDetailDataWithEquip fullData);
		public List<int> GetSwitchableSubImageNormalizedIdList();
		public static T DeepClone<T>(T obj)
			where T : class;
		public static UnitDetailModel CreateInSelfBoxModel(UnitDetailType type, ulong keyId, ulong equipWeaponId = 0, ulong equipDragonId = 0, ulong equipAbilityCrest1_1 = 0, ulong equipAbilityCrest1_2 = 0, ulong equipAbilityCrest1_3 = 0, ulong equipAbilityCrest2_1 = 0, ulong equipAbilityCrest2_2 = 0, int equipWeaponSkinId = 0, int index = 0, int editSkill1CharaId = 0, int editSkill2CharaId = 0);
		public static UnitDetailModel CreateInSelfBoxModelPartySettingList(UnitDetailType type, int index = 0, PartySettingList partySettingList = null);
		private void GetCharaEquipData(ulong charaKeyId, out ulong equipWeaponKeyId, out ulong equipDragonKeyId);
		private void InitInSelfBox(UnitDetailType type, ulong keyId, ulong equipWeaponId, ulong equipDragonId, ulong[] equipAmuletId1, ulong[] equipAmuletId2, int equipSkinWeaponId, int editSkill1CharaId, int editSkill2CharaId, int index);
		private void InitInSelfBoxPartySettingList(UnitDetailType type, int index, PartySettingList partySettingList);
		public static UnitDetailModel CreateDefaultModelFromKeyId(UnitDetailType type, int masterId, int level = 1, int hpPlus = 0, int atkPlus = 0, int limitBreak = 0, Rarity charaSpecRarity = Rarity.NONE, bool showAllAmuletStories = false);
		public void InitDefaultFromKeyId(UnitDetailType type, int masterId, int level, int hpPlus, int atkPlus, int limitBreak, Rarity charaSpecRarity, int additionalMaxLevel);
		public static UnitDetailModel PlayerName(string UserName);
		public static UnitDetailModel CreateSupportCharaModel(TotalSupportData supportData);
		private void InitSupportChara(TotalSupportData supportData);
		public static UnitDetailModel CreateMatchingRoomCharaModel(MatchingRoomDetailData MatchingRoomCharaData, UnitDetailType detailType = UnitDetailType.CharacterAndEquip, string playerName = null, bool isSelf = false);
		public static UnitDetailModel CreateAmuletModelFromMatchingData(MatchingRoomDetailData MatchingRoomCharaData, int amuletNumber, string playerName = null, bool isSelf = false);
		private void InitMatchingRoomChara(MatchingRoomDetailData matchingRoomCharaData, UnitDetailType detailType = UnitDetailType.CharacterAndEquip, string playerName = null, bool isSelf = false);
		private void InitMatchingRoomAmulet(MatchingRoomDetailData matchingRoomCharaData, int amuletNumber, string playerName = null, bool isSelf = false);
		public static int GetCharaPartyPowerByDetailModel(CharaDetailData charaData);
		public static int GetDragonPartyPowerByDetailModel(DragonDetailData dragonData, ElementalType charaElementType = ElementalType.NONE);
		public static int GetWeaponPartyPowerByDetailModel(WeaponDetailData weaponData, ElementalType charaElementType = ElementalType.NONE);
		public static int GetAmuletPartyPowerByDetailModel(AmuletDetailData amuletData);
		public static void SetAbilityCustomData(AmuletDetailData args, List<AbilityPageData> abilityCustomDataList);
		public bool IsAllPlusEquip();
		public static List<int> GetPassiveAbilityIdList(WeaponType weaponType, ElementalType elementType);
	}
}
