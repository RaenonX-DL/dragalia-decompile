using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class DmodeServitorSkillChangeEquipPopupCell : DmodeServitorSkillCellBase
	{
		[SerializeField]
		private GameObject equipCheckMark;

		[SerializeField]
		private GameObject grayOut;

		public UnityAction<DmodeServitorSkillCellData> onDmodeServitorSkillCellPressed;

		public override void UpdateContent(DmodeServitorSkillCellData itemData)
		{
		}

		public override void UpdateContent()
		{
		}

		public void OnDmodeServitorSkillCellPressed()
		{
		}
	}
}
