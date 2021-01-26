/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Http;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailCanvas : PopupCanvas
	{
		// Fields
		[HideInInspector]
		public UnitDetailScene detailScene;
		[Header]
		[SerializeField]
		public PageViewBase pageView;
		public Viewer2DCanvas viewer2DCanvas;
		public Viewer3DCanvas viewer3DCanvas;
		public UnityAction viewerButtobCallBack;
		public UnityAction lockButtobCallBack;
		[HideInInspector]
		public UnitDetailContentType nowPage;
		[Header]
		[SerializeField]
		public RawImageWithAlphaBlend modelViewImage;
		[Header]
		[SerializeField]
		public Button unitLockButton;
		public Image lockButtonIcon;
		public Sprite unitLockSprite;
		public Sprite unitUnLockSprite;
		[Header]
		[SerializeField]
		public Button favoriteButton;
		public Image favoriteButtonIcon;
		public Sprite favoriteOnSprite;
		public Sprite favoriteOffSprite;
		[Header]
		[SerializeField]
		public Button growthMenuButton;
		[Header]
		[SerializeField]
		public UIAnimationPublisher mainPublisher;
		public UIAnimationPublisher quitPublisher;
		[Header]
		[SerializeField]
		private Camera oldFlashCamera;
		public RawImageWithAlphaBlend flashRawImage;
		[Header]
		[SerializeField]
		public GameObject viewerButtons;
		[Header]
		[SerializeField]
		public Image cvNameBase;
		public Button voiceButton;
		private int talkIndex;
		private string[] voiceNames;
		private string voiceSheetName;
		private AudioPlayback characterVoice;
		[Header]
		[SerializeField]
		public Image seasonVoiceButtonImage;
		public Button seasonVoiceButton;
		private string seasonVoiceSheetName;
		private string seasonVoiceName;
		private AudioPlayback seasonCharacterVoice;
		[Header]
		[SerializeField]
		public GameObject artistNameBase;
		public RawImage artistNameImage;
		private FlashPlayer switchFlashPlayer;
		[Header]
		[SerializeField]
		public Transform switchEffectAttachPoint;
		public GameObject switchButton;
		public UnityEngine.UI.Text switchText;
		[Header]
		[SerializeField]
		public GameObject switchChangeDragonButton;
		public UnityEngine.UI.Text switchChangeDragonText;
		[Header]
		[SerializeField]
		public GameObject switchSubButton;
		private int currentNormalizedIndex;
		private List<int> switchableNormalizedIdList;
		[Header]
		[SerializeField]
		public Button[] fullScreenButtons;
		public UIAnimationPublisher fullScreenModePublisher;
		public Image[] viewPageButtonsRaycast;
		[SerializeField]
		private GameObject amuletSwithButtonObj;
		[SerializeField]
		private UnityEngine.UI.Text amuletSwitchButtonText;
		[CompilerGenerated]
		private bool _isFullScreenMode_k__BackingField;
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
	
		// Properties
		public bool isFullScreenMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int sortingOrder { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__94_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnError_b__94_0();
		}
	
		[CompilerGenerated]
		private struct _OnFavoriteButtonPressed_d__95 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public UnitDetailCanvas __4__this;
			private TaskAwaiter<AbilityCrestSetFavoriteResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class _ChangeLocalizeTextPositionCoroutine_d__100 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnitDetailCanvas __4__this;
			public FlashPlayer flashPlayer;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeLocalizeTextPositionCoroutine_d__100(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_0
		{
			// Fields
			public ulong keyId;
			public UnitDetailCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass119_0();
	
			// Methods
			internal void _OnGrowthMenuPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass123_0
		{
			// Fields
			public UnitDetailCanvas __4__this;
			public bool withBackButton;
			public SimpleAnimationButton simpleAnimation;
			public bool oldStopState;
	
			// Constructors
			public __c__DisplayClass123_0();
	
			// Methods
			internal void _ToggleFullScreen_b__0();
			internal void _ToggleFullScreen_b__1();
		}
	
		// Constructors
		public UnitDetailCanvas();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		protected override void OnDestroy();
		public void ToggleSwitchSubButton(bool toEnable);
		public void CVButtonPressed();
		private void SetCVAndArtistBaseData(out string voiceSheetName, out string[] voiceNames);
		public void SeasonVoiceButtonPressed();
		private void SetSeasonVoiceData(out string voiceSheetName, out string voiceNames);
		public void PlaySwitchFlash();
		private void LoadVoiceGroup(string voiceSheetName, Image cvNameBase, Button voiceButton);
		public void RunFlashOut();
		private void CallTopCutinFlashMotion(string label);
		private void RunSwitchToViewFlash();
		private void RunSwitchFrom2DFlash();
		private void RunSwitchFrom3DFlash();
		public void OnViewerButtonPressed();
		public void OnSwitchViewModeButtonPressed();
		public void OnUnitLockButtonPressed();
		public void SendDataOnSuccess(WeaponSetLockResponse res);
		public void SendDataOnSuccess(AmuletSetLockResponse res);
		public void SendDataOnSuccess(DragonSetLockResponse res);
		public void OnError(ErrorType errorType, int resultCode);
		public async void OnFavoriteButtonPressed();
		private void LoadTopCutin();
		private void RefreshTopCutInContent();
		private void ReplaceAmuletTexture(FlPlane plane, string planeName);
		private void RefleshAmuletTexture();
		[IteratorStateMachine]
		private IEnumerator ChangeLocalizeTextPositionCoroutine(FlashPlayer flashPlayer);
		private void ChangeLocalizeTextPosition(string target, float addX, float addY, FlashPlayer flashPlayer);
		private void ApplyReplaceMat(FlPlane plane, Material replaceMat, string planeName, int baseId, int varId);
		public void SwitchTo3DMode();
		public void SwitchTo2DMode();
		public void OnReturnFromViewMode();
		public void PlayEnterAnimation();
		public void PlayExitAnimation();
		public void SetLockButton();
		public void SetFavoriteButton();
		public void SetUnitModel();
		private void SetupPageList();
		private void RefreshPageView(int startIndex);
		private void SetPageContent(GameObject parentPrefab, int index);
		public static void ShowSkillDetailDialog(int skillId, int level, int maxLevel, bool isWeaponElementalUnmatched = false);
		public static void ShowAbilityDetailDialog(int abilityId, bool isLockCell, ElementalType type);
		public static void ShowAbilityDetailDialog(AbilityPageData abilityPageData, bool isLockCell);
		public static void ShowExAbilityDetailDialog(int exAbilityId, bool isLockCell, bool isFirstAbility);
		private void ShowStatusDetailDialog();
		public void OnGrowthMenuPressed();
		public void OnSwitchSubButtonPressed();
		public void EnableFullScreenButton(bool toEnable);
		public void OnFullScreenButtonPressed();
		public void ToggleFullScreen(bool withBackButton = true);
		private void ButtonLaycastSetting(bool isLayCast);
		public void OnSwitchButtonTouched();
		public void ShowSwitchButton(bool isVisible);
		private void SetRefreshText();
		public void OnSwitchChangeDragonButton();
		[CompilerGenerated]
		private void _LoadTopCutin_b__96_0(int index);
		[CompilerGenerated]
		private void _SwitchTo3DMode_b__103_0();
		[CompilerGenerated]
		private void _SwitchTo2DMode_b__104_0();
		[CompilerGenerated]
		private void _PlayExitAnimation_b__107_0();
		[CompilerGenerated]
		private void _RefreshPageView_b__112_0(int index);
	}
}
