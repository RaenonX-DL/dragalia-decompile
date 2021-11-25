using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class FriendSortModel
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

				public List<FriendListCellData> ApplyFilter(List<FriendListCellData> idList)
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
					Elemental,
					WeaponType,
					Rarity,
					Level,
					Atk,
					PlayerLevel,
					LastLoginDate
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

					public List<FriendListCellData> itemList;
				}

				public class SortRawData
				{
					public ElementalType elemental;

					public WeaponType weaponType;

					public Rarity rarity;

					public UnitType charaType;

					public int level;

					public int plusVal;

					public int hp;

					public int atk;

					public int def;

					public int playerLevel;

					public int lastLoginDate;

					public int masterId;

					public ulong cellId;

					public FriendListCellData cellData;
				}

				public SortType sortType;

				public SortOrder sortOrder;

				public SortCondition MakeClone()
				{
					return null;
				}

				public List<SectionInfo> ApplySortSelfChara(List<FriendListCellData> idList)
				{
					return null;
				}

				private int GetReliability(int masterId)
				{
					return default(int);
				}

				public List<SectionInfo> ApplySort(List<FriendListCellData> idList)
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

		private static FriendSortModel instance;

		private const int SortTargetCount = 4;

		private Condition[] _conditions;

		private const string defaultCaptionPrefabPath = "Prefabs/OutGame/Common/CommonIconListCaption";

		public const ulong emptySpaceIconId = ulong.MaxValue;

		public static FriendSortModel Instance => null;

		public Condition condition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static void DeleteInstance()
		{
		}

		private FriendSortModel()
		{
		}

		static FriendSortModel()
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

		public int PreviewFilterResultCount(List<FriendListCellData> idList, [Optional] Condition.FilterCondition filterCondition)
		{
			return default(int);
		}

		public void ApplySortAndFilter(FriendListController controller, List<FriendListCellData> cellDataList, [Optional] string captionPrefabPath)
		{
		}
	}
}
