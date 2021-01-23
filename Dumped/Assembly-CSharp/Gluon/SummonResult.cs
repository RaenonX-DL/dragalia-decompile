/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonResult : MonoBehaviour
	{
		// Fields
		private static SummonResult instance;
		[CompilerGenerated]
		private SummonModelBase _model_k__BackingField;
		public Action onBackButtonTouched;
		public Action<SummonTopItemData.ButtonType> onSummonButtonTouched;
		[Header]
		[SerializeField]
		public GameObject multiSummonResult;
		public GameObject singleSummonResult;
		[Header]
		[SerializeField]
		public GameObject[] multiSummonCharaIconPosList;
		[Header]
		[SerializeField]
		public GameObject singleSummonButtonObject;
		public GameObject multiSummonButtonObject;
		[Header]
		[SerializeField]
		public GameObject firstViewBottomItemNode;
		public GameObject backButtonGO;
		public GameObject captionGO;
		public GameObject autoPresentBoxTextNode;
		public Image whiteFade;
		public GameObject bonusButton;
		public float bonusPopupDelayTime;
		[Header]
		[SerializeField]
		public GameObject illustration;
		public Transform illustrationViewOffset;
		public UnitDetail2dModel illustrationImage;
		[Header]
		[SerializeField]
		public Transform switchEffectAttachPoint;
		public UnityEngine.UI.Text switch2d3dButtonText;
		public GameObject switch2d3dButtonGO;
		public GameObject detailButtonGO;
		public DragEventScrollRect dragScrollRect;
		[Header]
		[SerializeField]
		public GameObject ownedSingleTickedLine;
		public GameObject ownedMultiTicketLine;
		public GameObject ownedStoneLine;
		public GameObject ownedPaidStoneLine;
		public UnityEngine.UI.Text ownedSingleTicketCountText;
		public UnityEngine.UI.Text ownedMultiTicketCountText;
		public UnityEngine.UI.Text ownedFreeStoneCountText;
		public UnityEngine.UI.Text ownedPaidStoneCountText;
		public UnityEngine.UI.Text ownedMoonCountText;
		public GameObject ownedFrame;
		[Header]
		[SerializeField]
		public Image singleCaptionIcon;
		public Image multiCaptionIcon;
		public Image dailyCaptionIcon;
		[Header]
		[SerializeField]
		public CommonIcon moonIcon;
		[Header]
		[SerializeField]
		public SummonResultStatusPlate statusPlate;
		[Header]
		[SerializeField]
		public RawImage bg3dRenderTextureImage;
		public RawImageWithAlphaBlend chara3dRenderTextureImage;
		public RawImage flashTextureImage;
		[Header]
		[SerializeField]
		public SimpleStoryManager storyManager;
		[Header]
		[SerializeField]
		public GameObject exchangeSummonNode;
		public UnityEngine.UI.Text beforeExchangeSummon;
		public UnityEngine.UI.Text afterExchangeSummon;
		public Image exchangeSummonImage;
		[Header]
		[SerializeField]
		public UIAnimationPublisher multiPublisher;
		public UIAnimationPublisher singlePublisher;
		public UIAnimationPublisher majorEnterPublisher;
		public UIAnimationPublisher exitPubliser;
		public UIAnimationPublisher subExitPubliser;
		[SerializeField]
		private float fadeTimeFactor;
		private FlashPlayer switchFlashPlayer;
		private bool bShowing2D;
		private int showingResultIndex;
		private bool bShowingSingleDetailOnMultiPage;
		private Transform current3DTransform;
		private float panelAnimationMoveDist;
		private float panelAnimationBaseDuration;
		private float panelAnimation10SwitchWaitTime;
		private float panelAnimationSwitchWaitTime;
		private float amuletScale;
		private Vector3 amuletViewOffset;
		private int oldFlashCameraDepth;
		private Vector3 originalChara3DCameraPosition;
		private readonly Vector3 resultChara3DCameraPosition;
		private RenderTexture bgRenderTexture;
		[HideInInspector]
		public SummonScene scene;
		private Camera oldFlashCamera;
		private FlashPlayer[] itemFallFlashPlayers;
		private FlashPlayer[] haloBackFlashPlayers;
		private FlashPlayer[] haloFrontFlashPlayers;
		private FlashPlayer[] bonusFrontFlashPlayers;
		private FlashPlayer extraBonusFrontFlashPlayers;
		private const string haloBackFlashPrefabPath = "Prefabs/OutGame/SummonShop/Result/SSRHaloFlash/pf_thumb_panel_effect_halo";
		private const string haloFrontFlashPrefabPath = "Prefabs/OutGame/SummonShop/Result/SSRHaloFlash/pf_thumb_panel_effect_ster";
		private const string summonResultBonusFlashPrefabPath = "Prefabs/OutGame/SummonShop/Result/SSRHaloFlash/pf_SummonResultBonus";
		private const string summonResultExtraBonusFlashPrefabPath = "Prefabs/OutGame/SummonShop/Result/SSRHaloFlash/pf_SummonResultExtraBonus";
		private const string flashLabelIconSquare = "init_sharp";
		private const string flashLabelIconRounded = "init_round";
		private const string flashLabelIconCut = "init_unique";
		private const string flashLabelBonus6thPrize = "Bonus_06";
		private const string flashLabelBonus5thPrize = "Bonus_05";
		private const string flashLabelBonusBronze = "Bonus_04";
		private const string flashLabelBonusSilver = "Bonus_03";
		private const string flashLabelBonusGold = "Bonus_02";
		private const string flashLabelBonusPlatinum = "Bonus_01";
		private const string flashBonusPlatinumSound = "SE_OUT_COMMON_0065";
		private const string flashBonusGoldSound = "SE_OUT_COMMON_0066";
		private const string flashBonusSilverSound = "SE_OUT_COMMON_0067";
		private const string flashBonusPocoPocoSound = "SE_OUT_COMMON_0068";
		private static readonly Vector2[] iconPosition1;
		private static readonly Vector2[] iconPosition2;
		private static readonly Vector2[] iconPosition3;
		private static readonly Vector2[] iconPosition4;
		private static readonly Vector2[] iconPosition5;
		private static readonly Vector2[] iconPosition6;
		private static readonly Vector2[] iconPosition7;
		private static readonly Vector2[] iconPosition8;
		private static readonly Vector2[] iconPosition9;
		public static readonly Vector2[] iconPosition10;
		public static readonly Vector2[][] iconPositions;
	
		// Properties
		public static SummonResult Instance { get; }
		public SummonModelBase model { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_0
		{
			// Fields
			public Vector2[] positionArray;
			public List<SummonResultItemData> resultItems;
			public SummonResult __4__this;
			public int resultCount;
			public int tutorialStep;
			public int bonusCount;
			public bool bonusAnimWait;
			public bool exBonusAnimWait;
			public bool exchangePopWait;
			public Action __9__9;
			public Action __9__11;
			public Func<bool> __9__10;
	
			// Constructors
			public __c__DisplayClass119_0();
	
			// Methods
			internal void _ItemFallCoroutine_b__0();
			internal void _ItemFallCoroutine_b__9();
			internal void _ItemFallCoroutine_b__11();
			internal bool _ItemFallCoroutine_b__10();
			internal bool _ItemFallCoroutine_b__1();
			internal void _ItemFallCoroutine_b__12();
			internal bool _ItemFallCoroutine_b__13();
			internal void _ItemFallCoroutine_b__2();
			internal bool _ItemFallCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_1
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public bool isAllLoadedDone;
			public int endedAnimationCount;
			public Action proceedLoading;
			public __c__DisplayClass119_0 CS___8__locals1;
			public Action __9__8;
	
			// Constructors
			public __c__DisplayClass119_1();
	
			// Methods
			internal void _ItemFallCoroutine_b__4();
			internal void _ItemFallCoroutine_b__8();
			internal bool _ItemFallCoroutine_b__5();
			internal bool _ItemFallCoroutine_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_2
		{
			// Fields
			public FlashPlayer flashPlayer;
			public __c__DisplayClass119_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass119_2();
	
			// Methods
			internal void _ItemFallCoroutine_b__7(int index);
		}
	
		[CompilerGenerated]
		private sealed class _ItemFallCoroutine_d__119 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonResult __4__this;
			private __c__DisplayClass119_0 __8__1;
			private __c__DisplayClass119_1 __8__2;
			private List<SummonResultPrize> _resultBonus_5__2;
			private int _lastBonusFlash_5__3;
			private int _i_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ItemFallCoroutine_d__119(int __1__state);
	
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
			public static Action __9__122_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ShowTutorialPopCoroutine_b__122_0();
		}
	
		[CompilerGenerated]
		private sealed class _ShowTutorialPopCoroutine_d__122 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonResult __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowTutorialPopCoroutine_d__122(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _OnSceneLoadEnd_d__135 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public SummonResult __4__this;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass140_0
		{
			// Fields
			public SummonResult __4__this;
			public SummonResultItemData item;
	
			// Constructors
			public __c__DisplayClass140_0();
	
			// Methods
			internal void _DoSwitchTo3DMode_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass146_0
		{
			// Fields
			public CommonPopup pop;
	
			// Constructors
			public __c__DisplayClass146_0();
	
			// Methods
			internal void _OnExchangeSummonDetail_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass147_0
		{
			// Fields
			public int summonId;
			public Action onClose;
			public CommonIconPopup popup;
	
			// Constructors
			public __c__DisplayClass147_0();
	
			// Methods
			internal void _ExchangePopup_b__0();
			internal void _ExchangePopup_b__1();
		}
	
		// Constructors
		private SummonResult();
		static SummonResult();
	
		// Methods
		public void Start();
		private bool IsExchangeSummon();
		public void StartItemFall();
		public static Vector3 GetFlashPositionFromLayoutPosition(Vector2 pos);
		private void SetFlashObjectPosition(FlashPlayer flashPlayer, Vector3 rawPosition, string[] objNameList);
		private string GetFlashLabelByGiftTypeForIcon(GiftType giftType);
		private string GetFlashLabelByBonusType(int index);
		private string GetFlashSoundLabelByBonusType(int index);
		private void SetEnableResultFlash(bool enable);
		[IteratorStateMachine]
		private IEnumerator ItemFallCoroutine();
		public void RefreshPrice();
		private void ShowTutorialPop();
		[IteratorStateMachine]
		private IEnumerator ShowTutorialPopCoroutine();
		private void DestroyItemFallFlashPlayers();
		public void Setup(SummonModelBase model);
		public void OnListItemClicked(SummonResultItemData data, int resultIndex);
		public void MovePanelYInstantly(Transform t, float dist);
		public void SetPanelAlpha(Transform t, float alpha = 1f);
		private void SetSingleResultView(SummonResultItemData data = null, int resultIndex = 0, bool playAnimation = true);
		public void OnSwitchToMultiListButtonClicked();
		public void OnBonusDetailButtonClicked();
		private void LoadMultiResultList();
		public void OnRedrawButtonPressed(SummonTopItemData.ButtonType buttonType);
		public void OnBackButtonPressed();
		public void OnDetailButtonPressed();
		private async void OnSceneLoadEnd();
		private void OnDestroy();
		private void OnSwitchTo2DMode(bool isBySwitchButton = false);
		private void DoSwitchTo2DMode();
		private void OnSwitchTo3DMode(bool isBySwitchButton = false);
		private void DoSwitchTo3DMode();
		private void Set3DModel(SummonResultItemData item);
		public void OnSwitch3D2DButtonClicked();
		public void OnScrollRectValueChanged(Vector2 changedVal);
		public void StartToStageAnimation(Action onDone);
		public void PlaySwitchFlash();
		public void OnExchangeSummonDetail();
		public void ExchangePopup(Action onClose);
		public void OnBeforeSceneLeaving();
		[CompilerGenerated]
		private void _ShowTutorialPop_b__121_0();
		[CompilerGenerated]
		private void _SetSingleResultView_b__128_0();
		[CompilerGenerated]
		private void _SetSingleResultView_b__128_1();
		[CompilerGenerated]
		private void _OnSwitchToMultiListButtonClicked_b__129_0();
		[CompilerGenerated]
		private void _OnSwitchToMultiListButtonClicked_b__129_1();
		[CompilerGenerated]
		private void _LoadMultiResultList_b__131_0(SummonResultItemData itemData, int index);
		[CompilerGenerated]
		private void _OnBackButtonPressed_b__133_0();
		[CompilerGenerated]
		private void _OnDetailButtonPressed_b__134_0();
		[CompilerGenerated]
		private void _OnSwitchTo2DMode_b__137_0();
		[CompilerGenerated]
		private void _OnSwitchTo2DMode_b__137_1();
		[CompilerGenerated]
		private void _OnSwitchTo3DMode_b__139_0();
		[CompilerGenerated]
		private void _OnSwitchTo3DMode_b__139_1();
	}
}
