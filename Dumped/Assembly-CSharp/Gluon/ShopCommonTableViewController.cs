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
	public class ShopCommonTableViewController : TableViewController<Gluon.ShopTradeProductData.CommonShopItemData>
	{
		// Fields
		private float cellHeight;
		private float cellWidth;
		public GameObject bottomNode;
		public GameObject maintenanceObject;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text noItemText;
		public ShopTradeProductData.CommonShopType shopType;
		private const string originalCellPrefabPath = "Prefabs/OutGame/ShopTrade/TableViewCell/ShopCommonItemCell";
		private const int paddingBottomLayoutHeight = 100;
		private const int paddingCellAdjustHeight = 56;
		private const int captionHeight = 68;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public RectTransform rt;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _ScrollToItem_b__0(float y);
		}
	
		// Constructors
		public ShopCommonTableViewController();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		protected virtual void ReloadTableData();
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		public virtual void OnCellButtonPressedForCommonItem(ShopTradeProductData.CommonShopItemData data);
		protected override TableViewCell<ShopTradeProductData.CommonShopItemData> CreateCellForIndex(int index);
		private void AppendAnimationForBottomItem(int index);
		protected override void UpdateContents();
		public void ScrollToItem(int tradeId);
		private float GetItemPosAtIndex(int findIndex);
	}
}
