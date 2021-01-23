/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class UIAnimationBase : MonoBehaviour
	{
		// Fields
		public const float animationFPS = 30f;
		[Header]
		[SerializeField]
		public AnimationUICanvas.AnimationPattern pattern;
		[Header]
		[SerializeField]
		public AnimationEnableType enableType;
		[Header]
		[SerializeField]
		public UIAnimationSetting setting;
		[NonSerialized]
		public bool ignoreTimeScale;
		public const float constDuration = 0.26666668f;
		protected float enterDuration;
		protected float exitDuration;
		protected Ease enterEase;
		protected Ease exitEase;
		protected Vector3 enterOffset;
		[CompilerGenerated]
		private Vector3 _exitOffset_k__BackingField;
		[CompilerGenerated]
		private float _enterDelay_k__BackingField;
		[CompilerGenerated]
		private float _exitDelay_k__BackingField;
		protected float enterAlpha;
		protected float exitAlpha;
		protected bool _shouldReEnableChildrenAfterExit;
		protected RectTransform rectTransform;
		protected CanvasGroup canvasGroup;
		protected bool elementsEnabled;
		protected UnityEngine.UI.Text[] childTexts;
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
	
		// Properties
		public Vector3 exitOffset { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float enterDelay { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float exitDelay { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool shouldReEnableChildrenAfterExit { get; set; }
	
		// Nested types
		public enum AnimationEnableType
		{
			BothEnterAndExit = 0,
			EnterOnly = 1,
			ExitOnly = 2,
			Preheated = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public UIAnimationBase __4__this;
			public Action onAnimationDone;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _StartEnterAnimation_b__0(float x);
			internal void _StartEnterAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public UIAnimationBase __4__this;
			public Vector3 initialPosition;
			public Vector3 endPosition;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _JoinEnterAnimation_b__0(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public UIAnimationBase __4__this;
			public Action onAnimationDone;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _StartExitAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public UIAnimationBase __4__this;
			public Vector3 initialPosition;
			public Vector3 endPosition;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _JoinExitAnimation_b__0(float x);
		}
	
		// Constructors
		public UIAnimationBase();
	
		// Methods
		protected virtual void Awake();
		public virtual void ApplySetting(UIAnimationSetting anotherSetting);
		public virtual void RecordCurrentStateAsDefault();
		public virtual void ResetUIAnimations();
		public virtual void CompleteRunningAnimations();
		public virtual void KillRunningAnimations();
		public bool IsAnimationRunning();
		protected virtual void OnReadyToCalculatePosition();
		public virtual void StartEnterAnimation(Action onAnimationDone = null);
		protected virtual void JoinEnterCanvasGroupAnimation();
		protected virtual void JoinEnterAnimation();
		public virtual void StartExitAnimation(Action onAnimationDone = null);
		protected virtual void JoinExitAnimation();
		protected virtual void JoinExitCanvasGroupAnimation();
		protected virtual float AppendExtraToEnterAnimation();
		protected virtual float AppendExtraToExitAnimation();
		public void ForceResetPlayedState(bool enterState, bool exitState);
		protected void DisableChildren();
		protected void EnableChildren(bool includeTouchEvent = true);
		protected void DisableTouchEventChildren();
		protected void EnableTouchEventChildren();
		public bool IsOnAnimation();
		public bool IsSamePattern(AnimationUICanvas.AnimationPattern animationPattern);
	}
}
