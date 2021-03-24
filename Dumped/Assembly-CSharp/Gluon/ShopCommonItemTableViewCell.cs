/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopCommonItemTableViewCell : TableViewCell<Gluon.ShopTradeProductData.CommonShopItemData>
	{
		// Fields
		[SerializeField]
		public UnityEventShopItemData buttonPressed;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text nameText;
		public UnityEngine.UI.Text limitCountText;
		public UnityEngine.UI.Text priceText;
		public Image packIcon;
		public UnityEngine.UI.Text sustainableContinueTimeText;
		[Header]
		[SerializeField]
		public GameObject sustainableEffectiveCover;
		public GameObject quantityLimitReachedCover;
		public GameObject priceLine;
		public GameObject recommendLabel;
		public RectTransform titleRectTrans;
		[Header]
		[SerializeField]
		public GameObject crystalIcon;
		public GameObject dragonDiamondIcon;
		public GameObject goldIcon;
		public GameObject moonIcon;
		public GameObject manaIcon;
		[Header]
		[SerializeField]
		public Button button;
		[Header]
		[SerializeField]
		public GameObject frameContent;
		[Header]
		[SerializeField]
		public GameObject captionFrame;
		public UnityEngine.UI.Text captionText;
		[SerializeField]
		private UnityEngine.UI.Text periodText;
		[Header]
		[SerializeField]
		public float periodIconPosY;
		public float periodIconScale;
		public float periodTitlePosY;
		[Header]
		[SerializeField]
		public float normalIconPosY;
		public float normalIconScale;
		public float normalTitlePosY;
		public Action onUpdateContent;
		protected ShopTradeProductData.CommonShopItemData data;
		protected ShopTradePanelBase panel;
	
		// Nested types
		[Serializable]
		public class UnityEventShopItemData : UnityEvent<ShopTradeProductData.CommonShopItemData>
		{
			// Constructors
			public UnityEventShopItemData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public ShopCommonItemTableViewCell __4__this;
			public Action OnPurchased;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _SetPopup_b__0();
			internal void _SetPopup_b__1(PaymentType paymentType);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public CommonPopup commonPopup;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _IsAstralItemExceed_b__0();
		}
	
		// Constructors
		public ShopCommonItemTableViewCell();
	
		// Methods
		protected virtual void Start();
		public static string GetQuantityLimitText(ShopTradeProductData.CommonShopItemData.ResetType resetType, int purchaseLimit, int boughtCount);
		public override void UpdateContent(ShopTradeProductData.CommonShopItemData data);
		public void OnPurchaseButtonPressed();
		private void SetPopup();
		private bool IsAstralItemExceed();
		private bool CanBuyMultiple();
	}
}
