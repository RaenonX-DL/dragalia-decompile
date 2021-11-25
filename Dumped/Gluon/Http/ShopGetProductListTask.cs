using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ShopGetProductListTask : IHttpTask
	{
		private byte[] postData;

		private Action<ShopGetProductListResponse> onSuccess;

		private Action<ErrorType, int, ShopGetProductListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ShopGetProductListTask(ShopGetProductListRequest request, Action<ShopGetProductListResponse> onSuccess, Action<ErrorType, int, ShopGetProductListResponse> onError)
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
