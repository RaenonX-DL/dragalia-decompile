using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class AlbumStoryReviewEventQuestSelectPageController : TableViewController<AlbumStoryReviewEventQuestSelectPageCellData>
	{
		[SerializeField]
		public float cellWidht;

		[SerializeField]
		public float cellHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		public void Load(AlbumStoryGroupType albumStoryType, UnityAction<int> unityAction)
		{
		}

		protected override TableViewCell<AlbumStoryReviewEventQuestSelectPageCellData> CreateCellForIndex(int index)
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
