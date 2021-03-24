/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponTypeAbilityListController : CommonDualListTableViewController
	{
		// Fields
		[HideInInspector]
		public WeaponType targetWeaponType;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Converter<CommonIconListCellData, WeaponPassiveAbilityListCellData> __9__2_0;
			public static Func<WeaponPassiveAbilityListCellData, bool> __9__2_1;
			public static Func<WeaponPassiveAbilityListCellData, int> __9__2_2;
			public static Converter<WeaponPassiveAbilityListCellData, CommonIconListCellData> __9__2_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal WeaponPassiveAbilityListCellData _CustomSort_b__2_0(CommonIconListCellData p);
			internal bool _CustomSort_b__2_1(WeaponPassiveAbilityListCellData p);
			internal int _CustomSort_b__2_2(WeaponPassiveAbilityListCellData p);
			internal CommonIconListCellData _CustomSort_b__2_3(WeaponPassiveAbilityListCellData p);
		}
	
		// Constructors
		public GrowthWeaponTypeAbilityListController();
	
		// Methods
		protected override CommonIconListCellData CreateWeaponPassiveAbilityCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override void CustomSort();
	}
}
