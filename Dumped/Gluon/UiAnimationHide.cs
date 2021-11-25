using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class UiAnimationHide : MonoBehaviour
	{
		private enum MoveDirection
		{
			UP,
			Down,
			Right,
			Left
		}

		private enum UiCondition
		{
			Show,
			Move,
			Hide
		}

		[Serializable]
		private class AnimationUi
		{
			public GameObject obj;

			public int moveOrder;

			public MoveDirection moveDirection;

			[NonSerialized]
			public Vector3 defaultPos;

			[NonSerialized]
			public UiCondition condition;
		}

		[SerializeField]
		[Header("ç§»å\u008b\u0095é\u0096\u0093é\u009a\u0094(ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0)")]
		private int interval;

		[SerializeField]
		[Header("ç§»å\u008b\u0095æ\u0099\u0082é\u0096\u0093")]
		private float duration;

		[SerializeField]
		[Header("ç§»å\u008b\u0095è·\u009dé\u009b¢ã\u0081®ã\u0083\u009eã\u0083¼ã\u0082\u00b8ã\u0083³")]
		private float moveMargin;

		[SerializeField]
		[Header("å\u0085¥ã\u0082\u008aã\u0081®Ease")]
		private Ease enterEase;

		[SerializeField]
		[Header("ã\u0081\u00afã\u0081\u0091ã\u0081®Ease")]
		private Ease exitEase;

		[SerializeField]
		[Header("ã\u0083\u0098ã\u0083\u0083ã\u0083\u0080ã\u0083¼ã\u0081®ç§»å\u008b\u0095é\u00a0\u0086")]
		private int headerMoveOrder;

		[SerializeField]
		[Header("ã\u0083\u0095ã\u0083\u0083ã\u0082¿ã\u0083¼ã\u0081®ç§»å\u008b\u0095é\u00a0\u0086")]
		private int footerMoveOrder;

		[SerializeField]
		[Header("è¡\u00a8ç¤ºç\u00af\u0084å\u009b²ã\u0082\u0092æ\u008c\u0087å®\u009aã\u0081\u0099ã\u0082\u008bã\u0081\u009fã\u0082\u0081ã\u0081®è¦ªã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®RectTransform")]
		private RectTransform parentObject;

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081\u0095ã\u0081\u009bã\u0082\u008bã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088")]
		private AnimationUi[] animationObjects;

		private int timingCount;

		private void Start()
		{
		}

		public void OnUiHideButtonPressed()
		{
		}

		public void OnFinishUiHideButtonPressed()
		{
		}

		private IEnumerator StartSlideOut()
		{
			return null;
		}

		private IEnumerator StartSlideIn()
		{
			return null;
		}

		private void SlideOut(AnimationUi ui)
		{
		}

		private void SlideIn(AnimationUi ui)
		{
		}

		private Vector3 GetToPosition(AnimationUi ui, RectTransform rectTransform)
		{
			return default(Vector3);
		}

		public bool IsMove()
		{
			return default(bool);
		}
	}
}
