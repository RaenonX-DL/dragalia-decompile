using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipSetRegistPopup : CommonPopup
	{
		public Image charaIcon;

		public Text charaNameText;

		public PartyEquipSetPopupCell fromSetCell;

		public PartyEquipSetPopupCell toSetCell;

		private int charaId;

		public static PartyEquipSetRegistPopup Create()
		{
			return null;
		}

		public void InitPopup(int charaId, int setIndex)
		{
		}

		public void OnCharaIconPressed()
		{
		}
	}
}
