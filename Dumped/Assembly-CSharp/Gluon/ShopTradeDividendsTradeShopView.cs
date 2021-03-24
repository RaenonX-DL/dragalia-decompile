/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeDividendsTradeShopView : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		public ShopTradeTableViewController tableview;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text ownedCountText;
		private static Action onHttpDone;
		private ShopTradeProductData.TradeShopItemData selectedData;
	
		// Constructors
		public ShopTradeDividendsTradeShopView();
	
		// Methods
		public static ShopTradeDividendsTradeShopView Create(Transform parent, ShopTradeScene scene);
		private static void ReloadData();
		private void Start();
		public override void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data);
		private void SetupHoldingCount();
		public void ReloadPage();
		public override void RefreshCurrentPage();
		[CompilerGenerated]
		private void _OnCellButtonPressed_b__7_0();
	}
}
