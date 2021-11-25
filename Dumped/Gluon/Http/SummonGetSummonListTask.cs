using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SummonGetSummonListTask : IHttpTask
	{
		private byte[] postData;

		private Action<SummonGetSummonListResponse> onSuccess;

		private Action<ErrorType, int, SummonGetSummonListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SummonGetSummonListTask(SummonGetSummonListRequest request, Action<SummonGetSummonListResponse> onSuccess, Action<ErrorType, int, SummonGetSummonListResponse> onError)
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
