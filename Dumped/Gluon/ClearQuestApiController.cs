using System;
using System.Collections;
using Cute.Http;
using ExitGames.Client.Photon;
using Gluon.Event;
using Gluon.Http;

namespace Gluon
{
	public class ClearQuestApiController
	{
		private enum State
		{
			None,
			ClientToPhoton,
			ClientToServer
		}

		private GameDataManager _gameDataManager;

		private Action _onClearQuestApiSuccess;

		private Action _onClearQuestApiError;

		private ClearQuestRequest _tmpClearQuestRequest;

		private State _state;

		public void Initialize(GameDataManager gameDataManager)
		{
		}

		public void Start(Action onSuccess, Action onError)
		{
		}

		private void ApiDungeonRecord()
		{
		}

		private void OnSuccessDungeonRecord(DungeonRecordRecordResponse res)
		{
		}

		private void ApiDungeonRecordMulti()
		{
		}

		private void OnSuccessDungeonRecordMulti(DungeonRecordRecordMultiResponse res, bool isIgnoreRankingData)
		{
		}

		private void OnSuccessBattleRoyalRecordMulti(BattleRoyalRecordRoyalRecordMultiResponse res)
		{
		}

		private void SendPhotonRequest()
		{
		}

		private void OnEvent(EventData photonEvent)
		{
		}

		private void OnStatusChanged(StatusCode statusCode)
		{
		}

		private IEnumerator ApiDungeonRecordMultiWrapper(float sec)
		{
			return null;
		}

		private DungeonRecordRecordMultiRequest CreateDungeonRecordMultiRequest()
		{
			return null;
		}

		private BattleRoyalRecordRoyalRecordMultiRequest CreateBattleRoyalRecordMultiRequest()
		{
			return null;
		}

		private void OnFinishClearResponse(ClearQuestResponse clearQuestResponse)
		{
		}

		private ResponseType OnFinishClearResponseCommon<ResponseType>(byte[] recordMultiResponse) where ResponseType : Gluon.Http.ResponseCommon
		{
			return null;
		}

		private PlayRecord CreatePlayRecord()
		{
			return null;
		}

		private void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void OnCloseCallback()
		{
		}

		private void OnFatalError()
		{
		}

		private static void PauseIngame(bool pause)
		{
		}
	}
}
