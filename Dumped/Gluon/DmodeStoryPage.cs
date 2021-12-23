using UnityEngine;

namespace Gluon
{
	public class DmodeStoryPage : DmodePageBase
	{
		[SerializeField]
		private DmodeStoryListController storyListCtrl;

		[SerializeField]
		private float loadingSeconds;

		[SerializeField]
		private float loadingDelay;

		public bool isStoryReadConnected;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void OnBackButtonTouched()
		{
		}

		public void OnDmodeStoryListCellPressed(DmodeStoryListCellData data)
		{
		}

		public void OnRequestDmodeReadStory(int storyId)
		{
		}

		private void ChangeDmodeStoryMemorySacredTreePage(int storyId)
		{
		}
	}
}
