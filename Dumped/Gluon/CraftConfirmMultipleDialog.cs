using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftConfirmMultipleDialog : PopupBase
	{
		public CommonPopup confirmDialog;

		public UnityEvent okButtonPressed;

		[SerializeField]
		private GameObject quotientWeaponCell;

		[SerializeField]
		private Text quotientWeaponText;

		[SerializeField]
		private Image quotientWeaponImage;

		[SerializeField]
		private GameObject quotientWeaponSortDecoAttachNode;

		[SerializeField]
		private GameObject reminderWeaponCell;

		[SerializeField]
		private Text reminderWeaponText;

		[SerializeField]
		private Image reminderWeaponImage;

		[SerializeField]
		private GameObject reminderWeaponSortDecoAttachNode;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text infoText;

		[SerializeField]
		private Text cancelButtonText;

		[SerializeField]
		private Text okButtonText;

		private const string prefabPath = "Prefabs/OutGame/Growth/Craft/CraftConfirmMultipleDialog";

		public static CraftConfirmMultipleDialog Create()
		{
			return null;
		}

		public void InitSetting(int weaponId, int quantity)
		{
		}

		public void OnOkButtonPressed()
		{
		}

		public void OnCancelButtonPressed()
		{
		}
	}
}
