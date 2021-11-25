using System.Collections;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class InGameDialogBase : MonoBehaviour
	{
		protected const float animWaitFrame = 3f;

		protected const float animFrame = 5f;

		protected bool _isClose;

		private RectTransform rectTransform;

		private Vector3 originalPosition;

		private bool _isClosing;

		private Tweener openTweenerPos;

		private Tweener openTweenerAlpha;

		private Tweener closeTweenerPos;

		private Tweener closeTweenerAlpha;

		protected bool isPressedButton;

		protected static Vector3 tmpVec;

		public bool ignoreTimeScale;

		public bool isClose => default(bool);

		public bool isClosing => default(bool);

		private void Awake()
		{
		}

		protected IEnumerator StartShowAnimation(float rectHeight, [Optional] UnityEvent onCompleted)
		{
			return null;
		}

		protected IEnumerator StartCloseAnimationCoroutine(float rectHeight, [Optional] UnityEvent onCompleted)
		{
			return null;
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		protected Vector3 GetOriginalPosition()
		{
			return default(Vector3);
		}

		protected void SetOriginalPosition(Vector3 pos)
		{
		}
	}
}
