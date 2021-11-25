using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SummonExcludeGetListTask : IHttpTask
	{
		private byte[] postData;

		private Action<SummonExcludeGetListResponse> onSuccess;

		private Action<ErrorType, int, SummonExcludeGetListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SummonExcludeGetListTask(SummonExcludeGetListRequest request, Action<SummonExcludeGetListResponse> onSuccess, Action<ErrorType, int, SummonExcludeGetListResponse> onError)
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
