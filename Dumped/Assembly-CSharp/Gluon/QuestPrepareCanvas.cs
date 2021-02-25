/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Cute.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPrepareCanvas : PartyUICanvasBase
	{
		// Fields
		[HideInInspector]
		public QuestPrepareScene questPrepareScene;
		public PartyPageViewBase pageView;
		public UnityAction partyEditCallBack;
		public UnityAction questStartCallBack;
		[SerializeField]
		private GameObject questDifficultyIconRoot;
		[SerializeField]
		private GameObject questElementIconRoot0;
		[SerializeField]
		private GameObject questElementIconRoot;
		public static readonly float lackOfPowerWarningThresholdRatio;
		private const string clearSEName = "SE_OUT_COMMON_0054";
		public RawImage render3dImage;
		public Transform pageViewContentParent;
		public GameObject questInfoBase;
		public UnityEngine.UI.Text questInfoText;
		public Button clearPartyButton;
		public Button supportChangeButton;
		public Button partyEditButton;
		[SerializeField]
		private Image partyEditNormalImage;
		[SerializeField]
		private Image partyEditSelectedImage;
		public Image supportSkillIcon;
		public UnityEngine.UI.Text clearPartyText;
		public UnityEngine.UI.Text questName;
		public float runAnimationDistance;
		public QuestPrepareUIStatus[] partyStatus;
		public Image leadImage;
		public GameObject statusBase;
		[SerializeField]
		private Button questStartButton;
		[SerializeField]
		private GameObject partyCheckRoot;
		[SerializeField]
		private GameObject questSkipRoot;
		[SerializeField]
		private Button questSkipButton;
		[SerializeField]
		private Image questSkipDisabledImage;
		[SerializeField]
		private Image questSkipNotSatisfyConditionsImage;
		[SerializeField]
		private UnityEngine.UI.Text questSkipTicketNumText;
		[SerializeField]
		private UnityEngine.UI.Text questSkipButtonTitleText;
		[SerializeField]
		private UnityEngine.UI.Text questSkipTicketUseText;
		[SerializeField]
		private Button normalPartyButton;
		[SerializeField]
		private GameObject dragonOnlyIcon;
		[SerializeField]
		private GameObject dragonOnlyBallon1Unit;
		[SerializeField]
		private GameObject dragonOnlyBallon4Unit;
		[SerializeField]
		private GameObject soloQuestBalloon;
		public QuestPrepareRepeatButton repeatButton;
		private SceneUICanvas sceneUiCanvas;
		private GameObject questDifficultyIconObj;
		private GameObject questElementIconObj0;
		private GameObject questElementIconObj;
		private QuestSkipTicketConfirmPopup skipConfirmPopup;
		protected EventQuestConditionPopup conditionPopup;
		private bool isPartyEditPressed;
		private bool isPartyEditOpened;
		[CompilerGenerated]
		private QuestPreparePageView _pageCtrl_k__BackingField;
		public RectTransform edgeToEdgeFrame;
		[Header]
		[SerializeField]
		public RectTransform partyBaseMoveTo;
		public RectTransform learderImageMoveTo;
		public RectTransform statusMoveTo;
		public RectTransform switchButtonMoveTo;
		[Header]
		[SerializeField]
		public UIAnimationPublisher enterExitPublisherPublisher;
		public UIAnimationPublisher goCharacterPublisher1;
		public UIAnimationPublisher goCharacterPublisher2;
		public UIAnimationPublisher goEquipPublisher1;
		public UIAnimationPublisher goEquipPublisher2;
		[Header]
		[SerializeField]
		public GameObject[] questReadyPawEventObjects;
		public FlashPlayerManager flashPlayerManager;
		private FlashPlayer questReadyPawMainEventFlash;
		public Transform questReadyPawMainEventFlashParent;
		public float questReadyPawMainOffsetY;
		private FlashPlayer questReadyPawLowerEventFlash;
		public Transform questReadyPawLowerEventFlashParent;
		public float questReadyPawLowerOffsetY;
		[Header]
		[SerializeField]
		public PointerEventHandler[] characterTransparentButtonsEventHandler;
		private bool isGoPartyCharacter;
		private bool isScreenCaptureEnd;
		[HideInInspector]
		public int questId;
		public UnityEngine.UI.Text partyNameText;
		public GameObject partyNameBaseObject;
		public GameObject partyChangeButtonObject;
	
		// Properties
		public GameObject charaModelBase { get; }
		public QuestPreparePageView pageCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ActivateStatusDelay_d__84 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestPrepareCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ActivateStatusDelay_d__84(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_0
		{
			// Fields
			public SkillAbilityDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass87_0();
	
			// Methods
			internal void _OnSupportSkillIconPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_0
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass94_0();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction closeCallBack;
	
			// Constructors
			public __c__DisplayClass105_0();
	
			// Methods
			internal void _ShowQuestOrderPartyCautionPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass106_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction questStartCallBack;
			public QuestPrepareCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass106_0();
	
			// Methods
			internal void _MakeLackOfPowerPopup_b__0();
			internal void _MakeLackOfPowerPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass108_0
		{
			// Fields
			public UnityAction onSucceed;
			public QuestPrepareCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass108_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass108_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass108_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass108_1();
	
			// Methods
			internal void _CheckOverrideQuest_b__0();
			internal void _CheckOverrideQuest_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _PartyCharacterButtonUpDelayRoutine_d__117 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public QuestPrepareCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PartyCharacterButtonUpDelayRoutine_d__117(int __1__state);
	
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
			public QuestLimitedElementConfirmPopup limitedElementalTypePopup;
			public QuestPrepareCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass119_0();
	
			// Methods
			internal void _OnSkipButton_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass123_0
		{
			// Fields
			public QuestPrepareCanvas __4__this;
			public int playCount;
	
			// Constructors
			public __c__DisplayClass123_0();
	
			// Methods
			internal void _OnSkipConfirmPopupOk_b__0(bool isRecoveredStamina);
		}
	
		[CompilerGenerated]
		private sealed class _LoadSceneCoroutine_d__129 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestPrepareCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSceneCoroutine_d__129(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitExitAnim_d__130 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitExitAnim_d__130(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass136_0
		{
			// Fields
			public QuestPrepareCanvas __4__this;
			public MatchingPartyMenuPopup popup;
	
			// Constructors
			public __c__DisplayClass136_0();
	
			// Methods
			internal void _OnCharaPartyButtonTouched_b__0();
			internal void _OnCharaPartyButtonTouched_b__1();
			internal void _OnCharaPartyButtonTouched_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass136_1
		{
			// Fields
			public AutoPartySelectDialog autoPartySelectDialog;
			public __c__DisplayClass136_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass136_1();
	
			// Methods
			internal void _OnCharaPartyButtonTouched_b__3();
			internal void _OnCharaPartyButtonTouched_b__4();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ErrorType, int> __9__136_5;
			public static Action __9__137_0;
			public static Action __9__137_1;
			public static Action<ErrorType, int> __9__148_4;
			public static Action<ErrorType, int> __9__150_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnCharaPartyButtonTouched_b__136_5(ErrorType type, int resultCode);
			internal void _GoPartyCharacterScene_b__137_0();
			internal void _GoPartyCharacterScene_b__137_1();
			internal void _OnPartyChangeButtonPressed_b__148_4(ErrorType error, int resultCode);
			internal void _UpdateCanvasAction_b__150_1(ErrorType error, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class _WaitLastAnimationInnerMoveEnd_d__140 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestPrepareCanvas __4__this;
			public Action onFinished;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitLastAnimationInnerMoveEnd_d__140(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass142_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public QuestPrepareCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass142_0();
	
			// Methods
			internal void _OnBgAnimationFinished_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass148_0
		{
			// Fields
			public PartyChangePopup popup;
			public QuestPrepareCanvas __4__this;
			public Action __9__5;
	
			// Constructors
			public __c__DisplayClass148_0();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__0(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__1(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__5();
			internal void _OnPartyChangeButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass148_1
		{
			// Fields
			public bool isOtherGroupLoad;
			public __c__DisplayClass148_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass148_1();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass149_0
		{
			// Fields
			public PartySwitchPopup popup;
			public QuestPrepareCanvas __4__this;
			public int oldPartyIndex;
			public int oldPartySwitchIndex;
	
			// Constructors
			public __c__DisplayClass149_0();
	
			// Methods
			internal void _OnPartyChackButtonPressed_b__0();
		}
	
		// Constructors
		public QuestPrepareCanvas();
		static QuestPrepareCanvas();
	
		// Methods
		private void Start();
		public void SetupAndStartEnterAnimation();
		private void SetElementIcon();
		public void ReflechSkipTicketStatus(int questId);
		public void ReflechSkipTicketStatusWall(int wallId);
		[IteratorStateMachine]
		private IEnumerator ActivateStatusDelay();
		public void RefreshSupportInfo();
		public void ShowSupportInfo(bool hasSupporter);
		public void OnSupportSkillIconPressed();
		public void SetPageContent(GameObject page, int index);
		private void SavePartySwichIndex();
		public void CharaModelPressed(int tag);
		public void CharaModelLongPressed(int tag);
		public void ShowClearParty(bool isAutoSelect = false);
		public void ShowNormalParty(bool isAutoSelect = false);
		public void OnExAbilityButtonPressed();
		public void PartyEditPressed();
		public void QuestStartPressed();
		private void OnJoinConditionsFailed(StringBuilder failedDescription);
		private void OnTemporaryCharaInParty();
		private void CheckAfterCheckStamina();
		private bool IsLackOfPartyPower();
		private bool IsNotSuperiorElement();
		private ElementalType GetSuperiorElementalType();
		private ElementalType GetCurrentElementalType();
		private bool IsMakeNotMatchElementPopup();
		public void ShowQuestOrderPartyCautionPopup(string cautionText, UnityAction closeCallBack = null);
		private void MakeLackOfPowerPopup(UnityAction questStartCallBack);
		private void MakeNotMatchElementPopup(bool isLackOfPower, UnityAction questStartCallBack);
		private void CheckOverrideQuest(UnityAction onSucceed);
		private void CloseEventQuestConditionPopup();
		public void ResetQuestButtonImage();
		private void ResetQuestSkipButtonImage();
		public void SetupPowerParam();
		protected override void ReloadExAbilityIcon();
		protected override void RefreshUnionBonus();
		public void OnPartyButtonUp();
		private void PartyCharacterButtonUpDelay(float delay);
		[IteratorStateMachine]
		private IEnumerator PartyCharacterButtonUpDelayRoutine(float delay);
		public void OnPartyButtonDown();
		public void OnSkipButton();
		public void OnSkipDisabledButton();
		private bool IsLackOfTicket();
		public void OnSkipNotSatisfyConditions();
		public void OnSkipConfirmPopupOk();
		public void OnSkipTicket();
		public void OnSkipConfirmPopupCancel();
		public void QuestStartApi(int playCount);
		private void onSkipSuccess();
		private void LoadResultScene();
		[IteratorStateMachine]
		private IEnumerator LoadSceneCoroutine();
		[IteratorStateMachine]
		private IEnumerator WaitExitAnim();
		private void onSkipError(ErrorType errorType, int resultCode);
		private void SetClearPartyEnable(bool enable);
		public void OnClearPartyButtonTouched();
		public void OnNormalPartyButtonTouched();
		private void OnCharactersExchangeByJumping();
		public void OnCharaPartyButtonTouched();
		public void GoPartyCharacterScene();
		public void StartGoCharacterSceneAnimation(Action onFinished, Action onHalfFinished = null);
		public void StartGoEquipSceneAnimation(Action onFinished, Action onHalfFinished = null);
		[IteratorStateMachine]
		private IEnumerator WaitLastAnimationInnerMoveEnd(Action onFinished);
		public void AdjustInnerAnimationOffset();
		public void OnBgAnimationFinished();
		private FlashPlayer InitializeFlash(string path, float offsetY, Transform parent);
		private void OnQuestReadyPawFlashEnded(TouchGuardObject touchGuard);
		private void SetQuestReadyPawEventObjectEnable(bool enable);
		private void SetDragonOnlyIcon(QuestDataElement questData);
		private void SetDisabledImage(bool isActive);
		public void OnPartyChangeButtonPressed();
		public void OnPartyChackButtonPressed();
		private void UpdateCanvasAction();
		private void ReloadPartyView();
		public void OnPartyNameEditButtonPressed();
		protected override void SetStatusMode(PartyModel.PartySceneUnitStatusMode statusMode);
		private void SetUIStatusForQuestOrderParty();
		[CompilerGenerated]
		private void _SetupAndStartEnterAnimation_b__80_0();
		[CompilerGenerated]
		private void _SetupAndStartEnterAnimation_b__80_1();
		[CompilerGenerated]
		private void _SetupAndStartEnterAnimation_b__80_2(PointerEventData x);
		[CompilerGenerated]
		private void _SetupAndStartEnterAnimation_b__80_3(PointerEventData x);
		[CompilerGenerated]
		private void _SetupAndStartEnterAnimation_b__80_4(PointerEventData x);
		[CompilerGenerated]
		private void _SetupAndStartEnterAnimation_b__80_5(PointerEventData x);
		[CompilerGenerated]
		private void _onSkipSuccess_b__127_0();
		[CompilerGenerated]
		private bool _LoadSceneCoroutine_b__129_0();
		[CompilerGenerated]
		private void _onSkipError_b__131_0();
		[CompilerGenerated]
		private void _GoPartyCharacterScene_b__137_2();
		[CompilerGenerated]
		private bool _WaitLastAnimationInnerMoveEnd_b__140_0();
		[CompilerGenerated]
		private void _UpdateCanvasAction_b__150_0();
		[CompilerGenerated]
		private void _OnPartyNameEditButtonPressed_b__152_0(string newName);
	}
}
