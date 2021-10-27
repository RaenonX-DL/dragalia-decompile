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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private TouchGuardObject endPieceEffectTouchGuard;
		private int storyPopupCount;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public ManaCircle2DCircleObject __4__this;
			public GrowthManaCircleManaPieceData pieceData;
			public bool isGrowRelease;
			public Action __9__6;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _OnPieceIconPressed_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_1
		{
			// Fields
			public GrowthManaCircleReleaseDonePopup releaseDonePopup;
	
			// Constructors
			public __c__DisplayClass18_1();
	
			// Methods
			internal void _OnPieceIconPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_2
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass18_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass18_2();
	
			// Methods
			internal void _OnPieceIconPressed_b__1();
			internal void _OnPieceIconPressed_b__2();
			internal void _OnPieceIconPressed_b__3();
			internal void _OnPieceIconPressed_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_3
		{
			// Fields
			public GrowthManaCircleAbilityReleaseSkillMaterialPopup materialPopup;
			public __c__DisplayClass18_2 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass18_3();
	
			// Methods
			internal void _OnPieceIconPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _OnLimitBreakPieceIconPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
			public ManaCircle2DCircleObject __4__this;
	
			// Constructors
			public __c__DisplayClass19_1();
	
			// Methods
			internal void _OnLimitBreakPieceIconPressed_b__1();
			internal void _OnLimitBreakPieceIconPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_2
		{
			// Fields
			public GrowthManaCircleCannotLimitReleasePopup popup;
			public ManaCircle2DCircleObject __4__this;
	
			// Constructors
			public __c__DisplayClass19_2();
	
			// Methods
			internal void _OnLimitBreakPieceIconPressed_b__4();
			internal void _OnLimitBreakPieceIconPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public ManaCircle2DCircleObject __4__this;
			public bool isShowStoryPopup;
			public Action __9__1;
			public Action __9__0;
	
			// Nested types
			private struct __PlayReleasePieceEffect_b__0_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass21_0 __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal async void _PlayReleasePieceEffect_b__0();
			internal void _PlayReleasePieceEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_1
		{
			// Fields
			public bool stopAsync;
	
			// Constructors
			public __c__DisplayClass21_1();
	
			// Methods
			internal void _PlayReleasePieceEffect_b__2();
			internal bool _PlayReleasePieceEffect_b__3();
		}
	
		[CompilerGenerated]
		private struct _PlayReleasePieceEffect_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ManaCircle2DCircleObject __4__this;
			public bool isShowStoryPopup;
			private __c__DisplayClass21_0 __8__1;
			private int _i_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public ManaCircle2DCircleObject __4__this;
			public bool isReleaseLimitBreak;
			public bool isShowStoryPopup;
			public Action __9__0;
	
			// Nested types
			private struct __PlayAutoReleasePieceEffect_b__0_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass22_0 __4__this;
				private __c__DisplayClass22_1 __8__1;
				private bool _isAllReleased_5__2;
				private bool _isAllMaxRelease_5__3;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal async void _PlayAutoReleasePieceEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_1
		{
			// Fields
			public bool stopAsync;
			public __c__DisplayClass22_0 CS___8__locals1;
			public Action __9__10;
	
			// Constructors
			public __c__DisplayClass22_1();
	
			// Methods
			internal void _PlayAutoReleasePieceEffect_b__1();
			internal bool _PlayAutoReleasePieceEffect_b__2();
			internal void _PlayAutoReleasePieceEffect_b__3();
			internal void _PlayAutoReleasePieceEffect_b__10();
			internal void _PlayAutoReleasePieceEffect_b__4();
			internal bool _PlayAutoReleasePieceEffect_b__5();
			internal void _PlayAutoReleasePieceEffect_b__6();
			internal bool _PlayAutoReleasePieceEffect_b__7();
			internal void _PlayAutoReleasePieceEffect_b__8();
			internal bool _PlayAutoReleasePieceEffect_b__9();
		}
	
		[CompilerGenerated]
		private struct _PlayAutoReleasePieceEffect_d__22 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ManaCircle2DCircleObject __4__this;
			public bool isReleaseLimitBreak;
			public bool isShowStoryPopup;
			private __c__DisplayClass22_0 __8__1;
			private int _i_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _PlayReleaseAllCirclePieceEffect_d__23 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ManaCircle2DCircleObject __4__this;
			private int _i_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public ManaCircle2DCircleObject __4__this;
			public TouchGuardObject touchGuard;
			public int storyPopupCount;
			public Action __9__1;
	
			// Nested types
			private struct __PlayReleaseLimitBreakPieceEffect_b__1_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass25_0 __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _PlayReleaseLimitBreakPieceEffect_b__0();
			internal async void _PlayReleaseLimitBreakPieceEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_1
		{
			// Fields
			public bool stopAsync;
	
			// Constructors
			public __c__DisplayClass25_1();
	
			// Methods
			internal void _PlayReleaseLimitBreakPieceEffect_b__2();
			internal bool _PlayReleaseLimitBreakPieceEffect_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public ManaCircle2DCircleObject __4__this;
			public TouchGuardObject touchGuard;
			public int storyPopupCount;
			public Action __9__1;
	
			// Nested types
			private struct __PlayReleasePieceAndLimitBreakEffect_b__1_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass26_0 __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _PlayReleasePieceAndLimitBreakEffect_b__0();
			internal async void _PlayReleasePieceAndLimitBreakEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_1
		{
			// Fields
			public bool stopAsync;
	
			// Constructors
			public __c__DisplayClass26_1();
	
			// Methods
			internal void _PlayReleasePieceAndLimitBreakEffect_b__2();
			internal bool _PlayReleasePieceAndLimitBreakEffect_b__3();
		}
	
		[CompilerGenerated]
		private struct _PlayReleasePieceAndLimitBreakEffect_d__26 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ManaCircle2DCircleObject __4__this;
			public int storyPopupCount;
			public GrowthManaCircleManaPieceData[] pieceDataList;
			private __c__DisplayClass26_0 __8__1;
			private int _i_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public Action OnPopAnimationEnded;
			public Action onCompleted;
			public GrowthManaCircleKnightsStoryPopup popup;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _CreateCharaStoryPopup_b__0();
			internal void _CreateCharaStoryPopup_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__27_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateCharaStoryPopup_b__27_2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public bool isShowRewardPopup;
			public bool stopAsync;
			public bool isShowLevelMaxPopup;
			public GrowthAwakeResultPop resultPop;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _PlayUsePlatinumCrystalDirection_b__10();
			internal void _PlayUsePlatinumCrystalDirection_b__11();
			internal bool _PlayUsePlatinumCrystalDirection_b__12();
			internal void _PlayUsePlatinumCrystalDirection_b__0();
			internal bool _PlayUsePlatinumCrystalDirection_b__1();
			internal void _PlayUsePlatinumCrystalDirection_b__2();
			internal bool _PlayUsePlatinumCrystalDirection_b__3();
			internal bool _PlayUsePlatinumCrystalDirection_b__4();
			internal void _PlayUsePlatinumCrystalDirection_b__5();
			internal void _PlayUsePlatinumCrystalDirection_b__6();
			internal bool _PlayUsePlatinumCrystalDirection_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_1
		{
			// Fields
			public bool isLastPieceEffectEnd;
	
			// Constructors
			public __c__DisplayClass29_1();
	
			// Methods
			internal void _PlayUsePlatinumCrystalDirection_b__8();
			internal bool _PlayUsePlatinumCrystalDirection_b__9();
		}
	
		[CompilerGenerated]
		private struct _PlayUsePlatinumCrystalDirection_d__29 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int storyPopupCount;
			public ManaCircle2DCircleObject __4__this;
			public GrowthManaCircleManaPieceData[] pieceDataList;
			private __c__DisplayClass29_0 __8__1;
			public GrowthAwakeResultPop.BeforeData beforeData;
			private bool _isShowStoryPopup_5__2;
			private bool _isShowAlbumBonusPopup_5__3;
			private int _i_5__4;
			private UniTask<int> __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public bool isStopLoop;
			public ManaCircle2DCircleObject __4__this;
			public Func<bool> __9__0;
			public Action __9__1;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal bool _ShowStoryPopups_b__0();
			internal void _ShowStoryPopups_b__1();
			internal void _ShowStoryPopups_b__2();
		}
	
		[CompilerGenerated]
		private struct _ShowStoryPopups_d__30 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ManaCircle2DCircleObject __4__this;
			private __c__DisplayClass30_0 __8__1;
			private int _i_5__2;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public Action action;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass31_0();
	
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
		protected async void PlayAutoReleasePieceEffect(bool isShowStoryPopup, bool isReleaseLimitBreak);
		public async void PlayReleaseAllCirclePieceEffect();
		private bool IsChangeGrowMaterialPopup(bool isGrowRelease);
		public void PlayReleaseLimitBreakPieceEffect(int storyPopupCount = 0);
		public async void PlayReleasePieceAndLimitBreakEffect(GrowthManaCircleManaPieceData[] pieceDataList, int storyPopupCount);
		public static void CreateCharaStoryPopup(int characterId, int storyIndex, int rarity, bool isTemporary, Action OnPopAnimationEnded, Action onCompleted);
		public void AutoReleaseResultAction(GrowthManaCircleManaPieceData[] pieceDataList, int storyPopupCount, bool isReleaseLimitBreak);
		public async void PlayUsePlatinumCrystalDirection(GrowthAwakeResultPop.BeforeData beforeData, GrowthManaCircleManaPieceData[] pieceDataList, int storyPopupCount, bool isReleaseLimitBreak);
		private async void ShowStoryPopups();
		private void ShowGrowEndPopup(Action action = null);
		public void SetEnableAllPiece(bool enable);
		public void SetEnablePieceByPieceIndex(int index, bool enable);
		private bool IsRelesableCircleByRarity();
		[CompilerGenerated]
		private void _OnLimitBreakPieceIconPressed_b__19_3();
	}
}
