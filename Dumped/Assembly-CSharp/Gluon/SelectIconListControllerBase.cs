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
	public class SelectIconListControllerBase : CommonIconListController
	{
		// Fields
		[HideInInspector]
		public List<ulong> selectKeys;
		public Action<CommonIconListCellData> onIconPressedCallBack;
		[HideInInspector]
		protected int maxSelectCount;
		protected bool isAllListIconLock;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public CommonIconListCellData data;
			public SelectIconListControllerBase __4__this;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _UpdateEquipIconLock_b__0();
		}
	
		// Constructors
		public SelectIconListControllerBase();
	
		// Methods
		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateAmuletCellData(ulong keyId, int decoNum);
		public int CheckSelectIcon(ulong keyId);
		public void UpdateCellByKeyIds(ulong[] keyIds);
		public void SetMultiSelectFlag(bool flag);
		public void UpdateCellDataSelectNumber();
		public void AllListIconLock();
		public void AllListIconUnlock();
		public void IconListSelectClear();
		protected void UpdateSelectIconNumber();
		protected virtual void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		protected virtual bool IsSelectableData(CommonIconListCellData data);
		protected virtual void UnSelectIcon(ulong targetKey);
		protected void UpdateEquipIconLock(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
	}
}
