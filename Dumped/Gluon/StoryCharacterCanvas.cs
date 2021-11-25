using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryCharacterCanvas : MonoBehaviour
	{
		[SerializeField]
		public Canvas uiCanvas;

		[SerializeField]
		public RectTransform[] characterRects;

		[SerializeField]
		public DifferenceImageController[] imageCtrls;

		[SerializeField]
		public CanvasGroup[] characterGroups;

		[SerializeField]
		public CanvasGroup characterParentGroup;

		[SerializeField]
		public RectTransform characterParent;

		[SerializeField]
		public Image characterFrontLayerImage;

		[SerializeField]
		public CanvasGroup characterFrontLayerGroup;
	}
}
