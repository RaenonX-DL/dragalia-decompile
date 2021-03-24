/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LimitBreakMaterialListController : CommonIconListController
	{
		// Fields
		public int growthBaseId;
		public GrowthBaseType growthBaseType;
		public TutorialDataManager.GrowthTutorialType tutorialType;
	
		// Constructors
		public LimitBreakMaterialListController();
	
		// Methods
		protected override void Awake();
		protected override CommonIconListCellData CreateDragonCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum);
		public void AllListIconLock();
		public void AllListIconUnlock();
		public void UpdateCellByKeyIds(ulong[] keyIds);
		public void UpdateCellDataSelectNumber(ulong[] keyIds);
		private void AddItemIcon();
		private void AddSphereMaterialIcon();
		protected override void AddExceptionButton(CommonIconListType type);
		public void UpdateContentByIndex(int index);
	}
}
