using System;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon
{
	public class TradeRaidWeaponDonePopup : PopupBase
	{
		[SerializeField]
		[Header("Contents")]
		public GameObject tapButtonObject;

		public Camera flashCamera;

		public RawImageWithAlphaBlend rawImage;

		private ShopTradeProductData.TradeShopItemData data;

		private Action onDone;

		private string flashBasePath;

		private string flashCompletePath;

		private TouchGuardObject touchGuardObj;

		private FlRoot root;

		private FlRoot topRoot;

		public static TradeRaidWeaponDonePopup Create(ShopTradeProductData.TradeShopItemData data, Action onDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnTapButtonPressed()
		{
		}
	}
}
