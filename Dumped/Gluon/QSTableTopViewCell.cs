using UnityEngine;

namespace Gluon
{
	public class QSTableTopViewCell : QuestCommonTableViewCell<QSTableViewData>
	{
		[SerializeField]
		private QSTableViewController _parentViewController;

		public QSTableViewController parentViewController => null;

		public override void OnClick()
		{
		}

		public override void UpdateContent(QSTableViewData data)
		{
		}
	}
}
