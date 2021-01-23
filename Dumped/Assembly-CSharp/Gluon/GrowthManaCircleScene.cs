/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleScene : SceneBase
	{
		// Fields
		public Camera mainCamera;
		public Camera uiCamera;
		public GrowthManaCircleCameraController cameraController;
		public GrowthManaCircleEffectController effectController;
		public GrowthManaCircleObjectsController objectsController;
		public GrowthManaCircleObjectSettings objectSettings;
		public GrowthManaCircleEffectSettings effectSettings;
		public GrowthManaCircleCameraSettings cameraSettings;
		public GrowthManaCircleSoundController soundController;
		public GrowthManaCircleUICanvas mainCanvas;
		public GrowthManaCircleModel model;
		public float idleTime;
		public bool isMenuOpened;
		private List<GrowthManaCircleManaPieceObject> selectedTouchPointList;
		protected GrowthManaCircleStatusCanvas statusCanvas;
		protected GrowthManaCircleManaPieceDescriptionCanvas pointDescCanvas;
		private int lastTouchPointIndex;
		public static string prefabDir;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__18_0;
			public static Action __9__38_0;
			public static Action __9__39_2;
			public static Action __9__42_0;
			public static Action __9__47_0;
			public static Action __9__48_0;
			public static Action __9__56_1;
			public static TweenCallback __9__56_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Start_b__18_0();
			internal void _GoManaCircleBlankScene_b__38_0();
			internal void _CreateCharaStoryPopup_b__39_2();
			internal void _OnBackButtonPressed_b__42_0();
			internal void _OnGrowthButtonPressed_b__47_0();
			internal void _OnAwakeningButtonPressed_b__48_0();
			internal void _ShowTutorialPointer_b__56_0();
			internal void _ShowTutorialPointer_b__56_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public GrowthManaCircleScene __4__this;
			public bool isGrowRelease;
			public GrowthManaCircleManaPieceObject touchedPoint;
	
			// Constructors
			public __c__DisplayClass28_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_1
		{
			// Fields
			public GrowthManaCircleReleaseDonePopup popup;
	
			// Constructors
			public __c__DisplayClass28_1();
	
			// Methods
			internal void _OnTouchPointClicked_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_2
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass28_2();
	
			// Methods
			internal void _OnTouchPointClicked_b__1();
			internal void _OnTouchPointClicked_b__2();
			internal void _OnTouchPointClicked_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_3
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass28_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass28_3();
	
			// Methods
			internal void _OnTouchPointClicked_b__4();
			internal void _OnTouchPointClicked_b__5();
			internal void _OnTouchPointClicked_b__6();
			internal void _OnTouchPointClicked_b__7();
			internal void _OnTouchPointClicked_b__8();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public GrowthManaCircleAutoPopup popup;
			public GrowthManaCircleScene __4__this;
			public List<GrowthManaCircleManaPieceData> pieceDataList;
			public bool isGrowMaterial;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _OnAutotButtonPressed_b__0();
			internal void _OnAutotButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_1
		{
			// Fields
			public CommonPopup maxPopup;
	
			// Constructors
			public __c__DisplayClass31_1();
	
			// Methods
			internal void _OnAutotButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_2
		{
			// Fields
			public CommonPopup maxPopup;
	
			// Constructors
			public __c__DisplayClass31_2();
	
			// Methods
			internal void _OnAutotButtonPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public CommonPopup popup;
			public GrowthManaCircleScene __4__this;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__0();
			internal void _OnReleaseMotifClicked_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_1
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
			public GrowthManaCircleScene __4__this;
	
			// Nested types
			private struct __OnReleaseMotifClicked_b__3_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass35_1 __4__this;
				private TaskAwaiter<CharaLimitBreakResponse> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass35_1();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__2();
			internal async void _OnReleaseMotifClicked_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_2
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
	
			// Constructors
			public __c__DisplayClass35_2();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_3
		{
			// Fields
			public GrowthManaCircleCannotLimitReleasePopup popup;
	
			// Constructors
			public __c__DisplayClass35_3();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_4
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
			public GrowthManaCircleScene __4__this;
	
			// Constructors
			public __c__DisplayClass35_4();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__6();
			internal void _OnReleaseMotifClicked_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public Action onCompleted;
			public GrowthManaCircleKnightsStoryPopup popup;
			public GrowthManaCircleScene __4__this;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _CreateCharaStoryPopup_b__0();
			internal void _CreateCharaStoryPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _CreateReleaseAutoCannotDueToLimitPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public GrowthManaCircleAllReleaseRewardPopup popup;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _CreateAllReleasedRewardPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public GrowthManaCircleAbilityListPopup popup;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _OnAbilityListButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _StartTutorialCoroutine_d__55 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartTutorialCoroutine_d__55(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthManaCircleScene();
		static GrowthManaCircleScene();
	
		// Methods
		[IteratorStateMachine]
		protected virtual IEnumerator Start();
		[IteratorStateMachine]
		protected virtual new IEnumerator WaitPrevSceneExit();
		public override void OnBeforeLeaving();
		private void OnDestroy();
		protected virtual void Update();
		protected override void LateUpdate();
		protected virtual void LateUpdateTask();
		public void OnEndDrag();
		protected virtual void UpdatePointDesc(int targetCircleIndex, int centerTouchPointIndex);
		public void UpdateStatusCanvas();
		public void OnTouchPointClicked(GrowthManaCircleManaPieceObject touchedPoint);
		public void OnReleasePointSuccess(CharaBuildupManaResponse res);
		private void DoReleasePoint();
		public void OnAutotButtonPressed();
		public void OnAutoReleasePointSuccess(CharaBuildupManaResponse res);
		private void DoAutoReleasePoint();
		public void OnMotifClicked(GrowthManaCircleMotifObject.MotifType type, GrowthManaCircleMotifObject touchedMotif);
		private void OnReleaseMotifClicked(GrowthManaCircleMotifObject touchedMotif);
		public void OnLimitBreakSuccess(CharaLimitBreakResponse res);
		private void DoLimitBreak();
		public void GoManaCircleBlankScene(bool isShowTips = true);
		public void CreateCharaStoryPopup(Action onCompleted = null);
		public static void CreateReleaseAutoCannotDueToLimitPopup();
		public void CreateAllReleasedRewardPopup();
		public void OnBackButtonPressed();
		public void SetEnablePointDescCanvas(bool arg);
		public void ForceMoveUpToMaxCircle(float duration);
		public void OnAbilityListButtonPressed();
		public void OnManaCircleMenuButtonPressed();
		public void OnGrowthButtonPressed();
		public void OnAwakeningButtonPressed();
		public void OnListButtonPressed();
		public void StartScreenSaver();
		public void FinishScreenSaver();
		public void AllReleaseForDevelop();
		public virtual void Reset();
		public void StartTutorial();
		[IteratorStateMachine]
		private IEnumerator StartTutorialCoroutine();
		private void ShowTutorialPointer();
		public void ShowTutorialFinishWindow();
		[CompilerGenerated]
		private bool _Start_b__18_1();
		[CompilerGenerated]
		private bool _Start_b__18_2();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__19_0();
		[CompilerGenerated]
		private void _DoReleasePoint_b__30_0();
		[CompilerGenerated]
		private void _ShowTutorialFinishWindow_b__57_0();
		[CompilerGenerated]
		private void _ShowTutorialFinishWindow_b__57_1();
	}
}
