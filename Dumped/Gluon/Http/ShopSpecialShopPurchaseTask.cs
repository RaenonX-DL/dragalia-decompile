using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ShopSpecialShopPurchaseTask : IHttpTask
	{
		private byte[] postData;

		private Action<ShopSpecialShopPurchaseResponse> onSuccess;

		private Action<ErrorType, int, ShopSpecialShopPurchaseResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ShopSpecialShopPurchaseTask(ShopSpecialShopPurchaseRequest request, Action<ShopSpecialShopPurchaseResponse> onSuccess, Action<ErrorType, int, ShopSpecialShopPurchaseResponse> onError)
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
