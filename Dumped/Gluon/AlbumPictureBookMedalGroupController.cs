namespace Gluon
{
	public class AlbumPictureBookMedalGroupController : TableViewController<AlbumPictureBookMedalCellGroupData>
	{
		public float cellWidth;

		public float cellHeight;

		public void LoadMedalList()
		{
		}

		protected override TableViewCell<AlbumPictureBookMedalCellGroupData> CreateCellForIndex(int index)
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
