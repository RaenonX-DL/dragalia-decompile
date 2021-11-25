using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UIAnimationBase : MonoBehaviour
	{
		public enum AnimationEnableType
		{
			BothEnterAndExit,
			EnterOnly,
			ExitOnly,
			Preheated
		}

		public const float animationFPS = 30f;

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0091ã\u0082¿ã\u0083¼ã\u0083³")]
		public AnimationUICanvas.AnimationPattern pattern;

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0095ã\u0083©ã\u0082°")]
		public AnimationEnableType enableType;

		[SerializeField]
		[Header("Setting")]
		public UIAnimationSetting setting;

		[NonSerialized]
		public bool ignoreTimeScale;

		public const float constDuration = 4f / 15f;

		protected float enterDuration;

		protected float exitDuration;

		protected Ease enterEase;

		protected Ease exitEase;

		protected Vector3 enterOffset;

		protected float enterAlpha;

		protected float exitAlpha;

		protected bool _shouldReEnableChildrenAfterExit;

		protected RectTransform rectTransform;

		protected CanvasGroup canvasGroup;

		protected bool elementsEnabled;

		protected Text[] childTexts;

		protected Image[] childImages;

		protected PointerEventHandler[] childPointEventHandlers;

		protected bool isEnterAnimationPlayed;

		protected bool isExitAnimationPlayed;

		private List<Behaviour> disabledObjectList;

		protected bool isOnEnterAnimation;

		protected bool isOnExitAnimation;

		protected Vector3 startPosition;

		protected Vector3 startNormalAnchorPosition;

		protected Sequence runningSequence;

		public Vector3 exitOffset
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float enterDelay
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float exitDelay
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool shouldReEnableChildrenAfterExit
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

		public virtual void ApplySetting(UIAnimationSetting anotherSetting)
		{
		}

		public virtual void RecordCurrentStateAsDefault()
		{
		}

		public virtual void ResetUIAnimations()
		{
		}

		public virtual void CompleteRunningAnimations()
		{
		}

		public virtual void KillRunningAnimations()
		{
		}

		public bool IsAnimationRunning()
		{
			return default(bool);
		}

		protected virtual void OnReadyToCalculatePosition()
		{
		}

		public virtual void StartEnterAnimation([Optional] Action onAnimationDone)
		{
		}

		protected virtual void JoinEnterCanvasGroupAnimation()
		{
		}

		protected virtual void JoinEnterAnimation()
		{
		}

		public virtual void StartExitAnimation([Optional] Action onAnimationDone)
		{
		}

		protected virtual void JoinExitAnimation()
		{
		}

		protected virtual void JoinExitCanvasGroupAnimation()
		{
		}

		protected virtual float AppendExtraToEnterAnimation()
		{
			return default(float);
		}

		protected virtual float AppendExtraToExitAnimation()
		{
			return default(float);
		}

		public void ForceResetPlayedState(bool enterState, bool exitState)
		{
		}

		protected void DisableChildren()
		{
		}

		protected void EnableChildren(bool includeTouchEvent = true)
		{
		}

		protected void DisableTouchEventChildren()
		{
		}

		protected void EnableTouchEventChildren()
		{
		}

		public bool IsOnAnimation()
		{
			return default(bool);
		}

		public bool IsSamePattern(AnimationUICanvas.AnimationPattern animationPattern)
		{
			return default(bool);
		}
	}
}
