/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WeaponEvolutionSelectListController : CommonIconListController
	{
		// Fields
		public bool isShowAllTarget;
	
		// Properties
		public int CellCount { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Converter<CommonIconListCellData, WeaponEvolutionListCellData> __9__4_0;
			public static Func<WeaponEvolutionListCellData, bool> __9__4_1;
			public static Converter<WeaponEvolutionListCellData, CommonIconListCellData> __9__4_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal WeaponEvolutionListCellData _CustomSort_b__4_0(CommonIconListCellData p);
			internal bool _CustomSort_b__4_1(WeaponEvolutionListCellData p);
			internal CommonIconListCellData _CustomSort_b__4_2(WeaponEvolutionListCellData p);
		}
	
		// Constructors
		public WeaponEvolutionSelectListController();
	
		// Methods
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override void CustomSort();
	}
}
