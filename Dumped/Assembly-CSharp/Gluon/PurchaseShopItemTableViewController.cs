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
	public class PurchaseShopItemTableViewController : ShopCommonTableViewController
	{
		// Fields
		public GiftType pickUpGiftType;
		public Action onUpdateCallback;
	
		// Constructors
		public PurchaseShopItemTableViewController();
	
		// Methods
		protected override void ReloadTableData();
		private List<ShopTradeProductData.CommonShopItemData> PickUpListData(List<ShopTradeProductData.CommonShopItemData> beforeData, GiftType giftType);
		protected override TableViewCell<ShopTradeProductData.CommonShopItemData> CreateCellForIndex(int index);
		protected override void UpdateContents();
	}
}
