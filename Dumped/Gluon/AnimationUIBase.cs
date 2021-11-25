using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AnimationUIBase : MonoBehaviour
	{
		public enum AnimationEnableType
		{
			BothEnterAndExit,
			EnterOnly,
			ExitOnly,
			Preheated
		}

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0091ã\u0082¿ã\u0083¼ã\u0083³")]
		public AnimationUICanvas.AnimationPattern pattern;

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0095ã\u0083©ã\u0082°")]
		public AnimationEnableType enableType;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³æ\u009c\u0089ã\u0082\u008a")]
		public bool enterAlphaAnimation;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093ï¼\u0088ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ï¼\u0089")]
		public int enterDuration;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡é\u0081\u0085å»¶ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		public int enterDelay;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u0088\u009dæ\u009c\u009fæ\u008b¡å¤§ç\u008e\u0087")]
		public float enterScale;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u009b\u009eè»¢")]
		public Vector3 enterRotation;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u009b\u009eè»¢é\u0081\u0085å»¶ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		public int enterRotationDelay;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u009b\u009eè»¢æ\u0099\u0082é\u0096\u0093ï¼\u0088ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ï¼\u0089")]
		public int enterRotationDuration;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u0088\u009dæ\u009c\u009fä½\u008dç½®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 enterOffset;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡ã\u0082¤ã\u0083¼ã\u0082\u00b8ã\u0083³ã\u0082°")]
		public Ease enterEase;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0090ã\u0082¦ã\u0083³ã\u0083\u0089ã\u0081\u0082ã\u0082\u008a")]
		public bool isBounds;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0090ã\u0082¦ã\u0083³ã\u0083\u0089ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 enterBoundOffset;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0090ã\u0082¦ã\u0083³ã\u0083\u0089ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
		public float enterBoundScale;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³æ\u009c\u0089ã\u0082\u008a")]
		public bool exitAlphaAnimation;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093ï¼\u0088ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ï¼\u0089")]
		public int exitDuration;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡é\u0081\u0085å»¶ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		public int exitDelay;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡æ\u009c\u0080çµ\u0082ç\u00b8®å°\u008fç\u008e\u0087")]
		public float exitScale;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ç§»å\u008b\u0095é\u0080\u009fåº¦")]
		public float exitSpeed;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ç§»å\u008b\u0095æ\u0096¹è§\u0092")]
		public float exitDirection;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081\u00afé\u0080\u009fåº¦ã\u0082\u0084æ\u0096¹è§\u0092ã\u0081§ã\u0081\u00afã\u0081ªã\u0081\u008fã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0082\u0092ä½¿ã\u0081\u0086")]
		public bool useExitOffset;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡çµ\u0082äº\u0086æ\u0099\u0082ä½\u008dç½®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 exitOffset;

		[SerializeField]
		[Header("ã\u0083\u0080ã\u0082¤ã\u0082¢ã\u0083­ã\u0082°çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡å\u009b\u009eè»¢")]
		public Vector3 exitRotation;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡å®\u008cäº\u0086æ\u0099\u0082ã\u0081«é\u009d\u009eè¡\u00a8ç¤ºã\u0081«ã\u0081\u0099ã\u0082\u008b")]
		public bool dispOffOnCompletelyExit;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0082¤ã\u0083¼ã\u0082\u00b8ã\u0083³ã\u0082°")]
		public Ease exitEase;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0090ã\u0082¦ã\u0083³ã\u0083\u0089ã\u0081\u0082ã\u0082\u008a")]
		public bool isExitAnimeBounds;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0090ã\u0082¦ã\u0083³ã\u0083\u0089ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 exitBoundOffset;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0090ã\u0082¦ã\u0083³ã\u0083\u0089ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
		public float exitBoundScale;

		protected RectTransform rectTransform;

		protected Image image;

		protected bool elementsEnabled;

		protected CanvasGroup canvasGroup;

		protected Text[] childTexts;

		protected Image[] childImages;

		protected PointerEventHandler[] childPointEventHandlers;

		protected bool isEnterAnimationPlayed;

		protected bool isExitAnimationPlayed;

		protected const float overRunFrame = 4f;

		protected const float overRunDirection = 10f;

		private List<Behaviour> disabledObjectList;

		protected bool isOnEnterAnimation;

		protected bool isOnExitAnimation;

		protected Vector3 startPosition;

		protected Quaternion startRotation;

		protected Vector3 startScale;

		protected Sequence runningSequence;

		public virtual void Awake()
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

		public virtual void StartEnterAnimation([Optional] Action onAnimationDone)
		{
		}

		public virtual void StartExitAnimation([Optional] Action onAnimationDone)
		{
		}

		protected virtual void AddToDefaultEnterAnimation()
		{
		}

		protected virtual void AddToDefaultExitAnimation()
		{
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
