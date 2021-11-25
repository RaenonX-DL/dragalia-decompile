using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CartoonLatestTask : IHttpTask
	{
		private byte[] postData;

		private Action<CartoonLatestResponse> onSuccess;

		private Action<ErrorType, int, CartoonLatestResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CartoonLatestTask(CartoonLatestRequest request, Action<CartoonLatestResponse> onSuccess, Action<ErrorType, int, CartoonLatestResponse> onError)
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
