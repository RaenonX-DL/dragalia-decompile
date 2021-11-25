using UnityEngine.UI;

namespace Gluon
{
	public class LivingLocationSelectPopup : CommonPopup
	{
		public Text subTitleText;

		public LivingLocationSelectToggle[] toggles;

		private LocalizeUtil.LocationCode location;

		private bool isLocationChanged;

		public static LivingLocationSelectPopup Create(string locationStr)
		{
			return null;
		}

		public void OnLocationChecked(LocalizeUtil.LocationCode selectedLocation)
		{
		}
	}
}
