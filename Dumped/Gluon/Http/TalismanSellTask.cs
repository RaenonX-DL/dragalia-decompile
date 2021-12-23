using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class TalismanSellTask : IHttpTask
	{
		private byte[] postData;

		private Action<TalismanSellResponse> onSuccess;

		private Action<ErrorType, int, TalismanSellResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public TalismanSellTask(TalismanSellRequest request, Action<TalismanSellResponse> onSuccess, Action<ErrorType, int, TalismanSellResponse> onError)
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
