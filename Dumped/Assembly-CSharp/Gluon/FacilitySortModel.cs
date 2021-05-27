/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilitySortModel
	{
		// Fields
		public Condition condition;
		private static bool isFirstAccess;
		private const string prefsTemplateType = "SortPreset_{0}_Type";
		private const string prefsTemplateOrder = "SortPreset_{0}_Order";
		private const string prefsTemplateFilter = "FilterPreset_{0}";
		private static FacilitySortModel instance;
	
		// Properties
		public static FacilitySortModel Instance { get; }
		public static bool IsInstanceEmpty { get; }
	
		// Nested types
		public enum Preset
		{
			ManagedFacilityTypeProduce = 0,
			ManagedFacilityTypeCharaBoost = 1,
			ManagedFacilityTypeDragonBoost = 2,
			ManagedFacilityTypeDecoration = 3,
			ManagedFacilityTypeOther = 4
		}
	
		[Serializable]
		public class Condition
		{
			// Fields
			public FilterCondition filterCondition;
			public SortCondition sortCondition;
	
			// Nested types
			[Serializable]
			public class FilterCondition
			{
				// Fields
				public ElementalFilter elementalBonusFilter;
				public WeaponTypeFilter weaponTypeBonusFilter;
				public FacilityStateFilter facilityStateFilter;
	
				// Nested types
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
					public bool ShouldFortAssetPass([IsReadOnly] in ManagedFacilityModel.ManagedFacility managedFacility);
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
	
					// Constructors
					public WeaponTypeFilter();
	
					// Methods
					public WeaponTypeFilter MakeClone();
					public void ChangeAllState(bool value);
					public bool IsAllOn();
					public bool IsAllOff();
					public bool ShouldRawValuePass(int weaponType);
					public bool ShouldRawValuePass(WeaponType type);
					public bool ShouldFortAssetPass([IsReadOnly] in ManagedFacilityModel.ManagedFacility managedFacility);
				}
	
				[Serializable]
				public class FacilityStateFilter
				{
					// Fields
					public bool canLevelUp;
					public bool needMaterials;
					public bool isBuilding;
					public bool isStored;
	
					// Nested types
					public enum FacilityState
					{
						None = 0,
						CanLevelUp = 1,
						NeedMaterialsForLevelUp = 2,
						Building = 3,
						Stored = 4
					}
	
					// Constructors
					public FacilityStateFilter();
	
					// Methods
					public FacilityStateFilter MakeClone();
					public void ChangeAllState(bool value);
					public bool IsAllOn();
					public bool IsAllOff();
					public bool IsOn(FacilityState state);
					public bool ShouldRawValuePass(ManagedFacilityModel.ManagedFacility managedFacility);
					public bool ShouldFortAssetPass([IsReadOnly] in ManagedFacilityModel.ManagedFacility managedFacility);
				}
	
				// Constructors
				public FilterCondition();
	
				// Methods
				public FilterCondition MakeClone();
				public void ClearAllFilters();
				public List<ManagedFacilityModel.ManagedFacility> ApplyFilter(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
			}
	
			[Serializable]
			public class SortCondition
			{
				// Fields
				public SortType sortType;
				public SortOrder sortOrder;
	
				// Nested types
				public enum SortType
				{
					None = 0,
					Level = 1,
					WeaponType = 2,
					Elemental = 3,
					Hp = 4,
					Atk = 5,
					Upgradeable = 6,
					NeedsMaterial = 7,
					Building = 8,
					Stored = 9,
					Max = 10
				}
	
				public enum SortOrder
				{
					None = 0,
					Ascending = 1,
					Descending = 2,
					Max = 3
				}
	
				[Serializable]
				[CompilerGenerated]
				private sealed class __c
				{
					// Fields
					public static readonly __c __9;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__6_0;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__6_1;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__6_2;
					public static Func<ManagedFacilityModel.ManagedFacility, ElementalType> __9__6_3;
					public static Func<ManagedFacilityModel.ManagedFacility, ElementalType> __9__6_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__6_5;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__6_6;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__6_7;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__7_0;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__7_1;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__7_2;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__7_3;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__7_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__7_5;
					public static Func<ManagedFacilityModel.ManagedFacility, ElementalType> __9__7_6;
					public static Func<ManagedFacilityModel.ManagedFacility, ElementalType> __9__7_7;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__7_8;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__8_0;
					public static Func<ManagedFacilityModel.ManagedFacility, ElementalType> __9__8_1;
					public static Func<ManagedFacilityModel.ManagedFacility, ElementalType> __9__8_2;
					public static Func<ManagedFacilityModel.ManagedFacility, ElementalType> __9__8_3;
					public static Func<ManagedFacilityModel.ManagedFacility, ElementalType> __9__8_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__8_5;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__8_6;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__8_7;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__8_8;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__9_0;
					public static Func<ManagedFacilityModel.ManagedFacility, float> __9__9_1;
					public static Func<ManagedFacilityModel.ManagedFacility, float> __9__9_2;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__9_3;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__9_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__9_5;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__9_6;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__10_0;
					public static Func<ManagedFacilityModel.ManagedFacility, float> __9__10_1;
					public static Func<ManagedFacilityModel.ManagedFacility, float> __9__10_2;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__10_3;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__10_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__10_5;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__10_6;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__11_0;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__11_1;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__11_2;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__11_3;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__11_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__11_5;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__11_6;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__12_0;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__12_1;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__12_2;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__12_3;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__12_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__12_5;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__12_6;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__13_0;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__13_1;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__13_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__13_5;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__13_6;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__13_7;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__14_0;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__14_1;
					public static Func<ManagedFacilityModel.ManagedFacility, bool> __9__14_2;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__14_3;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__14_4;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__14_5;
					public static Func<ManagedFacilityModel.ManagedFacility, int> __9__14_6;
	
					// Constructors
					static __c();
					public __c();
	
					// Methods
					internal bool _ApplySortRawDataLevel_b__6_0(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLevel_b__6_1(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLevel_b__6_2(ManagedFacilityModel.ManagedFacility data);
					internal ElementalType _ApplySortRawDataLevel_b__6_3(ManagedFacilityModel.ManagedFacility data);
					internal ElementalType _ApplySortRawDataLevel_b__6_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLevel_b__6_5(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLevel_b__6_6(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLevel_b__6_7(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataWeaponType_b__7_0(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataWeaponType_b__7_1(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataWeaponType_b__7_2(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataWeaponType_b__7_3(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataWeaponType_b__7_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataWeaponType_b__7_5(ManagedFacilityModel.ManagedFacility data);
					internal ElementalType _ApplySortRawDataWeaponType_b__7_6(ManagedFacilityModel.ManagedFacility data);
					internal ElementalType _ApplySortRawDataWeaponType_b__7_7(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataWeaponType_b__7_8(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataElementalType_b__8_0(ManagedFacilityModel.ManagedFacility data);
					internal ElementalType _ApplySortRawDataElementalType_b__8_1(ManagedFacilityModel.ManagedFacility data);
					internal ElementalType _ApplySortRawDataElementalType_b__8_2(ManagedFacilityModel.ManagedFacility data);
					internal ElementalType _ApplySortRawDataElementalType_b__8_3(ManagedFacilityModel.ManagedFacility data);
					internal ElementalType _ApplySortRawDataElementalType_b__8_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataElementalType_b__8_5(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataElementalType_b__8_6(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataElementalType_b__8_7(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataElementalType_b__8_8(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataHp_b__9_0(ManagedFacilityModel.ManagedFacility data);
					internal float _ApplySortRawDataHp_b__9_1(ManagedFacilityModel.ManagedFacility data);
					internal float _ApplySortRawDataHp_b__9_2(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataHp_b__9_3(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataHp_b__9_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataHp_b__9_5(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataHp_b__9_6(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataAtk_b__10_0(ManagedFacilityModel.ManagedFacility data);
					internal float _ApplySortRawDataAtk_b__10_1(ManagedFacilityModel.ManagedFacility data);
					internal float _ApplySortRawDataAtk_b__10_2(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataAtk_b__10_3(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataAtk_b__10_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataAtk_b__10_5(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataAtk_b__10_6(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataUpgradeable_b__11_0(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataUpgradeable_b__11_1(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataUpgradeable_b__11_2(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataUpgradeable_b__11_3(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataUpgradeable_b__11_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataUpgradeable_b__11_5(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataUpgradeable_b__11_6(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataLackMaterials_b__12_0(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataLackMaterials_b__12_1(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataLackMaterials_b__12_2(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLackMaterials_b__12_3(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLackMaterials_b__12_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLackMaterials_b__12_5(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataLackMaterials_b__12_6(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataBuilding_b__13_0(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataBuilding_b__13_1(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataBuilding_b__13_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataBuilding_b__13_5(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataBuilding_b__13_6(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataBuilding_b__13_7(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataStored_b__14_0(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataStored_b__14_1(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataStored_b__14_2(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataStored_b__14_3(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataStored_b__14_4(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataStored_b__14_5(ManagedFacilityModel.ManagedFacility data);
					internal int _ApplySortRawDataStored_b__14_6(ManagedFacilityModel.ManagedFacility data);
				}
	
				[CompilerGenerated]
				private sealed class __c__DisplayClass13_0
				{
					// Fields
					public Func<ManagedFacilityModel.ManagedFacility, bool> IsBulding;
	
					// Constructors
					public __c__DisplayClass13_0();
	
					// Methods
					internal bool _ApplySortRawDataBuilding_b__2(ManagedFacilityModel.ManagedFacility data);
					internal bool _ApplySortRawDataBuilding_b__3(ManagedFacilityModel.ManagedFacility data);
				}
	
				// Constructors
				public SortCondition();
	
				// Methods
				public SortCondition MakeClone();
				public List<ManagedFacilityModel.ManagedFacility> ApplySortRawData(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataLevel(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataWeaponType(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataElementalType(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataHp(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataAtk(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataUpgradeable(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataLackMaterials(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataBuilding(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataStored(List<ManagedFacilityModel.ManagedFacility> managedFacilityList);
			}
	
			// Constructors
			public Condition();
	
			// Methods
			public Condition MakeClone();
		}
	
		// Constructors
		private FacilitySortModel();
		static FacilitySortModel();
	
		// Methods
		public static void DeleteInstance();
		public void LoadPreset(Preset preset);
		public void SaveAsPreset(Preset preset);
		public int PreviewFilterResultCount(List<ManagedFacilityModel.ManagedFacility> managedFacilityList, Condition.FilterCondition filterCondition = null);
		public bool IsAnyFilterOn();
		public bool IsAscending();
		public string GetSortButtonDisplayText();
		public List<ManagedFacilityModel.ManagedFacility> ApplySortAndFilter(List<ManagedFacilityModel.ManagedFacility> cellDataList);
		private void SetSortTypeDefault(Preset preset);
		private void SetSortOrderDefault(Preset preset);
	}
}
