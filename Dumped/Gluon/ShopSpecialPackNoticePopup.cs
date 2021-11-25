using System;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopSpecialPackNoticePopup : PopupBase
	{
		[SerializeField]
		public RawImage image;

		public Text titleText;

		[SerializeField]
		private MaintenanceButtonController okButtonMaintenance;

		private const string imagePathTemplate = "Images/OutGame/Shop/Top/ShopSpecialPackNotice/{0}";

		private List<ShopCenterBannerElement> dataList;

		private Action onDone;

		private const string prefRecordTemplate = "__ShopSpecialPackNoticePopup_{0}";

		private const string prefMontylyRecordTemplate = "__ShopMontylyPackNoticePopup_{0}_{1}";

		public static bool ShouldShowMonthlyBadge()
		{
			return default(bool);
		}

		public static void CreateModule(ShopTradeProductData.CommonShopData limitedShopData, Action onDone)
		{
		}

		private static ShopSpecialPackNoticePopup Create(List<ShopCenterBannerElement> dataList, Action onDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnGoSpecialShop()
		{
		}
	}
}
