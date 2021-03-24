/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumDetailCanvas : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public UnitDetailScene detailScene;
		[Header]
		[SerializeField]
		public Viewer2DCanvas viewer2DCanvas;
		[SerializeField]
		public Viewer3DCanvas viewer3DCanvas;
		[Header]
		[SerializeField]
		public RawImageWithAlphaBlend modelViewImage;
		[Header]
		[SerializeField]
		public UIAnimationPublisher mainPublisher;
		[SerializeField]
		public UIAnimationPublisher quitPublisher;
		[Header]
		[SerializeField]
		public GameObject viewerButtons;
		[Header]
		[SerializeField]
		public Image cvNameBase;
		[SerializeField]
		public Button voiceButton;
		[Header]
		[SerializeField]
		private Image seasonVoiceButtonImage;
		[SerializeField]
		private Button seasonVoiceButton;
		[Header]
		[SerializeField]
		public GameObject artistNameBase;
		public RawImage artistNameImage;
		[Header]
		[SerializeField]
		private UnitDetail2dModel unitImage;
		[SerializeField]
		private RectTransform imageOffset;
		[Header]
		[SerializeField]
		public Transform switchEffectAttachPoint;
		[SerializeField]
		public GameObject switchButton;
		[SerializeField]
		public UnityEngine.UI.Text switchText;
		[Header]
		[SerializeField]
		public GameObject switchChangeDragonButton;
		[SerializeField]
		public UnityEngine.UI.Text switchChangeDragonText;
		[Header]
		[SerializeField]
		public GameObject switchSubButton;
		[Header]
		[SerializeField]
		public Button[] fullScreenButtons;
		public UIAnimationPublisher fullScreenModePublisher;
		public Image[] viewPageButtonsRaycast;
		[Header]
		[SerializeField]
		private Image rareIcon;
		[SerializeField]
		private Image elementalIcon;
		[SerializeField]
		private Image weaponTypeIcon;
		[SerializeField]
		private UnityEngine.UI.Text anotherName;
		[SerializeField]
		private UnityEngine.UI.Text anotherNameRuby;
		[SerializeField]
		private UnityEngine.UI.Text unitName;
		[SerializeField]
		private Button albumMemoryPopupButton;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text unitLevel;
		[SerializeField]
		private UnityEngine.UI.Text unitLevelTitle;
		[SerializeField]
		private UnityEngine.UI.Text unitManaCircle;
		[SerializeField]
		private UnityEngine.UI.Text unitManaCircleTitle;
		[SerializeField]
		private UnityEngine.UI.Text maxLimitBreakCount;
		[SerializeField]
		private UnityEngine.UI.Text maxLimitBreakCountTitle;
		[SerializeField]
		private UnityEngine.UI.Text reliabilityLevel;
		[SerializeField]
		private UnityEngine.UI.Text reliabilityLevelTitle;
		[SerializeField]
		private List<GameObject> allAchievementObj;
		[SerializeField]
		private List<GameObject> charaAchievementObj;
		[SerializeField]
		private List<GameObject> dragonAchievementObj;
		[Header]
		[SerializeField]
		private Button growthMenuButton;
		[CompilerGenerated]
		private bool _isFullScreenMode_k__BackingField;
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
	
		// Properties
		public bool isFullScreenMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int sortingOrder { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public AlbumDetailCanvas __4__this;
			public bool withBackButton;
			public SimpleAnimationButton simpleAnimation;
			public bool oldStopState;
	
			// Constructors
			public __c__DisplayClass93_0();
	
			// Methods
			internal void _ToggleFullScreen_b__0();
			internal void _ToggleFullScreen_b__1();
		}
	
		// Constructors
		public AlbumDetailCanvas();
	
		// Methods
		private void Awake();
		private void Start();
		protected void OnDestroy();
		public void SetUnit2DImage(int forceSubId = -1);
		private void SetChangeDragonButton();
		private void SetAlbumStatus();
		private void SetAchievementObj();
		private void SetLockButton();
		private void SetSwitchSubButton();
		public void CVButtonPressed();
		private void SetCVAndArtistBaseData(out string voiceSheetName, out string[] voiceNames);
		public void SeasonVoiceButtonPressed();
		private void SetSeasonVoiceData(out string voiceSheetName, out string voiceNames);
		private void LoadVoiceGroup(string voiceSheetName, Image cvNameBase, Button voiceButton);
		public void OnMemoryButton();
		public void OnProfileButton();
		public void ToggleSwitchSubButton(bool toEnable);
		public void OnViewerButtonPressed();
		public void OnSwitchViewModeButtonPressed();
		public void SwitchTo3DMode();
		public void SwitchTo2DMode();
		public void OnReturnFromViewMode();
		public void PlayEnterAnimation();
		public void PlayExitAnimation();
		public void SetUnitModel();
		public void OnSwitchSubButtonPressed();
		public void EnableFullScreenButton(bool toEnable);
		public void OnFullScreenButtonPressed();
		public void ToggleFullScreen(bool withBackButton = true);
		private void ButtonLaycastSetting(bool isLayCast);
		public void OnSwitchChangeDragonButton();
		public void OnGrowthMenuPressed();
		public void PlaySwitchFlash();
		[CompilerGenerated]
		private void _SwitchTo3DMode_b__84_0();
		[CompilerGenerated]
		private void _SwitchTo2DMode_b__85_0();
		[CompilerGenerated]
		private void _PlayExitAnimation_b__88_0();
	}
}
