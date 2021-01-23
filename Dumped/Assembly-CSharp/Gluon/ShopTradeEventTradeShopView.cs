/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeEventTradeShopView : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		private ShopTradeTableViewController tableview;
		[Header]
		[SerializeField]
		public TabBase[] tabControllers;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text resetInfoText;
		[SerializeField]
		public RectTransform frameDialogRectTransform;
		private List<ShopTradeTableViewController> tableViewList;
		private TabBase usingTabBase;
		private static Action onHttpDone;
		private ShopTradeProductData.TradeShopItemData selectedData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public string resetTimeStr;
			public ShopTradeEventTradeShopView __4__this;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _Awake_b__0(int index);
		}
	
		// Constructors
		public ShopTradeEventTradeShopView();
	
		// Methods
		public static ShopTradeEventTradeShopView Create(Transform parent, ShopTradeScene scene);
		public static void RequestForEntryHttp(Action onHttpDoneCallback);
		private void Awake();
		private static void ReloadData();
		public static void OnEntryHttpSuccess(EventTradeGetListResponse response);
		private void OnEnable();
		public override void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data);
		public void ReloadPage();
		public override void RefreshCurrentPage();
		public void SetSelectTabIndex(int index);
		[CompilerGenerated]
		private void _OnCellButtonPressed_b__14_0();
	}
}
