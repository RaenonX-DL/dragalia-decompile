using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSupportListCell : QuestCommonTableViewCell<QuestSupportListCellData>
	{
		public GameObject cellBase;

		public CommonFriendListCell supportListCell;

		[SerializeField]
		private GameObject noSupportBase;

		public Text noSupportText;

		public Text useSkill4Text;

		public Text multiPlayText;

		public Image friendIcon;

		[SerializeField]
		public CommonIconButtonEvent buttonPressed;

		public override void UpdateContent(QuestSupportListCellData data)
		{
		}

		public void OnButtonPressed()
		{
		}
	}
}
