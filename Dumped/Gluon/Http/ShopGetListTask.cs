using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ShopGetListTask : IHttpTask
	{
		private byte[] postData;

		private Action<ShopGetListResponse> onSuccess;

		private Action<ErrorType, int, ShopGetListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ShopGetListTask(ShopGetListRequest request, Action<ShopGetListResponse> onSuccess, Action<ErrorType, int, ShopGetListResponse> onError)
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
