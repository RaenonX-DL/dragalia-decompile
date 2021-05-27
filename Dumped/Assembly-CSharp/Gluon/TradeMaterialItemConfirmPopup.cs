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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TradeMaterialItemConfirmPopup : ShopCommonPopup, ICustomMessage
	{
		// Fields
		protected ShopTradeProductData.TradeShopItemData data;
		protected Action onPopupClosed;
		public Action onPopupCancelled;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text itemName;
		public UnityEngine.UI.Text itemDescription;
		public CommonIcon icon;
		public UnityEngine.UI.Text ownedCount;
		public CommonSliderSelection slider;
		public UnityEngine.UI.Text priceText;
		public UnityEngine.UI.Text confirmText;
		public GameObject sliderFrame;
		public Button tradeButton;
		[SerializeField]
		private UnityEngine.UI.Text itemNoticeText;
		[Header]
		[SerializeField]
		public ShopTradeMaterialIcon[] materialIcons;
		[Header]
		[SerializeField]
		public SelectIconListController selectController;
		[Header]
		[SerializeField]
		public GameObject ownedCountParent;
		[SerializeField]
		private List<GameObject> rarityObjs;
		[SerializeField]
		protected UnityEngine.UI.Text selectAmuletText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text limitCountText;
		public UnityEngine.UI.Text endTimeText;
		public UnityEngine.UI.Text limitCommentText;
		public bool isUseShortQuantityLimite;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text errorText;
		protected int tradeCount;
		protected int selectionTargetIconIndex;
		protected ulong targetKeyId;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public bool bOK;
			public TradeMaterialItemConfirmPopup __4__this;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _OnClosePopup_b__0();
		}
	
		// Constructors
		public TradeMaterialItemConfirmPopup();
	
		// Methods
		public static TradeMaterialItemConfirmPopup Create(ShopTradeProductData.TradeShopItemData data, Action onPopupClosed);
		protected override void OnDestroy();
		protected override void Start();
		protected long GetMaxTradeCount();
		protected long GetMaxCountByMaterial(int id, int needCount, GiftType giftType = GiftType.MATERIAL);
		public void OnSliderValueChanged(float val);
		public void OnClosePopup(bool bOK);
		public void RequestItemTrade();
		protected void OnItemTradeSuccess(TreasureTradeTradeResponse response);
		protected virtual void OnTradeDone();
		protected void OnItemTradeSuccess(EventTradeTradeResponse response);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _Start_b__28_0(List<ulong> selectedKeyIds);
		[CompilerGenerated]
		private void _RequestItemTrade_b__33_0();
		[CompilerGenerated]
		private void _OnTradeDone_b__35_0();
	}
}
