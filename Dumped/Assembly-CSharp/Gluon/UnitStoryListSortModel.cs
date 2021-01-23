/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitStoryListSortModel
	{
		// Fields
		private static UnitStoryListSortModel instance;
		public Condition condition;
		private const string defaultCaptionPrefabPath = "Prefabs/OutGame/Common/CommonIconListCaption";
		public const ulong emptySpaceIconId = 18446744073709551615;
	
		// Properties
		public static UnitStoryListSortModel Instance { get; }
	
		// Nested types
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
				public ElementalFilter elementalFilter;
				public WeaponTypeFilter weaponTypeFilter;
	
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
					public bool ShouldCharacterPass(int masterId);
					public bool ShouldDragonPass(int masterId);
					public bool ShouldWeaponPass(int masterId);
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
					public bool ShouldRawValuePass(WeaponType type);
					public bool ShouldCharacterPass(int masterId);
					public bool ShouldWeaponPass(int masterId);
				}
	
				// Constructors
				public FilterCondition();
	
				// Methods
				public FilterCondition MakeClone();
				public void ClearAllFilters();
				public List<UnitStoryListCellData> ApplyFilter(List<UnitStoryListCellData> idList);
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
					Add = 1,
					Rarity = 2
				}
	
				public enum SortOrder
				{
					None = 0,
					Ascending = 1,
					Descending = 2
				}
	
				public class SectionInfo
				{
					// Fields
					public int abilityId;
					public string title;
					public List<UnitStoryListCellData> itemList;
	
					// Constructors
					public SectionInfo();
				}
	
				public class SortRawData
				{
					// Fields
					public ElementalType elemental;
					public WeaponType weaponType;
					public Rarity rarity;
					public int masterId;
					public ulong cellId;
					public UnitStoryListCellData cellData;
	
					// Constructors
					public SortRawData();
				}
	
				[Serializable]
				[CompilerGenerated]
				private sealed class __c
				{
					// Fields
					public static readonly __c __9;
					public static Func<SortRawData, int> __9__9_0;
					public static Func<SortRawData, int> __9__9_1;
					public static Func<SortRawData, Rarity> __9__9_2;
					public static Func<SortRawData, ElementalType> __9__9_3;
					public static Func<SortRawData, WeaponType> __9__9_4;
					public static Func<SortRawData, int> __9__9_5;
					public static Func<SortRawData, ulong> __9__9_6;
					public static Func<SortRawData, int> __9__9_7;
					public static Func<SortRawData, int> __9__9_8;
					public static Func<SortRawData, Rarity> __9__9_9;
					public static Func<SortRawData, ElementalType> __9__9_10;
					public static Func<SortRawData, WeaponType> __9__9_11;
					public static Func<SortRawData, int> __9__9_12;
					public static Func<SortRawData, ulong> __9__9_13;
					public static Func<SortRawData, Rarity> __9__9_14;
					public static Func<SortRawData, int> __9__9_15;
					public static Func<SortRawData, int> __9__9_16;
					public static Func<SortRawData, ElementalType> __9__9_17;
					public static Func<SortRawData, WeaponType> __9__9_18;
					public static Func<SortRawData, int> __9__9_19;
					public static Func<SortRawData, ulong> __9__9_20;
					public static Func<SortRawData, Rarity> __9__9_21;
					public static Func<SortRawData, int> __9__9_22;
					public static Func<SortRawData, int> __9__9_23;
					public static Func<SortRawData, ElementalType> __9__9_24;
					public static Func<SortRawData, WeaponType> __9__9_25;
					public static Func<SortRawData, int> __9__9_26;
					public static Func<SortRawData, ulong> __9__9_27;
	
					// Constructors
					static __c();
					public __c();
	
					// Methods
					internal int _ApplySortRawData_b__9_0(SortRawData p);
					internal int _ApplySortRawData_b__9_1(SortRawData p);
					internal Rarity _ApplySortRawData_b__9_2(SortRawData p);
					internal ElementalType _ApplySortRawData_b__9_3(SortRawData p);
					internal WeaponType _ApplySortRawData_b__9_4(SortRawData p);
					internal int _ApplySortRawData_b__9_5(SortRawData p);
					internal ulong _ApplySortRawData_b__9_6(SortRawData p);
					internal int _ApplySortRawData_b__9_7(SortRawData p);
					internal int _ApplySortRawData_b__9_8(SortRawData p);
					internal Rarity _ApplySortRawData_b__9_9(SortRawData p);
					internal ElementalType _ApplySortRawData_b__9_10(SortRawData p);
					internal WeaponType _ApplySortRawData_b__9_11(SortRawData p);
					internal int _ApplySortRawData_b__9_12(SortRawData p);
					internal ulong _ApplySortRawData_b__9_13(SortRawData p);
					internal Rarity _ApplySortRawData_b__9_14(SortRawData p);
					internal int _ApplySortRawData_b__9_15(SortRawData p);
					internal int _ApplySortRawData_b__9_16(SortRawData p);
					internal ElementalType _ApplySortRawData_b__9_17(SortRawData p);
					internal WeaponType _ApplySortRawData_b__9_18(SortRawData p);
					internal int _ApplySortRawData_b__9_19(SortRawData p);
					internal ulong _ApplySortRawData_b__9_20(SortRawData p);
					internal Rarity _ApplySortRawData_b__9_21(SortRawData p);
					internal int _ApplySortRawData_b__9_22(SortRawData p);
					internal int _ApplySortRawData_b__9_23(SortRawData p);
					internal ElementalType _ApplySortRawData_b__9_24(SortRawData p);
					internal WeaponType _ApplySortRawData_b__9_25(SortRawData p);
					internal int _ApplySortRawData_b__9_26(SortRawData p);
					internal ulong _ApplySortRawData_b__9_27(SortRawData p);
				}
	
				// Constructors
				public SortCondition();
	
				// Methods
				public SortCondition MakeClone();
				public List<SectionInfo> ApplySortSelfChara(List<UnitStoryListCellData> idList);
				public List<SectionInfo> ApplySort(List<UnitStoryListCellData> idList);
				public List<SectionInfo> ApplySortRawData(List<SortRawData> rawDataList);
			}
	
			// Constructors
			public Condition();
	
			// Methods
			public Condition MakeClone();
		}
	
		// Constructors
		private UnitStoryListSortModel();
		static UnitStoryListSortModel();
	
		// Methods
		public static void DeleteInstance();
		public bool IsAnyFilterOn();
		public bool IsAscending();
		public string GetSortButtonDisplayText();
		public void ClearAllFilters();
		public int PreviewFilterResultCount(List<UnitStoryListCellData> idList, Condition.FilterCondition filterCondition = null);
		public void ApplySortAndFilter(UnitStoryListController controller, List<UnitStoryListCellData> cellDataList, string captionPrefabPath = null);
	}
}
