using System.Runtime.InteropServices;
using Cute.AssetBundle;
using UnityEngine;

namespace Gluon
{
	public class AlbumStoryReviewIllustrationPage : AlbumStoryReviewPageBase
	{
		[SerializeField]
		private AlbumStoryReviewIllustrationPageController IllustrationTableCtrl;

		private AlbumStoryReviewQuestStoryData albumStoryReviewQuestStoryData;

		public override void OnPageBecomeActive(object data)
		{
		}

		public void DisableToJoinCallback(int artwarkImageId)
		{
		}

		private void OpenStoryPopup(int artwarkImageId, [Optional] DownloadOperation downloadOperation, [Optional] DownloadOperation downloadOperationWithoutVoice)
		{
		}

		private void DownloadCompleteCallback(int artwarkImageId)
		{
		}

		private void OnBackButtonTouched()
		{
		}
	}
}
