/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ManaCircle2DCircleObject : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected ManaCircle2DCirclePieceObject[] pieceIcons;
		[SerializeField]
		private ManaCircle2DCircleLimitBreakPieceObject limitBreakIcon;
		[SerializeField]
		private Image nextLimitBreakArrow;
		[SerializeField]
		private Image nextCircleArrow;
		[SerializeField]
		protected Image[] lineImages;
		[SerializeField]
		private Sprite enableArrowSprite;
		[SerializeField]
		protected Sprite enableleLineSprite;
		protected int circleIndex;
		protected GrowthManaCircle2DScene scene;
		protected GrowthManaCircleModel model;
		protected List<int> releaseTargetIdList;
		private bool isShowLimitBreakIcon;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public ManaCircle2DCircleObject __4__this;
			public bool isGrowRelease;
			public GrowthManaCircleManaPieceData pieceData;
			public Action __9__5;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _OnPieceIconPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_1
		{
			// Fields
			public GrowthManaCircleReleaseDonePopup releaseDonePopup;
	
			// Constructors
			public __c__DisplayClass16_1();
	
			// Methods
			internal void _OnPieceIconPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_2
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass16_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass16_2();
	
			// Methods
			internal void _OnPieceIconPressed_b__1();
			internal void _OnPieceIconPressed_b__2();
			internal void _OnPieceIconPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_3
		{
			// Fields
			public GrowthManaCircleAbilityReleaseSkillMaterialPopup materialPopup;
			public __c__DisplayClass16_2 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass16_3();
	
			// Methods
			internal void _OnPieceIconPressed_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _OnLimitBreakPieceIconPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
			public ManaCircle2DCircleObject __4__this;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _OnLimitBreakPieceIconPressed_b__1();
			internal void _OnLimitBreakPieceIconPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_2
		{
			// Fields
			public GrowthManaCircleCannotLimitReleasePopup popup;
	
			// Constructors
			public __c__DisplayClass17_2();
	
			// Methods
			internal void _OnLimitBreakPieceIconPressed_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public ManaCircle2DCircleObject __4__this;
			public bool isShowStoryPopup;
			public Action __9__0;
	
			// Nested types
			private struct __PlayReleasePieceEffect_b__0_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass19_0 __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal async void _PlayReleasePieceEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public bool stopAsync;
	
			// Constructors
			public __c__DisplayClass19_1();
	
			// Methods
			internal void _PlayReleasePieceEffect_b__1();
			internal bool _PlayReleasePieceEffect_b__2();
		}
	
		[CompilerGenerated]
		private struct _PlayReleasePieceEffect_d__19 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ManaCircle2DCircleObject __4__this;
			public bool isShowStoryPopup;
			private __c__DisplayClass19_0 __8__1;
			private int _i_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public ManaCircle2DCircleObject __4__this;
			public TouchGuardObject touchGuard;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _PlayReleaseLimitBreakPieceEffect_b__0();
			internal void _PlayReleaseLimitBreakPieceEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public Action onCompleted;
			public GrowthManaCircleKnightsStoryPopup popup;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _CreateCharaStoryPopup_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__22_1;
			public static Comparison<GrowthManaCircleManaPieceData> __9__23_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateCharaStoryPopup_b__22_1();
			internal int _AutoReleasePiece_b__23_0(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public GrowthManaCircleAutoPopup popup;
			public ManaCircle2DCircleObject __4__this;
			public List<GrowthManaCircleManaPieceData> pieceDataList;
			public bool isGrowRelease;
			public Action __9__4;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _AutoReleasePiece_b__1();
			internal void _AutoReleasePiece_b__2();
			internal void _AutoReleasePiece_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_1
		{
			// Fields
			public CommonPopup noReleasePopup;
	
			// Constructors
			public __c__DisplayClass23_1();
	
			// Methods
			internal void _AutoReleasePiece_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public bool isStopLoop;
			public Func<bool> __9__0;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal bool _ShowStoryPopups_b__0();
			internal void _ShowStoryPopups_b__1();
		}
	
		[CompilerGenerated]
		private struct _ShowStoryPopups_d__24 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			private __c__DisplayClass24_0 __8__1;
			public ManaCircle2DCircleObject __4__this;
			private int _i_5__2;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public Action action;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _ShowGrowEndPopup_b__0();
		}
	
		// Constructors
		public ManaCircle2DCircleObject();
	
		// Methods
		public void InitCircle(GrowthManaCircle2DScene scene, int circleIndex);
		public void UpdatePiece();
		public virtual void UpdateLine();
		public bool IsReleaseAllPiece();
		protected virtual void OnPieceIconPressed(GrowthManaCircleManaPieceData pieceData, ManaCircle2DCirclePieceBase.PieceState state);
		private void OnLimitBreakPieceIconPressed(ManaCircle2DCirclePieceBase.PieceState state);
		private ManaCircle2DCirclePieceObject GetPieceObjectByPieceDataId(int id);
		protected async void PlayReleasePieceEffect(bool isShowStoryPopup = false);
		private bool IsChangeGrowMaterialPopup(bool isGrowRelease);
		private void PlayReleaseLimitBreakPieceEffect();
		public void CreateCharaStoryPopup(Action onCompleted = null);
		public void AutoReleasePiece();
		private async void ShowStoryPopups();
		private void ShowGrowEndPopup(Action action = null);
		public void SetEnableAllPiece(bool enable);
		public void SetEnablePieceByPieceIndex(int index, bool enable);
		[CompilerGenerated]
		private void _OnLimitBreakPieceIconPressed_b__17_3();
	}
}
