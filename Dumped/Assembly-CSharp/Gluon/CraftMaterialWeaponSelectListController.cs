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
	public class CraftMaterialWeaponSelectListController : SelectIconListControllerBase
	{
		// Fields
		[HideInInspector]
		public int[] targetIds;
		[HideInInspector]
		public int[] targetLimitbreak;
		[HideInInspector]
		public List<ulong> usedKeyIdList;
		public Action iconLockCallBack;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public CraftMaterialWeaponSelectListController __4__this;
			public CommonIconListCellData data;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
		}
	
		// Constructors
		public CraftMaterialWeaponSelectListController();
	
		// Methods
		protected override void Start();
		private void LoadListData();
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum);
		public void InitListParam(int[] ids, int[] limitbreak, int needCount, ulong[] usedKeyIds);
		protected override bool IsSelectableData(CommonIconListCellData data);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private ulong[] CreateDataIdList(int[] ids, int[] limitBreakCount);
		public void OnSortButtonClicked();
		public void MaterialAutoSelect(int maxSelectCount);
	}
}
