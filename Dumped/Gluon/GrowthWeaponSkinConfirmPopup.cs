using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponSkinConfirmPopup : CommonPopup
	{
		public Text messageText;

		public Text weaponName;

		public CommonUnitIcon weaponIcon;

		public static GrowthWeaponSkinConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthWeaponSkinConfirmData data)
		{
		}

		public void InitPopup(int weaponSkinId)
		{
		}
	}
}
