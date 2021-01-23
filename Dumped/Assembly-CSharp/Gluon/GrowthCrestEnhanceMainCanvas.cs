/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using FLATOUT.Main;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthCrestEnhanceMainCanvas : GrowthUnitEnhanceMainCanvas
	{
		// Fields
		public GrowthUnitEnhanceListCell[] listCells;
		public Button growPlusButton;
		public GameObject effectBaseObject;
		private BaseCanvasContents baseCanvasContents;
		private GameObject amuletAnimation;
		private GameObject amuletHeaderAnimation;
		private EffectObject frontEffectObject;
		private EffectObject backEffectObject;
		private EffectObject firstEffectObject;
		private bool isSkipButtonLocked;
		private GrowthLimitBreak.SkipEffectStatus nowEffectStatus;
		private int effectSkipSortOderKey;
		private AudioPlayback amuletSePlayback;
		private Canvas uiCanvas;
		private TouchGuardObject playCloseEffectTouchGuard;
		private FlashTextType playTextType;
		private int beforeLimitBreak;
		private bool isPlayMemorialRiseEffect;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public GrowthCrestEnhanceMainCanvas __4__this;
			public bool isPlayResultEffect;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _PlayResultEffects_b__0();
			internal bool _PlayResultEffects_b__1();
			internal void _PlayResultEffects_b__5();
			internal bool _PlayResultEffects_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_1
		{
			// Fields
			public bool isLoadEfectEnded;
	
			// Constructors
			public __c__DisplayClass20_1();
	
			// Methods
			internal void _PlayResultEffects_b__3();
			internal bool _PlayResultEffects_b__4();
		}
	
		[CompilerGenerated]
		private struct _PlayResultEffects_d__20 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthCrestEnhanceMainCanvas __4__this;
			public GrowthUnitEnhanceSendData[] sendDatas;
			private __c__DisplayClass20_0 __8__1;
			public Action effectEndCallBack;
			private TaskAwaiter __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public GrowthAutoUnitEnhanceConfirmPopup popup;
			public GrowthCrestEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _OnAutoButtonPressed_b__0();
			internal void _OnAutoButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_1
		{
			// Fields
			public int totalReleaseCount;
			public int beforeBuilup;
			public __c__DisplayClass22_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass22_1();
	
			// Methods
			internal void _OnAutoButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public GrowthUnitStatusConfirmPopup popup;
			public bool isPlayTutorial;
			public GrowthCrestEnhanceMainCanvas __4__this;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _OnCellButtonPressed_b__0();
			internal void _OnCellButtonPressed_b__3();
			internal void _OnCellButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_1
		{
			// Fields
			public int beforeBuilup;
			public int beforePower;
			public __c__DisplayClass23_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass23_1();
	
			// Methods
			internal void _OnCellButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_2
		{
			// Fields
			public bool isPlayTutorial;
			public GrowthWeaponLimitBreakConfirmPopup popup;
			public GrowthCrestEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass23_2();
	
			// Methods
			internal void _OnCellButtonPressed_b__4();
			internal void _OnCellButtonPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_3
		{
			// Fields
			public int beforeAbility1Id;
			public __c__DisplayClass23_2 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass23_3();
	
			// Methods
			internal void _OnCellButtonPressed_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_4
		{
			// Fields
			public GrowthUnitEquipCountConfirmPopup popup;
			public GrowthCrestEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass23_4();
	
			// Methods
			internal void _OnCellButtonPressed_b__7();
			internal void _OnCellButtonPressed_b__8();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public GrowthCrestPlusParamPopup popup;
			public GrowthCrestEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _OnPlusButtonPressed_b__0();
			internal void _OnPlusButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public GrowthCrestPlusParamConfirmPopup popup;
			public GrowthCrestEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _ShowPlusParamConfirmPopup_b__0();
			internal void _ShowPlusParamConfirmPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_1
		{
			// Fields
			public GrowthCrestPlusParamResultPopup.BeforeData beforeData;
			public __c__DisplayClass29_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass29_1();
	
			// Methods
			internal void _ShowPlusParamConfirmPopup_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public GrowthCrestLimitBreakResultPopup popup;
			public GrowthCrestEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _ShowCrestLimitBreakResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public GrowthCrestPlusParamResultPopup popup;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _ShowCrestPlusParamResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public GrowthAutoUnitEnhanceResultPopup popup;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _ShowAutoEnhanceResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public bool initUIManager;
			public TutorialGuideWindowData windowData;
			public GrowthCrestEnhanceMainCanvas __4__this;
			public Action __9__3;
			public Action __9__4;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _StartLimitBreakTutorial_b__0();
			internal bool _StartLimitBreakTutorial_b__1();
			internal void _StartLimitBreakTutorial_b__2();
			internal void _StartLimitBreakTutorial_b__3();
			internal void _StartLimitBreakTutorial_b__4();
		}
	
		[CompilerGenerated]
		private struct _StartLimitBreakTutorial_d__33 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthCrestEnhanceMainCanvas __4__this;
			private __c__DisplayClass33_0 __8__1;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _EndLimitBreakTutorial_d__34 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthCrestEnhanceMainCanvas __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ShowMemorialRiseEffect_d__35 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthCrestEnhanceMainCanvas __4__this;
			public Action memorialRiseEffectEndCallBack;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public Image blackImage;
			public GrowthCrestEnhanceMainCanvas __4__this;
			public Action endCallBack;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _CloseMemorialRiseEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public FlRoot headerFlRoot;
			public GrowthCrestEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _PlayMemorialRiseEffect_b__0();
			internal void _PlayMemorialRiseEffect_b__1();
		}
	
		[CompilerGenerated]
		private struct _PlayMemorialRiseEffect_d__38 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthCrestEnhanceMainCanvas __4__this;
			private FlMotion _amuletAnimeMotion_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthCrestEnhanceMainCanvas();
	
		// Methods
		public static GrowthCrestEnhanceMainCanvas GetUICanvas(Transform parentTransform);
		public override void InitCanvas(GrowthUnitEnhanceScene scene, GrowthUnitEnhanceModel model);
		public override async void PlayResultEffects(GrowthUnitEnhanceSendData[] sendDatas, Action effectEndCallBack = null);
		protected override GrowthUnitEnhanceListCell GetEnhanceListCell(UnitEnhanceListCellType type);
		public override void OnAutoButtonPressed();
		private void OnCellButtonPressed(UnitEnhanceListCellType type);
		protected override void UpdateCell();
		protected override bool IsAllCellComplete();
		protected override bool IsUsableAutoButton();
		private void SendAutoEnhanceData(GrowthAutoUnitEnhanceConfirmPopup autoUnitEnhanceConfirmPopup, Action resultAction);
		public void OnPlusButtonPressed();
		private void ShowPlusParamConfirmPopup(Dictionary<int, int> materialData);
		private void ShowCrestLimitBreakResultPopup(int beforeLimitBreak, bool isUpdateAbility);
		private void ShowCrestPlusParamResultPopup(GrowthCrestPlusParamResultPopup.BeforeData data);
		private void ShowAutoEnhanceResultPopup(int totalReleaseCount, int beforeBuildup);
		private async void StartLimitBreakTutorial();
		private async void EndLimitBreakTutorial();
		private async void ShowMemorialRiseEffect(Action memorialRiseEffectEndCallBack);
		private void SetupMemorialRiseEffect();
		private void CloseMemorialRiseEffect(Action endCallBack);
		private async void PlayMemorialRiseEffect();
		private void OnSkipButtonPressed(bool isBackKey = false);
		private void PlayCloseMemorialRiseEffect();
		private void ShowTutorialPointer();
		private void UpdatePlusButton(bool interactable);
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(GrowthUnitEnhanceSendData[] sendDatas, Action completeCallBack);
		[CompilerGenerated]
		private void _EndLimitBreakTutorial_b__34_0();
		[CompilerGenerated]
		private void _EndLimitBreakTutorial_b__34_1();
		[CompilerGenerated]
		private bool _ShowMemorialRiseEffect_b__35_0();
		[CompilerGenerated]
		private void _SetupMemorialRiseEffect_b__36_0();
		[CompilerGenerated]
		private void _SetupMemorialRiseEffect_b__36_1();
		[CompilerGenerated]
		private void _PlayCloseMemorialRiseEffect_b__40_0();
		[CompilerGenerated]
		private void _ShowTutorialPointer_b__41_0();
	}
}
