/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftMaterialWeaponSelectPopup : CommonPopup
	{
		// Fields
		public Action<int> createMaterialWeaponCallBack;
		[SerializeField]
		private CraftMaterialWeaponTargetCell[] materialTargetIcon;
		[SerializeField]
		private UnityEngine.UI.Text needCountText;
		[SerializeField]
		private CraftMaterialWeaponSelectListController listController;
		private int needCount;
	
		// Properties
		public ulong[] selectMaterialKeyIds { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public CraftMaterialWeaponDetailPopup popup;
			public CraftMaterialWeaponSelectPopup __4__this;
			public int weaponId;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _ShowDetailPopup_b__0();
			internal void _ShowDetailPopup_b__1();
		}
	
		// Constructors
		public CraftMaterialWeaponSelectPopup();
	
		// Methods
		public static CraftMaterialWeaponSelectPopup Create(bool showBlackLayer = true);
		public void InitPopup(CraftMaterialCellData cellData, ulong[] usedKeyIds, bool isLockDetailPopup = false);
		public void SetSelectKeyIds(ulong[] selectKeyIds);
		public void OnAutoSelectPressed();
		public void UpdatePopup();
		private void OnMaterialIconPressed(CommonIconListCellData cellData);
		private void ShowDetailPopup(int weaponId);
	}
}
