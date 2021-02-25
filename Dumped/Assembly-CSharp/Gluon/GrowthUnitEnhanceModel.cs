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
	public class GrowthUnitEnhanceModel
	{
		// Fields
		[CompilerGenerated]
		private TutorialType _tutorialType_k__BackingField;
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
	
		// Properties
		public DataType dataType { get; }
		public int masterId { get; }
		public int rarity { get; }
		public string unitName { get; }
		public int buildupCount { get; }
		public int limitBreak { get; }
		public int limitOver { get; }
		public int hp { get; }
		public int atk { get; }
		public int power { get; }
		public int equipableCount { get; }
		public bool isFavorite { get; }
		public int slotType1NowCount { get; }
		public int slotType1MaxCount { get; }
		public int slotType2NowCount { get; }
		public int slotType2MaxCount { get; }
		public int slotType3NowCount { get; }
		public int slotType3MaxCount { get; }
		public int emptySlotCount { get; }
		public int additionalSlotCount { get; }
		public int additionalSlotType1Count { get; }
		public int additionalSlotType2Count { get; }
		public int additionalSlotType3Count { get; }
		public int weaponPassiveAbilityReleasedCount { get; }
		public int weaponPassiveAbilityDataMaxCount { get; }
		public int weaponBonusNowCount { get; }
		public int weaponBonusMaxCount { get; }
		public WeaponType weaponType { get; }
		public float weaponBonusHpParam { get; }
		public float weaponBonusAtkParam { get; }
		public int maxHpPlus { get; }
		public int maxAtkPlus { get; }
		public int nowHpPlus { get; }
		public int nowAtkPlus { get; }
		public TutorialType tutorialType { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum DataType
		{
			None = 0,
			Weapon = 1,
			Crest = 2
		}
	
		public enum TutorialType
		{
			None = 0,
			Buildup = 1,
			LimitBreak = 2,
			Result = 3
		}
	
		// Constructors
		public GrowthUnitEnhanceModel(DataType type, int masterId);
	
		// Methods
		public void UpdateModel();
		public void UpdateUserWeaponData();
		public void UpdateUserCrestData();
		public int GetSkillId(int toLimitOver = -1);
		public int GetSkillLevel(int toLimitBreak = -1, int toLimitOver = -1);
		public int GetAbilityId(int abilityNo, int toLimitOver = -1, int toLimitBreak = -1);
		public int GetWeaponAbilityLevel(int abilityNo, int toLimitOver = -1);
		public int GetCrestAbilityLevel(int abilityNo, int toLimitBreak = -1);
		public int GetMaxBuildupCount();
		public int GetMaxBuildupCountByLimitBreakCount(int limitBreak);
		public int GetMaxLimitBreak();
		public int GetMaxLimitBreakByLimitOver(int limitOver);
		public int GetMaxLimitOver();
		public int GetMaxEquipableCount();
		public bool CanBuildup();
		public bool ExistsBuildupDataByPieceType(BuildupPieceType pieceType);
		public bool ExistsWeapopnPassiveAbility();
		public bool CanLimitBreak();
		public bool CanLimitOver();
		public bool CanReleaseWeaponPassiveAbility();
		public bool CanReleaseCrestSlot();
		public bool CanReleaseWeaponBonus();
		public bool CanReleaseEquipableCount();
		public int GetUnlockConditonLevelByPieceTypeAndStep(BuildupPieceType pieceType, int step);
		public int GetUnlockConditonLimitBreakCountByPieceTypeAndStep(BuildupPieceType pieceType, int step);
		public int GetUnlockConditonLimitOverCountByPieceTypeAndStep(BuildupPieceType pieceType, int step);
		public string GetBuildupPreConditionString(BuildupPieceType pieceType, int step);
		public GrowthWeaponSkinConfirmData[] GetLimitBreakRewardSkinConfirmDatas();
		public GrowthWeaponSkinConfirmData[] GetLimitOverRewardSkinIds();
		public GrowthWeaponSkinConfirmData[] GetWeaponPassiveAbilityRewardSkinIds();
		public int GetHpParamByBuildupCount(int builupCount);
		public int GetAtkParamByBuildupCount(int builupCount);
		public Dictionary<int, int> GetNeedMaterialFromNowBuildupToSpecifiedBuildup(int toBuildup);
		public Dictionary<int, int> GetNeedMaterialFromNowLimitBreakToSpecifiedLimitBreak(int releaseCount, int useItemCount);
		public Dictionary<int, int> GetNeedMaterialFromNowEquipableCountToSpecifiedEquipableCount(int toCount);
		public int GetLimitBreakItemId();
		public Dictionary<int, int> GetNeedMaterialToNextLimitOver();
		public Dictionary<int, int> GetNeedMaterialToReleaseWeaponBonus();
		public int GetNeedRupiToReleaseWeaponBonus();
		public Dictionary<int, int> GetNeedMaterialBySlotCount(BuildupPieceType pieceType, int count);
		public int GetNeedRupiBySlotCount(BuildupPieceType pieceType, int count);
		public int GetMaxEquipCountByNow();
		public int[] GetWeaponPassiveAbilityDataIds();
		public int GetNeedDewByLimitBreak(int limitBreak);
		public int GetNeedDewFromNowLimitBreakToSpecifiedLimitBreak(int releaseCount, int useItemCount);
		public int GetNeedDewByEquipableCount(int count);
		public int GetNeedDewFromNowEquipableCountToSpecifiedEquipableCount(int toCount);
		public int GetPlusItemId(MaterialType materialType);
		public bool CanGrowPlusParam();
		public int GetNeedRupiByLimitBreak(int limitBreak);
		public int GetNeedRupiFromNowLimitBreakToSpecifiedLimitBreak(int releaseCount, int useItemCount);
		public int GetNeedRupiByEquipCount(int equipSetp);
		public int GetNeedRupiFromNowEquipCountToSpecifiedEquipCount(int toEquipSetp);
		public int GetNeedRupiByLimitOver(int limitOver);
		public int GetNeedRupiFromNowLimitBreakToSpecifiedLimitOver(int toLimitOver);
		public int[] GetSkinIdsFromNowLimitBreakToSpecifiedLimitBreak(int toLimitBreak);
		public int[] GetSkinIdsFromNowLimitOverToSpecifiedLimitOver(int toLimitOver);
		public void SetReleasableBuildupInfo(ref Dictionary<int, int> materialDatas, ref int canReleaseCount);
		public void SetReleasableWeaponPassiveAbilityInfo(ref Dictionary<int, int> materialDatas, ref List<int> abilityIds, ref int needRupi);
		public void SetReleasableSlotInfo(ref Dictionary<int, int> materialDatas, ref int addSlotType1, ref int addSlotType2, ref int addSlotType3, ref int needRupi);
		public void SetReleasableWeaponBonusInfo(ref Dictionary<int, int> materialDatas, ref int releaseCount, ref int needRupi);
		public void UpdateTutorialType();
		public void ResetTutorialType();
		private void SetupWeaponData();
		private void SetupCrestData();
		private TutorialType GetPlayTutorialType();
		public static Localize.TextId GetConditionLimitBreakString(DataType dataType, int conditionLimitBreak);
		public bool IsShowMemorialRiseEffect();
	}
}
