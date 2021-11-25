using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Event;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingRoomCanvas : PartyUICanvasBase
	{
		private enum NotifyEnum
		{
			roomConditionChangeNofity,
			instructorBonusNofity
		}

		private enum EnumStete
		{
			Initializing,
			Prepare
		}

		[SerializeField]
		private RawImage render3dImage;

		[SerializeField]
		private RoomInfoFrame roomInfo;

		[SerializeField]
		private RoomIdFrame roomIdFrame;

		[SerializeField]
		public Button abilityButton;

		[SerializeField]
		private Button publicButton;

		[SerializeField]
		private Button privateButton;

		[SerializeField]
		private Button locationButton;

		[SerializeField]
		private Button guildButton;

		[SerializeField]
		private Button organizationButton;

		[SerializeField]
		private Text organizationButtonText;

		[SerializeField]
		[Header("QuestButtons")]
		public Button questButton;

		[SerializeField]
		private Button questPrepareButton;

		[SerializeField]
		private Button questReadyButton;

		[SerializeField]
		private Button breakUpButton;

		public UnityAction<int, MatchingService.Room, bool, bool> onChangePlayer;

		[SerializeField]
		private Text exitButtonText;

		[SerializeField]
		private Button stampButton;

		[SerializeField]
		private Toggle skippingCuttToggle;

		[SerializeField]
		[Header("CellPosition")]
		public Transform[] cellPositions;

		[HideInInspector]
		public MatchingRoomCell[] cells;

		[HideInInspector]
		public MatchingRoomScene matchingRoomScene;

		[SerializeField]
		private GameObject roomConditionRoot;

		[SerializeField]
		private Text roomConditionPowerTitle;

		[SerializeField]
		private Text roomConditionPower;

		[SerializeField]
		private Image[] roomConditionElementals;

		[SerializeField]
		private GameObject roomConditionWeaponRoot;

		[SerializeField]
		private Image[] roomConditionWeaponTypes;

		[SerializeField]
		private Button roomConditionChangeButton;

		[SerializeField]
		private Text roomPurposeText;

		[SerializeField]
		private Text clearPartyText;

		[SerializeField]
		private GameObject pagerParent;

		[SerializeField]
		private float pagerWidth;

		[SerializeField]
		private float partyChangeWaitTime;

		[SerializeField]
		[Header("RoomConditionChangeAnimation")]
		private MatchingConditionChangeAnimation[] conditionIconAnimations;

		[SerializeField]
		private float iconAnimationDelayStep;

		[SerializeField]
		private MatchingRoomNotify roomConditionChangeNotify;

		[Header("InstructorAnimation")]
		private MatchingRoomNotify instructorBonusNofity;

		private bool isCheckInstructor;

		[SerializeField]
		[Header("others")]
		private FlashPlayerManager flashPlayerManager;

		private MatchingStampPopup stampPopup;

		private MatchingService matching;

		private EnumStete state;

		private bool notDestroyPhoton;

		public bool isShow16Chara;

		private int totalPower;

		private UnityEvent _onBreakEvent;

		private int pageCount;

		private List<PartyPager> pagers;

		private StepChangeParam requirePowerParam;

		private RoomEntryCondition prevRoomEntryCondition;

		private DateTime prevConditionUpdateTime;

		private const float updateConditionInterval = 1f;

		private bool isEnableRaidBoost;

		private int questId;

		private const string seStamp = "SE_OUT_COMMON_0028";

		private const string matchingRoomCellLeftPrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingRoomCellLeft";

		private const string matchingRoomCellRightPrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingRoomCellRight";

		private const string matchingRoomNotifyPrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingRoomNotify";

		[HideInInspector]
		public List<MatchingService.Room.PackedRoomCharacterStatusInfo> packedRoomInfo;

		public RectTransform edgeToEdgeFrame;

		public Text partyNameText;

		public GameObject partyNameBaseObject;

		public GameObject partyChangeButtonObject;

		private Queue<NotifyEnum> stackNotify;

		private bool notifyAnimationFlag;

		public RawImage Render3dImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEvent onBreakEvent => null;

		protected override void Awake()
		{
		}

		public void OnSceneChanged()
		{
		}

		public void PlayRequireConditionChangedAnimation()
		{
		}

		private void SetRoomConditionPurpose(RoomEntryCondition roomEntryCondition)
		{
		}

		private void InitCondition(RoomEntryCondition roomEntryCondition)
		{
		}

		private void UpdateRoomCondition(RoomEntryCondition roomEntryCondition)
		{
		}

		private void SetupMyRoomSelfPlayer()
		{
		}

		public void Initialize()
		{
		}

		private void InitSkipRaidCuttToggle()
		{
		}

		private void InitConditionChangeFlash(RoomEntryCondition roomEntryCondition)
		{
		}

		private IEnumerator SetTutorialReady()
		{
			return null;
		}

		private void InitializeForDisconnected(MatchingService.Room myRoom, MatchingService.Player player)
		{
		}

		protected override void Update()
		{
		}

		private void CheckMaxPower()
		{
		}

		private void RaiseExecutiveEvent(List<MatchingService.Room.PackedRoomCharacterStatusInfo> prevRoomInfo, List<MatchingService.Room.PackedRoomCharacterStatusInfo> updatedPackedRoom, bool playSelfVoice = false, bool forceReplaceSelf = false)
		{
		}

		private void JoinEvent()
		{
		}

		private void LeaveEvent()
		{
		}

		private void StampEvent(int index, int stampId)
		{
		}

		private void UpdateRoomPlayer()
		{
		}

		private void UpdateRoomPlayer(bool forceReplaceSelf)
		{
		}

		private void UpdateReadyState()
		{
		}

		public void UpdateData()
		{
		}

		private void PlayInstructorAnimation()
		{
		}

		private void QuestButtonEnabledCheck()
		{
		}

		private void SetEnableQuestButton(bool enabled, bool confirmingSuccessionFlag = false)
		{
		}

		private void OnExAbilityButtonPressed()
		{
		}

		private void OnPartyEditPressed()
		{
		}

		private void OnPartySwitchOkPressed()
		{
		}

		private void ShowPartyEditMenu()
		{
		}

		private void GoPartyCharacterScene()
		{
		}

		private void ShowAutoPartySelectDialog(MatchingService.Room myRoom, MatchingService.Player myPlayer)
		{
		}

		private void OnQuestStartPressed()
		{
		}

		private bool IsAllMemberReady()
		{
			return default(bool);
		}

		private void ShowRoomNotFullPopup(Action onOk, Action onCancel)
		{
		}

		private void PopupPowerWarning(Action onOk, Action onCancel)
		{
		}

		private void OnPublicRoomButtonPressed()
		{
		}

		private void OnPrivateRoomButtonPressed()
		{
		}

		private void OnLocationRoomButtonPressed()
		{
		}

		private void OnGuildButtonPressed()
		{
		}

		private void SetMatchingTypeButton(MatchingType matchingType)
		{
		}

		private void OnPlayerStatusIcon(int playerIndex, int partyIndex, int id, int iconType)
		{
		}

		private void OnCharaModelButtonPressed(int index)
		{
		}

		private void OnClickStamp(int stampId)
		{
		}

		public void OnPressedSkipRaidCuttToggle()
		{
		}

		private string GetPrefsKeyIsSkipCuttCheck()
		{
			return null;
		}

		private void SetQuestStartButtonState(MatchingService.Room myRoom, MatchingService.Player myPlayer)
		{
		}

		protected override void OnDestroy()
		{
		}

		private void PopupImpossibleStartConfirmCreate([Optional] UnityAction close)
		{
		}

		private void PopupStartConfirmCreate([Optional] Action ok, [Optional] Action cancel)
		{
		}

		private int GetSumPower()
		{
			return default(int);
		}

		public int GetSinglePower(MatchingRoomPlayerData playerData, int memberIndex)
		{
			return default(int);
		}

		private void OnBreakUpButtonPressed()
		{
		}

		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void PopupContinuousBattleConfirmationWaitingCreate(ButtonWithSelectedImage buttonWithSelectedImage, [Optional] UnityAction ok, [Optional] UnityAction cancel)
		{
		}

		public void OnStampButtonPressed()
		{
		}

		public void OnConditionSettingButtonPressed()
		{
		}

		protected override void RefreshEventBonusIcon()
		{
		}

		protected override void ReloadExAbilityIcon()
		{
		}

		private void DetachFooterCallback()
		{
		}

		private void CreatePager()
		{
		}

		private void UpdatePagerElementImage(int pageIndex)
		{
		}

		private void UpdatePager()
		{
		}

		private void OnPagerPressed(int pressedPagerIndex)
		{
		}

		public void OnPartyChangeButtonPressed()
		{
		}

		private void ChangeParty(int index, int state = -2)
		{
		}

		private void ReloadPartyView(MatchingReadyState prevState)
		{
		}

		private void CheckTemporaryCharaInParty(int oldCurrentPartyIndex)
		{
		}

		private IEnumerator DelayChangeReadyState(MatchingReadyState readyState, float delayTime, TouchGuardObject touchGuard)
		{
			return null;
		}

		private void PlayNotify(NotifyEnum state)
		{
		}

		private IEnumerator PlayNotiryCorutine()
		{
			return null;
		}

		private void SetMyReadyState(MatchingReadyState readyState)
		{
		}
	}
}
