using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class AlbumStoryReviewQuestStorySelectPageController : TableViewController<QuestCellData>
	{
		[SerializeField]
		public float cellWidht;

		[SerializeField]
		public float cellHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float enterAnimationDuration;

		private AlbumStoryReviewQuestStoryData albumStoryReviewQuestStoryData;

		private UnityAction<QuestCellData> disableToJoinCallback;

		public void Load(AlbumStoryReviewQuestStoryData data, UnityAction<QuestCellData> callback)
		{
		}

		protected override TableViewCell<QuestCellData> CreateCellForIndex(int index)
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
