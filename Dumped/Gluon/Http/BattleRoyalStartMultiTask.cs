using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BattleRoyalStartMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<BattleRoyalStartMultiResponse> onSuccess;

		private Action<ErrorType, int, BattleRoyalStartMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BattleRoyalStartMultiTask(BattleRoyalStartMultiRequest request, Action<BattleRoyalStartMultiResponse> onSuccess, Action<ErrorType, int, BattleRoyalStartMultiResponse> onError)
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
