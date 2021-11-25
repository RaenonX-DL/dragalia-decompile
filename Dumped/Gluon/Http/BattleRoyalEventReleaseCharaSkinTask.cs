using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BattleRoyalEventReleaseCharaSkinTask : IHttpTask
	{
		private byte[] postData;

		private Action<BattleRoyalEventReleaseCharaSkinResponse> onSuccess;

		private Action<ErrorType, int, BattleRoyalEventReleaseCharaSkinResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BattleRoyalEventReleaseCharaSkinTask(BattleRoyalEventReleaseCharaSkinRequest request, Action<BattleRoyalEventReleaseCharaSkinResponse> onSuccess, Action<ErrorType, int, BattleRoyalEventReleaseCharaSkinResponse> onError)
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
