using UnityEngine;

namespace Gluon
{
	public class AlbumStoryReviewEventQuestSelectPage : AlbumStoryReviewPageBase
	{
		[SerializeField]
		private AlbumStoryReviewEventQuestSelectPageController ctrl;

		private AlbumStoryGroupType type;

		public override void OnPageBecomeActive(object data)
		{
		}

		public void OnEventCellPressed(int eventId)
		{
		}

		private void OnBackButtonTouched()
		{
		}
	}
}
