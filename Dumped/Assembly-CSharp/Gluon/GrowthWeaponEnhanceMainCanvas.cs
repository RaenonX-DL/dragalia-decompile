/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using DG.Tweening;
using FLATOUT.Main;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponEnhanceMainCanvas : GrowthUnitEnhanceMainCanvas
	{
		// Fields
		public TabBase statusCellTab;
		public GrowthUnitEnhanceListCell[] statusCells;
		public GrowthUnitEnhanceListCell[] specCells;
		public UnityEngine.UI.Text EmptySpecCellText;
		public GameObject craftEffectBaseObject;
		public RectTransform craftEffectResultButtonsRect;
		public Button closeButtonForCraftResult;
		public UnityEngine.UI.Text closeTextForCraftResult;
		private bool isShowEmptySpecCellText;
		private GameObject craftAnimation;
		private GameObject craftHeaderAnimation;
		private GameObject weaponModel;
		private BaseCanvasContents baseCanvasContents;
		private EffectObject frontEffectObject;
		private EffectObject backEffectObject;
		private List<FlMotion> outMotionList;
		private int effectSkipSortOderKey;
		private bool isShowSkinResultCloseButton;
		private Canvas uiCanvas;
		private Vector2 craftResultCloseButtonTargetPos;
		private Tweener craftResultCloseButtonTween;
		private RectTransform craftEffectResultCloseButtonRect;
		private int[] weaponSkinIds;
		private int[] effectMaterialIds;
		private FlashTextType playTextType;
		private bool isPlaySkinResultEffect;
		private bool isAllGetSkinEffectEned;
		private string skinResultLabelName;
		private int skinResultFrontEffectTrigger;
		private bool isSkipSkinResultEffect;
		private bool isTapAndBackKeyLockFlag;
		private AudioPlayback skinResultSePlayback;
		private int skinResultEffectSkinId;
		private bool isSkipSkinResultSound;
		private Coroutine skinResultEffectCoroutine;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public bool isPlayResultEffect;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _PlayResultEffects_b__0();
			internal bool _PlayResultEffects_b__1();
			internal void _PlayResultEffects_b__4();
			internal bool _PlayResultEffects_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_1
		{
			// Fields
			public bool isLoadEfectEnded;
	
			// Constructors
			public __c__DisplayClass39_1();
	
			// Methods
			internal void _PlayResultEffects_b__2();
			internal bool _PlayResultEffects_b__3();
		}
	
		[CompilerGenerated]
		private struct _PlayResultEffects_d__39 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public GrowthUnitEnhanceSendData[] sendDatas;
			private __c__DisplayClass39_0 __8__1;
			public Action effectEndCallBack;
			private TaskAwaiter __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public GrowthAutoUnitEnhanceConfirmPopup popup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _OnAutoButtonPressed_b__0();
			internal void _OnAutoButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_1
		{
			// Fields
			public int totalReleaseCount;
			public int beforeBuilup;
			public int beforePassiveAbilityCount;
			public int beforeType1Slot;
			public int beforeType2Slot;
			public int beforeType3Slot;
			public float breforeBounsHpParam;
			public float breforeBounsAtkParam;
			public __c__DisplayClass41_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass41_1();
	
			// Methods
			internal void _OnAutoButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public GrowthUnitStatusConfirmPopup popup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _OnCellButtonPressed_b__0();
			internal void _OnCellButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_1
		{
			// Fields
			public int beforeBuilup;
			public int beforePower;
			public __c__DisplayClass43_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass43_1();
	
			// Methods
			internal void _OnCellButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_2
		{
			// Fields
			public GrowthWeaponLimitBreakConfirmPopup popup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass43_2();
	
			// Methods
			internal void _OnCellButtonPressed_b__3();
			internal void _OnCellButtonPressed_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_3
		{
			// Fields
			public int beforeSkillLevel;
			public int beforeAbility1;
			public int beforeAbility2;
			public int beforeLimitBreak;
			public __c__DisplayClass43_2 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass43_3();
	
			// Methods
			internal void _OnCellButtonPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_4
		{
			// Fields
			public GrowthUnitLimitOverConfirmPopup popup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass43_4();
	
			// Methods
			internal void _OnCellButtonPressed_b__6();
			internal void _OnCellButtonPressed_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_5
		{
			// Fields
			public GrowthWeaponSlotConfirmPopup popup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass43_5();
	
			// Methods
			internal void _OnCellButtonPressed_b__8();
			internal void _OnCellButtonPressed_b__9();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_6
		{
			// Fields
			public GrowthWeaponBonusConfirmPopup popup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass43_6();
	
			// Methods
			internal void _OnCellButtonPressed_b__10();
			internal void _OnCellButtonPressed_b__11();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_7
		{
			// Fields
			public GrowthUnitEquipCountConfirmPopup popup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass43_7();
	
			// Methods
			internal void _OnCellButtonPressed_b__12();
			internal void _OnCellButtonPressed_b__13();
		}
	
		[CompilerGenerated]
		private struct _InitTab_d__44 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public GrowthWeaponAbilitySelectPopup selectPopup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _ShowWeaponTypeAbilitySelectPopup_b__0();
			internal void _ShowWeaponTypeAbilitySelectPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public GrowthReleaseWeaponAbilityConfirmPopup releasePopup;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public int[] selectIds;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _ShowWeaponTypeAbilityReleaseConfirmPopup_b__0();
			internal void _ShowWeaponTypeAbilityReleaseConfirmPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public GrowthWeaponLimitResultPopup popup;
			public BitArray diffParam;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _ShowWeaponLimitBreakResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public GrowthWeaponUpdateSkillResultPopup popup;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _ShowUpdateSkillAbilityPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public int beforeLimitOver;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _SendLimitOverData_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public int[] selectAbilityDataIds;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal void _SendWeaponTypeAbilityData_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public int beforeType1Slot;
			public int beforeType2Slot;
			public int beforeType3Slot;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _SendWeaponSlotData_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public GrowthWeaponLimitResultPopup popup;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _ShowLimitOverResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public GrowthWeaponTypeAbilityResultPopup popup;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _ShowWeaponTypeAbilityResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public GrowthWeaponSlotResultPopup popup;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _ShowWeaponSlotResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public GrowthWeaponBonusResultPopup popup;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _ShowWeaponBonusResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public GrowthAutoUnitEnhanceResultPopup popup;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal void _ShowAutoEnhanceResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private struct _ShowGetSkinEffect_d__67 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public Action effectEndCallBack;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _PlayResultSkinEffect_d__68 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			private int _i_5__2;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0
		{
			// Fields
			public Image blackImage;
			public GrowthWeaponEnhanceMainCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass70_0();
	
			// Methods
			internal void _CloseSkinEffect_b__0();
		}
	
		[CompilerGenerated]
		private struct _PlayNextEffect_d__71 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public bool isBackKey;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0
		{
			// Fields
			public FlMotion craftAnimeMotion;
			public Action startEffectEndCallBack;
	
			// Constructors
			public __c__DisplayClass72_0();
	
			// Methods
			internal void _PlayGetSkinStartEffect_b__0();
		}
	
		[CompilerGenerated]
		private struct _PlayGetSkinStartEffect_d__72 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public Action startEffectEndCallBack;
			public int[] effectMaterialIds;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public int skinId;
			private int _matCount_5__2;
			private int _rarity_5__3;
			private UniTask.Awaiter __u__1;
			private int _i_5__4;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public FlMotion craftAnimeMotion;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _PlayResultEffect_b__1();
			internal void _PlayResultEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _PlayResultEffect_d__73 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public int skinId;
			public bool isFirstEffect;
			private __c__DisplayClass73_0 __8__1;
			private FlRoot _flHeaderRoot_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayResultEffect_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _SkipSkinResultEffect_d__75 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public bool isBackKey;
			public GrowthWeaponEnhanceMainCanvas __4__this;
			private FlRoot _flHeaderRoot_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public CanvasGroup group;
			public Vector2 closeButtonStartPos;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal void _ShowCraftResultButtons_b__0(float value);
			internal void _ShowCraftResultButtons_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0
		{
			// Fields
			public GrowthWeaponEnhanceMainCanvas __4__this;
			public CanvasGroup group;
			public Vector2 closeButtonEndPos;
	
			// Constructors
			public __c__DisplayClass77_0();
	
			// Methods
			internal void _HideCraftResultButtons_b__0(float value);
			internal void _HideCraftResultButtons_b__1();
		}
	
		// Constructors
		public GrowthWeaponEnhanceMainCanvas();
	
		// Methods
		public static GrowthUnitEnhanceMainCanvas GetUICanvas(Transform parentTransform);
		private void Start();
		private void OnDestroy();
		public override void InitCanvas(GrowthUnitEnhanceScene scene, GrowthUnitEnhanceModel model);
		public override async void PlayResultEffects(GrowthUnitEnhanceSendData[] sendDatas, Action effectEndCallBack = null);
		public void OnTabSelected(int index);
		public override void OnAutoButtonPressed();
		protected override GrowthUnitEnhanceListCell GetEnhanceListCell(UnitEnhanceListCellType type);
		private void OnCellButtonPressed(UnitEnhanceListCellType type);
		private async void InitTab();
		protected override void UpdateCell();
		protected override bool IsAllCellComplete();
		protected override bool IsUsableAutoButton();
		private void ShowWeaponTypeAbilitySelectPopup();
		private void ShowWeaponTypeAbilityReleaseConfirmPopup(int[] selectIds);
		private void ShowWeaponLimitBreakResultPopup(int beforeLimitBreak, BitArray diffParam);
		private void ShowUpdateSkillAbilityPopup(BitArray diffParam);
		private void SendLimitOverData(int limitOver);
		private void SendWeaponTypeAbilityData(int[] selectAbilityDataIds);
		private GrowthUnitEnhanceSendData[] CreateSendWeaponTypeAbilityData(int[] abilityDataIds);
		private void SendWeaponSlotData(int addSlotType1, int addSlotType2, int addSlotType3);
		private GrowthUnitEnhanceSendData[] CreateSendWeaponSlotData(int addSlotType1, int addSlotType2, int addSlotType3);
		private void SendWeaponBonusData();
		private GrowthUnitEnhanceSendData[] CreateSendWeaponBonusData();
		private void SendAutoEnhanceData(GrowthAutoUnitEnhanceConfirmPopup autoUnitEnhanceConfirmPopup, Action resultAction);
		private void ShowLimitOverResultPopup(int beforeLimitOver);
		private void ShowWeaponTypeAbilityResultPopup(int[] selectAbilitys);
		private void ShowWeaponSlotResultPopup(int beforeType1Slot, int beforeType2Slot, int beforeType3Slot);
		private void ShowWeaponBonusResultPopup();
		private void ShowAutoEnhanceResultPopup(int totalReleaseCount, int beforeBuildup, int beforePassiveAbilityCount, int beforeType1Slot, int beforeType2Slot, int beforeType3Slot, float beforeBonusHpParam, float beforeBonusAtkParam);
		private void SetupSkinEffectData(UnitEnhanceListCellType type, int toCount);
		private void SetupPassiveAbilitySkinEffectData(int[] selectAbilityDataIds);
		private async void ShowGetSkinEffect(Action effectEndCallBack);
		private async void PlayResultSkinEffect();
		private void SetupSkinEffect();
		private void CloseSkinEffect();
		private async void PlayNextEffect(bool isBackKey = false);
		private async void PlayGetSkinStartEffect(int skinId, int[] effectMaterialIds, Action startEffectEndCallBack);
		[IteratorStateMachine]
		private IEnumerator PlayResultEffect(int skinId, bool isFirstEffect);
		private void AfterResultAction();
		private async void SkipSkinResultEffect(bool isBackKey = false);
		private void ShowCraftResultButtons(float duration, Action onComplete = null);
		private void HideCraftResultButtons();
		private void DestoryButtonTween();
		private void CreateWeaponModel(int skinId);
		public void InitWeaponTransform(WeaponType weaponType);
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(GrowthUnitEnhanceSendData[] sendDatas, Action completeCallBack);
		[CompilerGenerated]
		private void _SendWeaponBonusData_b__57_0();
		[CompilerGenerated]
		private void _ShowGetSkinEffect_b__67_0();
		[CompilerGenerated]
		private bool _ShowGetSkinEffect_b__67_1();
		[CompilerGenerated]
		private bool _PlayResultSkinEffect_b__68_0();
		[CompilerGenerated]
		private void _SetupSkinEffect_b__69_0();
		[CompilerGenerated]
		private void _SetupSkinEffect_b__69_1();
		[CompilerGenerated]
		private void _AfterResultAction_b__74_0();
		[CompilerGenerated]
		private void _AfterResultAction_b__74_1();
	}
}
