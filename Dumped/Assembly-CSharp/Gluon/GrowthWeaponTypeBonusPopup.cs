/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponTypeBonusPopup : CommonPopup
	{
		// Fields
		public TabBase weaponTypeTabBase;
		public Transform listParentTransform;
		public GameObject emptyTextObject;
		private int tabIndex;
		private List<WeaponTypeBonusPopupListData> bonusWeaponList;
	
		// Nested types
		private class WeaponTypeBonusPopupListData
		{
			// Fields
			public int weaponId;
			public int seriesId;
			public int seriesSortId;
	
			// Constructors
			public WeaponTypeBonusPopupListData(int weaponId, int seriesId);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public WeaponTypeBonusPopupListData bonusWeaponData;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _ReloadList_b__0(GrowthWeaponTypeBonusSeriesCell cell);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<WeaponTypeBonusPopupListData, int> __9__9_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetBonusWeaponList_b__9_0(WeaponTypeBonusPopupListData p);
		}
	
		// Constructors
		public GrowthWeaponTypeBonusPopup();
	
		// Methods
		public static GrowthWeaponTypeBonusPopup Create();
		public void InitPopup(int defaultTabIndex = 1);
		public void OnTabSelected(int index);
		private void ReloadList();
		private void SetBonusWeaponList(WeaponType type);
	}
}
