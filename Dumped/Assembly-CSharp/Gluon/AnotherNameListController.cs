/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnotherNameListController : TableViewController<Gluon.AnotherNameCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public NameListBase nameListBase;
		private AnotherNameSortData sortData;
	
		// Nested types
		private enum EmblemDataCategory
		{
			None = 0,
			Chara = 1,
			Dragon = 2,
			Weapon = 3,
			Quest = 4,
			Other = 5
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<AnotherNameCellData, IconRarity> __9__6_0;
			public static Func<AnotherNameCellData, NameCategory> __9__6_1;
			public static Func<AnotherNameCellData, ElementalType> __9__6_2;
			public static Func<AnotherNameCellData, WeaponType> __9__6_3;
			public static Func<AnotherNameCellData, int> __9__6_4;
			public static Func<AnotherNameCellData, int> __9__6_5;
			public static Func<AnotherNameCellData, int> __9__6_6;
			public static Func<AnotherNameCellData, IconRarity> __9__6_7;
			public static Func<AnotherNameCellData, NameCategory> __9__6_8;
			public static Func<AnotherNameCellData, ElementalType> __9__6_9;
			public static Func<AnotherNameCellData, WeaponType> __9__6_10;
			public static Func<AnotherNameCellData, int> __9__6_11;
			public static Func<AnotherNameCellData, int> __9__6_12;
			public static Func<AnotherNameCellData, int> __9__6_13;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal IconRarity _LoadData_b__6_0(AnotherNameCellData p);
			internal NameCategory _LoadData_b__6_1(AnotherNameCellData p);
			internal ElementalType _LoadData_b__6_2(AnotherNameCellData p);
			internal WeaponType _LoadData_b__6_3(AnotherNameCellData p);
			internal int _LoadData_b__6_4(AnotherNameCellData p);
			internal int _LoadData_b__6_5(AnotherNameCellData p);
			internal int _LoadData_b__6_6(AnotherNameCellData p);
			internal IconRarity _LoadData_b__6_7(AnotherNameCellData p);
			internal NameCategory _LoadData_b__6_8(AnotherNameCellData p);
			internal ElementalType _LoadData_b__6_9(AnotherNameCellData p);
			internal WeaponType _LoadData_b__6_10(AnotherNameCellData p);
			internal int _LoadData_b__6_11(AnotherNameCellData p);
			internal int _LoadData_b__6_12(AnotherNameCellData p);
			internal int _LoadData_b__6_13(AnotherNameCellData p);
		}
	
		// Constructors
		public AnotherNameListController();
	
		// Methods
		protected override void Start();
		public void LoadData(EmblemList[] allNameList);
		private void SetupAnotherNameCellData(EmblemDataElement masterEmblemData, out AnotherNameCellData cellData);
		public void SetSortData(AnotherNameSortData newSortData);
		public void Reload();
		public void ClearList();
		public void UpdateNameCell(int nameId);
		protected override void UpdateVisibleRect();
		protected override TableViewCell<AnotherNameCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__13_0(int cellIndex);
	}
}
