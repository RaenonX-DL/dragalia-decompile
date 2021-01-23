/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemMaterialListController : TableViewController<Gluon.ItemMaterialCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public GrowMaterialListBase materialListBase;
		public UnityAction<int, int> itemCellCallback;
		public int nowExp;
		public int maxExp;
		public int maxHpPlus;
		public int maxAtkPlus;
		public TutorialDataManager.GrowthTutorialType tutorialType;
	
		// Properties
		public int CellCount { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction<int> __9__19_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateCellForIndex_b__19_0(int itemId);
		}
	
		// Constructors
		public ItemMaterialListController();
	
		// Methods
		public void LoadItemData(MaterialList[] useItemDatas);
		private int GetMaxUseItemCount(int itemId);
		public void ItemCellCountLock(bool isExpItemLock, bool isHpPlusItemLock, bool isAtkPlusItemLock);
		public void Reload();
		public void ClearList();
		public void ItemListCountClear();
		private void CellLock(MaterialType type, bool isLock);
		public ItemMaterialCellData[] GetAutoSelectMaterial(int expMargin);
		protected override TableViewCell<ItemMaterialCellData> CreateCellForIndex(int index);
		private void OnApplicationPause(bool stop);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__19_1(int materialId, int count);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__19_2();
		[CompilerGenerated]
		private void _CreateCellForIndex_b__19_3();
	}
}
