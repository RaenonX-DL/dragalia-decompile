using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class GrowthCraftUtil : MonoBehaviour
	{
		public enum CraftErrorType
		{
			None,
			ShortageMaterial,
			ShortageCoin,
			LowCraftLevel,
			ShortageGrowthMaterial
		}

		public const int maxCraftMaterialCount = 5;

		public const int maxCraftCount = 100;

		public const int maxCraftCountStep2 = 25;

		public const int maxCraftCountStep3 = 5;

		public const int weaponOtherSeriesId = 6;

		public static bool CheckWeaponGradeUp(ulong keyId)
		{
			return default(bool);
		}

		public static void SendBreakNewFlagList(List<int> breakNewFlagList, [Optional] UnityAction callBack, bool isInvokeCallbackWhenEmptyList = false)
		{
		}

		public static int GetMaxCraftGroupStep(int groupId)
		{
			return default(int);
		}

		public static WeaponCraftTreeElement GetCraftTreeDataByWeaponId(int weaponId)
		{
			return null;
		}

		public static GameObject LoadWeaponModel(int baseId, int variationId, UnitDetailUnitShaderSettings shaderSetting)
		{
			return null;
		}

		public static bool CheckMaterialNotShortage(WeaponCraftDataElement craftData)
		{
			return default(bool);
		}

		public static bool IsWeaponUpgradable(int weaponMasterId)
		{
			return default(bool);
		}

		public static void SetupCraftModelTransform(WeaponType type, ref GameObject modelObj)
		{
		}

		public static CaftNeedMaterialData GetNeedMaterialData(int weaponId, int quantity)
		{
			return null;
		}

		public static List<CraftErrorType> GetCraftError(CaftNeedMaterialData caftNeedMaterialData)
		{
			return null;
		}

		public static ulong[] GetTargetWeaponKeyIds(int weaponId, int limitbreak = 0, bool isMaxLv = true)
		{
			return null;
		}

		public static long GetCraftCountLimit(int weaponId)
		{
			return default(long);
		}

		public static ulong GetAllGrowItemExp(GrowthBaseType type)
		{
			return default(ulong);
		}

		public static bool IsDismantleWeapon(int weaponId)
		{
			return default(bool);
		}

		public static int[] GetNextStepWeaponIds(int weaponId)
		{
			return null;
		}

		public static int GetMaxCraftCount(int weaponId)
		{
			return default(int);
		}

		public static bool ExistsSpecialUpgreadeWeaponInNextCraftWeapon(int weaponId)
		{
			return default(bool);
		}

		public static bool IsSpecialUpgreadeWeapon(int weaponId)
		{
			return default(bool);
		}

		public static bool IsCompleteWeaponEnhance(int weaponId)
		{
			return default(bool);
		}

		public static bool ExistNeedCraftWeapon(int weaponId)
		{
			return default(bool);
		}

		public static bool IsCompleteNeedWeaponEnhance(int weaponId)
		{
			return default(bool);
		}

		public static bool IsUnlockedWeaponPassiveAbility(WeaponType weaponType, int passiveAbilityDataId)
		{
			return default(bool);
		}

		public static bool IsUnlockedWeaponPassiveAbility(int weaponId, int passiveAbilityDataId)
		{
			return default(bool);
		}

		public static bool IsClearWeaponPassiveAbilityConditionByWeaponId(int weaponId, int passiveAbilityId)
		{
			return default(bool);
		}

		public static bool IsCraftableWeaponByWeaponId(int weaponId)
		{
			return default(bool);
		}

		public static bool IsCraftableWeaponBySeriesId(int seriesId)
		{
			return default(bool);
		}

		public static bool IsGrowableWeaponByWeaponId(int weaponId)
		{
			return default(bool);
		}

		public static bool IsGrowableWeaponBySeriesId(int seriesId)
		{
			return default(bool);
		}

		public static bool IsGrowableAbilityCrestByCrestId(int crestId)
		{
			return default(bool);
		}

		public static bool IsValidWeaponSeries(int seriesId)
		{
			return default(bool);
		}

		public static bool HasWeaponBodyBySeriesId(int seriesId)
		{
			return default(bool);
		}

		public static bool IsRequiredCountMaterialHas(Dictionary<int, int> needMaterialDict)
		{
			return default(bool);
		}

		public static void AddMaterialDictionary(Dictionary<int, int> baseMaterialDict, Dictionary<int, int> addMaterialDict)
		{
		}
	}
}
