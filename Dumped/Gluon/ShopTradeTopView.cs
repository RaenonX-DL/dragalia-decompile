using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeTopView : ShopTradePanelBase
	{
		[SerializeField]
		[Header("PageView")]
		public PageViewBase pageView;

		public GameObject pageViewNode;

		[SerializeField]
		[Header("Badge")]
		public GameObject materialSummonBadge;

		public GameObject amuletNewIcon;

		public GameObject diaRecommendedIcon;

		[SerializeField]
		[Header("Campaign")]
		public GameObject campaignButtonGO;

		public ButtonWithSelectedImage campaignButtonWithSelectedImage;

		[SerializeField]
		[Header("CenterBannerBG")]
		public Image centerBannerBGImage;

		public MaintenanceButtonController centerBGMaintenanceButton;

		public Text centerBannerText;

		[SerializeField]
		[Header("SubBunner")]
		public GameObject starterPackSubBanner;

		public GameObject commonPackSubBanner;

		private const float autoMoveTime = 8f;

		private float moveTimer;

		private bool autoMove;

		private GameObject preLoadedPage;

		private ShopTopBannerModel.BannerData centerData;

		public static ShopTradeTopView Create(Transform parent, ShopTradeScene scene)
		{
			return null;
		}

		public static void RequestForEntryHttp(Action onHttpDoneCallback)
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void SetSubBanner()
		{
		}

		private void SetCenterBannerBG(ShopTopBannerModel.BannerData data)
		{
		}

		public void OnCenterBannerPressed()
		{
		}

		private void GenerateCenterBanners()
		{
		}

		private void Update()
		{
		}

		public void CheckAmuletNewBadge()
		{
		}

		public void CheckDiaRecommendedBadge()
		{
		}

		public void OnCampainButtonPressed()
		{
		}
	}
}
