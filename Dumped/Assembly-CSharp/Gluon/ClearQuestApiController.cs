/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using ExitGames.Client.Photon;
using Gluon.Event;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ClearQuestApiController
	{
		// Fields
		private GameDataManager _gameDataManager;
		private Action _onClearQuestApiSuccess;
		private Action _onClearQuestApiError;
		private ClearQuestRequest _tmpClearQuestRequest;
		private State _state;
	
		// Nested types
		private enum State
		{
			None = 0,
			ClientToPhoton = 1,
			ClientToServer = 2
		}
	
		// Constructors
		public ClearQuestApiController();
	
		// Methods
		public void Initialize(GameDataManager gameDataManager);
		public void Start(Action onSuccess, Action onError);
		private void ApiDungeonRecord();
		private void OnSuccessDungeonRecord(DungeonRecordRecordResponse res);
		private void ApiDungeonRecordMulti();
		private void OnSuccessDungeonRecordMulti(DungeonRecordRecordMultiResponse res, bool isIgnoreRankingData);
		private void OnSuccessBattleRoyalRecordMulti(BattleRoyalRecordRoyalRecordMultiResponse res);
		private void SendPhotonRequest();
		private void OnEvent(EventData photonEvent);
		private void OnStatusChanged(StatusCode statusCode);
		private DungeonRecordRecordMultiRequest CreateDungeonRecordMultiRequest();
		private BattleRoyalRecordRoyalRecordMultiRequest CreateBattleRoyalRecordMultiRequest();
		private void OnFinishClearResponse(ClearQuestResponse clearQuestResponse);
		private ResponseType OnFinishClearResponseCommon<ResponseType>(byte[] recordMultiResponse)
			where ResponseType : Gluon.Http.ResponseCommon;
		private PlayRecord CreatePlayRecord();
		private void OnError(ErrorType errorType, int resultCode);
		private void OnCloseCallback();
		private void OnFatalError();
		private static void PauseIngame(bool pause);
		[CompilerGenerated]
		private void _ApiDungeonRecordMulti_b__10_0(DungeonRecordRecordMultiResponse res);
	}
}
