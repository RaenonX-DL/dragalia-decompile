using UnityEngine.UI;

namespace Gluon
{
	public class AlreadyEquipedDialog : CommonPopup
	{
		public Image charaIcon;

		public Text charaName;

		public static AlreadyEquipedDialog Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void SetupEquipCharaData(int charaId, int rarity)
		{
		}
	}
}
