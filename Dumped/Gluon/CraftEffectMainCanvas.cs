using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftEffectMainCanvas : MonoBehaviour
	{
		public GameObject craftEffectBaseObject;

		public RectTransform craftEffectResultButtonsRect;

		public Button toPowerUpButtonForCraftResult;

		public Text toPowerTextForCraftResult;

		public Button closeButtonForCraftResult;

		public Text closeTextForCraftResult;

		protected Vector2 craftResultEnhanceButtonTargetPos;

		protected Vector2 craftResultCloseButtonTargetPos;

		protected Tweener craftResultEnhanceButtonTween;

		protected Tweener craftResultCloseButtonTween;

		protected RectTransform craftEffectResultEnhanceButtonRect;

		protected RectTransform craftEffectResultCloseButtonRect;

		protected virtual void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void ShowCraftResultButtons([Optional] Action onComplete)
		{
		}

		public void HideCraftResultButtons()
		{
		}

		private void DestoryButtonTween()
		{
		}
	}
}
