using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class FacilitySortModel
	{
		public enum Preset
		{
			ManagedFacilityTypeProduce,
			ManagedFacilityTypeCharaBoost,
			ManagedFacilityTypeDragonBoost,
			ManagedFacilityTypeDecoration,
			ManagedFacilityTypeOther
		}

		[Serializable]
		public class Condition
		{
			[Serializable]
			public class FilterCondition
			{
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

					public bool ShouldFortAssetPass([In] ref ManagedFacilityModel.ManagedFacility managedFacility)
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

					public bool ShouldRawValuePass(int weaponType)
					{
						return default(bool);
					}

					public bool ShouldRawValuePass(WeaponType type)
					{
						return default(bool);
					}

					public bool ShouldFortAssetPass([In] ref ManagedFacilityModel.ManagedFacility managedFacility)
					{
						return default(bool);
					}
				}

				[Serializable]
				public class FacilityStateFilter
				{
					public enum FacilityState
					{
						None,
						CanLevelUp,
						NeedMaterialsForLevelUp,
						Building,
						Stored
					}

					public bool canLevelUp;

					public bool needMaterials;

					public bool isBuilding;

					public bool isStored;

					public FacilityStateFilter MakeClone()
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

					public bool IsOn(FacilityState state)
					{
						return default(bool);
					}

					public bool ShouldRawValuePass(ManagedFacilityModel.ManagedFacility managedFacility)
					{
						return default(bool);
					}

					public bool ShouldFortAssetPass([In] ref ManagedFacilityModel.ManagedFacility managedFacility)
					{
						return default(bool);
					}
				}

				public ElementalFilter elementalBonusFilter;

				public WeaponTypeFilter weaponTypeBonusFilter;

				public FacilityStateFilter facilityStateFilter;

				public FilterCondition MakeClone()
				{
					return null;
				}

				public void ClearAllFilters()
				{
				}

				public List<ManagedFacilityModel.ManagedFacility> ApplyFilter(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
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
					Level,
					WeaponType,
					Elemental,
					Hp,
					Atk,
					Upgradeable,
					NeedsMaterial,
					Building,
					Stored,
					Max
				}

				public enum SortOrder
				{
					None,
					Ascending,
					Descending,
					Max
				}

				public SortType sortType;

				public SortOrder sortOrder;

				public SortCondition MakeClone()
				{
					return null;
				}

				public List<ManagedFacilityModel.ManagedFacility> ApplySortRawData(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataLevel(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataWeaponType(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataElementalType(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataHp(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataAtk(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataUpgradeable(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataLackMaterials(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataBuilding(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}

				private List<ManagedFacilityModel.ManagedFacility> ApplySortRawDataStored(List<ManagedFacilityModel.ManagedFacility> managedFacilityList)
				{
					return null;
				}
			}

			public FilterCondition filterCondition;

			public SortCondition sortCondition;

			public Condition MakeClone()
			{
				return null;
			}
		}

		public Condition condition;

		private static bool isFirstAccess;

		private const string prefsTemplateType = "SortPreset_{0}_Type";

		private const string prefsTemplateOrder = "SortPreset_{0}_Order";

		private const string prefsTemplateFilter = "FilterPreset_{0}";

		private static FacilitySortModel instance;

		public static FacilitySortModel Instance => null;

		public static bool IsInstanceEmpty => default(bool);

		public static void DeleteInstance()
		{
		}

		private FacilitySortModel()
		{
		}

		static FacilitySortModel()
		{
		}

		public void LoadPreset(Preset preset)
		{
		}

		public void SaveAsPreset(Preset preset)
		{
		}

		public int PreviewFilterResultCount(List<ManagedFacilityModel.ManagedFacility> managedFacilityList, [Optional] Condition.FilterCondition filterCondition)
		{
			return default(int);
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

		public List<ManagedFacilityModel.ManagedFacility> ApplySortAndFilter(List<ManagedFacilityModel.ManagedFacility> cellDataList)
		{
			return null;
		}

		private void SetSortTypeDefault(Preset preset)
		{
		}

		private void SetSortOrderDefault(Preset preset)
		{
		}
	}
}
