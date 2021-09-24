/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using UniRx.Async;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthSecondManaCircleScene : GrowthManaCircleScene
	{
		// Fields
		public GrowthSecondManaCircleObjectsController secondObjectsController;
		public GrowthSecondManaCircleModel secondModel;
		private List<GrowthSecondManaCircleManaPieceObject> selectedTouchPointList;
		public bool isPlayFirstEnterEffect;
		private static GrowthAwakeResultPop.BeforeData beforeUsePlatinumCrystalData;
		private int autoReleaseStartIndex;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public GrowthSecondManaCircleScene __4__this;
			public GrowthSecondManaCircleObjectsController seconObjectsController;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal bool _Start_b__0();
			internal bool _Start_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthSecondManaCircleScene __4__this;
			private __c__DisplayClass6_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthSecondManaCircleScene __4__this;
			private int _index_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public GrowthSecondManaCircleScene __4__this;
			public GrowthSecondManaCircleManaPieceObject touchedPoint;
	
			// Constructors
			public __c__DisplayClass12_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass12_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass12_1();
	
			// Methods
			internal void _OnTouchPointClicked_b__0();
			internal void _OnTouchPointClicked_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_2
		{
			// Fields
			public GrowthManaCircleReleaseDonePopup popup;
	
			// Constructors
			public __c__DisplayClass12_2();
	
			// Methods
			internal void _OnTouchPointClicked_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_3
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass12_0 CS___8__locals2;
	
			// Nested types
			private struct __OnTouchPointClicked_b__9_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass12_3 __4__this;
				private TaskAwaiter<CharaBuildupManaResponse> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass12_3();
	
			// Methods
			internal void _OnTouchPointClicked_b__4();
			internal void _OnTouchPointClicked_b__5();
			internal void _OnTouchPointClicked_b__6();
			internal void _OnTouchPointClicked_b__7();
			internal void _OnTouchPointClicked_b__8();
			internal async void _OnTouchPointClicked_b__9();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__12_2;
			public static Predicate<GrowthSecondManaCircleManaPieceObject> __9__21_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnTouchPointClicked_b__12_2();
			internal bool _PlayAutoReleaseEffect_b__21_0(GrowthSecondManaCircleManaPieceObject x);
		}
	
		[CompilerGenerated]
		private sealed class _PlayReleasePointEffect_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthSecondManaCircleManaPieceObject touchedPoint;
			public GrowthSecondManaCircleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayReleasePointEffect_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _PlayFirstEnterEffectAsync_d__16 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthSecondManaCircleScene __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public CommonPopup maxPopup;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _OnAutotButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private struct _PlayAutoReleaseEffect_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthSecondManaCircleScene __4__this;
			public List<GrowthSecondManaCircleManaPieceObject> pointList;
			public TouchGuardObject touchGuardObject;
			private TaskAwaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _PlayAutoReleaseEffectTask_d__22 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder __t__builder;
			public GrowthSecondManaCircleScene __4__this;
			public List<GrowthSecondManaCircleManaPieceObject> pointList;
			public bool isUsePlatinum;
			private int _index_5__2;
			private int _effectStartPieceCount_5__3;
			private int _effectEndPieceCount_5__4;
			private float _whiteFadeInOutTime_5__5;
			private float _movePointTime_5__6;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public GrowthAwakeResultPop popup;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _PlayUsePlatinumCrystalDirection_b__0();
			internal bool _PlayUsePlatinumCrystalDirection_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_1
		{
			// Fields
			public bool isContinue;
			public GrowthManaCircleAllReleaseRewardPopup allReleasedRewardPopup;
	
			// Constructors
			public __c__DisplayClass24_1();
	
			// Methods
			internal void _PlayUsePlatinumCrystalDirection_b__2();
			internal bool _PlayUsePlatinumCrystalDirection_b__3();
			internal bool _PlayUsePlatinumCrystalDirection_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_2
		{
			// Fields
			public bool isContinue;
			public CommonPopup albumBonusPopup;
	
			// Constructors
			public __c__DisplayClass24_2();
	
			// Methods
			internal void _PlayUsePlatinumCrystalDirection_b__5();
			internal bool _PlayUsePlatinumCrystalDirection_b__6();
			internal bool _PlayUsePlatinumCrystalDirection_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_3
		{
			// Fields
			public bool isContinue;
	
			// Constructors
			public __c__DisplayClass24_3();
	
			// Methods
			internal void _PlayUsePlatinumCrystalDirection_b__8();
			internal bool _PlayUsePlatinumCrystalDirection_b__9();
		}
	
		[CompilerGenerated]
		private struct _PlayUsePlatinumCrystalDirection_d__24 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthSecondManaCircleScene __4__this;
			public int startIndex;
			public List<GrowthSecondManaCircleManaPieceObject> pointList;
			private __c__DisplayClass24_0 __8__1;
			public GrowthAwakeResultPop.BeforeData beforeData;
			private __c__DisplayClass24_1 __8__2;
			private __c__DisplayClass24_2 __8__3;
			private TouchGuardObject _touchGuardObject_5__2;
			private int _storyIndex_5__3;
			private TaskAwaiter __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthSecondManaCircleScene();
		static GrowthSecondManaCircleScene();
	
		// Methods
		[IteratorStateMachine]
		protected override IEnumerator Start();
		[IteratorStateMachine]
		protected override IEnumerator WaitPrevSceneExit();
		public void FirstEnterEffectComplete();
		protected override void Update();
		protected override void LateUpdateTask();
		public override void Reset();
		public void OnTouchPointClicked(GrowthSecondManaCircleManaPieceObject touchedPoint);
		protected void UpdatePointDesc(int centerTouchPointIndex);
		private new void DoReleasePoint();
		[IteratorStateMachine]
		private IEnumerator PlayReleasePointEffect(GrowthSecondManaCircleManaPieceObject touchedPoint);
		public async void PlayFirstEnterEffectAsync();
		public void ResetDescCanvasParam();
		public override void OnAutotButtonPressed();
		protected override void SendAutoReleaseData(List<GrowthManaCircleManaPieceData> pieceDataList, bool isGrowMaterial);
		protected override void DoAutoReleasePoint();
		private async void PlayAutoReleaseEffect(List<GrowthSecondManaCircleManaPieceObject> pointList, TouchGuardObject touchGuardObject);
		private async Task PlayAutoReleaseEffectTask(List<GrowthSecondManaCircleManaPieceObject> pointList, bool isUsePlatinum);
		protected override void UsePlatinumCrystalResultAction(GrowthAwakeResultPop.BeforeData beforeData);
		private async void PlayUsePlatinumCrystalDirection(GrowthAwakeResultPop.BeforeData beforeData, int startIndex, List<GrowthSecondManaCircleManaPieceObject> pointList);
		[CompilerGenerated]
		private void _WaitPrevSceneExit_b__7_0();
		[CompilerGenerated]
		private void _WaitPrevSceneExit_b__7_1();
		[CompilerGenerated]
		private void _FirstEnterEffectComplete_b__8_0();
		[CompilerGenerated]
		private void _PlayFirstEnterEffectAsync_b__16_0();
	}
}
