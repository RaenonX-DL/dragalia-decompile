/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitMaterialListController : CommonIconListController
	{
		// Fields
		public GrowthMaterialSelectScene scene;
	
		// Properties
		public int CellCount { get; }
	
		// Constructors
		public UnitMaterialListController();
	
		// Methods
		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum);
		protected override CommonIconListCellData CreateAmuletCellData(ulong keyId, int decoNum);
		public GrowMaterialCellData GetCellDataByKeyId(ulong keyId);
		public void UpdateCellByKeyIds(ulong[] keyIds);
		public void NotUseMaterialIconLock(bool isExpItemLock, bool isHpPlusLock, bool isAtkPlusLock);
		public void AllListIconLock();
		public void AllListIconUnlock();
		public void IconListSelectClear();
		public GrowMaterialCellData[] GetAutoSelectMaterial();
		public void UpdateCellDataSelectNumber();
	}
}
