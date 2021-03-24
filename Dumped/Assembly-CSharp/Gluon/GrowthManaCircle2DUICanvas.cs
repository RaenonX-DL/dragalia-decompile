/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircle2DUICanvas : MonoBehaviour
	{
		// Fields
		public GameObject star;
		public GameObject manaPoint;
		public Button menuButton;
		public Button autoButton;
		public Button abilityListButton;
		public UnityEngine.UI.Text abilityDetailButtonText;
		public UnityEngine.UI.Text growthButtonText;
		public UnityEngine.UI.Text autoButtonText;
		public UnityEngine.UI.Text manaPointText;
		public UnityEngine.UI.Text releasedNumText;
		public DragEventScrollRect CircleScrollRect;
		public RectTransform circlrObjectParent;
		[HideInInspector]
		public GrowthManaCircle2DScene scene;
		private GrowthManaCircleModel model;
		private ManaCircle2DCircleObject[] firstCircleObjects;
		private SecondManaCircle2DCircleObject secondCircleObject;
		private int currentCircleIndex;
		private bool isFirstLoadEnded;
		public const int firstCircleLastIndex = 4;
		public const float firstCircleLastCircleObjectHeight = 250f;
	
		// Nested types
		[CompilerGenerated]
		private struct _InitScrollPosition_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthManaCircle2DUICanvas __4__this;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SetUIInteractable_d__23 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthManaCircle2DUICanvas __4__this;
			public bool interactable;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SetActiveTutorialPiece_d__24 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthManaCircle2DUICanvas __4__this;
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
			public GrowthManaCircleAbilityListPopup popup;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _OnAbilityListButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public CommonPopup maxPopup;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _FirstCircleAutoReleaseAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public CommonPopup maxPopup;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _SecondCircleAutoReleaseAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public GrowthManaCircle2DUICanvas __4__this;
			public Action onCompleteCallBack;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _PlayReleaseLimitBreakEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public GrowthManaCircleAllReleaseRewardPopup popup;
			public GrowthManaCircle2DUICanvas __4__this;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _CreateAllReleasedRewardPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public CommonPopup popup;
			public Action callBack;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _CreateAlbumBonusPopup_b__0();
		}
	
		// Constructors
		public GrowthManaCircle2DUICanvas();
	
		// Methods
		private void Start();
		private async void InitScrollPosition();
		public void Reload();
		public async void SetUIInteractable(bool interactable);
		public async void SetActiveTutorialPiece();
		public void OnAbilityListButtonPressed();
		public void OnAutoButtonPressed();
		public void FirstCircleAutoReleaseAction();
		public void SecondCircleAutoReleaseAction();
		public void OnManaCircleMenuButtonPressed();
		public void MoveCircleListByCircleIndex(int circleIndex);
		public void PlayReleaseLimitBreakEffect(Action onCompleteCallBack = null);
		public void PlayReleaseAllPieceEffect();
		public void CreateAllReleasedRewardPopup();
		public void CreateAlbumBonusPopup(Action callBack = null);
		[CompilerGenerated]
		private bool _SetUIInteractable_b__23_0();
		[CompilerGenerated]
		private bool _SetActiveTutorialPiece_b__24_0();
		[CompilerGenerated]
		private void _PlayReleaseAllPieceEffect_b__32_0();
	}
}
