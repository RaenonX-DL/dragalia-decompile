using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuPurchaseInfoPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/Menu/MenuPurchaseInfoPopup";

		[SerializeField]
		private Text purchasedStoneText;

		[SerializeField]
		private Text freeStoneText;

		public static MenuPurchaseInfoPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}
	}
}
