using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugBattleRoyalEventAllReleaseTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugBattleRoyalEventAllReleaseResponse> onSuccess;

		private Action<ErrorType, int, DebugBattleRoyalEventAllReleaseResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugBattleRoyalEventAllReleaseTask(DebugBattleRoyalEventAllReleaseRequest request, Action<DebugBattleRoyalEventAllReleaseResponse> onSuccess, Action<ErrorType, int, DebugBattleRoyalEventAllReleaseResponse> onError)
		{
		}

		public void SetHeader(string key, string value)
		{
		}

		public IWebRequest Send(string url)
		{
			return null;
		}

		public bool Deserialize(byte[] body)
		{
			return default(bool);
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}
	}
}
