/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UIAnimationPublisher : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UIAnimationSetting[] settings;
		[Header]
		[SerializeField]
		public bool bAutoStartEnterAnimation;
		[Header]
		[SerializeField]
		public bool bAutoClearAnimation;
		[Header]
		[SerializeField]
		public AnimationUICanvas.AnimationPattern pattern;
		[Header]
		[SerializeField]
		public UIAnimationBase.AnimationEnableType enableType;
		[Header]
		[SerializeField]
		public GameObject[] objsInSetting;
		public UIAnimationSetting templateSetting;
		public bool firstInFirstOut;
		public DelayOrderType enterDelayType;
		public DelayOrderType exitDelayType;
		[Header]
		[SerializeField]
		public bool overrideOriginal;
		[Header]
		[SerializeField]
		public bool doNotPublishToInactive;
		[Header]
		[SerializeField]
		public bool waitEvenIfNoObjectsPublished;
		public bool shouldReEnableChildrenAfterExit;
		private List<UIAnimationBase> uiAnimationBaseList;
		public const int defaultMaximumCutoffDurationInFrame = 11;
		public const float defaultMaximumCutoffDuration = 0.36666667f;
		public const int defaultHalfCutoffDurationInFrame = 6;
		public const float defaultHalfCutoffDuration = 0.2f;
		public float maximumCutoffDuration;
		public float halfCutoffDuration;
		[CompilerGenerated]
		private bool _onEnterAnimation_k__BackingField;
		[CompilerGenerated]
		private bool _onExitAnimation_k__BackingField;
		[CompilerGenerated]
		private UnityEvent _onEnterEvent_k__BackingField;
		[CompilerGenerated]
		private UnityEvent _onExitEvent_k__BackingField;
		[NonSerialized]
		public bool ignoreTimeScale;
	
		// Properties
		public bool onEnterAnimation { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool onExitAnimation { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public UnityEvent onEnterEvent { [CompilerGenerated] get; [CompilerGenerated] set; }
		public UnityEvent onExitEvent { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum DelayOrderType
		{
			Auto = 0,
			Ascending = 1,
			Descending = 2
		}
	
		[CompilerGenerated]
		private sealed class _EnterAnimationCoroutine_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UIAnimationPublisher __4__this;
			public Action onHalfFinished;
			public Action onFinished;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EnterAnimationCoroutine_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ExitAnimationCoroutine_d__52 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UIAnimationPublisher __4__this;
			public Action onHalfFinished;
			public Action onFinished;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExitAnimationCoroutine_d__52(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public UIAnimationPublisher();
	
		// Methods
		private void Awake();
		public void PreheatAll();
		public void ResetUIAnimations();
		public static UIAnimationPublisher[] GetValidPublisherList(UIAnimationPublisher[] publishers, AnimationUICanvas.AnimationPattern pattern, UIAnimationBase.AnimationEnableType enableType);
		public void RePublishSetting();
		public void RePublishAll();
		public bool IsSamePattern(AnimationUICanvas.AnimationPattern pattern);
		public bool IsEnableTypeMatch(UIAnimationBase.AnimationEnableType enableType);
		public bool IsOnAnimation();
		private void Start();
		public void PlayEnterAnimation(Action onFinished, Action onHalfFinished = null);
		[IteratorStateMachine]
		private IEnumerator EnterAnimationCoroutine(Action onFinished, Action onHalfFinished);
		public void PlayExitAnimation(Action onFinished, Action onHalfFinished = null);
		[IteratorStateMachine]
		private IEnumerator ExitAnimationCoroutine(Action onFinished, Action onHalfFinished = null);
		private void CheckAndClearPlayState();
		public void ForceClearPlayedStatus();
		public void CompleteRunningAnimation();
		private void ReleaseUIAnimationForObject(GameObject obj);
		public int RemoveObject(GameObject obj);
		public void OverrideObjectAtIndex(int index, GameObject obj);
	}
}
