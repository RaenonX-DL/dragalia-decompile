/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TradeItemOnTheSpotPopup : CommonPopup
	{
		// Fields
		public Transform contentParent;
		[SerializeField]
		private TradeItemOnTheSpotTableView tableView;
		private int itemId;
		private List<ShopTradeProductData.TradeShopItemData> items;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<ShopTradeProductData.TradeShopItemData> __9__7_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _RefreshExchangeView_b__7_0(ShopTradeProductData.TradeShopItemData left, ShopTradeProductData.TradeShopItemData right);
		}
	
		// Constructors
		public TradeItemOnTheSpotPopup();
	
		// Methods
		public static TradeItemOnTheSpotPopup Create(int itemId);
		private void RequestTradeData(int itemId);
		private void OnEntryHttpSuccess(TreasureTradeGetListAllResponse response);
		public void RefreshExchangeView();
	}
}
