using UnityEngine;

namespace Gluon
{
	public class CraftMaterialWeaponDetailPopup : CommonPopup
	{
		[SerializeField]
		private CraftEvolutionBaseFrame materialWeaponDetail;

		public static CraftMaterialWeaponDetailPopup Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void InitPop(int weaponId)
		{
		}

		public override void OnOkButtonPressed()
		{
		}
	}
}
