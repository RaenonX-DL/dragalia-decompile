/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class IngameApiController
	{
		// Fields
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
	
		// Constructors
		public IngameApiController();
		static IngameApiController();
	
		// Methods
		public void Initialize(GameDataManager gameDataManager);
		public bool IsConnectingApiServer();
		public bool IsClearQuestApiSucceeded();
		public void ApiClearQuest();
		public void ApiFailQuest(FailQuestApiController.DungeonFailState failState);
		public void ApiTimeupQuest();
		public TimeupQuestApiController.Result GetTimeupQuestResult();
		private void OnSuccess();
		private void OnSuccessClearQuest();
		private void OnError();
		public void ApiTutorialUpdateStep(int stepData);
		private void OnSuccess(TutorialUpdateStepResponse res);
		public void ApiDungeonRetry(PaymentType type, Action<DungeonRetryResponse> callback, Action errorCallback);
		private void OnSuccess(DungeonRetryResponse res);
		public void ApiAreaChange(int areaIdx);
		private void OnSuccess(DungeonGetAreaOddsResponse res);
		public void ApiWallRecord();
		private void OnSuccess(WallRecordRecordResponse res);
		protected void OnError(ErrorType errorType, int resultCode);
		protected void OnErrorDungeonRetry(ErrorType errorType, int resultCode);
		public static bool IsInGameShopMaintenance(ErrorType errorType, int resultCode);
		public void OnCloseCallback();
		private static void PauseIngame(bool pause);
	}
}
