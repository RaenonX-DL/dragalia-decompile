using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeServitorSkillCellBase : TableViewCell<DmodeServitorSkillCellData>
	{
		[SerializeField]
		private CommonIcon commonIcon;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private Text detailText;

		public override void UpdateContent(DmodeServitorSkillCellData itemData)
		{
		}

		public virtual void UpdateContent()
		{
		}

		public void OnSkillIcon()
		{
		}
	}
}
