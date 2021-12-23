using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class DmodeServitorSkillChangeEquipPopup : PopupBase
	{
		public const string prefabPath = "Prefabs/OutGame/Dmode/DmodeServitor/DmodeServitorSkillChangeEquipPopup";

		[SerializeField]
		private DmodeServitorSkillChangeEquipPopupController skillListCtrl;

		private UnityAction<int> onDmodeServitorChangeSkill;

		public static DmodeServitorSkillChangeEquipPopup Create(UnityAction<int> onChengeSkill, DmodeServitorType selectedServitorType)
		{
			return null;
		}

		private void LoadData(DmodeServitorType selectedServitorType)
		{
		}

		public void OnEquipButtonPressed()
		{
		}
	}
}
