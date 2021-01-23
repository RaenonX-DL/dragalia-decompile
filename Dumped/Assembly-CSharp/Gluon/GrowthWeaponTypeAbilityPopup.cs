/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponTypeAbilityPopup : CommonPopup
	{
		// Fields
		public TabBase weaponTypeTabBase;
		public GrowthWeaponTypeAbilityListController weaponTypeAbilityListController;
		public GameObject emptyTextObject;
		public UnityEngine.UI.Text changeButtonText;
		private int tabIndex;
		private List<ulong> weaponPassiveAbilityList;
	
		// Constructors
		public GrowthWeaponTypeAbilityPopup();
	
		// Methods
		public static GrowthWeaponTypeAbilityPopup Create();
		public void InitPopup(int defaultTabIndex = 1);
		public void OnTabSelected(int index);
		public void OnChangeListTypeButtonPressed();
		private void LoadCellList();
		private void ReloadList();
		private void SetWeaponPassiveAbilityList(WeaponType type);
		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
	}
}
