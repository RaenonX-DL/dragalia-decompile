using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SummonRequestTask : IHttpTask
	{
		private byte[] postData;

		private Action<SummonRequestResponse> onSuccess;

		private Action<ErrorType, int, SummonRequestResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SummonRequestTask(SummonRequestRequest request, Action<SummonRequestResponse> onSuccess, Action<ErrorType, int, SummonRequestResponse> onError)
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
