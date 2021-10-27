/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Camera mainCamera;
		private string charaVoiceGroupName;
		private TouchGuardObject albumSceneTouchGuard;
		private TouchGuardObject albumSceneTutorialTouchGuard;
		private bool isTutorial;
		private bool isConnecting;
	
		// Nested types
		[CompilerGenerated]
		private struct _OnInitReadyRequestHttp_d__10 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public AlbumScene __4__this;
			private TaskAwaiter<AlbumIndexResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__11_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__11_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumScene __4__this;
			private AlbumCanvas _mainCanvas_5__2;
	
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
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public AlbumScene __4__this;
			public UnityAction updateFlagCompleteAction;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _TutorialAlbumCoroutine_b__0();
			internal void _TutorialAlbumCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialAlbumCoroutine_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumScene __4__this;
			private __c__DisplayClass13_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialAlbumCoroutine_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _CreateGetAlbumBonusPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass14_1();
	
			// Methods
			internal void _CreateGetAlbumBonusPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_2
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass14_2();
	
			// Methods
			internal void _CreateGetAlbumBonusPopup_b__2();
		}
	
		// Constructors
		public AlbumScene();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnEnterScene();
		private void OnPrevSceneExitDone();
		private async void OnInitReadyRequestHttp();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		private void TutorialStart();
		[IteratorStateMachine]
		private IEnumerator TutorialAlbumCoroutine();
		private void CreateGetAlbumBonusPopup();
		public override void OnBeforeLeaving();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__11_1();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__11_2();
		[CompilerGenerated]
		private void _TutorialStart_b__12_0();
	}
}
