/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class QuestAutoTransitionUtil
	{
		// Fields
		private static string backSceneNameForGuest;
		private static MultiJoinBaseLocation multiJoinBaseLocation;
		private static GuestEnterRoomFromType guestEnterRoomFromType;
		private static PartySceneMode partySceneMode;
		[CompilerGenerated]
		private static ReturnDestScene _returnDestFromQuestPrepare_k__BackingField;
	
		// Properties
		public static bool isQuestSelectFlow { get; }
		public static bool isMatchingFlow { get; }
		public static bool isPartySwitchMultiPrepare { get; }
		public static ReturnDestScene returnDestFromQuestPrepare { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum MultiJoinBaseLocation
		{
			None = 0,
			EventQuestTop = 1,
			EventQuestRanking = 2,
			EventQuestSupport = 3,
			NormalEventSelectTop = 4,
			QuestSelectSupport = 5,
			NormalEventSelectSupport = 6,
			GuildTop = 7
		}
	
		public enum GuestEnterRoomFromType
		{
			None = 0,
			EventTab = 1,
			NormalTab = 2,
			IDInput = 3,
			Location = 4,
			RaidTab = 5,
			QuestSupport = 6
		}
	
		public enum PartySceneMode
		{
			Party = 0,
			QuestPrepare = 1,
			Matching = 2,
			PartySwitchMultiPrepare = 3
		}
	
		public enum ReturnDestScene
		{
			QuestSupport = 0,
			NormalEventTop = 1,
			SpecialEventTop = 2,
			GuildTop = 3
		}
	
		[CompilerGenerated]
		private struct _ReturnPrevSceneAsync_d__19 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public string nextSceneName;
			private TaskAwaiter<GuildIndexResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public PartySwitchPopup popup;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _CheckPartySwitch_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public Action exitAfterAction;
			public int questId;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _GoToIngameNormal_b__0();
			internal void _GoToIngameNormal_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public Action onStartFailed;
			public Action startQuestAction;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _CheckQuestStart_b__0(bool isRecoveredStamina);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_1
		{
			// Fields
			public CommonPopup commonPopup;
			public __c__DisplayClass23_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass23_1();
	
			// Methods
			internal void _CheckQuestStart_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_2
		{
			// Fields
			public QuestLimitedConfirmPopup limitedElementalTypePopup;
			public __c__DisplayClass23_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass23_2();
	
			// Methods
			internal void _CheckQuestStart_b__2();
		}
	
		// Constructors
		static QuestAutoTransitionUtil();
	
		// Methods
		public static void ClearGoQuestType();
		public static bool IsGoQuestFromMultiJoin();
		public static bool IsGoQuestFromGuild();
		public static void SaveQuestTransitionLocationFromGuild();
		public static void SaveQuestTransitionLocationFromQuestSelect(MultiJoinBaseLocation joinLocation);
		public static void SaveQuestTransitionLocationFromQuestSelect(int questId);
		public static void SaveQuestTransitionLocationFromMultiJoin(MultiJoinBaseLocation location, GuestEnterRoomFromType enterRoomFromType);
		public static MultiJoinBaseLocation GetMultiJoinBaseLocation();
		public static string GetNextSceneNameFromMultiJoin();
		public static string GetNextSceneNameFromMultiJoin(MultiJoinBaseLocation location);
		public static SceneNameDefine.PageName GetEventQuestFirstPageNameFromMultiJoin(MultiJoinBaseLocation location);
		public static GuestEnterRoomFromType GetLastSelectMultiJoinType();
		public static void SetBackSceneNameForGuest(string sceneName);
		public static string GetBackSceneNameForGuest();
		public static async void ReturnPrevSceneAsync(string nextSceneName);
		public static void ReturnPrevSceneAsyncBeforeQuestForGuest();
		public static void CheckPartySwitch(GameObject parentObject, int questId, Action goPrepareSceneAction);
		public static void GoToIngameNormal(int questId, ulong supportUserId, Action<Action> exitStartAction, Action exitAfterAction);
		public static void CheckQuestStart(GameObject popupParent, int questId, Action startQuestAction, Action onStartFailed, Action<StringBuilder> joinConditionsFailed, Action onTemporaryCharaInParty);
		public static void ClearPartySceneMode();
		public static void GoQuestPrepareScene(int questId, Action changeParentUiAction, ReturnDestScene returnDest);
		public static void GoPartySwitchPrepareScene(int questId, Action changeParentUiAction, ReturnDestScene returnDest, GuestEnterRoomFromType returnShowPopup = GuestEnterRoomFromType.None);
		private static void GoQuestPrepareScene(PartySceneMode mode, int questId, Action changeParentUiAction, ReturnDestScene returnDest, GuestEnterRoomFromType returnShowPopup);
		public static void GoMatchingScene();
	}
}
