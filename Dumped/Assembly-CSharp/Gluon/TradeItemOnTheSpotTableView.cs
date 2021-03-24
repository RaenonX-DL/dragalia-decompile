/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TradeItemOnTheSpotTableView : TableViewController<Gluon.ShopTradeProductData.TradeShopItemData>
	{
		// Fields
		[CompilerGenerated]
		private TradeItemOnTheSpotPopup _parentPopup_k__BackingField;
		private float cellHeight;
	
		// Properties
		public TradeItemOnTheSpotPopup parentPopup { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public ShopTradeProductData.TradeShopItemData data;
			public TradeItemOnTheSpotTableView __4__this;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _CreateCellForIndex_b__1();
		}
	
		// Constructors
		public TradeItemOnTheSpotTableView();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<ShopTradeProductData.TradeShopItemData> dataList);
		protected override TableViewCell<ShopTradeProductData.TradeShopItemData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__7_0(ShopTradeProductData.TradeShopItemData data);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__7_2();
		[CompilerGenerated]
		private void _CreateCellForIndex_b__7_3();
	}
}
