using UnityEngine;

namespace Gluon
{
	public class FortLeftSideUIViewController : MonoBehaviour
	{
		private Vector3 defaultPos;

		private bool isAnimating;

		private bool isSlidingOut;

		[SerializeField]
		private float slideDistanceAdd;

		private CanvasGroup canvasGroup;

		private void Start()
		{
		}

		public void SlideIn(float duration = 0.3f)
		{
		}

		public void SlideOut(float duration = 0.3f, bool isSaveCurrentPos = false)
		{
		}
	}
}
