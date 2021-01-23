/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopMaterialItemShopView : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase tabController;
		[Header]
		[SerializeField]
		public ShopCommonTableViewController[] tableviews;
		[Header]
		[SerializeField]
		public GameObject freeSummonGO;
		public GameObject allFreeSummonGO;
		public GameObject campaignMarkGO;
		public GameObject normalSummonGO;
		public GameObject unavailableSummonGO;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text campaignRemainTimeText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text updateDateText;
		public UnityEngine.UI.Text updatePeriodText;
		public UnityEngine.UI.Text summonPriceText;
		public Button summonButton;
		public GameObject[] summonBadges;
		private TabType currentTabType;
	
		// Nested types
		private enum TabType
		{
			None = 0,
			Daily = 1,
			Weekly = 2,
			Monthly = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public bool isInCampaign;
			public ShopMaterialItemShopView __4__this;
			public Action<ShopItemSummonExecResponse> __9__1;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _OnDrawMaterialSummonButtonPressed_b__0();
			internal void _OnDrawMaterialSummonButtonPressed_b__1(ShopItemSummonExecResponse res);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ShopItemSummonOddResponse> __9__30_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnDrawMaterialSummonOddsButtonPressed_b__30_0(ShopItemSummonOddResponse res);
		}
	
		// Constructors
		public ShopMaterialItemShopView();
	
		// Methods
		public static ShopMaterialItemShopView Create(Transform parent, ShopTradeScene scene);
		private void Awake();
		private void Start();
		public void RaiseTalk(bool isTouched);
		public void OnSwitchTab(int tabIndex, bool calledFromUI);
		private void Update();
		private string GetTimeLeftString(DateTime from, DateTime to, string templateDays, string templateHours, string templateMinutes);
		private void LoadTabs();
		private static void ReloadData();
		public void ReloadPage();
		public override void RefreshCurrentPage();
		public override void ScrollToItem(int tradeId);
		public static int GetCurrentSummonPrice();
		private void RefreshSummon();
		public void OnDrawMaterialSummonButtonPressed();
		public void OnDrawMaterialSummonOddsButtonPressed();
	}
}
