using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SummonGetSummonHistoryTask : IHttpTask
	{
		private byte[] postData;

		private Action<SummonGetSummonHistoryResponse> onSuccess;

		private Action<ErrorType, int, SummonGetSummonHistoryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SummonGetSummonHistoryTask(SummonGetSummonHistoryRequest request, Action<SummonGetSummonHistoryResponse> onSuccess, Action<ErrorType, int, SummonGetSummonHistoryResponse> onError)
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
