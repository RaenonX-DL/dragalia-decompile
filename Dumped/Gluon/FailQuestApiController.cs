using System;
using Cute.Http;
using Gluon.Http;

namespace Gluon
{
	public class FailQuestApiController
	{
		public enum DungeonFailState
		{
			Retire = 1,
			GameOver,
			AfterOtherRetire,
			DisconnectedAsGuest,
			DisconnectedInRankingBattle,
			Timeup,
			Defence_ObjectiveFailed,
			Retry
		}

		private GameDataManager _gameDataManager;

		private Action _onFailQuestApiSuccess;

		private Action _onFailQuestApiError;

		private DungeonFailState _failState;

		public void Initialize(GameDataManager gameDataManager)
		{
		}

		public void Start(DungeonFailState failState, Action onSuccess, Action onError)
		{
		}

		private bool NeedSetQuestClearParty()
		{
			return default(bool);
		}

		private void ApiSetQuestClearParty()
		{
		}

		private void OnSuccessSetQuestClearParty(QuestSetQuestClearPartyMultiResponse res)
		{
		}

		private void ApiDungeonFail(DungeonFailState failState)
		{
		}

		private void OnSuccessDungeonFail(DungeonFailResponse res)
		{
		}

		private void OnSuccessWallFail(WallFailResponse res)
		{
		}

		private void ApiBattleRoyalFail(DungeonFailState failState)
		{
		}

		private void OnSuccessBattleRoyalFail(BattleRoyalFailResponse res)
		{
		}

		protected void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void OnCloseCallback()
		{
		}

		private static bool IsQuestCleared(int questId)
		{
			return default(bool);
		}

		private static void PauseIngame(bool pause)
		{
		}
	}
}
