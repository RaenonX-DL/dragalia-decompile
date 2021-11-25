using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SSRSummonTicketShopInfoPopup : PopupBase
	{
		public class PackModel
		{
			private static PackModel instance;

			public int diamondCount;

			public List<int> ssrTicketIds;

			public List<SummonTicketShopInfo> summonTicketShopItems;

			public int price;

			public long completeDate;

			public int tradeId;

			public string productId;

			public ShopTradeProductData.CommonShopItemData data;

			public static PackModel Instance => null;

			public static void DeleteInstance()
			{
			}

			private PackModel()
			{
			}

			static PackModel()
			{
			}
		}

		public class SummonTicketShopInfo
		{
			public int id;

			public GiftType type;

			public int count;
		}

		[SerializeField]
		[Header("TopTexts")]
		public Text titleText;

		public Text topText;

		[SerializeField]
		[Header("Images")]
		public RawImage image;

		[SerializeField]
		[Header("Icons")]
		public CommonIcon diamondIcon;

		public Text[] ssrTicketNames;

		public CommonIcon[] ssrTicketIcons;

		public GameObject[] ssrTicketIconGOs;

		[SerializeField]
		[Header("Button")]
		public Button purchaseButton;

		[SerializeField]
		[Header("Texts")]
		public Text limitCountText;

		public Text priceText;

		public Text insufficientText;

		[SerializeField]
		[Header("OnOffs")]
		public GameObject[] charaDescriptionGOs;

		public GameObject[] dragonDescritptionGOs;

		[SerializeField]
		[Header("SCA")]
		public GameObject specifiedCommercialActObj;

		public Text specifiedCommercialTransactionActText;

		private Action onPurchaseDone;

		private const string imagePathTemplate = "Images/OutGame/Shop/Top/SummonTicketPack/{0}";

		public static void CreateModule(ShopTradeProductData.CommonShopItemData item, Action onPurchaseDone)
		{
		}

		private void Setup()
		{
		}

		public void OnOddsButtonClicked(int i)
		{
		}

		public void OnPurchaseButtonClicked()
		{
		}

		public void OnSpecifiedCommercialTransactionActPressed()
		{
		}
	}
}
