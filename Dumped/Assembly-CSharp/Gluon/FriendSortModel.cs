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
	public class FriendSortModel
	{
		// Fields
		private static FriendSortModel instance;
		private const int SortTargetCount = 4;
		private Condition[] _conditions;
		private const string defaultCaptionPrefabPath = "Prefabs/OutGame/Common/CommonIconListCaption";
		public const ulong emptySpaceIconId = 18446744073709551615;
	
		// Properties
		public static FriendSortModel Instance { get; }
		public Condition condition { get; set; }
	
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
				public List<FriendListCellData> ApplyFilter(List<FriendListCellData> idList);
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
					Elemental = 1,
					WeaponType = 2,
					Rarity = 3,
					Level = 4,
					Atk = 5,
					PlayerLevel = 6,
					LastLoginDate = 7
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
					public List<FriendListCellData> itemList;
	
					// Constructors
					public SectionInfo();
				}
	
				public class SortRawData
				{
					// Fields
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
	
					// Constructors
					public SortRawData();
				}
	
				[Serializable]
				[CompilerGenerated]
				private sealed class __c
				{
					// Fields
					public static readonly __c __9;
					public static Func<SortRawData, ElementalType> __9__10_0;
					public static Func<SortRawData, WeaponType> __9__10_1;
					public static Func<SortRawData, Rarity> __9__10_2;
					public static Func<SortRawData, int> __9__10_3;
					public static Func<SortRawData, int> __9__10_4;
					public static Func<SortRawData, ulong> __9__10_5;
					public static Func<SortRawData, ElementalType> __9__10_6;
					public static Func<SortRawData, WeaponType> __9__10_7;
					public static Func<SortRawData, Rarity> __9__10_8;
					public static Func<SortRawData, int> __9__10_9;
					public static Func<SortRawData, int> __9__10_10;
					public static Func<SortRawData, ulong> __9__10_11;
					public static Func<SortRawData, WeaponType> __9__10_12;
					public static Func<SortRawData, ElementalType> __9__10_13;
					public static Func<SortRawData, Rarity> __9__10_14;
					public static Func<SortRawData, int> __9__10_15;
					public static Func<SortRawData, int> __9__10_16;
					public static Func<SortRawData, ulong> __9__10_17;
					public static Func<SortRawData, WeaponType> __9__10_18;
					public static Func<SortRawData, ElementalType> __9__10_19;
					public static Func<SortRawData, Rarity> __9__10_20;
					public static Func<SortRawData, int> __9__10_21;
					public static Func<SortRawData, int> __9__10_22;
					public static Func<SortRawData, ulong> __9__10_23;
					public static Func<SortRawData, Rarity> __9__10_24;
					public static Func<SortRawData, ElementalType> __9__10_25;
					public static Func<SortRawData, WeaponType> __9__10_26;
					public static Func<SortRawData, int> __9__10_27;
					public static Func<SortRawData, int> __9__10_28;
					public static Func<SortRawData, ulong> __9__10_29;
					public static Func<SortRawData, Rarity> __9__10_30;
					public static Func<SortRawData, ElementalType> __9__10_31;
					public static Func<SortRawData, WeaponType> __9__10_32;
					public static Func<SortRawData, int> __9__10_33;
					public static Func<SortRawData, int> __9__10_34;
					public static Func<SortRawData, ulong> __9__10_35;
					public static Func<SortRawData, int> __9__10_36;
					public static Func<SortRawData, ElementalType> __9__10_37;
					public static Func<SortRawData, WeaponType> __9__10_38;
					public static Func<SortRawData, Rarity> __9__10_39;
					public static Func<SortRawData, int> __9__10_40;
					public static Func<SortRawData, int> __9__10_41;
					public static Func<SortRawData, ulong> __9__10_42;
					public static Func<SortRawData, int> __9__10_43;
					public static Func<SortRawData, ElementalType> __9__10_44;
					public static Func<SortRawData, WeaponType> __9__10_45;
					public static Func<SortRawData, Rarity> __9__10_46;
					public static Func<SortRawData, int> __9__10_47;
					public static Func<SortRawData, int> __9__10_48;
					public static Func<SortRawData, ulong> __9__10_49;
					public static Func<SortRawData, int> __9__10_50;
					public static Func<SortRawData, ElementalType> __9__10_51;
					public static Func<SortRawData, WeaponType> __9__10_52;
					public static Func<SortRawData, Rarity> __9__10_53;
					public static Func<SortRawData, int> __9__10_54;
					public static Func<SortRawData, int> __9__10_55;
					public static Func<SortRawData, ulong> __9__10_56;
					public static Func<SortRawData, int> __9__10_57;
					public static Func<SortRawData, ElementalType> __9__10_58;
					public static Func<SortRawData, WeaponType> __9__10_59;
					public static Func<SortRawData, Rarity> __9__10_60;
					public static Func<SortRawData, int> __9__10_61;
					public static Func<SortRawData, int> __9__10_62;
					public static Func<SortRawData, ulong> __9__10_63;
					public static Func<SortRawData, int> __9__10_64;
					public static Func<SortRawData, ElementalType> __9__10_65;
					public static Func<SortRawData, WeaponType> __9__10_66;
					public static Func<SortRawData, Rarity> __9__10_67;
					public static Func<SortRawData, int> __9__10_68;
					public static Func<SortRawData, int> __9__10_69;
					public static Func<SortRawData, ulong> __9__10_70;
					public static Func<SortRawData, int> __9__10_71;
					public static Func<SortRawData, ElementalType> __9__10_72;
					public static Func<SortRawData, WeaponType> __9__10_73;
					public static Func<SortRawData, Rarity> __9__10_74;
					public static Func<SortRawData, int> __9__10_75;
					public static Func<SortRawData, int> __9__10_76;
					public static Func<SortRawData, ulong> __9__10_77;
					public static Func<SortRawData, int> __9__10_78;
					public static Func<SortRawData, ElementalType> __9__10_79;
					public static Func<SortRawData, WeaponType> __9__10_80;
					public static Func<SortRawData, Rarity> __9__10_81;
					public static Func<SortRawData, int> __9__10_82;
					public static Func<SortRawData, ulong> __9__10_83;
					public static Func<SortRawData, int> __9__10_84;
					public static Func<SortRawData, ElementalType> __9__10_85;
					public static Func<SortRawData, WeaponType> __9__10_86;
					public static Func<SortRawData, Rarity> __9__10_87;
					public static Func<SortRawData, int> __9__10_88;
					public static Func<SortRawData, ulong> __9__10_89;
	
					// Constructors
					static __c();
					public __c();
	
					// Methods
					internal ElementalType _ApplySortRawData_b__10_0(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_1(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_2(SortRawData p);
					internal int _ApplySortRawData_b__10_3(SortRawData p);
					internal int _ApplySortRawData_b__10_4(SortRawData p);
					internal ulong _ApplySortRawData_b__10_5(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_6(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_7(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_8(SortRawData p);
					internal int _ApplySortRawData_b__10_9(SortRawData p);
					internal int _ApplySortRawData_b__10_10(SortRawData p);
					internal ulong _ApplySortRawData_b__10_11(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_12(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_13(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_14(SortRawData p);
					internal int _ApplySortRawData_b__10_15(SortRawData p);
					internal int _ApplySortRawData_b__10_16(SortRawData p);
					internal ulong _ApplySortRawData_b__10_17(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_18(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_19(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_20(SortRawData p);
					internal int _ApplySortRawData_b__10_21(SortRawData p);
					internal int _ApplySortRawData_b__10_22(SortRawData p);
					internal ulong _ApplySortRawData_b__10_23(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_24(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_25(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_26(SortRawData p);
					internal int _ApplySortRawData_b__10_27(SortRawData p);
					internal int _ApplySortRawData_b__10_28(SortRawData p);
					internal ulong _ApplySortRawData_b__10_29(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_30(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_31(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_32(SortRawData p);
					internal int _ApplySortRawData_b__10_33(SortRawData p);
					internal int _ApplySortRawData_b__10_34(SortRawData p);
					internal ulong _ApplySortRawData_b__10_35(SortRawData p);
					internal int _ApplySortRawData_b__10_36(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_37(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_38(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_39(SortRawData p);
					internal int _ApplySortRawData_b__10_40(SortRawData p);
					internal int _ApplySortRawData_b__10_41(SortRawData p);
					internal ulong _ApplySortRawData_b__10_42(SortRawData p);
					internal int _ApplySortRawData_b__10_43(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_44(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_45(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_46(SortRawData p);
					internal int _ApplySortRawData_b__10_47(SortRawData p);
					internal int _ApplySortRawData_b__10_48(SortRawData p);
					internal ulong _ApplySortRawData_b__10_49(SortRawData p);
					internal int _ApplySortRawData_b__10_50(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_51(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_52(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_53(SortRawData p);
					internal int _ApplySortRawData_b__10_54(SortRawData p);
					internal int _ApplySortRawData_b__10_55(SortRawData p);
					internal ulong _ApplySortRawData_b__10_56(SortRawData p);
					internal int _ApplySortRawData_b__10_57(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_58(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_59(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_60(SortRawData p);
					internal int _ApplySortRawData_b__10_61(SortRawData p);
					internal int _ApplySortRawData_b__10_62(SortRawData p);
					internal ulong _ApplySortRawData_b__10_63(SortRawData p);
					internal int _ApplySortRawData_b__10_64(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_65(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_66(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_67(SortRawData p);
					internal int _ApplySortRawData_b__10_68(SortRawData p);
					internal int _ApplySortRawData_b__10_69(SortRawData p);
					internal ulong _ApplySortRawData_b__10_70(SortRawData p);
					internal int _ApplySortRawData_b__10_71(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_72(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_73(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_74(SortRawData p);
					internal int _ApplySortRawData_b__10_75(SortRawData p);
					internal int _ApplySortRawData_b__10_76(SortRawData p);
					internal ulong _ApplySortRawData_b__10_77(SortRawData p);
					internal int _ApplySortRawData_b__10_78(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_79(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_80(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_81(SortRawData p);
					internal int _ApplySortRawData_b__10_82(SortRawData p);
					internal ulong _ApplySortRawData_b__10_83(SortRawData p);
					internal int _ApplySortRawData_b__10_84(SortRawData p);
					internal ElementalType _ApplySortRawData_b__10_85(SortRawData p);
					internal WeaponType _ApplySortRawData_b__10_86(SortRawData p);
					internal Rarity _ApplySortRawData_b__10_87(SortRawData p);
					internal int _ApplySortRawData_b__10_88(SortRawData p);
					internal ulong _ApplySortRawData_b__10_89(SortRawData p);
				}
	
				// Constructors
				public SortCondition();
	
				// Methods
				public SortCondition MakeClone();
				public List<SectionInfo> ApplySortSelfChara(List<FriendListCellData> idList);
				private int GetReliability(int masterId);
				public List<SectionInfo> ApplySort(List<FriendListCellData> idList);
				public List<SectionInfo> ApplySortRawData(List<SortRawData> rawDataList);
			}
	
			// Constructors
			public Condition();
	
			// Methods
			public Condition MakeClone();
		}
	
		// Constructors
		private FriendSortModel();
		static FriendSortModel();
	
		// Methods
		public static void DeleteInstance();
		public bool IsAnyFilterOn();
		public bool IsAscending();
		public string GetSortButtonDisplayText();
		public void ClearAllFilters();
		public int PreviewFilterResultCount(List<FriendListCellData> idList, Condition.FilterCondition filterCondition = null);
		public void ApplySortAndFilter(FriendListController controller, List<FriendListCellData> cellDataList, string captionPrefabPath = null);
	}
}
