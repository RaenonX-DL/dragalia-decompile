using System;
using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class QuestEnterCloud : MonoBehaviour
	{
		public RectTransform leftCloud;

		public RectTransform rightCloud;

		public Vector2 firstLeftPosition;

		public Vector2 firstRightPosition;

		public float firstLeftScale;

		public float firstRightScale;

		public float firstDuration;

		public Vector2 secondLeftPosition;

		public Vector2 secondRightPosition;

		public float secondLeftScale;

		public float secondRightScale;

		public float secondDuration;

		public Vector2 thirdLeftPosition;

		public Vector2 thirdRightPosition;

		public float thirdLeftScale;

		public float thirdRightScale;

		private Action _onCompleteCallback;

		private bool _keepClosed;

		private bool _isAnimationDuring;

		private bool _isSecondAnimationDuring;

		public Action onCompleteCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool keepClosed
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isAnimationDuring => default(bool);

		public bool isSecondAnimationDuring => default(bool);

		public void StartAnimation()
		{
		}

		private IEnumerator PreloadCoroutine()
		{
			return null;
		}

		private IEnumerator SecondAnimationCoroutine()
		{
			return null;
		}

		private void OnStartAnimationCompleted()
		{
		}
	}
}
