using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumPictureBookCanvas : AnimationUICanvas
	{
		[SerializeField]
		private AlbumPictureListController albumCtrl;

		[SerializeField]
		private CommonIconListBase iconListBase;

		[SerializeField]
		private TabBase tabBase;

		private CommonIconListType listType;

		[SerializeField]
		private UIAnimationPublisher uiAnimation;

		[SerializeField]
		private Button medalButton;

		public SimpleAnimationButton backButton;

		private AlbumPictureBookMedalPopup albumPictureBookMedalPopup;

		private bool isDetailScene;

		private void Start()
		{
		}

		private IEnumerator DelayLoadUnitDetail()
		{
			return null;
		}

		public void OnSelectedTab(int index)
		{
		}

		public void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		public void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void LoadUnitDetailScene(int masterId, CommonIconListType listType)
		{
		}

		private void AlbumSceneSetActive(bool isActive)
		{
		}

		public void BackButtonFadeOut()
		{
		}

		public void BakButtonFadeIn()
		{
		}

		public void ListRefresh()
		{
		}

		public void OnBonusPopupButton()
		{
		}

		public void OnMedalPopupButton()
		{
		}

		private void SetMedalButton()
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}
	}
}
