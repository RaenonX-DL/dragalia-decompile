using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StampInfoPopup : CommonPopup
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text stampName;

		private static readonly string popupPath;

		public static StampInfoPopup Create(int stampId, bool showBlackLayer = true)
		{
			return null;
		}

		private void SetupPopup(int stampId)
		{
		}
	}
}
