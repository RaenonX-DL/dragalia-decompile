using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopSustainableTopButton : MonoBehaviour
	{
		public enum Status
		{
			NotPurchased,
			Claimable,
			Claimed
		}

		public ShopTradeProductData.CommonShopItemData.PackContentType contentType;

		public Text remainText;

		public GameObject badge;

		private Button button;

		private bool preOrderable;

		private ShopTradeModel.ShopTopData.SustainableBonusData data;

		private void Start()
		{
		}

		private void SetupByRemainings()
		{
		}

		private void Update()
		{
		}

		private void SetAsInactive()
		{
		}

		public void OnButtonPressed()
		{
		}

		private void CreateClaimedPopup(bool isChargeDone)
		{
		}

		public static string CreateRenewalRemainDaysComment(int remainDays, long endUnixTime)
		{
			return null;
		}
	}
}
