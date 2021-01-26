/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialSummonScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Camera _uiCamera;
		[SerializeField]
		private Camera _flashCamera;
		public bool isDebugNotConnecting;
	
		// Properties
		public Camera uiCamera { get; }
		public Camera flashCamera { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__11_0;
			public static Func<bool> __9__11_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__11_0();
			internal bool _WaitPrevSceneExit_b__11_2();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialSummonScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartExitAnimationCoroutine_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialSummonScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartExitAnimationCoroutine_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TutorialSummonScene();
	
		// Methods
		private void Start();
		private void OnEnterScene();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		public override void OnBeforeLeaving();
		public override void StartExitAnimation();
		[IteratorStateMachine]
		private IEnumerator StartExitAnimationCoroutine();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__11_1();
		[CompilerGenerated]
		private bool _StartExitAnimationCoroutine_b__14_0();
	}
}
