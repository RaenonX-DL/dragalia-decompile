using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class AlbumStoryReviewMainQuestSelectPageController : TableViewController<AlbumStoryReviewMainQuestSelectPageCellData>
	{
		[SerializeField]
		public float cellWidht;

		[SerializeField]
		public float cellHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private DragEventScrollRect desr;

		public void Load(UnityAction<int> onCellPressed)
		{
		}

		protected override TableViewCell<AlbumStoryReviewMainQuestSelectPageCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override void UpdateContents()
		{
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
