using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine.Events;

namespace Gluon
{
	public class UnitDetailModel
	{
		public enum UnitDetailType
		{
			None,
			Character,
			CharacterAndEquip,
			Dragon,
			Weapon,
			Amulet
		}

		public enum OriginType
		{
			None,
			SelfInBox,
			DefaultFromKeyId,
			Support,
			MatchingRoom
		}

		[Serializable]
		public class DetailDataBase
		{
			[Serializable]
			public class SkillAbilityInfo
			{
				public int id;

				public int level;

				public SkillAbilityInfo MakeClone()
				{
					return null;
				}
			}

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

			protected ulong keyId
			{
				get
				{
					return default(ulong);
				}
				set
				{
				}
			}

			public int maxLevel => default(int);

			public virtual int battlePower => default(int);

			public bool isSelfInBox => default(bool);

			public void DisableGrowth()
			{
			}

			public void RuleOutInvalidEventAbilities()
			{
			}

			public virtual void FillWithSelfData(GiftType giftType, ulong keyId, int charaMasterId = 0)
			{
			}

			public void FillWithDefaultData(GiftType giftType, int masterId, int level, int hpPlus, int atkPlus, int limitBreak, int additionalMaxLevel)
			{
			}

			public void FillWithSupportData(GiftType giftType, SupportData supportData)
			{
			}

			protected virtual void FillWithSelfData()
			{
			}

			protected virtual void FillWithDefaultData()
			{
			}

			protected virtual void FillWithSupportData(SupportData supportData)
			{
			}

			public bool CanGrowth()
			{
				return default(bool);
			}

			public bool CanMoveOtherScene()
			{
				return default(bool);
			}

			public virtual bool CanPowerUp()
			{
				return default(bool);
			}

			public virtual bool CanAwaken()
			{
				return default(bool);
			}

			public virtual bool CanManaCircle()
			{
				return default(bool);
			}

			public virtual bool CanLimitBreak()
			{
				return default(bool);
			}

			public virtual bool CanGradeup()
			{
				return default(bool);
			}

			public virtual bool CanBuildUp()
			{
				return default(bool);
			}

			public virtual bool CanEquipableCount()
			{
				return default(bool);
			}

			public virtual void ConvertKeyIdToMatching()
			{
			}

			public ulong GetKeyIdForSelfInBox()
			{
				return default(ulong);
			}

			public int GetAbilityLevel(int abilityIndex)
			{
				return default(int);
			}
		}

		[Serializable]
		public class CharaDetailData : DetailDataBase
		{
			public int emblemId;

			public int maxHpBase;

			public int attackBase;

			public int defenseBase;

			public int manaCount;

			public UnitType charaType;

			public int fortMaxHpPlus;

			public int fortAttackPlus;

			public int fortDefensePlus;

			public int albumMaxHpPlus;

			public int albumAttackPlus;

			public int albumDefensePlus;

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

			public override int battlePower => default(int);

			public int maxManaCount => default(int);

			private void FillSelfEmblemId()
			{
			}

			public CharaDataElement GetMasterElement()
			{
				return null;
			}

			private CharaList GetDataManagerElement()
			{
				return null;
			}

			protected override void FillWithSelfData()
			{
			}

			public void FillWithSelfSkillData(int editSkill1CharaId, int editSkill2CharaId, ulong weaponKeyId)
			{
			}

			public void FillWithSelfSkillData(PartySettingList partyData, ulong weaponKeyId)
			{
			}

			private void FillMasterBasedParams(Rarity specificRarity, string playerName)
			{
			}

			public void ResetMatchingName()
			{
			}

			protected override void FillWithDefaultData()
			{
			}

			public void FillWithAllManaCircleData()
			{
			}

			public void FillWithOrderPartyData([In] ref QuestPrepareData orderPartyUnit)
			{
			}

			protected override void FillWithSupportData(SupportData supportData)
			{
			}

			public void FillAbilities(int[] levels)
			{
			}

			public void FillSkills(int[] levels)
			{
			}

			public void FillExAbilities(int[] levels)
			{
			}

			public void CalcSelfFortPlus()
			{
			}

			public void CalcSelfAlbumPlus()
			{
			}

			public void CalcDragonPlus(DragonDetailData dragonData)
			{
			}

			public void CalcWeaponPlus(WeaponDetailData weaponData)
			{
			}

			public void CalcAmuletPlus(AmuletDetailData[] amuletData, AmuletDetailData[] amuletData2, AmuletDetailData[] amuletData3)
			{
			}

			public void CalcAllAbilityPlus(DragonDetailData dragonData, WeaponDetailData weaponData, AmuletDetailData[] abilityCrestData, AmuletDetailData[] abilityCrestData2, AmuletDetailData[] abilityCrestData3)
			{
			}

			public void CalcCharaAbilityPlus()
			{
			}

			public void CalcFinalStatus(bool isAllAbilityPlus = false)
			{
			}

			public int GetDefaultEquipWeaponId()
			{
				return default(int);
			}

			public override bool CanManaCircle()
			{
				return default(bool);
			}
		}

		[Serializable]
		public class DragonDetailData : DetailDataBase
		{
			public int maxHpBase;

			public int attackBase;

			public int defenseBase;

			public int abilityLv1;

			public int abilityLv2;

			public int fortMaxHpPlus;

			public int fortAttackPlus;

			public int fortDefensePlus;

			public int albumMaxHpPlus;

			public int albumAttackPlus;

			public int albumDefensePlus;

			public int reliabilityLevel;

			public int onlyHp;

			public int onlyAtk;

			public int onlyFortHp;

			public int onlyFortAtk;

			public int onlyAlbumHp;

			public int onlyAlbumAtk;

			private ElementalType charaElement;

			public override int battlePower => default(int);

			public override void FillWithSelfData(GiftType giftType, ulong keyId, int charaMasterId = 0)
			{
			}

			protected override void FillWithSelfData()
			{
			}

			protected override void FillWithDefaultData()
			{
			}

			public void SetCharaElement(int charaMasterId)
			{
			}

			public void FillWithOrderPartyData([In] ref QuestPrepareData orderPartyUnit)
			{
			}

			protected override void FillWithSupportData(SupportData supportData)
			{
			}

			public void FillWithAlbumData(ulong masterId)
			{
			}

			public void AdjustFortBonus(int fortDragonMaxHpPlus, int fortDragonAttackPlus, int fortDragonDefensePlus)
			{
			}

			private void FillMasterBasedParams()
			{
			}

			public void ResetMatchingName()
			{
			}

			public void CalcSelfFortPlus()
			{
			}

			public void CalcSelfAlbumPlus()
			{
			}

			public void DragonOnlyStatus()
			{
			}

			public DragonDataElement GetMasterElement()
			{
				return null;
			}

			public DragonLevelElement GetMasterLevelElement()
			{
				return null;
			}

			private DragonList GetDataManagerElement()
			{
				return null;
			}

			public void FillAbilities(int[] abilityLevels)
			{
			}

			public void FillSkills()
			{
			}

			public override bool CanLimitBreak()
			{
				return default(bool);
			}
		}

		[Serializable]
		public class WeaponDetailData : DetailDataBase
		{
			private ElementalType charaElement;

			public int aWeaponSlotNum;

			public int bWeaponSlotNum;

			public int cWeaponSlotNum;

			public List<int> passiveAbilityIdList;

			public override int battlePower => default(int);

			public int equipSkinWeaponId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public override void FillWithSelfData(GiftType giftType, ulong keyId, int charaMasterId = 0)
			{
			}

			protected override void FillWithSelfData()
			{
			}

			protected override void FillWithDefaultData()
			{
			}

			public void SetCharaElement(int charaMasterId)
			{
			}

			public void FillWithOrderPartyData([In] ref QuestPrepareData orderPartyUnit)
			{
			}

			protected override void FillWithSupportData(SupportData supportData)
			{
			}

			private void FillMasterBasedParams()
			{
			}

			public void ResetMatchingName()
			{
			}

			public WeaponBodyElement GetMasterElement()
			{
				return null;
			}

			public WeaponSkinElement GetMasterSkinElement()
			{
				return null;
			}

			public WeaponLevelElement GetMasterLevelElement()
			{
				return null;
			}

			private WeaponBodyList GetDataManagerElement()
			{
				return null;
			}

			public void FillSkills()
			{
			}

			public void FillAbilities()
			{
			}

			public void FillPassiveAbility(int[] releasedNoList)
			{
			}

			public override bool CanPowerUp()
			{
				return default(bool);
			}

			public override bool CanLimitBreak()
			{
				return default(bool);
			}

			public override bool CanBuildUp()
			{
				return default(bool);
			}

			public override bool CanEquipableCount()
			{
				return default(bool);
			}
		}

		[Serializable]
		public class AmuletDetailData : DetailDataBase
		{
			public int unionAbilityGroupId;

			public override int battlePower => default(int);

			protected override void FillWithSelfData()
			{
			}

			protected override void FillWithDefaultData()
			{
			}

			public void FillWithOrderPartyData([In] ref CommonPartyPowerCalculateAbilityCrestData crestData)
			{
			}

			protected override void FillWithSupportData(SupportData supportData)
			{
			}

			private void FillMasterBasedParams()
			{
			}

			public void ResetMatchingName()
			{
			}

			public AbilityCrestElement GetMasterElement()
			{
				return null;
			}

			private AbilityCrestList GetDataManagerElement()
			{
				return null;
			}

			public void FillAbilities()
			{
			}

			public override bool CanPowerUp()
			{
				return default(bool);
			}

			public override bool CanLimitBreak()
			{
				return default(bool);
			}

			public override bool CanBuildUp()
			{
				return default(bool);
			}

			public override bool CanEquipableCount()
			{
				return default(bool);
			}
		}

		private static UnitDetailModel instance;

		public UnitDetailType detailType;

		public UnityAction unitLockCallback;

		public UnityAction crestFavoriteCallback;

		public UnityAction backButtonCallback;

		public UnityAction backButtonFastCallback;

		public string playerName;

		public bool showAmuletSwitchButton;

		public bool isShowLockButton;

		public bool isShowTutorialSummon;

		public int partyIndex;

		public bool isAddEditSkillPower;

		public const int equipableMaxCount = 4;

		public bool isAlbumDetail;

		public bool _showAllAmuletStories;

		public List<int> partyPassiveAbilityIdList;

		public DetailDataBase data;

		public CharaDetailData charaData;

		public WeaponDetailData weaponData;

		public DragonDetailData dragonData;

		public AmuletDetailData[] abilityCrestData1;

		public AmuletDetailData[] abilityCrestData2;

		public AmuletDetailData[] abilityCrestData3;

		public static UnitDetailModel Instance => null;

		public bool showAllAmuletStories
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public int battlePower => default(int);

		public int normalizedSwitchableImageIndex => default(int);

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private UnitDetailModel()
		{
		}

		static UnitDetailModel()
		{
		}

		public static int CalculateBattlePower(UnitDetailType detailType, UnitDetailDataWithEquip fullData)
		{
			return default(int);
		}

		public List<int> GetSwitchableSubImageNormalizedIdList()
		{
			return null;
		}

		public static T DeepClone<T>(T obj) where T : class
		{
			return null;
		}

		public static UnitDetailModel CreateInSelfBoxModel(UnitDetailType type, ulong keyId, ulong equipWeaponId = 0uL, ulong equipDragonId = 0uL, ulong equipAbilityCrest1_1 = 0uL, ulong equipAbilityCrest1_2 = 0uL, ulong equipAbilityCrest1_3 = 0uL, ulong equipAbilityCrest2_1 = 0uL, ulong equipAbilityCrest2_2 = 0uL, ulong equipAbilityCrest3_1 = 0uL, ulong equipAbilityCrest3_2 = 0uL, int equipWeaponSkinId = 0, int index = 0, int editSkill1CharaId = 0, int editSkill2CharaId = 0)
		{
			return null;
		}

		public static UnitDetailModel CreateInSelfBoxModelPartySettingList(UnitDetailType type, int index = 0, [Optional] PartySettingList partySettingList)
		{
			return null;
		}

		private void GetCharaEquipData(ulong charaKeyId, out ulong equipWeaponKeyId, out ulong equipDragonKeyId)
		{
		}

		private void InitInSelfBox(UnitDetailType type, ulong keyId, ulong equipWeaponId, ulong equipDragonId, ulong[] equipAmuletId1, ulong[] equipAmuletId2, ulong[] equipAmuletId3, int equipSkinWeaponId, int editSkill1CharaId, int editSkill2CharaId, int index)
		{
		}

		private void InitInSelfBoxPartySettingList(UnitDetailType type, int index, PartySettingList partySettingList)
		{
		}

		public static UnitDetailModel CreateDefaultModelFromKeyId(UnitDetailType type, int masterId, int level = 1, int hpPlus = 0, int atkPlus = 0, int limitBreak = 0, Rarity charaSpecRarity = Rarity.NONE, bool showAllAmuletStories = false)
		{
			return null;
		}

		public void InitDefaultFromKeyId(UnitDetailType type, int masterId, int level, int hpPlus, int atkPlus, int limitBreak, Rarity charaSpecRarity, int additionalMaxLevel)
		{
		}

		public static UnitDetailModel CreateOrderPartyUnitModel(UnitDetailType type, int partyIndex, [In] ref QuestPrepareData orderPartyUnit)
		{
			return null;
		}

		private void InitOrderPartyUnitModel(UnitDetailType type, int partyIndex, [In] ref QuestPrepareData orderPartyUnit)
		{
		}

		public static UnitDetailModel CreateOrderPartyCrestModel([In] ref CommonPartyPowerCalculateAbilityCrestData crestData, bool showAllAbilityCrestStories = false)
		{
			return null;
		}

		public static UnitDetailModel CreateAlbumModel(UnitDetailType type, int masterId)
		{
			return null;
		}

		public static UnitDetailModel PlayerName(string UserName)
		{
			return null;
		}

		public static UnitDetailModel CreateSupportCharaModel(TotalSupportData supportData)
		{
			return null;
		}

		private void InitSupportChara(TotalSupportData supportData)
		{
		}

		public static UnitDetailModel CreateMatchingRoomCharaModel(MatchingRoomDetailData MatchingRoomCharaData, int memberIndex, UnitDetailType detailType = UnitDetailType.CharacterAndEquip, [Optional] string playerName, bool isSelf = false)
		{
			return null;
		}

		public static UnitDetailModel CreateAmuletModelFromMatchingData(MatchingRoomDetailData MatchingRoomCharaData, int amuletNumber, [Optional] string playerName, bool isSelf = false)
		{
			return null;
		}

		private void InitMatchingRoomChara(MatchingRoomDetailData matchingRoomCharaData, int memberIndex, UnitDetailType detailType = UnitDetailType.CharacterAndEquip, [Optional] string playerName, bool isSelf = false)
		{
		}

		private void InitMatchingRoomAmulet(MatchingRoomDetailData matchingRoomCharaData, int amuletNumber, [Optional] string playerName, bool isSelf = false)
		{
		}

		public static int GetCharaPartyPowerByDetailModel(CharaDetailData charaData)
		{
			return default(int);
		}

		public static int GetDragonPartyPowerByDetailModel(DragonDetailData dragonData, ElementalType charaElementType = ElementalType.NONE)
		{
			return default(int);
		}

		public static int GetWeaponPartyPowerByDetailModel(WeaponDetailData weaponData, ElementalType charaElementType = ElementalType.NONE)
		{
			return default(int);
		}

		public static int GetAmuletPartyPowerByDetailModel(AmuletDetailData amuletData)
		{
			return default(int);
		}

		public static void SetAbilityCustomData(AmuletDetailData args, List<AbilityPageData> abilityCustomDataList)
		{
		}

		public bool IsAllPlusEquip()
		{
			return default(bool);
		}

		public static List<int> GetPassiveAbilityIdList(WeaponType weaponType, ElementalType elementType)
		{
			return null;
		}
	}
}
