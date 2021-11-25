using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTopBanner : MonoBehaviour
	{
		public Image image;

		public GameObject buttonObj;

		public Button button;

		public MaintenanceButtonController maintenanceButton;

		private ShopTopBannerModel.BannerData data;

		public void UpdateByData(ShopTopBannerModel.BannerData data, bool hideButton = false)
		{
		}

		public static void SetMaintenanceButtonWithPanelType(MaintenanceButtonController button, ShopTradeModel.PanelType panel)
		{
		}

		public static List<MaintenanceFunctionType> GetMaintenaceTypeListWithPanelName(ShopTradeModel.PanelType panel)
		{
			return null;
		}

		public void OnPressed()
		{
		}
	}
}
