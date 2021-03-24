/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthBaseSelectListController : CommonDualListTableViewController
	{
		// Fields
		public TutorialDataManager.GrowthTutorialType tutorialType;
		public ulong[] limitBreakTagets;
		public bool isShowEquipableCount;
		private GrowthEquipBaseListCellData tutorialTargetCellData;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Converter<CommonIconListCellData, GrowthBaseListCellData> __9__8_0;
			public static Func<GrowthBaseListCellData, TutorialDataManager.TutorialCellType> __9__8_1;
			public static Converter<GrowthBaseListCellData, CommonIconListCellData> __9__8_2;
			public static Converter<CommonIconListCellData, GrowthEquipBaseListCellData> __9__8_3;
			public static Func<GrowthEquipBaseListCellData, TutorialDataManager.TutorialCellType> __9__8_4;
			public static Func<GrowthEquipBaseListCellData, bool> __9__8_5;
			public static Converter<GrowthEquipBaseListCellData, CommonIconListCellData> __9__8_6;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal GrowthBaseListCellData _CustomSort_b__8_0(CommonIconListCellData p);
			internal TutorialDataManager.TutorialCellType _CustomSort_b__8_1(GrowthBaseListCellData p);
			internal CommonIconListCellData _CustomSort_b__8_2(GrowthBaseListCellData p);
			internal GrowthEquipBaseListCellData _CustomSort_b__8_3(CommonIconListCellData p);
			internal TutorialDataManager.TutorialCellType _CustomSort_b__8_4(GrowthEquipBaseListCellData p);
			internal bool _CustomSort_b__8_5(GrowthEquipBaseListCellData p);
			internal CommonIconListCellData _CustomSort_b__8_6(GrowthEquipBaseListCellData p);
		}
	
		// Constructors
		public GrowthBaseSelectListController();
	
		// Methods
		protected override CommonIconListCellData CreateCharacterCellData(int keyId, int decoNum);
		protected override CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum);
		protected override void CustomSort();
		public void ChangeCrestLabelInfo();
	}
}
