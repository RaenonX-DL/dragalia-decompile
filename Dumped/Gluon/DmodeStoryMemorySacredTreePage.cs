using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeStoryMemorySacredTreePage : DmodePageBase
	{
		[SerializeField]
		private Text storyText;

		[SerializeField]
		private float loadingSeconds;

		[SerializeField]
		private float loadingDelay;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		public void OnBackButtonTouched()
		{
		}
	}
}
