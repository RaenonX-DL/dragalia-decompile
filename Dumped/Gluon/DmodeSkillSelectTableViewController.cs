namespace Gluon
{
	public class DmodeSkillSelectTableViewController : TableViewController<int>
	{
		private float cellWidth;

		private float cellHeight;

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		protected override void Start()
		{
		}

		public int GetItemByIndex(int index)
		{
			return default(int);
		}

		public int GetIndexByItem(int data)
		{
			return default(int);
		}

		protected override TableViewCell<int> CreateCellForIndex(int index)
		{
			return null;
		}
	}
}
