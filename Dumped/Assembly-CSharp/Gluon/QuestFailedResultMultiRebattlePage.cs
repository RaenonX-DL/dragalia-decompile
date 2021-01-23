/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestFailedResultMultiRebattlePage : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private QuestResultMultiFriendList[] friendList;
		[SerializeField]
		private UnityEngine.UI.Text rebattleCountDownText;
		[SerializeField]
		private UnityEngine.UI.Text conditionFailedText;
		[SerializeField]
		private Transform friendPanel;
		[SerializeField]
		private CanvasGroup friendCanvas;
		[SerializeField]
		private Transform reBattlePanel;
		[SerializeField]
		private CanvasGroup reBattleCanvas;
		[SerializeField]
		private Button reBattleButton;
		[SerializeField]
		private Button notReBattleButton;
		[SerializeField]
		private Button nextButton;
		[SerializeField]
		private UIAnimationPublisher animationPublisher;
		[SerializeField]
		private UIAnimationPublisher animationPublisherNextButton;
		[SerializeField]
		private float yDiffFirendAnimation;
		private bool isHost;
		private bool isTapToNextFlag;
		private QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info;
		private int selectedFriend;
		private DateTime rebattleStartTime;
		private const string NextSceneMatchingRoom = "PartyBase";
		private bool isConnected;
		private bool isHostWait;
		private const float waitTime = 0.06666667f;
		private EventQuestConditionPopup conditionPopup;
		private QuestResultMultiReBattleConfirm reBattleConfirm;
		private Action onRebbatlePageEnd;
		private bool isOnMultiPageReballePanelDone;
		private bool isMatchingRoomTransition;
		private List<MatchingService.Player> notMyPlayerList;
		private int questId;
		private List<QuestResultModel.FriendApplyModel.SingleFriendApplyInfo> supportList;
		private EnumGuestStete state;
	
		// Properties
		public bool IsTapToNextFlag { get; }
		public EnumGuestStete GuestRebattleSelectState { get; }
	
		// Nested types
		public enum EnumGuestStete
		{
			Prepare = 0,
			WaitHost = 1,
			Exit = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__36_0;
			public static Action __9__36_1;
			public static Action<bool> __9__41_0;
			public static Action __9__41_5;
			public static Action __9__41_3;
			public static Action __9__41_6;
			public static Action __9__42_0;
			public static Action __9__43_2;
			public static Action __9__43_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Update_b__36_0();
			internal void _Update_b__36_1();
			internal void _OnReBattle_b__41_0(bool isRecoveredStamina);
			internal void _OnReBattle_b__41_5();
			internal void _OnReBattle_b__41_3();
			internal void _OnReBattle_b__41_6();
			internal void _OnNotReBattle_b__42_0();
			internal void _checkDisconectType_b__43_2();
			internal void _checkDisconectType_b__43_3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public string nextSceneName;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _OnNotReBattle_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction close;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _PopupHostExitConfirmCreate_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _UpdateReBattle_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestFailedResultMultiRebattlePage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateReBattle_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public QuestFailedResultMultiRebattlePage __4__this;
			public Action onFinished;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _HideRebattlePanel_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public Action loadSceneAction;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _GoNextScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _DelayActionCoroutine_d__54 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delayTime;
			public Action action;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayActionCoroutine_d__54(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestFailedResultMultiRebattlePage();
	
		// Methods
		private void Update();
		public void Initialize(DateTime startTime, bool connection, Action rebattleEnd, int questId, List<MatchingService.Player> matchingPlayerModel);
		private void OnRequestButton(int index);
		private void OnInviteButton(int index);
		private void OnClose(bool onClose);
		public void OnReBattle();
		public void OnNotReBattle();
		private void checkDisconectType();
		private void PopupHostExitConfirmCreate(UnityAction close = null);
		[IteratorStateMachine]
		private IEnumerator UpdateReBattle();
		private void HideRebattlePanel(Action onFinished);
		private void ShowNextButton();
		private void IsReBattleButton(bool enabled);
		private int GetSecondRemain();
		private void Disconnect();
		private void CloseEventQuestConditionPopup();
		private void GoNextScene(Action loadSceneAction);
		private void PlayExitAnimation();
		[IteratorStateMachine]
		private IEnumerator DelayActionCoroutine(float delayTime, Action action);
		[CompilerGenerated]
		private void _Initialize_b__37_0();
		[CompilerGenerated]
		private void _Initialize_b__37_2();
		[CompilerGenerated]
		private void _Initialize_b__37_1();
		[CompilerGenerated]
		private void _OnReBattle_b__41_1(bool isRecoveredStamina);
		[CompilerGenerated]
		private void _OnReBattle_b__41_2();
		[CompilerGenerated]
		private void _OnReBattle_b__41_4();
		[CompilerGenerated]
		private void _checkDisconectType_b__43_0(MultiPlayError.ErrorType error);
		[CompilerGenerated]
		private void _checkDisconectType_b__43_1();
	}
}
