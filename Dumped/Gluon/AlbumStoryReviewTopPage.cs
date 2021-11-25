using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class AlbumStoryReviewTopPage : AlbumStoryReviewPageBase
	{
		[SerializeField]
		protected Transform contentTransform;

		[SerializeField]
		public AnimationListOneCol listAnimation;

		[SerializeField]
		private GameObject mainStoryMenuTitle;

		[SerializeField]
		private GameObject eventSpecialMenuTitle;

		[SerializeField]
		private Transform disableMenuTitleParent;

		[SerializeField]
		protected float duration;

		private float totalCellHeight;

		private readonly string storyCellPath;

		private HashSet<string> diaryStoryDeleteTargetAssets;

		private long diaryStoryDeleteSize;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void OnBackButtonTouched()
		{
		}

		private IEnumerator StartDelayExitAnimation()
		{
			return null;
		}

		private void CreateEventList()
		{
		}

		private void ClearEventList()
		{
		}

		private void AddMenuTitle(GameObject menuTitleObj, int delayIndex)
		{
		}

		public void OnEventCellPressed(AlbumStoryGroupType type)
		{
		}

		public void OnStoryDataDelete()
		{
		}

		public IEnumerator CollectDeleteAssets(CommonPopup popup)
		{
			return null;
		}

		private static IEnumerator CollectDeleteAsset(HashSet<string> targetAssets, HashSet<string> reservedAssets)
		{
			return null;
		}

		private IEnumerator DeleteDiaryStoryData()
		{
			return null;
		}
	}
}
