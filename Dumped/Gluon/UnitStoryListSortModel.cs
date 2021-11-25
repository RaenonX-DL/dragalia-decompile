using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class UnitStoryListSortModel
	{
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

					public bool ShouldCharacterPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldDragonPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldWeaponPass(int masterId)
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

					public bool ShouldRawValuePass(WeaponType type)
					{
						return default(bool);
					}

					public bool ShouldCharacterPass(int masterId)
					{
						return default(bool);
					}

					public bool ShouldWeaponPass(int masterId)
					{
						return default(bool);
					}
				}

				public ElementalFilter elementalFilter;

				public WeaponTypeFilter weaponTypeFilter;

				public FilterCondition MakeClone()
				{
					return null;
				}

				public void ClearAllFilters()
				{
				}

				public List<UnitStoryListCellData> ApplyFilter(List<UnitStoryListCellData> idList)
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
					Add,
					Rarity
				}

				public enum SortOrder
				{
					None,
					Ascending,
					Descending
				}

				public class SectionInfo
				{
					public int abilityId;

					public string title;

					public List<UnitStoryListCellData> itemList;
				}

				public class SortRawData
				{
					public ElementalType elemental;

					public WeaponType weaponType;

					public Rarity rarity;

					public int masterId;

					public ulong cellId;

					public UnitStoryListCellData cellData;
				}

				public SortType sortType;

				public SortOrder sortOrder;

				public SortCondition MakeClone()
				{
					return null;
				}

				public List<SectionInfo> ApplySortSelfChara(List<UnitStoryListCellData> idList)
				{
					return null;
				}

				public List<SectionInfo> ApplySort(List<UnitStoryListCellData> idList)
				{
					return null;
				}

				public List<SectionInfo> ApplySortRawData(List<SortRawData> rawDataList)
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

		private static UnitStoryListSortModel instance;

		public Condition condition;

		private const string defaultCaptionPrefabPath = "Prefabs/OutGame/Common/CommonIconListCaption";

		public const ulong emptySpaceIconId = ulong.MaxValue;

		public static UnitStoryListSortModel Instance => null;

		public static void DeleteInstance()
		{
		}

		private UnitStoryListSortModel()
		{
		}

		static UnitStoryListSortModel()
		{
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

		public void ClearAllFilters()
		{
		}

		public int PreviewFilterResultCount(List<UnitStoryListCellData> idList, [Optional] Condition.FilterCondition filterCondition)
		{
			return default(int);
		}

		public void ApplySortAndFilter(UnitStoryListController controller, List<UnitStoryListCellData> cellDataList, [Optional] string captionPrefabPath)
		{
		}
	}
}
