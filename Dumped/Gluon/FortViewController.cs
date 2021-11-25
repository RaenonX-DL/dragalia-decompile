using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class FortViewController : MonoBehaviour, FortUIEventInterface, IEventSystemHandler
	{
		[Serializable]
		private class FortDragonFruitsUiInfo
		{
			public FortTotalCropDisplay totalCropDisplay;

			public GameObject dragonFruitPrefab;

			public GameObject dragonFruitsTarget;

			public Text dragonFruitNumText;

			public Image dragonFruitIcon;
		}

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
		private Button managedFacilityButton;

		[SerializeField]
		public Button cropAllButton;

		[SerializeField]
		private GameObject leftCenterNode;

		public GameObject buildCursor;

		[SerializeField]
		private GameObject _croppingEffectRoot;

		public Transform coinTransform;

		[SerializeField]
		private Text totalLevelText;

		[SerializeField]
		private Text coinNumText;

		[SerializeField]
		private FortTotalCropDisplay coinTotalCropDisplay;

		private long _curCoinNum;

		private bool _onCoinTotalCropping;

		private bool _onShowingPopupForSelectedFacility;

		private Image buildButtonImage;

		private Image managedFacilityButtonImage;

		private Image cropAllButtonImage;

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

		[SerializeField]
		[Header("ã\u0083\u0090ã\u0083\u0083ã\u0082\u00b8é\u0096¢ä¿\u0082")]
		public GameObject buildButtonBadge;

		public GameObject managedFacilityButtonBadge;

		[SerializeField]
		[Header("buildCursor2Dã\u0081®ä\u00b8\u008bã\u0081«ç§»ã\u0081\u0099è·\u009dé\u009b¢ã\u0081®factor")]
		private float offsetFactor;

		[SerializeField]
		private GameObject beginnerBuildCampaignBanner;

		private List<FlashPlayer> fortFlashPlayerList;

		public GameObject croppingEffectRoot => null;

		public long curCoinNum
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public bool onCoinTotalCropping
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool onShowingPopupForSelectedFacility
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public FortScene fortScene
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool onDragonFruitTotalCropping
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public FlashPlayer coinGetFlashPlayer => null;

		public bool isInvisibleMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Canvas canvas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FacilityViewController currentSelectFacilityViewController => null;

		public Action rightSlideInCallbacks
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action rightSlideOutCallbacks
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<FacilityViewController> relocationStartAction
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float headFootSliderDuration => default(float);

		public ManagedFacilityDialogController managedFacilityDialogCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FlashPlayer GetDragonFruitGetFlashPlayer(int i)
		{
			return null;
		}

		private void Awake()
		{
		}

		public void OnInit(FortScene scene)
		{
		}

		private void SetFortTutorialUiState(int tutorialStep)
		{
		}

		private IEnumerator HideLeftUI()
		{
			return null;
		}

		public void CreateDebugMenu()
		{
		}

		public void SetupEventBanner()
		{
		}

		public static void GetBuildUiMaterialPathList(List<string> materialPathList)
		{
		}

		public static void GetBuildUiGridTexturePathList(List<string> texPathList)
		{
		}

		public FortTotalCropDisplay GetFortTotalCropDisplay(int fruitLevel)
		{
			return null;
		}

		public Vector3 GetDragonFruitTargetPos(int material)
		{
			return default(Vector3);
		}

		public int GetDragonFruitNum(int material)
		{
			return default(int);
		}

		public void SetDragonFruitNum(int material, int num)
		{
		}

		public GameObject GetDragonFruitPrefab(int material)
		{
			return null;
		}

		private int GetDragonFruitLevel(int material)
		{
			return default(int);
		}

		public void PlayDragonFruitGetFlashAnim(int material)
		{
		}

		public void PullMenuSlideIn()
		{
		}

		public void PullMenuSlideOut()
		{
		}

		private void SetPullMenuCallbacks()
		{
		}

		private IEnumerator WaitForEnableTouchEventObjectRaycastTarget(float waitTime, bool toEnable)
		{
			return null;
		}

		public bool IsFacilityTextActive()
		{
			return default(bool);
		}

		public bool IsSetFacilityText(FacilityViewController facilityVc)
		{
			return default(bool);
		}

		public void ShowBuildDialog()
		{
		}

		public void ShowManagekdFacilityDialog()
		{
		}

		public void OnBuildButtonPressed()
		{
		}

		public void EnableTouchEventObjectRaycastTarget(bool flag)
		{
		}

		public void OnFortDetailButtonPressed()
		{
		}

		public void OnAddSmithButtonPressed()
		{
		}

		public void BottomSlideOut(bool isButtonDisable = false)
		{
		}

		public static bool IsPlaying(Animator animator, string animName)
		{
			return default(bool);
		}

		public void BottomSlideIn(bool isButtonDisable = false)
		{
		}

		private void SetBottomButtonsRaycastTargetEnable(bool value)
		{
		}

		public void RightSlideOut()
		{
		}

		public void RightSlideIn()
		{
		}

		public void SetBuildButtonInteractable(bool interactable)
		{
		}

		public void SetManagedFacilityButtonInteractable(bool interactable)
		{
		}

		public void SetCropAllButtonInteractable(bool interactable)
		{
		}

		public void DragonFruitsSlideOut()
		{
		}

		public void DragonFruitsSlideIn()
		{
		}

		public void PlayRightSlideOut()
		{
		}

		public void PlayRightSlideIn()
		{
		}

		public void OnSelectFacility(FacilityViewController facilityViewController)
		{
		}

		public void CancelInvisibleModel(PointerEventData eventData)
		{
		}

		public void OnFacilitySelectCancel(bool playBottomSlideOut, bool playSlideIn = true)
		{
		}

		public void OnStoreButtonPressed()
		{
		}

		public void OnRelocationButtonPressed()
		{
		}

		public void OnFacilityStopButtonPressed()
		{
		}

		public void OnFacilityCompleteAtOnceButtonPressed()
		{
		}

		public void OnFacilityDetailButtonPressed()
		{
		}

		private void OpenFacilityDetailDialog(FacilityDetailDialogController.DialogType dialogType)
		{
		}

		public void OnLevelUpButtonPressed()
		{
		}

		public void UpdateAddSmithUI(int diff = 0)
		{
		}

		public void StartCroppingDragonFruits(int material, int count)
		{
		}

		public void FinishCroppingDragonFruits(int material, int count)
		{
		}

		public void StartCroppingCoins(int count)
		{
		}

		public bool FinishCroppingCoins(int count)
		{
			return default(bool);
		}

		public void CroppingCoinsAllCompleted()
		{
		}

		void FortUIEventInterface.OnPlayRightSlideIn()
		{
		}

		void FortUIEventInterface.OnPlayRightSlideOut()
		{
		}

		void FortUIEventInterface.OnRightSlideIn()
		{
		}

		void FortUIEventInterface.OnRightSlideOut()
		{
		}

		void FortUIEventInterface.OnBottomSlideIn()
		{
		}

		void FortUIEventInterface.OnBottomSlideOut()
		{
		}

		void FortUIEventInterface.OnFacilitySelectCancel(bool playBottomSlideOut)
		{
		}

		void FortUIEventInterface.OnFacilityVanished(GameObject gameObject)
		{
		}

		void FortUIEventInterface.OnFacilityStateChanged(ManagedFacilityDialogController.ExecutedFacilityAction executedFacilityAction)
		{
		}

		public void PutFacility()
		{
		}

		public void OnPutModeCanceled()
		{
		}

		public void ShowAddSmithResult()
		{
		}

		public void ShowBuildCursor2D(bool isShown, [Optional] Facility facility)
		{
		}

		private FlashPlayer SetupFlashPlayer(string flashPath, Transform target, Image hideImage)
		{
			return null;
		}

		public void SetTotalLevelOfFacilities(int totalLevel)
		{
		}

		public void SetCoin(long num)
		{
		}

		public void UpdateCoin()
		{
		}

		public void CropFromAllFacilities()
		{
		}

		public FlashPlayer GetFlashPlayerOnUi(string flashPath)
		{
			return null;
		}

		private void DestroyFlashPlayerOnUi()
		{
		}

		private FlashPlayer GetFortFlashPlayer()
		{
			return null;
		}

		public void SetCanvasSortOrder(int sortOrder)
		{
		}

		public void PlayStaminaEffect(Transform target)
		{
		}

		private FlashPlayer GetStaminaFlashPlayer(Transform target)
		{
			return null;
		}

		protected void OnDestroy()
		{
		}
	}
}
