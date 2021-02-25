/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomCanvas : PartyUICanvasBase
	{
		// Fields
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
		[Header]
		[SerializeField]
		public Button questButton;
		[SerializeField]
		private Button questPrepareButton;
		[SerializeField]
		private Button questReadyButton;
		[SerializeField]
		private Button breakUpButton;
		public UnityAction<int, MatchingService.Room, bool, bool> onChangePlayer;
		[SerializeField]
		private UnityEngine.UI.Text exitButtonText;
		[SerializeField]
		private Button stampButton;
		[SerializeField]
		private Toggle skippingCuttToggle;
		[Header]
		[SerializeField]
		public Transform[] cellPositions;
		[HideInInspector]
		public MatchingRoomCell[] cells;
		[HideInInspector]
		public MatchingRoomScene matchingRoomScene;
		[SerializeField]
		private GameObject roomConditionRoot;
		[SerializeField]
		private UnityEngine.UI.Text roomConditionPowerTitle;
		[SerializeField]
		private UnityEngine.UI.Text roomConditionPower;
		[SerializeField]
		private Image[] roomConditionElementals;
		[SerializeField]
		private GameObject roomConditionWeaponRoot;
		[SerializeField]
		private Image[] roomConditionWeaponTypes;
		[SerializeField]
		private Button roomConditionChangeButton;
		[SerializeField]
		private UnityEngine.UI.Text roomPurposeText;
		[SerializeField]
		private UnityEngine.UI.Text clearPartyText;
		[SerializeField]
		private GameObject pagerParent;
		[SerializeField]
		private float pagerWidth;
		[SerializeField]
		private float partyChangeWaitTime;
		[Header]
		[SerializeField]
		private MatchingConditionChangeAnimation[] conditionIconAnimations;
		[SerializeField]
		private float iconAnimationDelayStep;
		[SerializeField]
		private MatchingRoomNotify roomConditionChangeNotify;
		[Header]
		private MatchingRoomNotify instructorBonusNofity;
		private bool isCheckInstructor;
		[Header]
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		private MatchingStampPopup stampPopup;
		private MatchingService matching;
		private EnumStete state;
		private bool notDestroyPhoton;
		public bool isShow16Chara;
		private int totalPower;
		private MatchingRoomPlayerData[] playerData;
		private MatchingRoomPlayerData myPlayerData;
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
		public UnityEngine.UI.Text partyNameText;
		public GameObject partyNameBaseObject;
		public GameObject partyChangeButtonObject;
		private Queue<NotifyEnum> stackNotify;
		private bool notifyAnimationFlag;
	
		// Properties
		public RawImage Render3dImage { get; set; }
		public UnityEvent onBreakEvent { get; }
	
		// Nested types
		private enum NotifyEnum
		{
			roomConditionChangeNofity = 0,
			instructorBonusNofity = 1
		}
	
		private enum EnumStete
		{
			Prepare = 0,
			GoQuest = 1,
			Exit = 2
		}
	
		[CompilerGenerated]
		private sealed class _SetTutorialReady_d__83 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingRoomCanvas __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetTutorialReady_d__83(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_0
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass98_0();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private struct _OnPartyEditPressed_d__99 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public MatchingRoomCanvas __4__this;
			private TaskAwaiter<QuestGetQuestClearPartyMultiResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass100_0
		{
			// Fields
			public MatchingPartyMenuPopup popup;
			public MatchingRoomCanvas __4__this;
			public MatchingService.Room myRoom;
			public MatchingService.Player myPlayer;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass100_0();
	
			// Methods
			internal void _ShowPartyEditMenu_b__0();
			internal void _ShowPartyEditMenu_b__1();
			internal void _ShowPartyEditMenu_b__3();
			internal void _ShowPartyEditMenu_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass101_0
		{
			// Fields
			public AutoPartySelectDialog autoPartySelectDialog;
			public MatchingRoomCanvas __4__this;
			public MatchingService.Player myPlayer;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass101_0();
	
			// Methods
			internal void _ShowAutoPartySelectDialog_b__0();
			internal void _ShowAutoPartySelectDialog_b__2();
			internal void _ShowAutoPartySelectDialog_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ErrorType, int> __9__101_3;
			public static Action __9__102_0;
			public static UnityAction __9__121_2;
			public static Action<ErrorType, int> __9__136_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ShowAutoPartySelectDialog_b__101_3(ErrorType type, int resultCode);
			internal void _OnQuestStartPressed_b__102_0();
			internal void _OnBreakUpButtonPressed_b__121_2();
			internal void _ChangeParty_b__136_1(ErrorType error, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass102_0
		{
			// Fields
			public MatchingRoomCanvas __4__this;
			public bool isRoomFull;
	
			// Constructors
			public __c__DisplayClass102_0();
	
			// Methods
			internal void _OnQuestStartPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass102_1
		{
			// Fields
			public ButtonWithSelectedImage selectedImage;
			public Action tryGameStart;
			public Action onCancel;
			public Action tryPowerWarningCheck;
			public Action tryBlockedCharaCheck;
			public __c__DisplayClass102_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass102_1();
	
			// Methods
			internal void _OnQuestStartPressed_b__1();
			internal void _OnQuestStartPressed_b__3();
			internal void _OnQuestStartPressed_b__4();
			internal void _OnQuestStartPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_0
		{
			// Fields
			public Action onOk;
			public Action onCancel;
	
			// Constructors
			public __c__DisplayClass103_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass103_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass103_1();
	
			// Methods
			internal void _ShowRoomNotFullPopup_b__0();
			internal void _ShowRoomNotFullPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass104_0
		{
			// Fields
			public CommonPopup popup;
			public Action onOk;
			public Action onCancel;
	
			// Constructors
			public __c__DisplayClass104_0();
	
			// Methods
			internal void _PopupPowerWarning_b__0();
			internal void _PopupPowerWarning_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass117_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction close;
	
			// Constructors
			public __c__DisplayClass117_0();
	
			// Methods
			internal void _PopupImpossibleStartConfirmCreate_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass118_0
		{
			// Fields
			public CommonPopup popup;
			public Action cancel;
			public Action ok;
	
			// Constructors
			public __c__DisplayClass118_0();
	
			// Methods
			internal void _PopupStartConfirmCreate_b__0();
			internal void _PopupStartConfirmCreate_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass121_0
		{
			// Fields
			public MatchingRoomCanvas __4__this;
			public QuestEventGroupElement qege;
	
			// Constructors
			public __c__DisplayClass121_0();
	
			// Methods
			internal void _OnBreakUpButtonPressed_b__0();
			internal void _OnBreakUpButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass122_0
		{
			// Fields
			public MatchingRoomCanvas __4__this;
			public Footer.MenuTab tabType;
			public string tabName;
	
			// Constructors
			public __c__DisplayClass122_0();
	
			// Methods
			internal void _FooterButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass123_0
		{
			// Fields
			public MatchingRoomCanvas __4__this;
			public Footer.MenuTab tabType;
			public string tabName;
	
			// Constructors
			public __c__DisplayClass123_0();
	
			// Methods
			internal void _FooterButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass124_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction cancel;
			public ButtonWithSelectedImage buttonWithSelectedImage;
	
			// Constructors
			public __c__DisplayClass124_0();
	
			// Methods
			internal void _PopupContinuousBattleConfirmationWaitingCreate_b__0();
			internal void _PopupContinuousBattleConfirmationWaitingCreate_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass126_0
		{
			// Fields
			public MatchingConditionPopup popup;
			public MatchingRoomCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass126_0();
	
			// Methods
			internal void _OnConditionSettingButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass134_0
		{
			// Fields
			public MatchingRoomCanvas __4__this;
			public PartyChangePopup popup;
			public MatchingReadyState prevState;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass134_0();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__0(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__1(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__3();
			internal void _OnPartyChangeButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass136_0
		{
			// Fields
			public MatchingReadyState prevState;
			public MatchingRoomCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass136_0();
	
			// Methods
			internal void _ChangeParty_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass138_0
		{
			// Fields
			public MatchingRoomCanvas __4__this;
			public int oldCurrentPartyIndex;
	
			// Constructors
			public __c__DisplayClass138_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass138_1
		{
			// Fields
			public CommonPopup errorPopup;
			public __c__DisplayClass138_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass138_1();
	
			// Methods
			internal void _CheckTemporaryCharaInParty_b__0();
			internal void _CheckTemporaryCharaInParty_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _DelayChangeReadyState_d__139 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delayTime;
			public MatchingReadyState readyState;
			public MatchingRoomCanvas __4__this;
			public TouchGuardObject touchGuard;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayChangeReadyState_d__139(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayNotiryCorutine_d__141 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingRoomCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayNotiryCorutine_d__141(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MatchingRoomCanvas();
	
		// Methods
		protected override void Awake();
		public void OnSceneChanged();
		public void PlayRequireConditionChangedAnimation();
		private void SetRoomConditionPurpose(RoomEntryCondition roomEntryCondition);
		private void InitCondition(RoomEntryCondition roomEntryCondition);
		private void UpdateRoomCondition(RoomEntryCondition roomEntryCondition);
		private void SetupMyRoomSelfPlayer();
		public void Initialize();
		private void InitSkipRaidCuttToggle();
		private void InitConditionChangeFlash(RoomEntryCondition roomEntryCondition);
		[IteratorStateMachine]
		private IEnumerator SetTutorialReady();
		private void InitializeForDisconnected(MatchingService.Room myRoom, MatchingService.Player player);
		protected override void Update();
		private void CheckMaxPower();
		private void RaiseExecutiveEvent(List<MatchingService.Room.PackedRoomCharacterStatusInfo> prevRoomInfo, List<MatchingService.Room.PackedRoomCharacterStatusInfo> updatedPackedRoom, bool playSelfVoice = false, bool forceReplaceSelf = false);
		private void JoinEvent();
		private void LeaveEvent();
		private void StampEvent(int index, int stampId);
		private void UpdateRoomPlayer();
		private void UpdateRoomPlayer(bool forceReplaceSelf);
		private void UpdateReadyState();
		public void UpdateData();
		private void PlayInstructorAnimation();
		private void QuestButtonEnabledCheck();
		private void SetEnableQuestButton(bool enabled, bool confirmingSuccessionFlag = false);
		private void OnExAbilityButtonPressed();
		private async void OnPartyEditPressed();
		private void ShowPartyEditMenu();
		private void ShowAutoPartySelectDialog(MatchingService.Room myRoom, MatchingService.Player myPlayer);
		private void OnQuestStartPressed();
		private void ShowRoomNotFullPopup(Action onOk, Action onCancel);
		private void PopupPowerWarning(Action onOk, Action onCancel);
		private void OnPublicRoomButtonPressed();
		private void OnPrivateRoomButtonPressed();
		private void OnLocationRoomButtonPressed();
		private void OnGuildButtonPressed();
		private void SetMatchingTypeButton(MatchingType matchingType);
		private void OnPlayerStatusIcon(int playerIndex, int partyIndex, int id, int iconType);
		private void OnCharaModelButtonPressed(int index);
		private void OnClickStamp(int stampId);
		public void OnPressedSkipRaidCuttToggle();
		private string GetPrefsKeyIsSkipCuttCheck();
		private void SetQuestStartButtonState(MatchingService.Room myRoom, MatchingService.Player myPlayer);
		protected override void OnDestroy();
		private void PopupImpossibleStartConfirmCreate(UnityAction close = null);
		private void PopupStartConfirmCreate(Action ok = null, Action cancel = null);
		private int GetSumPower();
		public int GetSinglePower(MatchingRoomPlayerData playerData, int memberIndex);
		private void OnBreakUpButtonPressed();
		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType);
		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType);
		private void PopupContinuousBattleConfirmationWaitingCreate(ButtonWithSelectedImage buttonWithSelectedImage, UnityAction ok = null, UnityAction cancel = null);
		public void OnStampButtonPressed();
		public void OnConditionSettingButtonPressed();
		protected override void RefreshEventBonusIcon();
		protected override void ReloadExAbilityIcon();
		private void DetachFooterCallback();
		private void CreatePager();
		private void UpdatePagerElementImage(int pageIndex);
		private void UpdatePager();
		private void OnPagerPressed(int pressedPagerIndex);
		public void OnPartyChangeButtonPressed();
		private bool IsLimitedElemental(int partyIndex);
		private void ChangeParty(int index, int state = -2);
		private void ReloadPartyView(MatchingReadyState prevState);
		private void CheckTemporaryCharaInParty(int oldCurrentPartyIndex);
		[IteratorStateMachine]
		private IEnumerator DelayChangeReadyState(MatchingReadyState readyState, float delayTime, TouchGuardObject touchGuard);
		private void PlayNotify(NotifyEnum state);
		[IteratorStateMachine]
		private IEnumerator PlayNotiryCorutine();
		[CompilerGenerated]
		private void _Initialize_b__80_0();
		[CompilerGenerated]
		private void _Initialize_b__80_1();
		[CompilerGenerated]
		private void _CreatePager_b__130_0(int index);
	}
}
