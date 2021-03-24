/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TimeupQuestApiController
	{
		// Fields
		private GameDataManager _gameDataManager;
		private Action _onFailQuestApiSuccess;
		private Action _onFailQuestApiError;
		private FailQuestRequest _tmpFailQuestRequest;
		private Result _result;
	
		// Nested types
		public enum Result
		{
			None = 0,
			Timeup = 1,
			Clear = 2,
			Disconnected = 3
		}
	
		// Constructors
		public TimeupQuestApiController();
	
		// Methods
		public void Initialize(GameDataManager gameDataManager);
		public void Start(Action onSuccess, Action onError);
		public Result GetResult();
		private void SendPhotonRequest();
		private void OnEvent(EventData photonEvent);
		private void OnStatusChanged(StatusCode statusCode);
		private void OnFinishTimeupResponse(FailQuestResponse failQuestResponse);
	}
}
