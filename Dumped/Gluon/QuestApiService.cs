using System;
using System.Collections.Generic;
using Cute.Http;
using Gluon.Http;

namespace Gluon
{
	public static class QuestApiService
	{
		private static void _StartSinglePlayQuestApi_Common(int questId, ulong supportUserId, int playCount, Action onSuccess, Action<ErrorType, int> onError, bool isSkip = false, bool isCheckDateChange = false)
		{
		}

		public static void StartSinglePlayQuestApi(int questId, ulong supportUserId, int playCount, Action onSuccess, Action onError, bool isSkip = false)
		{
		}

		public static void StartSinglePlayQuestApi(int questId, ulong supportUserId, int playCount, Action onSuccess, Action<ErrorType, int> onError, bool isSkip = false)
		{
		}

		private static void OnSuccessSinglePlay(DungeonStartStartResponse res, Action onSuccess)
		{
		}

		private static void OnSuccessSinglePlay(WallStartStartResponse res, Action onSuccess)
		{
		}

		private static void OnSuccessSkipSinglePlay(DungeonSkipStartResponse res, Action onSuccess)
		{
		}

		private static void _StartSinglePlayQuestApiWithClearParty_Common(int questId, ulong supportUserId, int playCount, QuestPrepareData[] clearPartyDatas, Action onSuccess, Action<ErrorType, int> onError, bool isSkip, bool isCheckDateChange)
		{
		}

		public static void StartSinglePlayQuestApiWithClearParty(int questId, ulong supportUserId, int playCount, QuestPrepareData[] clearPartyDatas, Action onSuccess, Action onError, bool isSkip = false)
		{
		}

		public static void StartSinglePlayQuestApiWithClearParty(int questId, ulong supportUserId, int playCount, QuestPrepareData[] clearPartyDatas, Action onSuccess, Action<ErrorType, int> onError, bool isSkip = false)
		{
		}

		private static void OnSuccessSinglePlayWithClearParty(DungeonStartStartAssignUnitResponse res, Action onSuccess)
		{
		}

		private static void OnSuccessSinglePlayWithClearParty(WallStartStartAssignUnitResponse res, Action onSuccess)
		{
		}

		private static void OnSuccessSkipSinglePlayWithClearParty(DungeonSkipStartAssignUnitResponse res, Action onSuccess)
		{
		}

		public static void StartQuestGroupSkipApi(List<int> questIdList, ulong supportUserId, int playCount, Action onSuccess, Action<ErrorType, int> onError)
		{
		}

		private static void OnSuccessGroupSkip(DungeonSkipStartMultipleQuestResponse res, Action onSuccess)
		{
		}

		public static void StartMultiPlayQuestApi(int questId, int[] usePartySlots, Action onSuccess, Action onError)
		{
		}

		public static void StartMultiPlayBattleRoyalApi(int questId, Action onSuccess, Action onError)
		{
		}

		public static void StartMultiPlayQuestApiWithClearParty(int questId, QuestPrepareData[] clearPartyDatas, Action onSuccess, Action onError)
		{
		}

		private static int GetQuestStartRepeatState()
		{
			return default(int);
		}

		private static void OnSuccessMultiPlay(DungeonStartStartMultiResponse res, Action onSuccess)
		{
		}

		private static void OnSuccessMultiPlay(DungeonStartStartMultiAssignUnitResponse res, Action onSuccess)
		{
		}

		private static void OnSuccessMultiPlay(BattleRoyalStartRoyalMultiResponse res, Action onSuccess)
		{
		}

		private static void OnErrorMultiPlay(ErrorType errorType, int resultCode, Action onError)
		{
		}
	}
}
