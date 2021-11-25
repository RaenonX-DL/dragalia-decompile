namespace Gluon
{
	public class AlbumPictureBookMedalController : TableViewController<AlbumPictureBookMedalCellData>
	{
		public float cellWidth;

		public float cellHeight;

		public void LoadMedalList(int charaId)
		{
		}

		protected override TableViewCell<AlbumPictureBookMedalCellData> CreateCellForIndex(int index)
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
