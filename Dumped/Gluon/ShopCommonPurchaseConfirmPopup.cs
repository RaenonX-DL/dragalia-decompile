using System;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopCommonPurchaseConfirmPopup : ShopPurchaseConfirmPopupBase
	{
		[SerializeField]
		[Header("Content")]
		public GridLayoutGroup contentParent;

		public GridLayoutGroup bonusParent;

		public GridLayoutGroup missionContentParent;

		public Text contentTitleText;

		public GameObject[] missionContents;

		public GameObject[] bonusContents;

		public GameObject specifiedCommercialActObj;

		public Text specifiedCommercialTransactionActText;

		public static void Create(ShopTradeProductData.CommonShopItemData data, Action onPurchaseDone)
		{
		}

		private static ShopCommonPurchaseConfirmPopup DoCreate(ShopTradeProductData.CommonShopItemData data, Action onPurchaseDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void GoChallengeMissionScene(MissionTableViewData data)
		{
		}
	}
}
