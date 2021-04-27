/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NormalEventSelectUiCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private Canvas _uiCanvas;
		private UnityAction backButtonSoundAction;
		[SerializeField]
		private Button backButton;
		private UnityAction _unityAction;
		private bool _isOpen;
		public Button multiJoinButton;
		public Button treasureTradeButton;
		[SerializeField]
		private CanvasGroup canvasGroup;
		private NormalEventSelectScene.QuestSelectSceneType nowType;
		public QuestEventDetailBannerPage eventDetailBanner;
		[SerializeField]
		private UIAnimationPublisher topButtomAnimation;
		[SerializeField]
		private UIAnimationPublisher subButtomAnimation;
		[SerializeField]
		private float topButtomAnimationEnterDelay;
		public UnityAction<QuestSelectInstance.QuestEventData> actionScrollCell;
		[SerializeField]
		private Button[] balloonButtons;
		[SerializeField]
		private GameObject bonusSlideButtonObj;
		[SerializeField]
		private GameObject newSlideButtonObj;
		private QuestAutoTransitionUtil.GuestEnterRoomFromType multiJoinTypeOnBegin;
		private SceneBase parentScene;
	
		// Properties
		public Canvas uiCanvas { get; }
		public UnityAction unityAction { get; }
		public bool isOpen { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DelayAction_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delaySeconds;
			public NormalEventSelectUiCanvas __4__this;
			public UnityAction action;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayAction_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public MatchingTypeSelectPopup popup;
			public NormalEventSelectUiCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _ShowMatchingRoomListPopup_b__0();
			internal void _ShowMatchingRoomListPopup_b__1();
			internal void _ShowMatchingRoomListPopup_b__2();
			internal void _ShowMatchingRoomListPopup_b__3();
		}
	
		// Constructors
		public NormalEventSelectUiCanvas();
	
		// Methods
		protected override void Awake();
		public void Initialize(SceneBase parentScene);
		public void SetSlideButton();
		public void SetBackButtonCallback(NormalEventSelectScene.QuestSelectSceneType type, UnityAction unityAction, bool isAnimStop = true);
		public void StartExitAnimation();
		public void DeleteBackButtonCallback();
		private void PlayTopEnterAnimation();
		public void PlayEventTopExitAnimation();
		private void ShowEventTopButton(bool bShow);
		public void SetChangeStatus(NormalEventSelectScene.QuestSelectSceneType type);
		public void SetQuestSelectUiData(NormalEventSelectScene.QuestSelectSceneType type, UnityAction backButtonAction = null);
		[IteratorStateMachine]
		private IEnumerator DelayAction(UnityAction action, float delaySeconds);
		public void SetButtonActive();
		public void SetAllButtonsEnabled(bool isEnabled);
		public void OnMultiJoinButtonPressed();
		public void OnTreasureTradePressed();
		public void OnBalloonJumpNewQuestButtonPressed();
		public void OnBalloonJumpDailyBonusButtonPressed();
		private QuestSelectInstance.QuestEventData FindDailyBonusRemainEvent();
		private bool FindDailyBonusRemainEvent(QuestEventElement eventElement);
		private QuestSelectInstance.QuestEventData FindNewIconRemainEvent();
		private bool IsNewIconRemainEvent(QuestSelectInstance.QuestEventData eventData);
		public void ShowRoomListPopup(QuestAutoTransitionUtil.GuestEnterRoomFromType enterRoomFromType);
		public void ShowIdInputPopup(bool searchPrevRoom);
		private void ShowGpsSearchPopup();
		private void ShowMatchingRoomListPopup();
		private void SetParentUiQuestPrepareMode();
		private void GoPrepareScene(int questId, QuestAutoTransitionUtil.GuestEnterRoomFromType enterFromType);
		public void ReserveMultiJoinPopup(QuestAutoTransitionUtil.GuestEnterRoomFromType joinTypeOnBegin);
		public void ShowMultiJoinPopupOnBegin();
		[CompilerGenerated]
		private void _SetBackButtonCallback_b__29_0();
		[CompilerGenerated]
		private void _PlayTopEnterAnimation_b__32_0();
		[CompilerGenerated]
		private void _PlayEventTopExitAnimation_b__33_0();
		[CompilerGenerated]
		private void _SetChangeStatus_b__35_0();
		[CompilerGenerated]
		private void _OnMultiJoinButtonPressed_b__40_0();
	}
}
