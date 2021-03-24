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
	public class FailQuestApiController
	{
		// Fields
		private GameDataManager _gameDataManager;
		private Action _onFailQuestApiSuccess;
		private Action _onFailQuestApiError;
		private DungeonFailState _failState;
	
		// Nested types
		public enum DungeonFailState
		{
			Retire = 1,
			GameOver = 2,
			AfterOtherRetire = 3,
			DisconnectedAsGuest = 4,
			DisconnectedInRankingBattle = 5,
			Timeup = 6,
			Defence_ObjectiveFailed = 7,
			Retry = 8
		}
	
		// Constructors
		public FailQuestApiController();
	
		// Methods
		public void Initialize(GameDataManager gameDataManager);
		public void Start(DungeonFailState failState, Action onSuccess, Action onError);
		private bool NeedSetQuestClearParty();
		private void ApiSetQuestClearParty();
		private void OnSuccessSetQuestClearParty(QuestSetQuestClearPartyMultiResponse res);
		private void ApiDungeonFail(DungeonFailState failState);
		private void OnSuccessDungeonFail(DungeonFailResponse res);
		private void OnSuccessWallFail(WallFailResponse res);
		private void ApiBattleRoyalFail(DungeonFailState failState);
		private void OnSuccessBattleRoyalFail(BattleRoyalFailResponse res);
		protected void OnError(ErrorType errorType, int resultCode);
		private void OnCloseCallback();
		private static bool IsQuestCleared(int questId);
		private static void PauseIngame(bool pause);
	}
}
