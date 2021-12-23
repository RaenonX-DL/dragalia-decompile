using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class AlbumStoryReviewCharacterPage : AlbumStoryReviewPageBase
	{
		[SerializeField]
		private AlbumStoryReviewCharacterPageController commonIconListController;

		[SerializeField]
		private CommonIconListBase commonIconListBase;

		[SerializeField]
		private UIAnimationPublisher uiAnimation;

		private SimpleAnimationButton backButton;

		private AlbumStoryReviewQuestStoryData albumStoryReviewQuestStoryData;

		public override void OnPageBecomeActive(object data)
		{
		}

		private IEnumerator DelayLoadUnitDetail()
		{
			return null;
		}

		public void OnlistButtonCallBack(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		public void OnlistButtonLongPressCallBack(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		public void OnIconClick(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void LoadUnitDetailScene(int masterId, CommonIconListType listType)
		{
		}

		private void AlbumStorySceneSetActive(bool isActive)
		{
		}

		public void BackButtonFadeIn()
		{
		}

		public void BackButtonFadeOut()
		{
		}

		private void OnBackButtonTouched()
		{
		}
	}
}
