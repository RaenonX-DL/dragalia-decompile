/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopSelectUsedItemPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private Image itemIcon;
		[SerializeField]
		private UnityEngine.UI.Text itemNameText;
		[SerializeField]
		private UnityEngine.UI.Text detailText;
		[SerializeField]
		private Button crystalButton;
		[SerializeField]
		private UnityEngine.UI.Text crystalNumText;
		[SerializeField]
		private UnityEngine.UI.Text crystalHaveNumText;
		[SerializeField]
		private Button diamondButton;
		[SerializeField]
		private UnityEngine.UI.Text diamondNumText;
		[SerializeField]
		private UnityEngine.UI.Text diamondHaveNumText;
		[SerializeField]
		private Button diamondPurchaseButton;
		[SerializeField]
		private ButtonWithSelectedImage diamondPurchaseButtonSelectedImage;
		[SerializeField]
		private UnityEngine.UI.Text diamondPurchaseNumText;
		[SerializeField]
		private UnityEngine.UI.Text purcaseText;
		[SerializeField]
		private UnityEngine.UI.Text InsufficienText;
		private ShopTradeProductData.CommonShopItemData itemData;
		private bool hasEnoughDiamond;
		private UnityAction<PaymentType> onSelectPayMent;
	
		// Constructors
		public ShopSelectUsedItemPopup();
	
		// Methods
		public static ShopSelectUsedItemPopup Create(ShopTradeProductData.CommonShopItemData data, UnityAction<PaymentType> OnOkCallback = null);
		public void SetData(ShopTradeProductData.CommonShopItemData data);
		public void SetContent();
		public override void OnCloseButtonPressed();
		public void OnDiamondButton();
		public void OnCrystalButton();
		public void OnPurchaseButtonPressed();
		[CompilerGenerated]
		private void _OnPurchaseButtonPressed_b__23_0();
		[CompilerGenerated]
		private void _OnPurchaseButtonPressed_b__23_1();
	}
}
