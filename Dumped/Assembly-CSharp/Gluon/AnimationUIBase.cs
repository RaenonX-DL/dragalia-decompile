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
	public class AnimationUIBase : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public AnimationUICanvas.AnimationPattern pattern;
		[Header]
		[SerializeField]
		public AnimationEnableType enableType;
		[Header]
		[SerializeField]
		public bool enterAlphaAnimation;
		[Header]
		[SerializeField]
		public int enterDuration;
		[Header]
		[SerializeField]
		public int enterDelay;
		[Header]
		[SerializeField]
		public float enterScale;
		[Header]
		[SerializeField]
		public Vector3 enterRotation;
		[Header]
		[SerializeField]
		public int enterRotationDelay;
		[Header]
		[SerializeField]
		public int enterRotationDuration;
		[Header]
		[SerializeField]
		public Vector3 enterOffset;
		[Header]
		[SerializeField]
		public Ease enterEase;
		[Header]
		[SerializeField]
		public bool isBounds;
		[Header]
		[SerializeField]
		public Vector3 enterBoundOffset;
		[Header]
		[SerializeField]
		public float enterBoundScale;
		[Header]
		[SerializeField]
		public bool exitAlphaAnimation;
		[Header]
		[SerializeField]
		public int exitDuration;
		[Header]
		[SerializeField]
		public int exitDelay;
		[Header]
		[SerializeField]
		public float exitScale;
		[Header]
		[SerializeField]
		public float exitSpeed;
		[Header]
		[SerializeField]
		public float exitDirection;
		[Header]
		[SerializeField]
		public bool useExitOffset;
		[Header]
		[SerializeField]
		public Vector3 exitOffset;
		[Header]
		[SerializeField]
		public Vector3 exitRotation;
		[Header]
		[SerializeField]
		public bool dispOffOnCompletelyExit;
		[Header]
		[SerializeField]
		public Ease exitEase;
		[Header]
		[SerializeField]
		public bool isExitAnimeBounds;
		[Header]
		[SerializeField]
		public Vector3 exitBoundOffset;
		[Header]
		[SerializeField]
		public float exitBoundScale;
		protected RectTransform rectTransform;
		protected Image image;
		protected bool elementsEnabled;
		protected CanvasGroup canvasGroup;
		protected UnityEngine.UI.Text[] childTexts;
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
	
		// Nested types
		public enum AnimationEnableType
		{
			BothEnterAndExit = 0,
			EnterOnly = 1,
			ExitOnly = 2,
			Preheated = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public AnimationUIBase __4__this;
			public Vector3 overrunRotation;
			public float endScale;
			public Vector3 initialPosition;
			public Vector3 endPosition;
			public Action onAnimationDone;
			public Action<float> __9__7;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal void _StartEnterAnimation_b__0(float x);
			internal void _StartEnterAnimation_b__1(float x);
			internal void _StartEnterAnimation_b__2();
			internal void _StartEnterAnimation_b__7(float x);
			internal void _StartEnterAnimation_b__3(float x);
			internal void _StartEnterAnimation_b__4(float x);
			internal void _StartEnterAnimation_b__5(float x);
			internal void _StartEnterAnimation_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public AnimationUIBase __4__this;
			public float endScale;
			public Vector3 moveDelta;
			public Vector3 initialPosition;
			public Vector3 endPosition;
			public Action onAnimationDone;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _StartExitAnimation_b__0(float x);
			internal void _StartExitAnimation_b__1();
			internal void _StartExitAnimation_b__2(float x);
			internal void _StartExitAnimation_b__3();
			internal void _StartExitAnimation_b__4();
			internal void _StartExitAnimation_b__5();
		}
	
		// Constructors
		public AnimationUIBase();
	
		// Methods
		public virtual void Awake();
		public virtual void RecordCurrentStateAsDefault();
		public virtual void ResetUIAnimations();
		public virtual void CompleteRunningAnimations();
		public virtual void KillRunningAnimations();
		public bool IsAnimationRunning();
		public virtual void StartEnterAnimation(Action onAnimationDone = null);
		public virtual void StartExitAnimation(Action onAnimationDone = null);
		protected virtual void AddToDefaultEnterAnimation();
		protected virtual void AddToDefaultExitAnimation();
		public void ForceResetPlayedState(bool enterState, bool exitState);
		protected void DisableChildren();
		protected void EnableChildren(bool includeTouchEvent = true);
		protected void DisableTouchEventChildren();
		protected void EnableTouchEventChildren();
		public bool IsOnAnimation();
		public bool IsSamePattern(AnimationUICanvas.AnimationPattern animationPattern);
	}
}
