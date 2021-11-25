using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class GrowthUnitEnhanceModel
	{
		public enum DataType
		{
			None,
			Weapon,
			Crest
		}

		public enum TutorialType
		{
			None,
			Buildup,
			LimitBreak,
			Result
		}

		private DataType _dataType;

		private int _masterId;

		private int _rarity;

		private string _name;

		private int _buildupCount;

		private int _limitBreak;

		private int _limitOver;

		private int _hp;

		private int _atk;

		private int _power;

		private int _equipCount;

		private bool _isFavorite;

		private WeaponBodyElement targetWeaponBodyElement;

		private AbilityCrestElement targetCrestElement;

		private WeaponBodyList userWeaponData;

		private AbilityCrestList userCrestData;

		public DataType dataType => default(DataType);

		public int masterId => default(int);

		public int rarity => default(int);

		public string unitName => null;

		public int buildupCount => default(int);

		public int limitBreak => default(int);

		public int limitOver => default(int);

		public int hp => default(int);

		public int atk => default(int);

		public int power => default(int);

		public int equipableCount => default(int);

		public bool isFavorite => default(bool);

		public int slotType1NowCount => default(int);

		public int slotType1MaxCount => default(int);

		public int slotType2NowCount => default(int);

		public int slotType2MaxCount => default(int);

		public int slotType3NowCount => default(int);

		public int slotType3MaxCount => default(int);

		public int emptySlotCount => default(int);

		public int additionalSlotCount => default(int);

		public int additionalSlotType1Count => default(int);

		public int additionalSlotType2Count => default(int);

		public int additionalSlotType3Count => default(int);

		public int weaponPassiveAbilityReleasedCount => default(int);

		public int weaponPassiveAbilityDataMaxCount => default(int);

		public int weaponBonusNowCount => default(int);

		public int weaponBonusMaxCount => default(int);

		public WeaponType weaponType => default(WeaponType);

		public float weaponBonusHpParam => default(float);

		public float weaponBonusAtkParam => default(float);

		public int maxHpPlus => default(int);

		public int maxAtkPlus => default(int);

		public int nowHpPlus => default(int);

		public int nowAtkPlus => default(int);

		public TutorialType tutorialType
		{
			[CompilerGenerated]
			get
			{
				return default(TutorialType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GrowthUnitEnhanceModel(DataType type, int masterId)
		{
		}

		public void UpdateModel()
		{
		}

		public void UpdateUserWeaponData()
		{
		}

		public void UpdateUserCrestData()
		{
		}

		public int GetSkillId(int toLimitOver = -1)
		{
			return default(int);
		}

		public int GetSkillLevel(int toLimitBreak = -1, int toLimitOver = -1)
		{
			return default(int);
		}

		public int GetAbilityId(int abilityNo, int toLimitOver = -1, int toLimitBreak = -1)
		{
			return default(int);
		}

		public int GetWeaponAbilityLevel(int abilityNo, int toLimitOver = -1)
		{
			return default(int);
		}

		public int GetCrestAbilityLevel(int abilityNo, int toLimitBreak = -1)
		{
			return default(int);
		}

		public int GetMaxBuildupCount()
		{
			return default(int);
		}

		public int GetMaxBuildupCountByLimitBreakCount(int limitBreak)
		{
			return default(int);
		}

		public int GetMaxLimitBreak()
		{
			return default(int);
		}

		public int GetMaxLimitBreakByLimitOver(int limitOver)
		{
			return default(int);
		}

		public int GetMaxLimitOver()
		{
			return default(int);
		}

		public int GetMaxEquipableCount()
		{
			return default(int);
		}

		public bool CanBuildup()
		{
			return default(bool);
		}

		public bool ExistsBuildupDataByPieceType(BuildupPieceType pieceType)
		{
			return default(bool);
		}

		public bool ExistsWeapopnPassiveAbility()
		{
			return default(bool);
		}

		public bool CanLimitBreak()
		{
			return default(bool);
		}

		public bool CanLimitOver()
		{
			return default(bool);
		}

		public bool CanReleaseWeaponPassiveAbility()
		{
			return default(bool);
		}

		public bool CanReleaseCrestSlot()
		{
			return default(bool);
		}

		public bool CanReleaseWeaponBonus()
		{
			return default(bool);
		}

		public bool CanReleaseEquipableCount()
		{
			return default(bool);
		}

		public int GetUnlockConditonLevelByPieceTypeAndStep(BuildupPieceType pieceType, int step)
		{
			return default(int);
		}

		public int GetUnlockConditonLimitBreakCountByPieceTypeAndStep(BuildupPieceType pieceType, int step)
		{
			return default(int);
		}

		public int GetUnlockConditonLimitOverCountByPieceTypeAndStep(BuildupPieceType pieceType, int step)
		{
			return default(int);
		}

		public string GetBuildupPreConditionString(BuildupPieceType pieceType, int step)
		{
			return null;
		}

		public GrowthWeaponSkinConfirmData[] GetLimitBreakRewardSkinConfirmDatas()
		{
			return null;
		}

		public GrowthWeaponSkinConfirmData[] GetLimitOverRewardSkinIds()
		{
			return null;
		}

		public GrowthWeaponSkinConfirmData[] GetWeaponPassiveAbilityRewardSkinIds()
		{
			return null;
		}

		public int GetHpParamByBuildupCount(int builupCount)
		{
			return default(int);
		}

		public int GetAtkParamByBuildupCount(int builupCount)
		{
			return default(int);
		}

		public Dictionary<int, int> GetNeedMaterialFromNowBuildupToSpecifiedBuildup(int toBuildup)
		{
			return null;
		}

		public Dictionary<int, int> GetNeedMaterialFromNowLimitBreakToSpecifiedLimitBreak(int releaseCount, int useItemCount)
		{
			return null;
		}

		public Dictionary<int, int> GetNeedMaterialFromNowEquipableCountToSpecifiedEquipableCount(int toCount)
		{
			return null;
		}

		public int GetLimitBreakItemId()
		{
			return default(int);
		}

		public Dictionary<int, int> GetNeedMaterialToNextLimitOver()
		{
			return null;
		}

		public Dictionary<int, int> GetNeedMaterialToReleaseWeaponBonus()
		{
			return null;
		}

		public int GetNeedRupiToReleaseWeaponBonus()
		{
			return default(int);
		}

		public Dictionary<int, int> GetNeedMaterialBySlotCount(BuildupPieceType pieceType, int count)
		{
			return null;
		}

		public int GetNeedRupiBySlotCount(BuildupPieceType pieceType, int count)
		{
			return default(int);
		}

		public int GetMaxEquipCountByNow()
		{
			return default(int);
		}

		public int[] GetWeaponPassiveAbilityDataIds()
		{
			return null;
		}

		public int GetNeedDewByLimitBreak(int limitBreak)
		{
			return default(int);
		}

		public int GetNeedDewFromNowLimitBreakToSpecifiedLimitBreak(int releaseCount, int useItemCount)
		{
			return default(int);
		}

		public int GetNeedDewByEquipableCount(int count)
		{
			return default(int);
		}

		public int GetNeedDewFromNowEquipableCountToSpecifiedEquipableCount(int toCount)
		{
			return default(int);
		}

		public int GetPlusItemId(MaterialType materialType)
		{
			return default(int);
		}

		public bool CanGrowPlusParam()
		{
			return default(bool);
		}

		public int GetNeedRupiByLimitBreak(int limitBreak)
		{
			return default(int);
		}

		public int GetNeedRupiFromNowLimitBreakToSpecifiedLimitBreak(int releaseCount, int useItemCount)
		{
			return default(int);
		}

		public int GetNeedRupiByEquipCount(int equipSetp)
		{
			return default(int);
		}

		public int GetNeedRupiFromNowEquipCountToSpecifiedEquipCount(int toEquipSetp)
		{
			return default(int);
		}

		public int GetNeedRupiByLimitOver(int limitOver)
		{
			return default(int);
		}

		public int GetNeedRupiFromNowLimitBreakToSpecifiedLimitOver(int toLimitOver)
		{
			return default(int);
		}

		public int[] GetSkinIdsFromNowLimitBreakToSpecifiedLimitBreak(int toLimitBreak)
		{
			return null;
		}

		public int[] GetSkinIdsFromNowLimitOverToSpecifiedLimitOver(int toLimitOver)
		{
			return null;
		}

		public void SetReleasableBuildupInfo(ref Dictionary<int, int> materialDatas, ref int canReleaseCount)
		{
		}

		public void SetReleasableWeaponPassiveAbilityInfo(ref Dictionary<int, int> materialDatas, ref List<int> abilityIds, ref int needRupi)
		{
		}

		public void SetReleasableSlotInfo(ref Dictionary<int, int> materialDatas, ref int addSlotType1, ref int addSlotType2, ref int addSlotType3, ref int needRupi)
		{
		}

		public void SetReleasableWeaponBonusInfo(ref Dictionary<int, int> materialDatas, ref int releaseCount, ref int needRupi)
		{
		}

		public void UpdateTutorialType()
		{
		}

		public void ResetTutorialType()
		{
		}

		private void SetupWeaponData()
		{
		}

		private void SetupCrestData()
		{
		}

		private TutorialType GetPlayTutorialType()
		{
			return default(TutorialType);
		}

		public static Localize.TextId GetConditionLimitBreakString(DataType dataType, int conditionLimitBreak)
		{
			return default(Localize.TextId);
		}

		public bool IsShowMemorialRiseEffect()
		{
			return default(bool);
		}
	}
}
