using System;
using ExitGames.Client.Photon;
using Gluon.Event;

namespace Gluon
{
	public class TimeupQuestApiController
	{
		public enum Result
		{
			None,
			Timeup,
			Clear,
			Disconnected
		}

		private GameDataManager _gameDataManager;

		private Action _onFailQuestApiSuccess;

		private Action _onFailQuestApiError;

		private FailQuestRequest _tmpFailQuestRequest;

		private Result _result;

		public void Initialize(GameDataManager gameDataManager)
		{
		}

		public void Start(Action onSuccess, Action onError)
		{
		}

		public Result GetResult()
		{
			return default(Result);
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

		private void OnFinishTimeupResponse(FailQuestResponse failQuestResponse)
		{
		}
	}
}
