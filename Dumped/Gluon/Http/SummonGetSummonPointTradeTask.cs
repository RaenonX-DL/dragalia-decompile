using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SummonGetSummonPointTradeTask : IHttpTask
	{
		private byte[] postData;

		private Action<SummonGetSummonPointTradeResponse> onSuccess;

		private Action<ErrorType, int, SummonGetSummonPointTradeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SummonGetSummonPointTradeTask(SummonGetSummonPointTradeRequest request, Action<SummonGetSummonPointTradeResponse> onSuccess, Action<ErrorType, int, SummonGetSummonPointTradeResponse> onError)
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
