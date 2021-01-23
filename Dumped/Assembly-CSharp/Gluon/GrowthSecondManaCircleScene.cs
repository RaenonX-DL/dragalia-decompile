/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UniRx.Async;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthSecondManaCircleScene : GrowthManaCircleScene
	{
		// Fields
		public GrowthSecondManaCircleObjectsController secondObjectsController;
		public GrowthSecondManaCircleModel secondModel;
		private List<GrowthSecondManaCircleManaPieceObject> selectedTouchPointList;
		public bool isPlayFirstEnterEffect;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public GrowthSecondManaCircleScene __4__this;
			public GrowthSecondManaCircleObjectsController seconObjectsController;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal bool _Start_b__0();
			internal bool _Start_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__4 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthSecondManaCircleScene __4__this;
			private __c__DisplayClass4_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__5 : IEnumerator<object>
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
			public _WaitPrevSceneExit_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public GrowthSecondManaCircleScene __4__this;
			public GrowthSecondManaCircleManaPieceObject touchedPoint;
	
			// Constructors
			public __c__DisplayClass10_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass10_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass10_1();
	
			// Methods
			internal void _OnTouchPointClicked_b__0();
			internal void _OnTouchPointClicked_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_2
		{
			// Fields
			public GrowthManaCircleReleaseDonePopup popup;
	
			// Constructors
			public __c__DisplayClass10_2();
	
			// Methods
			internal void _OnTouchPointClicked_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_3
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass10_3();
	
			// Methods
			internal void _OnTouchPointClicked_b__4();
			internal void _OnTouchPointClicked_b__5();
			internal void _OnTouchPointClicked_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_4
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass10_0 CS___8__locals2;
	
			// Nested types
			private struct __OnTouchPointClicked_b__11_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass10_4 __4__this;
				private TaskAwaiter<CharaBuildupManaResponse> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass10_4();
	
			// Methods
			internal void _OnTouchPointClicked_b__7();
			internal void _OnTouchPointClicked_b__8();
			internal void _OnTouchPointClicked_b__9();
			internal void _OnTouchPointClicked_b__10();
			internal async void _OnTouchPointClicked_b__11();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__10_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnTouchPointClicked_b__10_2();
		}
	
		[CompilerGenerated]
		private sealed class _PlayReleasePointEffect_d__13 : IEnumerator<object>
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
			public _PlayReleasePointEffect_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _PlayFirstEnterEffectAsync_d__14 : IAsyncStateMachine
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
	
		// Constructors
		public GrowthSecondManaCircleScene();
	
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
		[CompilerGenerated]
		private void _WaitPrevSceneExit_b__5_0();
		[CompilerGenerated]
		private void _WaitPrevSceneExit_b__5_1();
		[CompilerGenerated]
		private void _FirstEnterEffectComplete_b__6_0();
		[CompilerGenerated]
		private void _PlayFirstEnterEffectAsync_b__14_0();
	}
}
