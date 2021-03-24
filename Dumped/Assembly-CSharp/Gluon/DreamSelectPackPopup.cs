/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DreamSelectPackPopup : PopupBase
	{
		// Fields
		public const string path = "Prefabs/OutGame/ShopTrade/Popup/DreamSelectPackPopup";
		[SerializeField]
		private RawImage bgImage;
		[SerializeField]
		private UnityEngine.UI.Text limitCountText;
		[SerializeField]
		private UnityEngine.UI.Text priceText;
		[SerializeField]
		private UnityEngine.UI.Text periodText;
		private ShopTradeProductData.CommonShopItemData itemData;
		private const string imagePathTemplate = "Images/OutGame/Shop/Top/DreamSelect/{0}";
	
		// Constructors
		public DreamSelectPackPopup();
	
		// Methods
		public void Init(ShopTradeProductData.CommonShopItemData itemData);
		public void OnPurchaseButtonClicked();
		[CompilerGenerated]
		private void _OnPurchaseButtonClicked_b__8_0(ShopGetDreamSelectUnitListResponse res);
		[CompilerGenerated]
		private void _OnPurchaseButtonClicked_b__8_1();
	}
}
