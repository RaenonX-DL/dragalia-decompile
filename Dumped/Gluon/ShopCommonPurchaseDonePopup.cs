using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopCommonPurchaseDonePopup : PopupBase
	{
		[SerializeField]
		[Header("Top")]
		public Image packIcon;

		public Text packName;

		public RectTransform frame;

		public GameObject limitOverCommentGO;

		public GameObject realMoneyCommentGO;

		public GameObject realMoneyDirectAddressCommentGO;

		private ShopTradeProductData.CommonShopItemData data;

		private Action onPurchaseDone;

		private bool isSentToPresentBox;

		public static ShopCommonPurchaseDonePopup Create(ShopTradeProductData.CommonShopItemData data, bool sentToPresentBox, Action onPurchaseDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
