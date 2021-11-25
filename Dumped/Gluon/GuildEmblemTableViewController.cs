namespace Gluon
{
	public class GuildEmblemTableViewController : TableViewController<int>
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

		protected override TableViewCell<int> CreateCellForIndex(int index)
		{
			return null;
		}
	}
}
