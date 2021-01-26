﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Core;
using DG.Tweening;
using Gluon.Master;
using Gluon.Mission;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestCell : QuestCellBase
	{
		// Fields
		public UnityAction<QuestCellData> pressedCallback;
		public UnityAction<QuestCellData> disableToJoinCallback;
		public UnityAction dataUpdateCallBack;
		public Action missionCloseCallBack;
		public Button baseButton;
		public UnityEngine.UI.Text title;
		[SerializeField]
		protected GameObject questNewIconRoot;
		[SerializeField]
		protected GameObject questNewGlowRoot;
		[SerializeField]
		protected GameObject storyNewIconRoot;
		[SerializeField]
		protected GameObject storyNewGlowRoot;
		[SerializeField]
		protected Button storyButton;
		[SerializeField]
		protected Image storyImage;
		[SerializeField]
		protected GameObject typeQuestRootObj;
		[SerializeField]
		protected Button detailButton;
		[SerializeField]
		protected UnityEngine.UI.Text storyTitle;
		[SerializeField]
		protected RectTransform storyIconTransform;
		[SerializeField]
		protected GameObject questMissionIconRoot;
		[SerializeField]
		protected ButtonSprite[] missionClearButtons;
		[SerializeField]
		protected GameObject questPreviewRoot;
		[SerializeField]
		protected Image questPreviewImage;
		[SerializeField]
		protected UnityEngine.UI.Text dungeonIndex;
		[SerializeField]
		protected UnityEngine.UI.Text storyIndex;
		[SerializeField]
		protected Image _dungeonArrow;
		[SerializeField]
		protected Image _storyArrow;
		[SerializeField]
		protected Image _rightArrow;
		[SerializeField]
		protected GameObject questPowerIconRoot;
		[SerializeField]
		protected UnityEngine.UI.Text questPowerValueText;
		[SerializeField]
		protected CircleOutline questPowerValueQutline;
		[SerializeField]
		protected Image recommendedPowerIcon;
		[SerializeField]
		protected Image necessaryPowerIcon;
		[SerializeField]
		protected Color lackOfPartyPowerColor;
		[SerializeField]
		protected Color defaultPowerColor;
		[SerializeField]
		protected Image questPowerValueBackGround;
		[SerializeField]
		protected Image questElementIcon;
		[SerializeField]
		protected UnityEngine.UI.Text questQuantityText;
		[SerializeField]
		private GameObject questItemAndStaminaRoot;
		[SerializeField]
		protected GameObject questItemIconRoot;
		[SerializeField]
		protected Image questItemIconImage;
		[SerializeField]
		protected GameObject getItemIconRoot;
		[SerializeField]
		protected Image getItemIconImage;
		[SerializeField]
		protected UnityEngine.UI.Text getItemCountText;
		[SerializeField]
		protected UnityEngine.UI.Text questItemNumText;
		[SerializeField]
		protected GameObject questStaminaRoot;
		[SerializeField]
		protected UnityEngine.UI.Text questStaminaText;
		[SerializeField]
		protected UnityEngine.UI.Text questStaminaNumText;
		[SerializeField]
		protected Color questStaminaZeroColor;
		[SerializeField]
		protected GameObject entryConditionRoot;
		[SerializeField]
		protected UnityEngine.UI.Text entryConditionText;
		[SerializeField]
		protected GameObject grayedOutImage;
		[SerializeField]
		protected GameObject normalImage;
		[SerializeField]
		private GameObject questStory;
		[SerializeField]
		private GameObject eventBalloon;
		[SerializeField]
		protected Vector2 titlePosWithNoSectionName;
		[SerializeField]
		private UiImageExchanger questDifficultFrameImageExchanger;
		[SerializeField]
		private UiImageExchanger questDifficultMissionImageExchanger;
		[SerializeField]
		private UiImageExchanger storyBandImageExchanger;
		[Header]
		[SerializeField]
		private GameObject collectLockGO;
		[SerializeField]
		private GameObject collectNeedItemIconGO;
		[SerializeField]
		private Image collectNeedItemIcon;
		[SerializeField]
		private UnityEngine.UI.Text collectNeedItemCountText;
		[SerializeField]
		private UnityEngine.UI.Text collectInsufficientText;
		[Header]
		[SerializeField]
		private GameObject storyTimeReleaseLockGO;
		[SerializeField]
		private UnityEngine.UI.Text storyTimeReleaseLockText;
		[SerializeField]
		private GameObject storyTitleGO;
		[SerializeField]
		private QuestPresentLevel questPresentLevel;
		[SerializeField]
		private UnityEngine.UI.Text remainTimeText;
		[SerializeField]
		private GameObject mainStoryMissionLockBaseObj;
		[SerializeField]
		private UnityEngine.UI.Text mainStoryMissionStatusText;
		[SerializeField]
		private GameObject mainStoryMissionLockRoot;
		[SerializeField]
		private Button mainStoryMissionMissionButton;
		[SerializeField]
		private GameObject dragonOnly1UnitImage;
		[SerializeField]
		private GameObject dragonOnly4UnitImage;
		[SerializeField]
		private GameObject soloQuestBalloon;
		[SerializeField]
		private CampaignButtons campaignButton;
		[SerializeField]
		private GameObject questTypeSoloImage;
		[SerializeField]
		private GameObject questTypeMultiImage;
		[SerializeField]
		private GameObject orderPartyBlueBalloon;
		[SerializeField]
		private GameObject orderPartyRedBalloon;
		[Header]
		[SerializeField]
		private Graphic limitedElementBlueBalloonIcon;
		[SerializeField]
		private Graphic limitedElementRedBalloonIcon;
		[SerializeField]
		private GameObject eventEndText;
		private List<QuestEventMenuElement> questEventMenuList;
		public QuestUtil.MainStoryMissionStatus mainStoryMissionStatus;
		protected QuestDetailInfoPopup detailInfoPopup;
		protected UnityEngine.UI.Text questIndexText;
		protected GameObject questElementIconObj;
		protected QuestStoryPopup storyPopup;
		protected EventQuestConditionPopup conditionPopup;
		protected Vector2 titleDefaultPos;
		protected Vector2 elementIconDefaultPos;
		protected RectTransform elementIconRectTrans;
		protected string sectionNameStr;
		protected SubType _subType;
		protected QuestCellData _questCellData;
		private bool _isEventEpilogueStory;
		private UiImageExchanger difficultyTitleImageExchanger;
		private UiTextColorExchanger difficultyTitleColorExchanger;
		private DateTime prevUpdateTime;
		private const float updateInterval = 1f;
		private bool prevPlayableStamina;
		private Sequence colorSeq;
		private const float halfSizeValue = 0.5f;
		private const float storyIconSpace = 24f;
		private bool isStoryBlockedByReleaseDateOrItem;
		private int dragonBattleLockConditionTextFontSize;
		private CellLockStatus cellLockStatus;
		private List<GameObject> balloonImageList;
		private Tweener baroonBlinkTween;
		private const float baroonBlinkTime = 1f;
	
		// Properties
		public QuestCellData questCellData { get; private set; }
		public SubType subType { get; set; }
		public Image dungeonArrow { get; }
		public Image storyArrow { get; }
		public Image rightArrow { get; }
		public bool isEventEpilogueStory { get; set; }
	
		// Nested types
		public enum SubType
		{
			Default = 0,
			ShortCutting = 1,
			SubList = 2
		}
	
		private enum CellLockStatus
		{
			Open = 0,
			Lock = 1,
			NotOpenPeriod = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass137_0
		{
			// Fields
			public Image image;
			public Action onCompleat;
	
			// Constructors
			public __c__DisplayClass137_0();
	
			// Methods
			internal void _SetArenaThumbnail_b__0(Material material);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass147_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass147_0();
	
			// Methods
			internal void _ShowNextEventSchedulePopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass150_0
		{
			// Fields
			public QuestCell __4__this;
			public int curQuestId;
	
			// Constructors
			public __c__DisplayClass150_0();
	
			// Methods
			internal void _OnMainQuestCellClicked_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass151_0
		{
			// Fields
			public DownloadOperation downloadOperation;
			public int[] fortGroup;
			public HashSet<string> hashSet;
			public DownloadOperation downloadOperationwithoutVoice;
			public HashSet<string> hashSetwithoutVoice;
	
			// Constructors
			public __c__DisplayClass151_0();
	
			// Methods
			internal void _CheckFortDownloadAndGoQuest_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CheckFortDownloadAndGoQuest_d__151 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int curQuestId;
			private __c__DisplayClass151_0 __8__1;
			public QuestCell __4__this;
			private TouchGuardObject _touchGuard_5__2;
			private ParallelJob _job_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckFortDownloadAndGoQuest_d__151(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass154_0
		{
			// Fields
			public QuestCell __4__this;
			public int curQuestId;
	
			// Constructors
			public __c__DisplayClass154_0();
	
			// Methods
			internal void _OnEventQuestDungeonCellClickExecute_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass155_0
		{
			// Fields
			public QuestCell __4__this;
			public QuestEventMenuElement menuElement;
	
			// Constructors
			public __c__DisplayClass155_0();
	
			// Methods
			internal void _OnEventQuestCellClicked_b__2();
			internal void _OnEventQuestCellClicked_b__3();
			internal void _OnEventQuestCellClicked_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__155_0;
			public static UnityAction __9__155_4;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnEventQuestCellClicked_b__155_0();
			internal void _OnEventQuestCellClicked_b__155_4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass158_0
		{
			// Fields
			public QuestCell __4__this;
			public int curQuestId;
			public QuestGroupType groupType;
	
			// Constructors
			public __c__DisplayClass158_0();
	
			// Methods
			internal void _OpenStoryPopup_b__1();
			internal void _OpenStoryPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass174_0
		{
			// Fields
			public QuestCell __4__this;
			public FlashPlayer mainStoryMissionUnlock;
	
			// Constructors
			public __c__DisplayClass174_0();
	
			// Methods
			internal void _PlayMainStoryMissionUnlockEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass174_1
		{
			// Fields
			public TouchGuardObject touchGuard;
			public Image missionButtonImage;
			public float crownsBaseGrayColor;
			public Image crownsBaseImage;
			public __c__DisplayClass174_0 CS___8__locals1;
			public Action<float> __9__5;
			public TweenCallback __9__6;
	
			// Constructors
			public __c__DisplayClass174_1();
	
			// Methods
			internal void _PlayMainStoryMissionUnlockEffect_b__0();
			internal void _PlayMainStoryMissionUnlockEffect_b__2(float value);
			internal void _PlayMainStoryMissionUnlockEffect_b__3();
			internal void _PlayMainStoryMissionUnlockEffect_b__4();
			internal void _PlayMainStoryMissionUnlockEffect_b__5(float value);
			internal void _PlayMainStoryMissionUnlockEffect_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass176_0
		{
			// Fields
			public MissionSelectPopup popup;
			public QuestCell __4__this;
	
			// Constructors
			public __c__DisplayClass176_0();
	
			// Methods
			internal void _OnStoryMissionButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass179_0
		{
			// Fields
			public GameObject activeBalloon;
	
			// Constructors
			public __c__DisplayClass179_0();
	
			// Methods
			internal bool _SetOrderPartyBalloon_b__0(GameObject x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass180_0
		{
			// Fields
			public QuestCell __4__this;
			public GameObject[] baloonObjects;
	
			// Constructors
			public __c__DisplayClass180_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass180_1
		{
			// Fields
			public GameObject baloon;
			public Image[] images;
			public RawImage[] rawImages;
			public int currentState;
			public UnityAction<bool> blinkCallback;
			public __c__DisplayClass180_0 CS___8__locals1;
			public Action<float> __9__1;
	
			// Constructors
			public __c__DisplayClass180_1();
	
			// Methods
			internal void _SetBalloonBlink_b__0(bool visible);
			internal void _SetBalloonBlink_b__1(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass180_2
		{
			// Fields
			public bool visible;
			public __c__DisplayClass180_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass180_2();
	
			// Methods
			internal void _SetBalloonBlink_b__2();
		}
	
		// Constructors
		public QuestCell();
	
		// Methods
		private void Awake();
		private void Update();
		public void SetContent(QuestMainMenuElement mainMenuElement, QuestSelectScene.Difficulty difficulty);
		public void SetContent(QuestEventMenuElement eventMenuElement, QuestUtil.QuestState state = QuestUtil.QuestState.None);
		public void SetContent(List<QuestEventMenuElement> eventMenuElementList);
		public void SetContent(int eventEpilogueId);
		public void SetContent(QuestCellData cellData, SubType givenSubType);
		private void SetInitContent();
		protected void SetBasicContent();
		private void BasicWallContents(QuestWallElement qwd);
		private void ArenaContent(int questSubType);
		private void SetArenaThumbnail(int questSubType, Image image, Action onCompleat);
		private void SetStatusArenaIcon();
		private string GetUnlockConditionString(EventKindType type, int eventId, QuestStoryElement storyData);
		private bool CheckQuestCondition();
		private void ResetSize(RectTransform refRectTransform);
		private void CreateNewEffect(QuestType questType);
		public override void SetStateIcons();
		public void QuestNewIconRootActive(bool enable);
		private void QuestStateIconObjActive(bool enable);
		public virtual void OnClick();
		private bool ShowNextEventSchedulePopup();
		public bool CheckLocalTime(string timeStr);
		private void OnMainQuestDungeonCellClickExecute(int curQuestId);
		private void OnMainQuestCellClicked();
		[IteratorStateMachine]
		private IEnumerator CheckFortDownloadAndGoQuest(int curQuestId);
		private bool IsEnabled();
		private bool IsReleased(QuestCellData cellData);
		private void OnEventQuestDungeonCellClickExecute(int curQuestId);
		private void OnEventQuestCellClicked();
		private void CheckRequiredStamina(int questId, bool isMultiStamina, Action<bool> onEnough);
		private void StartMatchingService(int entryQuestId);
		private void OpenStoryPopup(int curQuestId, QuestGroupType groupType, DownloadOperation downloadOperation = null, DownloadOperation downloadOperationWithoutVoice = null);
		private void DownloadCompleteCallback(int questId, QuestGroupType questGroupType);
		private void CloseStoryPopup();
		private void CloseEventQuestConditionPopup();
		public void SelectSupportor();
		public void OnDetailButtonTouched();
		protected void OnClickDetailPopupClose();
		public override bool SetGradientShader();
		private void SetQuestImageGradientShader();
		public bool IsTargetMainQuest(int questId);
		public bool IsTargetEventQuest(int questId);
		private void CampaignColor(UnityEngine.UI.Text text);
		private void SetStaminaValue(bool isPlayableStamina);
		private void OnDestroy();
		public void ShowStoryMissionLock(bool isShowCount = true);
		public void HideStoryMissionLock();
		public void PlayMainStoryMissionUnlockEffect();
		public void SetQuestDetailButtonOnStoryMissionLockUI();
		public void OnStoryMissionButtonPressed();
		private void SetDragonOnlyBalloon(QuestDataElement questData);
		private void SetLimitedElementalBalloon(QuestDataElement questData);
		private void SetOrderPartyBalloon(int questId, int orderPartyGroupId);
		public void SetBalloonBlink(GameObject[] baloonObjects);
		private void SetAlphaValue(Image[] images, RawImage[] rawImages, float value);
		private void ReleaseBalloonBlinkTween();
		private void SetEventEndText(QuestDataElement qde);
		[CompilerGenerated]
		private bool _SetBasicContent_b__134_1(GameObject x);
		[CompilerGenerated]
		private bool _SetBasicContent_b__134_2(GameObject x);
		[CompilerGenerated]
		private void _SetBasicContent_b__134_0();
		[CompilerGenerated]
		private bool _BasicWallContents_b__135_0(GameObject x);
		[CompilerGenerated]
		private bool _BasicWallContents_b__135_1(GameObject x);
		[CompilerGenerated]
		private void _ArenaContent_b__136_0();
		[CompilerGenerated]
		private void _OnStoryMissionButtonPressed_b__176_0(MissionSelectPopup popup);
	}
}
