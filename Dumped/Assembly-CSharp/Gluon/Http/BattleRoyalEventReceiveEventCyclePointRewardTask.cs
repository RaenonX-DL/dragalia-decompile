/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class BattleRoyalEventReceiveEventCyclePointRewardTask : IHttpTask
	{
		// Fields
		private byte[] postData;
		private Action<BattleRoyalEventReceiveEventCyclePointRewardResponse> onSuccess;
		private Action<ErrorType, int, BattleRoyalEventReceiveEventCyclePointRewardResponse> onError;
		private Dictionary<string, string> headers;
		private IWebRequest request;
	
		// Properties
		public int CacheTime { get; }
		public bool IsEncrypt { get; }
	
		// Constructors
		public BattleRoyalEventReceiveEventCyclePointRewardTask(BattleRoyalEventReceiveEventCyclePointRewardRequest request, Action<BattleRoyalEventReceiveEventCyclePointRewardResponse> onSuccess, Action<ErrorType, int, BattleRoyalEventReceiveEventCyclePointRewardResponse> onError);
	
		// Methods
		public void SetHeader(string key, string value);
		public IWebRequest Send(string url);
		public bool Deserialize(byte[] body);
		public void OnError(ErrorType errorType, int resultCode);
	}
}
