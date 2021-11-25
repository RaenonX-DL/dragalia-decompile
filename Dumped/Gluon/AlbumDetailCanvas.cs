using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumDetailCanvas : MonoBehaviour
	{
		[HideInInspector]
		public UnitDetailScene detailScene;

		[SerializeField]
		[Header("BaseComponents")]
		public Viewer2DCanvas viewer2DCanvas;

		[SerializeField]
		public Viewer3DCanvas viewer3DCanvas;

		[SerializeField]
		[Header("3DRenderTexture")]
		public RawImageWithAlphaBlend modelViewImage;

		[SerializeField]
		[Header("Publisher")]
		public UIAnimationPublisher mainPublisher;

		[SerializeField]
		public UIAnimationPublisher quitPublisher;

		[SerializeField]
		[Header("Buttons")]
		public GameObject viewerButtons;

		[SerializeField]
		[Header("CV")]
		public Image cvNameBase;

		[SerializeField]
		public Button voiceButton;

		[SerializeField]
		[Header("SeasonVoice")]
		private Image seasonVoiceButtonImage;

		[SerializeField]
		private Button seasonVoiceButton;

		[SerializeField]
		[Header("ArtistName")]
		public GameObject artistNameBase;

		public RawImage artistNameImage;

		[SerializeField]
		[Header("unitImage")]
		private UnitDetail2dModel unitImage;

		[SerializeField]
		private RectTransform imageOffset;

		[SerializeField]
		[Header("SwitchFor2D3D")]
		public Transform switchEffectAttachPoint;

		[SerializeField]
		public GameObject switchButton;

		[SerializeField]
		public Text switchText;

		[SerializeField]
		[Header("SwitchForDragon")]
		public GameObject switchChangeDragonButton;

		[SerializeField]
		public Text switchChangeDragonText;

		[SerializeField]
		[Header("SwitchForSub")]
		public GameObject switchSubButton;

		[SerializeField]
		[Header("FullScreenMode")]
		public Button[] fullScreenButtons;

		public UIAnimationPublisher fullScreenModePublisher;

		public Image[] viewPageButtonsRaycast;

		[SerializeField]
		[Header("AlbumStatus")]
		private Image rareIcon;

		[SerializeField]
		private Image elementalIcon;

		[SerializeField]
		private Image weaponTypeIcon;

		[SerializeField]
		private Text anotherName;

		[SerializeField]
		private Text anotherNameRuby;

		[SerializeField]
		private Text unitName;

		[SerializeField]
		private Button albumMemoryPopupButton;

		[SerializeField]
		[Header("Achievement")]
		private Text unitLevel;

		[SerializeField]
		private Text unitLevelTitle;

		[SerializeField]
		private Text unitManaCircle;

		[SerializeField]
		private Text unitManaCircleTitle;

		[SerializeField]
		private Text maxLimitBreakCount;

		[SerializeField]
		private Text maxLimitBreakCountTitle;

		[SerializeField]
		private Text reliabilityLevel;

		[SerializeField]
		private Text reliabilityLevelTitle;

		[SerializeField]
		private List<GameObject> allAchievementObj;

		[SerializeField]
		private List<GameObject> charaAchievementObj;

		[SerializeField]
		private List<GameObject> dragonAchievementObj;

		[SerializeField]
		[Header("Growth")]
		private Button growthMenuButton;

		[SerializeField]
		[Header("medal")]
		private Button medalButton;

		private bool switchSubButtonEnabled;

		private Canvas canvas;

		private int talkIndex;

		private string[] voiceNames;

		private string voiceSheetName;

		private AudioPlayback characterVoice;

		private FlashPlayerManager flashPlayerManager;

		private FlashPlayer switchFlashPlayer;

		private string seasonVoiceSheetName;

		private string seasonVoiceName;

		private AudioPlayback seasonCharacterVoice;

		private int currentNormalizedIndex;

		private List<int> switchableNormalizedIdList;

		private Color statusLevelDefaultTextColor;

		private Color statusLevelMaxTextColor;

		private Color statusLevelMax2TextColor;

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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		protected void OnDestroy()
		{
		}

		public void SetUnit2DImage(int forceSubId = -1)
		{
		}

		private void SetChangeDragonButton()
		{
		}

		private void SetMedalButton()
		{
		}

		private void SetAlbumStatus()
		{
		}

		private void SetAchievementObj()
		{
		}

		private void SetLockButton()
		{
		}

		private void SetSwitchSubButton()
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

		private void LoadVoiceGroup(string voiceSheetName, Image cvNameBase, Button voiceButton)
		{
		}

		public void OnMemoryButton()
		{
		}

		public void OnProfileButton()
		{
		}

		public void OnMedalButton()
		{
		}

		public void ToggleSwitchSubButton(bool toEnable)
		{
		}

		public void OnViewerButtonPressed()
		{
		}

		public void OnSwitchViewModeButtonPressed()
		{
		}

		public void SwitchTo3DMode()
		{
		}

		public void SwitchTo2DMode()
		{
		}

		public void OnReturnFromViewMode()
		{
		}

		public void PlayEnterAnimation()
		{
		}

		public void PlayExitAnimation()
		{
		}

		public void SetUnitModel()
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

		public void OnSwitchChangeDragonButton()
		{
		}

		public void OnGrowthMenuPressed()
		{
		}

		public void PlaySwitchFlash()
		{
		}
	}
}
