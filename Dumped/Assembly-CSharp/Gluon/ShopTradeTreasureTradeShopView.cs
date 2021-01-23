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
	public class ShopTradeTreasureTradeShopView : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		private ShopTradeTableViewController tableview;
		[Header]
		[SerializeField]
		public TabBase[] tabControllers;
		private List<ShopTradeTableViewController> tableViewList;
		private TabBase usingTabBase;
		private static Action onHttpDone;
		private ShopTradeProductData.TradeShopItemData selectedData;
	
		// Constructors
		public ShopTradeTreasureTradeShopView();
	
		// Methods
		public static ShopTradeTreasureTradeShopView Create(Transform parent, ShopTradeScene scene);
		private static void ReloadData();
		private void Awake();
		private void Start();
		public override void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data);
		public void ReloadPage();
		public override void RefreshCurrentPage();
		[CompilerGenerated]
		private void _OnCellButtonPressed_b__10_0();
	}
}
