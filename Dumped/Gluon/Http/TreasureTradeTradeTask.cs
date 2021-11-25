using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class TreasureTradeTradeTask : IHttpTask
	{
		private byte[] postData;

		private Action<TreasureTradeTradeResponse> onSuccess;

		private Action<ErrorType, int, TreasureTradeTradeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public TreasureTradeTradeTask(TreasureTradeTradeRequest request, Action<TreasureTradeTradeResponse> onSuccess, Action<ErrorType, int, TreasureTradeTradeResponse> onError)
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
