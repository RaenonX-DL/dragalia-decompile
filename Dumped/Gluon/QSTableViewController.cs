using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QSTableViewController : QuestCommonTableViewController<QSTableViewData>
	{
		[SerializeField]
		private int _groupId;

		public int groupId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsExist(QuestMainMenuElement a_qmme)
		{
			return default(bool);
		}

		public virtual bool IsEnable(QuestMainMenuElement qmme)
		{
			return default(bool);
		}

		public virtual bool IsAppear(QuestMainMenuElement a_qmme)
		{
			return default(bool);
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		public QuestCommonTableViewCell<QSTableViewData> GetQuestCommonTableViewCell(int questId)
		{
			return null;
		}
	}
}
