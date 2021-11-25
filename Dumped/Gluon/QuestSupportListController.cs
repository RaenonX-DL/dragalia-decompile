using Gluon.Http;

namespace Gluon
{
	public class QuestSupportListController : QuestCommonTableViewController<QuestSupportListCellData>
	{
		public float cellWidth;

		public float cellHeight;

		public QuestSupportListBase supportListBase;

		public void LoadData(int questId, UserSupportList[] supportData)
		{
		}

		public void Reload()
		{
		}

		public void ClearList()
		{
		}

		protected override TableViewCell<QuestSupportListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}
	}
}
