using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class UIAnimationPublisher : MonoBehaviour
	{
		public enum DelayOrderType
		{
			Auto,
			Ascending,
			Descending
		}

		[SerializeField]
		[Header("Settings")]
		public UIAnimationSetting[] settings;

		[SerializeField]
		[Header("è\u0087ªå\u008b\u0095é\u0096\u008bå§\u008b")]
		public bool bAutoStartEnterAnimation;

		[SerializeField]
		[Header("è\u0087ªå\u008b\u0095Playç\u008a¶æ\u0085\u008bæ¶\u0088ã\u0081\u0099")]
		public bool bAutoClearAnimation;

		[SerializeField]
		[Header("Animation Pattern")]
		public AnimationUICanvas.AnimationPattern pattern;

		[SerializeField]
		[Header("Animation Enable Type")]
		public UIAnimationBase.AnimationEnableType enableType;

		[SerializeField]
		[Header("ObjectsToPublish")]
		public GameObject[] objsInSetting;

		public UIAnimationSetting templateSetting;

		public bool firstInFirstOut;

		public DelayOrderType enterDelayType;

		public DelayOrderType exitDelayType;

		[SerializeField]
		[Header("Overrideã\u0081\u008bã\u0081©ã\u0081\u0086ã\u0081\u008b")]
		public bool overrideOriginal;

		[SerializeField]
		[Header("Activeã\u0081\u0098ã\u0082\u0083ã\u0081ªã\u0081\u0084ã\u0083\u008eã\u0083¼ã\u0083\u0089ã\u0082\u0092ç\u0084¡è¦\u0096ã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
		public bool doNotPublishToInactive;

		[SerializeField]
		[Header("Animationã\u0081\u008cã\u0081ªã\u0081\u008fã\u0081¦ã\u0082\u0082å®\u008cäº\u0086ã\u0081\u0099ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081¾ã\u0081¤")]
		public bool waitEvenIfNoObjectsPublished;

		public bool shouldReEnableChildrenAfterExit;

		private List<UIAnimationBase> uiAnimationBaseList;

		public const int defaultMaximumCutoffDurationInFrame = 11;

		public const float defaultMaximumCutoffDuration = 11f / 30f;

		public const int defaultHalfCutoffDurationInFrame = 6;

		public const float defaultHalfCutoffDuration = 0.2f;

		public float maximumCutoffDuration;

		public float halfCutoffDuration;

		[NonSerialized]
		public bool ignoreTimeScale;

		public bool onEnterAnimation
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool onExitAnimation
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public UnityEvent onEnterEvent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public UnityEvent onExitEvent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void PreheatAll()
		{
		}

		public void ResetUIAnimations()
		{
		}

		public static UIAnimationPublisher[] GetValidPublisherList(UIAnimationPublisher[] publishers, AnimationUICanvas.AnimationPattern pattern, UIAnimationBase.AnimationEnableType enableType)
		{
			return null;
		}

		public void RePublishSetting()
		{
		}

		public void RePublishAll()
		{
		}

		public bool IsSamePattern(AnimationUICanvas.AnimationPattern pattern)
		{
			return default(bool);
		}

		public bool IsEnableTypeMatch(UIAnimationBase.AnimationEnableType enableType)
		{
			return default(bool);
		}

		public bool IsOnAnimation()
		{
			return default(bool);
		}

		private void Start()
		{
		}

		public void PlayEnterAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		private IEnumerator EnterAnimationCoroutine(Action onFinished, Action onHalfFinished)
		{
			return null;
		}

		public void PlayExitAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		private IEnumerator ExitAnimationCoroutine(Action onFinished, [Optional] Action onHalfFinished)
		{
			return null;
		}

		private void CheckAndClearPlayState()
		{
		}

		public void ForceClearPlayedStatus()
		{
		}

		public void CompleteRunningAnimation()
		{
		}

		private void ReleaseUIAnimationForObject(GameObject obj)
		{
		}

		public int RemoveObject(GameObject obj)
		{
			return default(int);
		}

		public void OverrideObjectAtIndex(int index, GameObject obj)
		{
		}
	}
}
