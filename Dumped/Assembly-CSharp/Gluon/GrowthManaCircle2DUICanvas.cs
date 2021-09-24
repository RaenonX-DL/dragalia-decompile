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
		public GameObject platinumCrystal;
		public Button menuButton;
		public Button autoButton;
		public Button abilityListButton;
		public Button platinumButton;
		public UnityEngine.UI.Text abilityDetailButtonText;
		public UnityEngine.UI.Text growthButtonText;
		public UnityEngine.UI.Text autoButtonText;
		public UnityEngine.UI.Text manaPointText;
		public UnityEngine.UI.Text releasedNumText;
		public UnityEngine.UI.Text platinumCrystalCountText;
		[SerializeField]
		private Image usePlatinumCrystalButtonImage;
		[SerializeField]
		private Sprite spriteUsePlatinumCrystal1;
		[SerializeField]
		private Sprite spriteUsePlatinumCrystal2;
		public DragEventScrollRect CircleScrollRect;
		public RectTransform circlrObjectParent;
		[HideInInspector]
		public GrowthManaCircle2DScene scene;
		private GrowthManaCircleModel model;
		private ManaCircle2DCircleObject[] firstCircleObjects;
		private SecondManaCircle2DCircleObject secondCircleObject;
		private int currentCircleIndex;
		private bool isFirstLoadEnded;
		private Vector3 manaPointDefaultPosition;
		private Vector3 manaPointCenterPosition;
		public const int firstCircleLastIndex = 4;
		public const float firstCircleLastCircleObjectHeight = 250f;
	
		// Nested types
		[CompilerGenerated]
		private struct _InitScrollPosition_d__30 : IAsyncStateMachine
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
		private struct _SetUIInteractable_d__32 : IAsyncStateMachine
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
		private struct _SetActiveTutorialPiece_d__33 : IAsyncStateMachine
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
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public GrowthManaCircleAbilityListPopup popup;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _OnAbilityListButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public CommonPopup maxPopup;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _FirstCircleAutoReleaseAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_1
		{
			// Fields
			public CommonPopup needReleasePopup;
	
			// Constructors
			public __c__DisplayClass36_1();
	
			// Methods
			internal void _FirstCircleAutoReleaseAction_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public CommonPopup maxPopup;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _SecondCircleAutoReleaseAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public GrowthManaCircle2DUICanvas __4__this;
			public TouchGuardObject releaseLimitBreakEffectTouchGuard;
			public Action onCompleteCallBack;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _PlayReleaseLimitBreakEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public GrowthManaCircle2DUICanvas __4__this;
			public TouchGuardObject releaseAllPieceEffectTouchGuard;
			public bool isUsePlatinumCrystal;
			public Action onCompleteCallBack;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _PlayReleaseAllPieceEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public GrowthManaCircleAllReleaseRewardPopup popup;
			public bool isReloadUI;
			public GrowthManaCircle2DUICanvas __4__this;
			public Action onCompleteCallBack;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _CreateAllReleasedRewardPopup_b__0();
			internal void _CreateAllReleasedRewardPopup_b__1();
			internal void _CreateAllReleasedRewardPopup_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public GrowthManaCircle2DUICanvas __4__this;
			public TouchGuardObject touchGuard;
			public Action onCompleteCallBack;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _PlayLevelupEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public GrowthManaCircle2DUICanvas __4__this;
			public AutoReleasableAllCirclePointData autoReleasableData;
			public Action __9__1;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _AutoReleasePiece_b__0();
			internal void _AutoReleasePiece_b__1();
			internal void _AutoReleasePiece_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public AutoReleasableAllCirclePointData autoReleasableData;
			public GrowthManaCircle2DUICanvas __4__this;
			public bool isGrowRelease;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _AutoReleasePieceByPieceData_b__0();
			internal void _AutoReleasePieceByPieceData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public GrowthManaCircle2DUICanvas __4__this;
			public AutoReleasableAllCirclePointData autoReleasableData;
			public bool isGrowRelease;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _AutoReleasePieceByCircleIndex_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public GrowthManaCircleAutoReleasePopup popup;
			public Action autoReleasePopOkButtonCallBack;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _AutoReleaseCommonAction_b__0();
			internal void _AutoReleaseCommonAction_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_1
		{
			// Fields
			public CommonPopup noReleasePopup;
	
			// Constructors
			public __c__DisplayClass47_1();
	
			// Methods
			internal void _AutoReleaseCommonAction_b__2();
			internal void _AutoReleaseCommonAction_b__3();
			internal void _AutoReleaseCommonAction_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public GrowthManaCircle2DUICanvas __4__this;
			public GrowthAwakeResultPop.BeforeData beforeData;
			public int limitbreakCount;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _OnPlatinumCrystalPressed_b__0();
			internal void _OnPlatinumCrystalPressed_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__50_2;
			public static Func<GrowthManaCircleManaPieceData, int> __9__50_3;
			public static Func<GrowthManaCircleManaPieceData, int> __9__50_4;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _OnPlatinumCrystalPressed_b__50_2(GrowthManaCircleManaPieceData p);
			internal int _OnPlatinumCrystalPressed_b__50_3(GrowthManaCircleManaPieceData p);
			internal int _OnPlatinumCrystalPressed_b__50_4(GrowthManaCircleManaPieceData p);
		}
	
		// Constructors
		public GrowthManaCircle2DUICanvas();
	
		// Methods
		private void Awake();
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
		public void PlayReleaseAllPieceEffect(Action onCompleteCallBack, bool isUsePlatinumCrystal = false);
		public void CreateAllReleasedRewardPopup(Action onCompleteCallBack = null, bool isReloadUI = true);
		public void PlayLevelupEffect(Action onCompleteCallBack = null, bool isReloadUI = true);
		public void AutoReleasePiece(bool isReleaseSecondCircle = false);
		public void AutoReleasePieceByPieceData(GrowthManaCircleManaPieceData pieceData, bool isReleaseSecondCircle = false);
		public void AutoReleasePieceByCircleIndex(int circleIndex);
		private void AutoReleaseCommonAction(AutoReleasableAllCirclePointData autoReleasableData, Action autoReleasePopOkButtonCallBack);
		private void AutoReleaseDataSendCallBackAction(AutoReleasableAllCirclePointData autoReleasableData);
		private void PlayUsePlatinumCrystalDirection(GrowthAwakeResultPop.BeforeData beforeData, GrowthManaCircleManaPieceData[] pieceDataList, int limitBreakCount);
		public void OnPlatinumCrystalPressed();
		[CompilerGenerated]
		private bool _SetUIInteractable_b__32_0();
		[CompilerGenerated]
		private bool _SetActiveTutorialPiece_b__33_0();
	}
}
