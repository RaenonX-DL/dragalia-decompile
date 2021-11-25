using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryBackgroundCanvas : MonoBehaviour
	{
		[SerializeField]
		public Canvas uiCanvas;

		public StoryBackgroundBillboard[] backgrounds;

		public GameObject billboardParent;

		[SerializeField]
		public GameObject rootObject;

		[SerializeField]
		public Image backgroundFrameImage;

		[SerializeField]
		public CanvasGroup backgroundFrameGroup;

		[SerializeField]
		public Image chapterIntroFrameImage;

		[SerializeField]
		public CanvasGroup chapterIntroFrameGroup;

		[SerializeField]
		public Image backgroundLayerImage;

		[SerializeField]
		public CanvasGroup backgroundLayerGroup;

		[SerializeField]
		public Image backgroundSubLayerImage;

		[SerializeField]
		public CanvasGroup backgroundSubLayerGroup;

		public void SetIngameCuttSetting()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
