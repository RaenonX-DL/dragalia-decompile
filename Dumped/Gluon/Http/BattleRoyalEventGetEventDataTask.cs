using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BattleRoyalEventGetEventDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<BattleRoyalEventGetEventDataResponse> onSuccess;

		private Action<ErrorType, int, BattleRoyalEventGetEventDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BattleRoyalEventGetEventDataTask(BattleRoyalEventGetEventDataRequest request, Action<BattleRoyalEventGetEventDataResponse> onSuccess, Action<ErrorType, int, BattleRoyalEventGetEventDataResponse> onError)
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
