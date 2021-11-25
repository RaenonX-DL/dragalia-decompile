using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class AnimationUICanvas : MonoBehaviour
	{
		public enum AnimationPattern
		{
			Pattern_Any = -1,
			Pattern_1,
			Pattern_2,
			Pattern_3,
			Pattern_4,
			Pattern_5,
			Pattern_6
		}

		private bool _animationEnabled;

		private AnimationUIBase[] animationUIs;

		private UIAnimationPublisher[] animationPublishers;

		public Canvas canvas;

		public bool animationEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		public void RegisterToManager()
		{
		}

		private IEnumerator RegisterToManagerCoroutine()
		{
			return null;
		}

		public void RecollectAnimationUIs()
		{
		}

		public virtual void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator WaitForAnimationComplete(AnimationPattern pattern, Action onAnimationDone)
		{
			return null;
		}

		public virtual void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public void ForceResetPlayedState(bool enterState, bool exitState, AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
		}

		public virtual bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		public bool IsOnAnyAnimation()
		{
			return default(bool);
		}

		public void ResetUIAnimations()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
