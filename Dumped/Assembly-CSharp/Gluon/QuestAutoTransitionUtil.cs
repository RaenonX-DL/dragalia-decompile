/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class QuestAutoTransitionUtil
	{
		// Fields
		private static string backSceneNameForGuest;
		private static MultiJoinBaseLocation multiJoinBaseLocation;
	
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
	
		[CompilerGenerated]
		private struct _ReturnPrevSceneAsync_d__17 : IAsyncStateMachine
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
	
		// Constructors
		static QuestAutoTransitionUtil();
	
		// Methods
		public static void ClearGoQuestType();
		public static bool IsGoQuestFromMultiJoin();
		public static bool IsGoQuestFromGuild();
		public static void SaveQuestTransitionLocationFromGuild();
		public static void SaveQuestTransitionLocationFromQuestSelect(MultiJoinBaseLocation joinLocation);
		public static void SaveQuestTransitionLocationFromQuestSelect(int questId);
		public static void SaveQuestTransitionLocationFromMultiJoin(MultiJoinBaseLocation location, MatchingRoomScene.GuestEnterRoomFromType enterRoomFromType);
		public static MultiJoinBaseLocation GetMultiJoinBaseLocation();
		public static string GetNextSceneNameFromMultiJoin();
		public static string GetNextSceneNameFromMultiJoin(MultiJoinBaseLocation location);
		public static SceneNameDefine.PageName GetEventQuestFirstPageNameFromMultiJoin(MultiJoinBaseLocation location);
		public static MatchingRoomScene.GuestEnterRoomFromType GetLastSelectMultiJoinType();
		public static void SetBackSceneNameForGuest(string sceneName);
		public static string GetBackSceneNameForGuest();
		public static async void ReturnPrevSceneAsync(string nextSceneName);
		public static void ReturnPrevSceneAsyncBeforeQuestForGuest();
	}
}
