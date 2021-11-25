using System;
using System.Collections;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleMenuCanvas : MonoBehaviour
	{
		public GrowthManaCircleScene scene;

		public RectTransform frame;

		public CanvasGroup canvasGroup;

		public CanvasGroup bgCanvasGroup;

		public Canvas canvas;

		public GameObject listButton;

		public GameObject growthButton;

		public GameObject awakeningButton;

		public RectTransform maskTransform;

		public float enterAnimationDuration;

		public Ease enterAnimationEase;

		public float exitAnimationDuration;

		public Ease exitAnimationEase;

		public Action growthButtonPressAction;

		public Action awakeningButtonPressAction;

		public GrowthManaCircleModel manaCircle2DModel;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void UpdateButtonState(GrowthManaCircleModel model)
		{
		}

		private void StartEnterAnimation([Optional] Action onCompleted)
		{
		}

		private void StartExitAnimation([Optional] Action onCompleted)
		{
		}

		private void OnDestroy()
		{
		}

		public void OnCloseAreaPressed()
		{
		}

		public void OnListButtonPressed()
		{
		}

		public void OnGrowthButtonPressed()
		{
		}

		public void OnAwakeningButtonPressed()
		{
		}
	}
}
