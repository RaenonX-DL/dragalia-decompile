/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using ExitGames.Client.Photon;
using Gluon.Event;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
	
		[CompilerGenerated]
		private sealed class _ApiDungeonRecordMultiWrapper_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float sec;
			public ClearQuestApiController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ApiDungeonRecordMultiWrapper_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
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
		[IteratorStateMachine]
		private IEnumerator ApiDungeonRecordMultiWrapper(float sec);
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
