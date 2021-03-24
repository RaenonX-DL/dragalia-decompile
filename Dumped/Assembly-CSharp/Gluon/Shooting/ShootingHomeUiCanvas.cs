/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Http;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class ShootingHomeUiCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private Animator logoImageAnimator;
		[SerializeField]
		private Animator gameStartButtonAnimator;
		[SerializeField]
		private Animator backButtonAnimator;
		[SerializeField]
		private Animator scoreBoardButtonAnimator;
		[SerializeField]
		private Animator titleButtonAnimator;
		[SerializeField]
		private Animator modeSelectNodeAnimator;
		[SerializeField]
		private Animator modeSelectNightMareAnimator;
		[SerializeField]
		private Animator whiteScreenAnimator;
		[SerializeField]
		private Animator blackScreenAnimator;
		[SerializeField]
		private Animator textAttention;
		private static ShootingHomeScene shootingHomeScene;
		private const int homeBackKeyEventNum = 0;
		private const int rankingBackKeyEventNum = 1;
		private const int modeSelectBackKeyEventNum = 2;
		private const int endingBackKeyEventNum = 3;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _EpilogueAnim_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShootingHomeUiCanvas __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EpilogueAnim_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AfterScoreBoardButtonPressed_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShootingHomeUiCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AfterScoreBoardButtonPressed_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AfterTitleButtonPressed_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShootingHomeUiCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AfterTitleButtonPressed_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CloseShootingHome_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShootingHomeUiCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CloseShootingHome_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__32_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _StartShooting_b__32_0();
		}
	
		[CompilerGenerated]
		private struct _StartShooting_d__32 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ShootingHomeUiCanvas __4__this;
			private TaskAwaiter<DreamAdventurePlayResponse> __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class _StartUIAnimWithWaight_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float diray;
			public ShootingHomeUiCanvas __4__this;
			public Animator animator;
			public bool isIn;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartUIAnimWithWaight_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ShootingHomeUiCanvas();
		static ShootingHomeUiCanvas();
	
		// Methods
		private void Start();
		private void AppearUI();
		[IteratorStateMachine]
		private IEnumerator EpilogueAnim();
		public void OnGameStartButtonPressed();
		public void OnScoreBoardButtonPressed();
		[IteratorStateMachine]
		private IEnumerator AfterScoreBoardButtonPressed();
		public void OnTitleButtonPressed();
		[IteratorStateMachine]
		private IEnumerator AfterTitleButtonPressed();
		public void OnNormalModeButtonPressed();
		public void OnHardMordButtonPressed();
		public void OnNightMareMordButtonPressed();
		public void OnBackButtonPressed();
		public void OnTransparentButtonPressed();
		private void StartButtonsAnimation(bool isIn);
		[IteratorStateMachine]
		private IEnumerator CloseShootingHome();
		private void GoMyPage();
		private void OnStartShooting(STGDataManager.Mode mode);
		private async void StartShooting();
		public bool IsFirstClear();
		private bool IsClearedNormal();
		private bool IsReleaseNightmare();
		private void StartLogoAnim(bool isIn);
		private void StartGameStartButtonAnim(bool isIn, float diray = 0f);
		private void StartBackButtonAnim(bool isIn, float diray = 0f);
		private void StartScoreBoardButtonAnim(bool isIn, float diray = 0f);
		private void StartTitleButtonAnim(bool isIn, float diray = 0f);
		private void StartModeSelectNodeAnim(bool isIn, float diray = 0f);
		private void StartUIAnim(Animator animator, bool isIn);
		private void StartUIAnim(Animator animator, bool isIn, float diray);
		[IteratorStateMachine]
		private IEnumerator StartUIAnimWithWaight(Animator animator, bool isIn, float diray);
		private void SetBuckKeyEvent(int sortingOrder, UnityAction action);
		private void RemoveBuckKeyEvent(int sortingOrder);
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _AppearUI_b__16_0();
		[CompilerGenerated]
		private void _EpilogueAnim_b__17_0();
		[CompilerGenerated]
		private void _OnGameStartButtonPressed_b__18_0();
		[CompilerGenerated]
		private void _AfterScoreBoardButtonPressed_b__20_0();
	}
}
