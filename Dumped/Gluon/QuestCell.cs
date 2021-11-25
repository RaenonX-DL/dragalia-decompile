using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.AssetBundle;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestCell : QuestCellBase
	{
		public enum SubType
		{
			Default,
			ShortCutting,
			SubList
		}

		public enum QuestTypeIconType
		{
			solo,
			multi,
			randomMulti,
			none
		}

		private enum CellLockStatus
		{
			Open,
			Lock,
			NotOpenPeriod
		}

		public UnityAction<QuestCellData> pressedCallback;

		public UnityAction<QuestCellData> disableToJoinCallback;

		public UnityAction dataUpdateCallBack;

		public Action missionCloseCallBack;

		public Button baseButton;

		public Text title;

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
		protected Text storyTitle;

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
		protected Text dungeonIndex;

		[SerializeField]
		protected Text storyIndex;

		[SerializeField]
		protected Image _dungeonArrow;

		[SerializeField]
		protected Image _storyArrow;

		[SerializeField]
		protected Image _rightArrow;

		[SerializeField]
		protected GameObject questPowerIconRoot;

		[SerializeField]
		protected Text questPowerValueText;

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
		protected Image questElementIcon2;

		[SerializeField]
		private float questElementIconOffsetX;

		[SerializeField]
		protected Text questQuantityText;

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
		protected Text getItemCountText;

		[SerializeField]
		protected Text questItemNumText;

		[SerializeField]
		protected GameObject questStaminaRoot;

		[SerializeField]
		protected Text questStaminaText;

		[SerializeField]
		protected Text questStaminaNumText;

		[SerializeField]
		protected Color questStaminaZeroColor;

		[SerializeField]
		protected GameObject entryConditionRoot;

		[SerializeField]
		protected Text entryConditionText;

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

		[SerializeField]
		[Header("CollectStory")]
		private GameObject collectLockGO;

		[SerializeField]
		private GameObject collectNeedItemIconGO;

		[SerializeField]
		private Image collectNeedItemIcon;

		[SerializeField]
		private Text collectNeedItemCountText;

		[SerializeField]
		private Text collectInsufficientText;

		[SerializeField]
		[Header("TimeRelease")]
		private GameObject storyTimeReleaseLockGO;

		[SerializeField]
		private Text storyTimeReleaseLockText;

		[SerializeField]
		private GameObject storyTitleGO;

		[SerializeField]
		private QuestPresentLevel questPresentLevel;

		[SerializeField]
		private Text remainTimeText;

		[SerializeField]
		[Header("MainStoryMission")]
		private GameObject mainStoryMissionLockBaseObj;

		[SerializeField]
		private Text mainStoryMissionNameText;

		[SerializeField]
		private Text mainStoryMissionStatusCountText;

		[SerializeField]
		private GameObject mainStoryMissionLockRoot;

		[SerializeField]
		private Button mainStoryMissionMissionButton;

		[SerializeField]
		private CommonSlider missionCountGauge;

		[SerializeField]
		private Badge mainStoryMissionButtonBadge;

		private bool isShowMainStoryMissionLock;

		[SerializeField]
		private GameObject dragonOnly1UnitImage;

		[SerializeField]
		private GameObject dragonOnly4UnitImage;

		[SerializeField]
		private GameObject soloQuestBalloon;

		[SerializeField]
		private CampaignButtons campaignButton;

		[SerializeField]
		private GameObject[] questTypeImages;

		[SerializeField]
		private GameObject questTypePartySwitchImage;

		[SerializeField]
		private float questTypePartySwitchImageSoloOffsetX;

		[SerializeField]
		private float questTypePartySwitchImageMultiOffsetX;

		[SerializeField]
		private GameObject orderPartyBlueBalloon;

		[SerializeField]
		private GameObject orderPartyRedBalloon;

		[SerializeField]
		[Header("Limited Quest")]
		private Graphic limitedTypeBaseIcon;

		[SerializeField]
		private GameObject limitedTypeIconPanel;

		[SerializeField]
		private GameObject eventEndText;

		[SerializeField]
		private Image[] bpBaseImages;

		[SerializeField]
		private Image[] bpOnImages;

		[SerializeField]
		private Image[] bpRedImages;

		[SerializeField]
		private Image bpBaseBarImage;

		private List<QuestEventMenuElement> questEventMenuList;

		public QuestUtil.MainStoryMissionStatus mainStoryMissionStatus;

		protected QuestDetailInfoPopup detailInfoPopup;

		protected Text questIndexText;

		protected GameObject questElementIconObj;

		protected QuestStoryPopup storyPopup;

		protected EventQuestConditionPopup conditionPopup;

		protected Vector2 titleDefaultPos;

		protected Vector2 elementIconDefaultPos;

		protected Vector2 elementIcon2DefaultPos;

		protected RectTransform elementIconRectTrans;

		protected RectTransform elementIcon2RectTrans;

		protected RectTransform questTypePartySwitchRect;

		protected Vector2 questTypePartySwitchImageDefaultPos;

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

		public QuestCellData questCellData
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public SubType subType
		{
			get
			{
				return default(SubType);
			}
			set
			{
			}
		}

		public Image dungeonArrow => null;

		public Image storyArrow => null;

		public Image rightArrow => null;

		public bool isEventEpilogueStory
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetContent(QuestMainMenuElement mainMenuElement, QuestSelectScene.Difficulty difficulty, bool isAlbum = false)
		{
		}

		public void SetContent(QuestEventMenuElement eventMenuElement, QuestUtil.QuestState state = QuestUtil.QuestState.None, bool isAlbum = false)
		{
		}

		public void SetContent(QuestStoryElement questStoryElement, bool isAlbum)
		{
		}

		public void SetContent(List<QuestEventMenuElement> eventMenuElementList)
		{
		}

		public void SetContent(int eventEpilogueId)
		{
		}

		public void SetContent(QuestCellData cellData, SubType givenSubType)
		{
		}

		private static void ShowObjectByScale(GameObject obj, bool isShow)
		{
		}

		private void SetQuestType(QuestTypeIconType type)
		{
		}

		private void SetInitContent()
		{
		}

		protected void SetBasicContent()
		{
		}

		private static void SetQuestElementIcon(Image icon, bool isShowIcon, ElementalType elemental, QuestListCellShaderExchanger shaderExchanger)
		{
		}

		private void BasicWallContents(QuestWallElement qwd)
		{
		}

		private void SetTitleTextPosition()
		{
		}

		private void ArenaContent(int questSubType)
		{
		}

		private void SetArenaThumbnail(int questSubType, Image image, Action onCompleat)
		{
		}

		private void SetStatusArenaIcon()
		{
		}

		private string GetUnlockConditionString(EventKindType type, int eventId, QuestStoryElement storyData)
		{
			return null;
		}

		private bool CheckQuestCondition()
		{
			return default(bool);
		}

		private void ResetSize(RectTransform refRectTransform)
		{
		}

		private void CreateNewEffect(QuestType questType)
		{
		}

		public override void SetStateIcons()
		{
		}

		public void QuestNewIconRootActive(bool enable)
		{
		}

		private void QuestStateIconObjActive(bool enable)
		{
		}

		public virtual void OnClick()
		{
		}

		private bool ShowNextEventSchedulePopup()
		{
			return default(bool);
		}

		private bool ShowNextEventStoryPopup()
		{
			return default(bool);
		}

		public bool CheckLocalTime(string timeStr)
		{
			return default(bool);
		}

		private void OnMainQuestDungeonCellClickExecute(int curQuestId)
		{
		}

		private void OnMainQuestCellClicked()
		{
		}

		private IEnumerator CheckFortDownloadAndGoQuest(int curQuestId)
		{
			return null;
		}

		private bool IsEnabled()
		{
			return default(bool);
		}

		private bool IsReleased(QuestCellData cellData)
		{
			return default(bool);
		}

		private void OnEventQuestDungeonCellClickExecute(int curQuestId)
		{
		}

		private void OnEventQuestCellClicked()
		{
		}

		private void CheckRequiredStamina(int questId, bool isMultiStamina, Action<bool> onEnough)
		{
		}

		private void StartMatchingService(int entryQuestId)
		{
		}

		private void OpenStoryPopup(int curQuestId, QuestGroupType groupType, [Optional] DownloadOperation downloadOperation, [Optional] DownloadOperation downloadOperationWithoutVoice)
		{
		}

		private void DownloadCompleteCallback(int questId, QuestGroupType questGroupType)
		{
		}

		private void CloseStoryPopup()
		{
		}

		private void CloseEventQuestConditionPopup()
		{
		}

		public void SelectSupportor()
		{
		}

		public void OnDetailButtonTouched()
		{
		}

		protected void OnClickDetailPopupClose()
		{
		}

		public override bool SetGradientShader()
		{
			return default(bool);
		}

		private void SetQuestImageGradientShader()
		{
		}

		public bool IsTargetMainQuest(int questId)
		{
			return default(bool);
		}

		public bool IsTargetEventQuest(int questId)
		{
			return default(bool);
		}

		private void CampaignColor(Text text)
		{
		}

		private void SetStaminaValue(bool isPlayableStamina)
		{
		}

		private void OnDestroy()
		{
		}

		public void ShowStoryMissionLock(bool isShowCount = true)
		{
		}

		public void HideStoryMissionLock()
		{
		}

		public void PlayMainStoryMissionUnlockEffect()
		{
		}

		public void SetQuestDetailButtonOnStoryMissionLockUI()
		{
		}

		public void OnStoryMissionButtonPressed()
		{
		}

		private void ShowHowToReleaseQuestPopup()
		{
		}

		public void UpdateStoryMissionBadge()
		{
		}

		private void SetDragonOnlyBalloon(QuestDataElement questData)
		{
		}

		private void SetLimitedType(int questId)
		{
		}

		private void SetOrderPartyBalloon(int questId, int orderPartyGroupId)
		{
		}

		public void SetBalloonBlink(GameObject[] baloonObjects)
		{
		}

		private void SetAlphaValue(Image[] images, RawImage[] rawImages, float value)
		{
		}

		private void ReleaseBalloonBlinkTween()
		{
		}

		private void SetEventEndText(QuestDataElement qde)
		{
		}

		public void SetConsumeValue()
		{
		}

		private void SetConsumeValue(int questId)
		{
		}

		private void SetConsumeMultiStamina(int matchingEntryQuestId, Image baseBarImage, Image[] baseImages, Image[] onImages, Image[] redImages)
		{
		}
	}
}
