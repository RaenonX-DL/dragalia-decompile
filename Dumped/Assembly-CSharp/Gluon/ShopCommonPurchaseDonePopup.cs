/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopCommonPurchaseDonePopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Image packIcon;
		public UnityEngine.UI.Text packName;
		public RectTransform frame;
		public GameObject limitOverCommentGO;
		public GameObject realMoneyCommentGO;
		public GameObject realMoneyDirectAddressCommentGO;
		private ShopTradeProductData.CommonShopItemData data;
		private Action onPurchaseDone;
		private bool isSentToPresentBox;
	
		// Constructors
		public ShopCommonPurchaseDonePopup();
	
		// Methods
		public static ShopCommonPurchaseDonePopup Create(ShopTradeProductData.CommonShopItemData data, bool sentToPresentBox, Action onPurchaseDone);
		protected override void Start();
		public void OnCloseButtonPressed();
	}
}
