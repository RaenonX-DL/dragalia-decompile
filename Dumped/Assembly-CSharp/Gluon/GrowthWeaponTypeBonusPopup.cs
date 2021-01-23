/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
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
		private List<int> bonusWeaponList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public WeaponBodyElement weaponBodyElement;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _ReloadList_b__0(GrowthWeaponTypeBonusSeriesCell cell);
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
