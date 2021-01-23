/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthCraftUtil : MonoBehaviour
	{
		// Fields
		public const int maxCraftMaterialCount = 5;
		public const int maxCraftCount = 100;
		public const int maxCraftCountStep2 = 25;
		public const int maxCraftCountStep3 = 5;
		public const int weaponOtherSeriesId = 6;
	
		// Nested types
		public enum CraftErrorType
		{
			None = 0,
			ShortageMaterial = 1,
			ShortageCoin = 2,
			LowCraftLevel = 3,
			ShortageGrowthMaterial = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public UnityAction callBack;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _SendBreakNewFlagList_b__0(CraftResetNewResponse res);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<KeyValuePair<int, int>, int> __9__17_0;
			public static Func<KeyValuePair<int, int>, int> __9__17_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetCraftCountLimit_b__17_0(KeyValuePair<int, int> pair);
			internal int _GetCraftCountLimit_b__17_1(KeyValuePair<int, int> pair);
		}
	
		// Constructors
		public GrowthCraftUtil();
	
		// Methods
		public static bool CheckWeaponGradeUp(ulong keyId);
		public static void SendBreakNewFlagList(List<int> breakNewFlagList, UnityAction callBack = null, bool isInvokeCallbackWhenEmptyList = false);
		public static int GetMaxCraftGroupStep(int groupId);
		public static WeaponCraftTreeElement GetCraftTreeDataByWeaponId(int weaponId);
		public static GameObject LoadWeaponModel(int baseId, int variationId);
		public static bool CheckMaterialNotShortage(WeaponCraftDataElement craftData);
		public static bool IsWeaponUpgradable(int weaponMasterId);
		public static void SetupCraftModelTransform(WeaponType type, ref GameObject modelObj);
		public static CaftNeedMaterialData GetNeedMaterialData(int weaponId, int quantity);
		public static List<CraftErrorType> GetCraftError(CaftNeedMaterialData caftNeedMaterialData);
		public static ulong[] GetTargetWeaponKeyIds(int weaponId, int limitbreak = 0, bool isMaxLv = true);
		public static long GetCraftCountLimit(int weaponId);
		public static ulong GetAllGrowItemExp(GrowthBaseType type);
		public static bool IsDismantleWeapon(int weaponId);
		public static int[] GetNextStepWeaponIds(int weaponId);
		public static int GetMaxCraftCount(int weaponId);
		public static bool ExistsSpecialUpgreadeWeaponInNextCraftWeapon(int weaponId);
		public static bool IsSpecialUpgreadeWeapon(int weaponId);
		public static bool IsCompleteWeaponEnhance(int weaponId);
		public static bool ExistNeedCraftWeapon(int weaponId);
		public static bool IsCompleteNeedWeaponEnhance(int weaponId);
		public static bool IsUnlockedWeaponPassiveAbility(WeaponType weaponType, int passiveAbilityDataId);
		public static bool IsUnlockedWeaponPassiveAbility(int weaponId, int passiveAbilityDataId);
		public static bool IsClearWeaponPassiveAbilityConditionByWeaponId(int weaponId, int passiveAbilityId);
		public static bool IsCraftableWeaponByWeaponId(int weaponId);
		public static bool IsCraftableWeaponBySeriesId(int seriesId);
		public static bool IsGrowableWeaponByWeaponId(int weaponId);
		public static bool IsGrowableWeaponBySeriesId(int seriesId);
		public static bool IsGrowableAbilityCrestByCrestId(int crestId);
		public static bool IsValidWeaponSeries(int seriesId);
		public static bool HasWeaponBodyBySeriesId(int seriesId);
		public static bool IsRequiredCountMaterialHas(Dictionary<int, int> needMaterialDict);
		public static void AddMaterialDictionary(Dictionary<int, int> baseMaterialDict, Dictionary<int, int> addMaterialDict);
	}
}
