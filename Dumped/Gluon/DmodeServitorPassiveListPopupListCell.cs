using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeServitorPassiveListPopupListCell : TableViewCell<DmodeServitorPassiveListPopupListCellData>
	{
		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private Text passiveName;

		private DmodeServitorPassiveLevelElement dmodeServitorPassiveElement;

		public override void UpdateContent(DmodeServitorPassiveListPopupListCellData data)
		{
		}

		public void OnAbilityIcon()
		{
		}
	}
}
