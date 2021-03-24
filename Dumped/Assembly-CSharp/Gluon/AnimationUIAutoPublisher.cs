/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimationUIAutoPublisher : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public AnimationUIAutoSet[] uiSets;
		public const float animationFPS = 60f;
		[Header]
		[SerializeField]
		public int enterDuration;
		[Header]
		[SerializeField]
		public Vector3 enterRotation;
		[Header]
		[SerializeField]
		public int enterRotationDelay;
		[Header]
		[SerializeField]
		public Vector3 enterOffset;
		[Header]
		[SerializeField]
		public Vector3 enterBoundOffset;
		[Header]
		[SerializeField]
		public float enterBoundScale;
		[Header]
		[SerializeField]
		public int exitDuration;
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
		public Vector3 exitOffset;
		[Header]
		[SerializeField]
		public Vector3 exitRotation;
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
		public AnimationUIBase.AnimationEnableType enableType;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _EnterAnimationCoroutine_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AnimationUIAutoPublisher __4__this;
			public Action onFinished;
			public int setIndex;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EnterAnimationCoroutine_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ExitAnimationCoroutine_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AnimationUIAutoPublisher __4__this;
			public Action onFinished;
			public int setIndex;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExitAnimationCoroutine_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AnimationUIAutoPublisher();
	
		// Methods
		private void Awake();
		public void PreheatAll();
		public void RePublishAll();
		private void Start();
		public void PlayEnterAnimation(Action onFinished, int setIndex = -1);
		[IteratorStateMachine]
		private IEnumerator EnterAnimationCoroutine(Action onFinished, int setIndex = -1);
		public void PlayExitAnimation(Action onFinished, int setIndex = -1);
		private void CheckAndClearPlayState(int setIndex = -1);
		public void ForceClearPlayedStatus(int setIndex = -1);
		public void CompleteRunningAnimation(int setIndex = -1);
		[IteratorStateMachine]
		private IEnumerator ExitAnimationCoroutine(Action onFinished, int setIndex = -1);
	}
}
