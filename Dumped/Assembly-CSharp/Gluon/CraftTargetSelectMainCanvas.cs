/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftTargetSelectMainCanvas : CraftEffectMainCanvas
	{
		// Fields
		public CraftTargetSelectListController craftSelectListController;
		public WeaponEvolutionSelectListController evolutionSelectListController;
		public static WeaponType selectWeaponTab;
		public UnityAction<WeaponType> changeTypeCallBack;
		public TabBase listTab;
		public Transform craftListBase;
		public Transform evolutionListBase;
		public bool isEvolutionListShowAll;
		public UnityAction<bool> showAllButtonCallBack;
		public UnityAction dismantleButtonCallBack;
		public UnityEngine.UI.Text dismantleButtonText;
		public Button[] weaponTabs;
		public Transform[] weaponTabOnImages;
		public UnityEngine.UI.Text infoChangeButtonText;
		public Button changeInfoListButton;
		public bool isShowRootInfo;
	
		// Constructors
		public CraftTargetSelectMainCanvas();
		static CraftTargetSelectMainCanvas();
	
		// Methods
		protected override void Start();
		public void ChangeWeaponTab(int index);
		public void OnShowAllButtonPressed();
		public void OnDismantleWeaponButtonPressed();
		public void OnChangeInfoButtonPressed();
	}
}
