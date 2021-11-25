using UnityEngine;

namespace Gluon
{
	public class StoryListController : TableViewController<StoryListCellData>
	{
		public const float cellWidth = 275f;

		public const float cellHeight = 156f;

		public GameObject storyListBase;

		protected override void Start()
		{
		}

		public void LoadData(StoryListCategory dataType)
		{
		}

		private void LoadMainStoryData()
		{
		}

		private void LoadEventData()
		{
		}

		protected override void UpdateVisibleRect()
		{
		}

		protected override TableViewCell<StoryListCellData> CreateCellForIndex(int index)
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
