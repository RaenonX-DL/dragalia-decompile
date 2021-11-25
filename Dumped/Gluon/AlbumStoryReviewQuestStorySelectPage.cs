using System.Collections;
using System.Runtime.InteropServices;
using Cute.AssetBundle;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class AlbumStoryReviewQuestStorySelectPage : AlbumStoryReviewPageBase
	{
		[SerializeField]
		private RectTransform contentTransfrom;

		[SerializeField]
		private AlbumStoryReviewQuestStorySelectPageController ctrl;

		public AnimationListOneCol listAnimation;

		private AlbumStoryReviewQuestStoryData albumStoryReviewQuestStoryData;

		public override void OnPageBecomeActive(object data)
		{
		}

		public void DisableToJoinCallback(QuestCellData questCellData)
		{
		}

		private IEnumerator CheckFortDownloadAndGoQuest(QuestStoryElement storyElement)
		{
			return null;
		}

		private void OpenStoryPopup(QuestStoryElement storyElement, [Optional] DownloadOperation downloadOperation, [Optional] DownloadOperation downloadOperationWithoutVoice)
		{
		}

		private void DownloadCompleteCallback(int questId, QuestGroupType questGroupType)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void OnBackButtonTouched()
		{
		}

		public void OnAlbumStoryReviewCharacterPressed()
		{
		}

		public void OnAlbumStoryReviewIllustrationPressed()
		{
		}
	}
}
