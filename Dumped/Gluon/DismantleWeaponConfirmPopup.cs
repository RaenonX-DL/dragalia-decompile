using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DismantleWeaponConfirmPopup : CommonPopup
	{
		public CraftMaterialCell originCell;

		public Text totalCoin;

		public Text breforeCoin;

		public Text afterCoin;

		public Text messageText;

		public Text needCoinText;

		public Text coinErrorText;

		public Text weaponAlertText;

		public Text plusAlertText;

		public GameObject[] popSpeces;

		private int baseWeaponId;

		public static DismantleWeaponConfirmPopup Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void InitPop(WeaponCraftDataElement craftData, ulong keyId)
		{
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}
	}
}
