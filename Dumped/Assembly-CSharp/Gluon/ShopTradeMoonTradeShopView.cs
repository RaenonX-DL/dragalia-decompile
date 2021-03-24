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
	public class ShopTradeMoonTradeShopView : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase tabController;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text[] ownedCountText;
		[Header]
		[SerializeField]
		public ShopTradeTableViewController[] tableviews;
		private int[] ownedMoonCount;
		private MoonType currentTabType;
		private static Action onHttpDone;
		private ShopTradeProductData.TradeShopItemData selectedData;
	
		// Nested types
		private enum MoonType
		{
			None = 0,
			Bronze = 1,
			Silver = 2,
			Gold = 3
		}
	
		// Constructors
		public ShopTradeMoonTradeShopView();
	
		// Methods
		public static ShopTradeMoonTradeShopView Create(Transform parent, ShopTradeScene scene);
		public void OnSwitchTab(int tabIndex, bool calledFromUI);
		private static void ReloadData();
		private void Awake();
		private void UpdateTitleCount();
		private void Start();
		private void LoadTabs();
		public override void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data);
		public void ReloadPage();
		public override void RefreshCurrentPage();
		[CompilerGenerated]
		private void _OnCellButtonPressed_b__15_0();
	}
}
