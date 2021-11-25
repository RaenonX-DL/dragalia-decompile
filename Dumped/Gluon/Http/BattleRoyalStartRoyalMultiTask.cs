using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BattleRoyalStartRoyalMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<BattleRoyalStartRoyalMultiResponse> onSuccess;

		private Action<ErrorType, int, BattleRoyalStartRoyalMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BattleRoyalStartRoyalMultiTask(BattleRoyalStartRoyalMultiRequest request, Action<BattleRoyalStartRoyalMultiResponse> onSuccess, Action<ErrorType, int, BattleRoyalStartRoyalMultiResponse> onError)
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
