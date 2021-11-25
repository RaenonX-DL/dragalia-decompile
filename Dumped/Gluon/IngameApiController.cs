using System;
using Cute.Http;
using Gluon.Http;

namespace Gluon
{
	public class IngameApiController
	{
		private GameDataManager gameDataManager;

		private bool isConnectingApiServer;

		private bool isClearQuestSucceeded;

		private Action<DungeonRetryResponse> dungeonRetryResponseCallback;

		private Action dungeonRetryErrorResponseCallback;

		private ClearQuestApiController clearQuestApiController;

		private FailQuestApiController failQuestApiController;

		private TimeupQuestApiController timeupQuestApiController;

		private bool isFailQuestCalled;

		private static readonly MaintenanceFunctionType[] InGameShopMaintenanceTypeList;

		public void Initialize(GameDataManager gameDataManager)
		{
		}

		public bool IsConnectingApiServer()
		{
			return default(bool);
		}

		public bool IsClearQuestApiSucceeded()
		{
			return default(bool);
		}

		public void ApiClearQuest()
		{
		}

		public void ApiFailQuest(FailQuestApiController.DungeonFailState failState)
		{
		}

		public void ApiTimeupQuest()
		{
		}

		public TimeupQuestApiController.Result GetTimeupQuestResult()
		{
			return default(TimeupQuestApiController.Result);
		}

		private void OnSuccess()
		{
		}

		private void OnSuccessClearQuest()
		{
		}

		private void OnError()
		{
		}

		public void ApiTutorialUpdateStep(int stepData)
		{
		}

		private void OnSuccess(TutorialUpdateStepResponse res)
		{
		}

		public void ApiDungeonRetry(PaymentType type, Action<DungeonRetryResponse> callback, Action errorCallback)
		{
		}

		private void OnSuccess(DungeonRetryResponse res)
		{
		}

		public void ApiAreaChange(int areaIdx)
		{
		}

		private void OnSuccess(DungeonGetAreaOddsResponse res)
		{
		}

		public void ApiWallRecord()
		{
		}

		private void OnSuccess(WallRecordRecordResponse res)
		{
		}

		protected void OnError(ErrorType errorType, int resultCode)
		{
		}

		protected void OnErrorDungeonRetry(ErrorType errorType, int resultCode)
		{
		}

		public static bool IsInGameShopMaintenance(ErrorType errorType, int resultCode)
		{
			return default(bool);
		}

		public void OnCloseCallback()
		{
		}

		private static void PauseIngame(bool pause)
		{
		}
	}
}
