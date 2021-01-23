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
	public class GrowthWeaponAbilitySelectPopup : CommonPopup
	{
		// Fields
		public GrowthWeaponAbilitySelectPopupListController weaponTypeAbilityListController;
		private GrowthUnitEnhanceModel model;
		private List<int> selectIdList;
	
		// Properties
		public int[] selectIds { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _ShowReleaseConditionPopup_b__0();
		}
	
		// Constructors
		public GrowthWeaponAbilitySelectPopup();
	
		// Methods
		public static GrowthWeaponAbilitySelectPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		private void LoadCellList();
		private ulong[] SetWeaponPassiveAbilityList();
		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void OnIconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void ShowReleaseConditionPopup(int conditionParam);
	}
}
