using UnityEngine;

namespace Gluon
{
	public class AlbumStoryReviewMainQuestSelectPage : AlbumStoryReviewPageBase
	{
		[SerializeField]
		private AlbumStoryReviewMainQuestSelectPageController ctrl;

		private AlbumStoryGroupType type;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void OnBackButtonTouched()
		{
		}

		public void OnChapterCellPressed(int id)
		{
		}
	}
}
