using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SummonExcludeRequestTask : IHttpTask
	{
		private byte[] postData;

		private Action<SummonExcludeRequestResponse> onSuccess;

		private Action<ErrorType, int, SummonExcludeRequestResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SummonExcludeRequestTask(SummonExcludeRequestRequest request, Action<SummonExcludeRequestResponse> onSuccess, Action<ErrorType, int, SummonExcludeRequestResponse> onError)
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
