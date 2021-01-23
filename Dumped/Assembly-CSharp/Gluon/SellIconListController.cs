/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SellIconListController : CommonDualListTableViewController
	{
		// Fields
		[SerializeField]
		private Vector2 weaponListCellSize;
		public SellListScene scene;
	
		// Properties
		public int CellCount { get; }
	
		// Constructors
		public SellIconListController();
	
		// Methods
		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateAmuletCellData(ulong keyId, int decoNum);
		public void UpdateCellByKeyIds(ulong[] keyIds);
		public void SetMultiSelectFlag(bool flag);
		protected override void UpdateContents();
		public void UpdateAutoSelectButtonState();
		public void UpdateCellDataSelectNumber();
		public void AllListIconLock();
		public void AllListIconUnlock();
		public void IconListSelectClear();
		public ulong[] GetAutoSelectKeys(int maxSelect);
		public void SetLock(SellEquipIconCellData data, bool isLock, bool setUpdateFlag);
	}
}
