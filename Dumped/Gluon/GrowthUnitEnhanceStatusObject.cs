using UnityEngine;

namespace Gluon
{
	public class GrowthUnitEnhanceStatusObject : MonoBehaviour
	{
		public GrowthUnitEnhanceStatusController controller;

		private RectTransform rectTransform;

		private CanvasGroup canvasGroup;

		private const float duration = 0.5f;

		private const float imageWidth = 484f;

		private const float imageY = -59.5f;

		private Color32 darkColor;

		private void Awake()
		{
		}

		public void SetAlpha(float value)
		{
		}

		public void StartShowingAnimation(int direction)
		{
		}

		public void StartHidingAnimation(int direction)
		{
		}

		private void OnAlphaAnimationUpdate(float value)
		{
		}

		private void OnPositionAnimationUpdate(float value)
		{
		}

		private void OnPositionAnimationComplete()
		{
		}
	}
}
