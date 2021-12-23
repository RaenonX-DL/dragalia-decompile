using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Http;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitDetailCanvas : PopupCanvas
	{
		[HideInInspector]
		public UnitDetailScene detailScene;

		[SerializeField]
		[Header("BaseComponents")]
		public PageViewBase pageView;

		public Viewer2DCanvas viewer2DCanvas;

		public Viewer3DCanvas viewer3DCanvas;

		public UnityAction viewerButtobCallBack;

		public UnityAction lockButtobCallBack;

		[HideInInspector]
		public UnitDetailContentType nowPage;

		[SerializeField]
		[Header("3DRenderTexture")]
		public RawImageWithAlphaBlend modelViewImage;

		[SerializeField]
		[Header("Lock")]
		public Button unitLockButton;

		public Image lockButtonIcon;

		public Sprite unitLockSprite;

		public Sprite unitUnLockSprite;

		[SerializeField]
		[Header("Favorite")]
		public Button favoriteButton;

		public Image favoriteButtonIcon;

		public Sprite favoriteOnSprite;

		public Sprite favoriteOffSprite;

		[SerializeField]
		[Header("Growth")]
		public Button growthMenuButton;

		[SerializeField]
		[Header("Publisher")]
		public UIAnimationPublisher mainPublisher;

		public UIAnimationPublisher quitPublisher;

		[SerializeField]
		[Header("Flash")]
		private Camera oldFlashCamera;

		public RawImageWithAlphaBlend flashRawImage;

		[SerializeField]
		[Header("Buttons")]
		public GameObject viewerButtons;

		[SerializeField]
		[Header("CV")]
		public Image cvNameBase;

		public Button voiceButton;

		private int talkIndex;

		private string[] voiceNames;

		private string voiceSheetName;

		private AudioPlayback characterVoice;

		[SerializeField]
		[Header("SeasonVoice")]
		public Image seasonVoiceButtonImage;

		public Button seasonVoiceButton;

		private string seasonVoiceSheetName;

		private string seasonVoiceName;

		private AudioPlayback seasonCharacterVoice;

		[SerializeField]
		[Header("ArtistName")]
		public GameObject artistNameBase;

		public RawImage artistNameImage;

		private FlashPlayer switchFlashPlayer;

		[SerializeField]
		[Header("SwitchFor2D3D")]
		public Transform switchEffectAttachPoint;

		public GameObject switchButton;

		public Text switchText;

		[SerializeField]
		[Header("SwitchForDragon")]
		public GameObject switchChangeDragonButton;

		public Text switchChangeDragonText;

		[SerializeField]
		[Header("SwitchForSub")]
		public GameObject switchSubButton;

		private int currentNormalizedIndex;

		private List<int> switchableNormalizedIdList;

		[SerializeField]
		[Header("FullScreenMode")]
		public Button[] fullScreenButtons;

		public UIAnimationPublisher fullScreenModePublisher;

		public Image[] viewPageButtonsRaycast;

		[SerializeField]
		private GameObject amuletSwithButtonObj;

		[SerializeField]
		private Text amuletSwitchButtonText;

		private FlashPlayerManager flashPlayerManager;

		private FlashPlayer topCutinFlashPlayer;

		private List<FlMotion> topCutinOutCallMotions;

		private const string topCutinFlashPath = "Prefabs/OutGame/UnitDetail/pf_detail_obi_front";

		private RenderTexture topCutinRenderTexture;

		private List<UnitDetailContentType> detailPageList;

		private const float flashIconScale = 0.6f;

		public const string iconShaderMaterialPath = "Materials/Common/SpriteExternalAlphaAdjustmentA8";

		private const string artistNamePath = "Images/Icon/Amulet/ArtistName/";

		private const int maxAbilityNum = 8;

		private bool nextAbilityPageFlag;

		private int[] abilityPageIndexList;

		private FlRoot flashRoot;

		private bool switchSubButtonEnabled;

		private bool needRefreshFlash;

		private Canvas canvas;

		private const int defaultNameFontSize = 40;

		private const int amuletNameFontSize = 36;

		public bool isFullScreenMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int sortingOrder => default(int);

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void ToggleSwitchSubButton(bool toEnable)
		{
		}

		public void CVButtonPressed()
		{
		}

		private void SetCVAndArtistBaseData(out string voiceSheetName, out string[] voiceNames)
		{
		}

		public void SeasonVoiceButtonPressed()
		{
		}

		private void SetSeasonVoiceData(out string voiceSheetName, out string voiceNames)
		{
		}

		public void PlaySwitchFlash()
		{
		}

		private void LoadVoiceGroup(string voiceSheetName, Image cvNameBase, Button voiceButton)
		{
		}

		private void RunFlashIn()
		{
		}

		public void RunFlashOut()
		{
		}

		private void CallTopCutinFlashMotion(string label)
		{
		}

		private void RunSwitchToViewFlash()
		{
		}

		private void RunSwitchFrom2DFlash()
		{
		}

		private void RunSwitchFrom3DFlash()
		{
		}

		public void OnViewerButtonPressed()
		{
		}

		public void OnSwitchViewModeButtonPressed()
		{
		}

		public void OnUnitLockButtonPressed()
		{
		}

		public void SendDataOnSuccess(WeaponSetLockResponse res)
		{
		}

		public void SendDataOnSuccess(AmuletSetLockResponse res)
		{
		}

		public void SendDataOnSuccess(DragonSetLockResponse res)
		{
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}

		public void OnFavoriteButtonPressed()
		{
		}

		private void LoadTopCutin()
		{
		}

		private void RefreshTopCutInContent()
		{
		}

		private void ReplaceAmuletTexture(FlPlane plane, string planeName)
		{
		}

		private void RefleshAmuletTexture()
		{
		}

		private void ReplaceTalismanFrameTexture(FlPlane plane, string talismanFrameName)
		{
		}

		private void ReplaceTalismanTexture(FlPlane plane, string planeName)
		{
		}

		private void ReplaceTalismanAbilityTex(FlPlane plane, int id)
		{
		}

		private IEnumerator ChangeLocalizeTextPositionCoroutine(FlashPlayer flashPlayer)
		{
			return null;
		}

		private void ChangeLocalizeTextPosition(string target, float addX, float addY, FlashPlayer flashPlayer)
		{
		}

		private void ApplyReplaceMat(FlPlane plane, Material replaceMat, string planeName, int baseId, int varId)
		{
		}

		public void SwitchTo3DMode()
		{
		}

		public void SwitchTo2DMode()
		{
		}

		public void OnReturnFromViewMode(UnitDetailScene.ViewingMode mode)
		{
		}

		public void PlayEnterAnimation()
		{
		}

		public void PlayExitAnimation()
		{
		}

		public void SetLockButton()
		{
		}

		public void SetFavoriteButton()
		{
		}

		public void SetUnitModel()
		{
		}

		private void SetupPageList()
		{
		}

		private void RefreshPageView(int startIndex)
		{
		}

		private void SetPageContent(GameObject parentPrefab, int index)
		{
		}

		public static void ShowSkillDetailDialog(int skillId, int level, int maxLevel, bool isWeaponElementalUnmatched = false)
		{
		}

		public static void ShowAbilityDetailDialog(int abilityId, bool isLockCell, ElementalType type)
		{
		}

		public static void ShowAbilityDetailDialog(AbilityPageData abilityPageData, bool isLockCell)
		{
		}

		public static void ShowExAbilityDetailDialog(int exAbilityId, bool isLockCell, bool isFirstAbility)
		{
		}

		private void ShowStatusDetailDialog()
		{
		}

		public void OnGrowthMenuPressed()
		{
		}

		public void OnSwitchSubButtonPressed()
		{
		}

		public void EnableFullScreenButton(bool toEnable)
		{
		}

		public void OnFullScreenButtonPressed()
		{
		}

		public void ToggleFullScreen(bool withBackButton = true)
		{
		}

		private void ButtonLaycastSetting(bool isLayCast)
		{
		}

		public void OnSwitchButtonTouched()
		{
		}

		public void ShowSwitchButton(bool isVisible)
		{
		}

		private void SetRefreshText()
		{
		}

		public void OnSwitchChangeDragonButton()
		{
		}

		public void MultipleCharacterSwitchButtonAction()
		{
		}

		public void SetSwitchChangeButtonText(int charaId, UnitDetailScene.MultipleCharacter3DMode mode)
		{
		}

		private void SwitchChangeDragonButtonText()
		{
		}

		private void SwitchChangeDefaultDragonButtonText()
		{
		}
	}
}
