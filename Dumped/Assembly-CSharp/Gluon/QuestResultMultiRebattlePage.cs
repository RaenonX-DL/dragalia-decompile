/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultMultiRebattlePage : MonoBehaviour
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
		private UIAnimationPublisher animationPublisher;
		private bool isHost;
		private bool isTapToNextFlag;
		private IngameResultData resultData;
		private QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info;
		private int selectedFriend;
		private DateTime rebattleStartTime;
		private const string NextSceneMatchingRoom = "PartyBase";
		private const string NextSceneMyPage = "MyPage";
		private bool isConnected;
		private bool isHostWait;
		private const float waitTime = 0.06666667f;
		private EventQuestConditionPopup conditionPopup;
		private Action onRebbatlePageEnd;
		private bool isOnMultiPageReballePanelDone;
		private bool isMatchingRoomTransition;
		private List<MatchingService.Player> notMyPlayerList;
		private EnumGuestStete state;
	
		// Properties
		public bool IsTapToNextFlag { get; }
		public EnumGuestStete GuestRebattleSelectState { get; }
	
		// Nested types
		public enum EnumGuestStete
		{
			Prepare = 0,
			WaitTryGame = 1,
			WaitHost = 2,
			Exit = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__32_0;
			public static Action __9__32_1;
			public static Action __9__38_5;
			public static Action __9__38_6;
			public static Action __9__38_8;
			public static Action __9__39_0;
			public static Action __9__40_3;
			public static Action __9__40_4;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Update_b__32_0();
			internal void _Update_b__32_1();
			internal void _OnReBattle_b__38_5();
			internal void _OnReBattle_b__38_6();
			internal void _OnReBattle_b__38_8();
			internal void _OnNotReBattle_b__39_0();
			internal void _checkDisconectType_b__40_3();
			internal void _checkDisconectType_b__40_4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public QuestResultMultiRebattlePage __4__this;
			public int questId;
			public Action<bool> __9__1;
			public UnityAction __9__4;
			public Action<bool> __9__3;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _OnReBattle_b__0();
			internal void _OnReBattle_b__1(bool isRecoveredStamina);
			internal void _OnReBattle_b__2();
			internal void _OnReBattle_b__3(bool isRecoveredStamina);
			internal void _OnReBattle_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_1
		{
			// Fields
			public QuestResultMultiReBattleConfirm popup;
			public __c__DisplayClass38_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass38_1();
	
			// Methods
			internal void _OnReBattle_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public string nextSceneName;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _OnNotReBattle_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction close;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _PopupHostExitConfirmCreate_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _UpdateReBattle_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultMultiRebattlePage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateReBattle_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GoOtherSceneDelayCorutine_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delayTime;
			public Action loadSceneAction;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoOtherSceneDelayCorutine_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestResultMultiRebattlePage();
	
		// Methods
		private void Update();
		public void Initialize(DateTime startTime, bool connection, Action rebattleEnd);
		private bool IsExtraBattleQuest();
		private void onRequestButton(int index);
		private void OnInviteButton(int index);
		private void OnClose(bool onClose);
		public void OnReBattle();
		public void OnNotReBattle();
		private void checkDisconectType();
		private void PopupHostExitConfirmCreate(UnityAction close = null);
		[IteratorStateMachine]
		private IEnumerator UpdateReBattle();
		private void IsReBattleButton(bool enabled);
		private int GetSecondRemain();
		private void Disconnect();
		private void CloseEventQuestConditionPopup();
		private void GoNextScene(Action loadSceneAction);
		[IteratorStateMachine]
		private IEnumerator GoOtherSceneDelayCorutine(Action loadSceneAction, float delayTime);
		[CompilerGenerated]
		private void _Initialize_b__33_0();
		[CompilerGenerated]
		private void _checkDisconectType_b__40_0(MultiPlayError.ErrorType error);
		[CompilerGenerated]
		private void _checkDisconectType_b__40_1();
		[CompilerGenerated]
		private void _checkDisconectType_b__40_2();
		[CompilerGenerated]
		private void _UpdateReBattle_b__42_0();
	}
}
