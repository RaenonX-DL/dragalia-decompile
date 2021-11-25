using System;
using System.Runtime.CompilerServices;
using System.Text;
using UniRx.Async;
using UnityEngine;

namespace Gluon
{
	public static class QuestAutoTransitionUtil
	{
		public enum MultiJoinBaseLocation
		{
			None,
			EventQuestTop,
			EventQuestRanking,
			EventQuestSupport,
			NormalEventSelectTop,
			QuestSelectSupport,
			NormalEventSelectSupport,
			GuildTop
		}

		public enum GuestEnterRoomFromType
		{
			None,
			EventTab,
			NormalTab,
			IDInput,
			Location,
			RaidTab,
			QuestSupport
		}

		public enum PartySceneMode
		{
			Party,
			QuestPrepare,
			Matching,
			PartySwitchMultiPrepare
		}

		public enum ReturnDestScene
		{
			QuestSupport,
			NormalEventTop,
			SpecialEventTop,
			GuildTop
		}

		private static string backSceneNameForGuest;

		private static MultiJoinBaseLocation multiJoinBaseLocation;

		private static GuestEnterRoomFromType guestEnterRoomFromType;

		private static PartySceneMode partySceneMode;

		public static bool isQuestSelectFlow => default(bool);

		public static bool isMatchingFlow => default(bool);

		public static bool isPartySwitchMultiPrepare => default(bool);

		public static ReturnDestScene returnDestFromQuestPrepare
		{
			[CompilerGenerated]
			get
			{
				return default(ReturnDestScene);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void ClearGoQuestType()
		{
		}

		public static bool IsGoQuestFromMultiJoin()
		{
			return default(bool);
		}

		public static bool IsGoQuestFromGuild()
		{
			return default(bool);
		}

		public static void SaveQuestTransitionLocationFromGuild()
		{
		}

		public static void SaveQuestTransitionLocationFromQuestSelect(MultiJoinBaseLocation joinLocation)
		{
		}

		public static void SaveQuestTransitionLocationFromQuestSelect(int questId)
		{
		}

		public static void SaveQuestTransitionLocationFromMultiJoin(MultiJoinBaseLocation location, GuestEnterRoomFromType enterRoomFromType)
		{
		}

		public static MultiJoinBaseLocation GetMultiJoinBaseLocation()
		{
			return default(MultiJoinBaseLocation);
		}

		public static string GetNextSceneNameFromMultiJoin()
		{
			return null;
		}

		public static string GetNextSceneNameFromMultiJoin(MultiJoinBaseLocation location)
		{
			return null;
		}

		public static SceneNameDefine.PageName GetEventQuestFirstPageNameFromMultiJoin(MultiJoinBaseLocation location)
		{
			return default(SceneNameDefine.PageName);
		}

		public static GuestEnterRoomFromType GetLastSelectMultiJoinType()
		{
			return default(GuestEnterRoomFromType);
		}

		public static void SetBackSceneNameForGuest(string sceneName)
		{
		}

		public static string GetBackSceneNameForGuest()
		{
			return null;
		}

		public static void ReturnPrevSceneAsync(string nextSceneName)
		{
		}

		public static void ReturnPrevSceneAsyncBeforeQuestForGuest()
		{
		}

		public static void CheckPartySwitch(GameObject parentObject, int questId, Action goPrepareSceneAction)
		{
		}

		public static void GoToIngameNormal(int questId, ulong supportUserId, Action<Action> exitStartAction, Action exitAfterAction)
		{
		}

		public static void CheckQuestStart(GameObject popupParent, int questId, Action startQuestAction, Action onStartFailed, Action<StringBuilder> joinConditionsFailed, Action onTemporaryCharaInParty)
		{
		}

		public static void ClearPartySceneMode()
		{
		}

		public static void GoQuestPrepareScene(int questId, Action changeParentUiAction, ReturnDestScene returnDest)
		{
		}

		public static void GoPartySwitchPrepareScene(int questId, Action changeParentUiAction, ReturnDestScene returnDest, GuestEnterRoomFromType returnShowPopup = GuestEnterRoomFromType.None)
		{
		}

		private static void GoQuestPrepareScene(PartySceneMode mode, int questId, Action changeParentUiAction, ReturnDestScene returnDest, GuestEnterRoomFromType returnShowPopup)
		{
		}

		private static UniTask LoadPartyBaseScene(bool useLoadSceneAsync)
		{
			return default(UniTask);
		}

		public static void GoMatchingScene()
		{
		}
	}
}
