/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortViewController : MonoBehaviour, FortUIEventInterface
	{
		// Fields
		public const int LAYER_DEFAULT = 0;
		public GameObject touchEventNode;
		[SerializeField]
		private GameObject rightNode;
		private CanvasGroup rightNodeCanvasGroup;
		[SerializeField]
		private BottomNode bottomNode;
		public AddSmithUIViewController addSmithUIViewController;
		private Button addSmithButton;
		[SerializeField]
		public FortPullMenu pullMenu;
		[SerializeField]
		public Button buildButton;
		[SerializeField]
		private Button storageButton;
		[SerializeField]
		public Button cropAllButton;
		[SerializeField]
		private GameObject leftCenterNode;
		public GameObject buildCursor;
		[SerializeField]
		private GameObject _croppingEffectRoot;
		public Transform coinTransform;
		[SerializeField]
		private UnityEngine.UI.Text totalLevelText;
		[SerializeField]
		private UnityEngine.UI.Text coinNumText;
		[SerializeField]
		private FortTotalCropDisplay coinTotalCropDisplay;
		private long _curCoinNum;
		private bool _onCoinTotalCropping;
		private bool _onShowingPopupForSelectedFacility;
		private Image buildButtonImage;
		private Image storageButtonImage;
		private Image cropAllButtonImage;
		[CompilerGenerated]
		private FortScene _fortScene_k__BackingField;
		[SerializeField]
		private AnimationUIMove dragonFruitsAnimation;
		private CanvasGroup dragonFruitsCanvasGroup;
		private Dictionary<int, int> croppingDragonFruitsDictionary;
		private FlashPlayer[] _dragonFruitGetFlashPlayer;
		private bool _onDragonFruitTotalCropping;
		private int croppingCoinsCount;
		private FlashPlayer _coinGetFlashPlayer;
		public GameObject staminaEfectParent;
		public Transform staminaFromTransform;
		public Transform staminaToTransform;
		public float[] staminaImageScale;
		private FlashPlayer flashPlayerOnUi;
		[CompilerGenerated]
		private bool _isInvisibleMode_k__BackingField;
		[SerializeField]
		public float _headFootSliderDuration;
		[SerializeField]
		private FortDragonFruitsUiInfo[] dragonFruitsUiInfoList;
		public Button putButton;
		[SerializeField]
		private Button putCancelButton;
		[SerializeField]
		private RuntimeAnimatorController disableColorAnimController;
		[SerializeField]
		private GameObject bannerParent;
		[SerializeField]
		private GameObject leftNode;
		private FortLeftSideUIViewController leftNodeViewController;
		[SerializeField]
		private GameObject gameSystemMsgParent;
		private int[] dragonFruitCurNumList;
		private InGameSystemMsgUI gameSystemMsgUI;
		[CompilerGenerated]
		private Canvas _canvas_k__BackingField;
		[CompilerGenerated]
		private Action _rightSlideInCallbacks_k__BackingField;
		[CompilerGenerated]
		private Action _rightSlideOutCallbacks_k__BackingField;
		[CompilerGenerated]
		private Action<FacilityViewController> _relocationStartAction_k__BackingField;
		[Header]
		[SerializeField]
		public GameObject buildButtonBadge;
		public GameObject storeHouseButtonBadge;
		[Header]
		[SerializeField]
		private float offsetFactor;
		[SerializeField]
		private GameObject beginnerBuildCampaignBanner;
		private List<FlashPlayer> fortFlashPlayerList;
	
		// Properties
		public GameObject croppingEffectRoot { get; }
		public long curCoinNum { get; set; }
		public bool onCoinTotalCropping { get; set; }
		public bool onShowingPopupForSelectedFacility { get; set; }
		public FortScene fortScene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool onDragonFruitTotalCropping { get; set; }
		public FlashPlayer coinGetFlashPlayer { get; }
		public bool isInvisibleMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Canvas canvas { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FacilityViewController currentSelectFacilityViewController { get; }
		public Action rightSlideInCallbacks { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action rightSlideOutCallbacks { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action<FacilityViewController> relocationStartAction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float headFootSliderDuration { get; }
	
		// Nested types
		[Serializable]
		private class FortDragonFruitsUiInfo
		{
			// Fields
			public FortTotalCropDisplay totalCropDisplay;
			public GameObject dragonFruitPrefab;
			public GameObject dragonFruitsTarget;
			public UnityEngine.UI.Text dragonFruitNumText;
			public Image dragonFruitIcon;
	
			// Constructors
			public FortDragonFruitsUiInfo();
		}
	
		[CompilerGenerated]
		private sealed class _HideLeftUI_d__101 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortViewController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _HideLeftUI_d__101(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForEnableTouchEventObjectRaycastTarget_d__116 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float waitTime;
			public FortViewController __4__this;
			public bool toEnable;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForEnableTouchEventObjectRaycastTarget_d__116(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass147_0
		{
			// Fields
			public FortViewController __4__this;
			public Facility nextFacility;
			public Facility curFacility;
			public FacilityViewController curFacilityVC;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass147_0();
	
			// Methods
			internal void _OnLevelUpButtonPressed_b__1(Facility facility);
			internal void _OnLevelUpButtonPressed_b__2();
			internal void _OnLevelUpButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass164_0
		{
			// Fields
			public FortViewController __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass164_0();
	
			// Methods
			internal void _ShowAddSmithResult_b__0();
			internal void _ShowAddSmithResult_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__164_2;
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__164_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ShowAddSmithResult_b__164_2(FortUIEventInterface reciever, BaseEventData eventData);
			internal void _ShowAddSmithResult_b__164_3(FortUIEventInterface reciever, BaseEventData eventData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass166_0
		{
			// Fields
			public FlashPlayer flashPlayer;
			public Transform target;
			public Image hideImage;
	
			// Constructors
			public __c__DisplayClass166_0();
	
			// Methods
			internal void _SetupFlashPlayer_b__0(int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass173_0
		{
			// Fields
			public FlashPlayer newFlashPlayer;
	
			// Constructors
			public __c__DisplayClass173_0();
	
			// Methods
			internal bool _GetFortFlashPlayer_b__0(FlashPlayer x);
		}
	
		// Constructors
		public FortViewController();
	
		// Methods
		public FlashPlayer GetDragonFruitGetFlashPlayer(int i);
		private void Awake();
		public void OnInit(FortScene scene);
		private void SetFortTutorialUiState(int tutorialStep);
		[IteratorStateMachine]
		private IEnumerator HideLeftUI();
		public void CreateDebugMenu();
		public void SetupEventBanner();
		public static void GetBuildUiMaterialPathList(List<string> materialPathList);
		public static void GetBuildUiGridTexturePathList(List<string> texPathList);
		public FortTotalCropDisplay GetFortTotalCropDisplay(int fruitLevel);
		public Vector3 GetDragonFruitTargetPos(int material);
		public int GetDragonFruitNum(int material);
		public void SetDragonFruitNum(int material, int num);
		public GameObject GetDragonFruitPrefab(int material);
		private int GetDragonFruitLevel(int material);
		public void PlayDragonFruitGetFlashAnim(int material);
		public void PullMenuSlideIn();
		public void PullMenuSlideOut();
		private void SetPullMenuCallbacks();
		[IteratorStateMachine]
		private IEnumerator WaitForEnableTouchEventObjectRaycastTarget(float waitTime, bool toEnable);
		public bool IsFacilityTextActive();
		public bool IsSetFacilityText(FacilityViewController facilityVc);
		public void ShowBuildDialog();
		public void ShowStoreHouseDialog();
		public void OnBuildButtonPressed();
		public void EnableTouchEventObjectRaycastTarget(bool flag);
		public void OnFortDetailButtonPressed();
		public void OnAddSmithButtonPressed();
		public void BottomSlideOut(bool isButtonDisable = false);
		public static bool IsPlaying(Animator animator, string animName);
		public void BottomSlideIn(bool isButtonDisable = false);
		private void SetBottomButtonsRaycastTargetEnable(bool value);
		public void RightSlideOut();
		public void RightSlideIn();
		public void SetBuildButtonInteractable(bool interactable);
		public void SetStorageButtonInteractable(bool interactable);
		public void SetCropAllButtonInteractable(bool interactable);
		public void DragonFruitsSlideOut();
		public void DragonFruitsSlideIn();
		public void PlayRightSlideOut();
		public void PlayRightSlideIn();
		public void OnSelectFacility(FacilityViewController facilityViewController);
		public void CancelInvisibleModel(PointerEventData eventData);
		public void OnFacilitySelectCancel(bool playBottomSlideOut, bool playSlideIn = true);
		public void OnStoreButtonPressed();
		public void OnRelocationButtonPressed();
		public void OnFacilityStopButtonPressed();
		public void OnFacilityCompleteAtOnceButtonPressed();
		public void OnFacilityDetailButtonPressed();
		private void OpenFacilityDetailDialog(FacilityDetailDialogController.DialogType dialogType);
		public void OnLevelUpButtonPressed();
		public void UpdateAddSmithUI(int diff = 0);
		public void StartCroppingDragonFruits(int material, int count);
		public void FinishCroppingDragonFruits(int material, int count);
		public void StartCroppingCoins(int count);
		public bool FinishCroppingCoins(int count);
		public void CroppingCoinsAllCompleted();
		void FortUIEventInterface.OnPlayRightSlideIn();
		void FortUIEventInterface.OnPlayRightSlideOut();
		void FortUIEventInterface.OnRightSlideIn();
		void FortUIEventInterface.OnRightSlideOut();
		void FortUIEventInterface.OnBottomSlideIn();
		void FortUIEventInterface.OnBottomSlideOut();
		void FortUIEventInterface.OnFacilitySelectCancel(bool playBottomSlideOut);
		void FortUIEventInterface.OnFacilityVanished(GameObject gameObject);
		public void PutFacility();
		public void OnPutModeCanceled();
		public void ShowAddSmithResult();
		public void ShowBuildCursor2D(bool isShown, Facility facility = null);
		private FlashPlayer SetupFlashPlayer(string flashPath, Transform target, Image hideImage);
		public void SetTotalLevelOfFacilities(int totalLevel);
		public void SetCoin(long num);
		public void UpdateCoin();
		public void CropFromAllFacilities();
		public FlashPlayer GetFlashPlayerOnUi(string flashPath);
		private void DestroyFlashPlayerOnUi();
		private FlashPlayer GetFortFlashPlayer();
		public void SetCanvasSortOrder(int sortOrder);
		public void PlayStaminaEffect(Transform target);
		private FlashPlayer GetStaminaFlashPlayer(Transform target);
		protected void OnDestroy();
		[CompilerGenerated]
		private void _get_coinGetFlashPlayer_b__51_0(int index);
		[CompilerGenerated]
		private void _SetPullMenuCallbacks_b__115_0();
		[CompilerGenerated]
		private void _SetPullMenuCallbacks_b__115_1();
		[CompilerGenerated]
		private void _SetPullMenuCallbacks_b__115_2();
		[CompilerGenerated]
		private void _SetPullMenuCallbacks_b__115_3();
		[CompilerGenerated]
		private void _EnableTouchEventObjectRaycastTarget_b__122_0(BaseEventData data);
		[CompilerGenerated]
		private void _RightSlideIn_b__130_0();
		[CompilerGenerated]
		private void _OpenFacilityDetailDialog_b__146_0();
		[CompilerGenerated]
		private void _FinishCroppingDragonFruits_b__150_0();
	}
}
