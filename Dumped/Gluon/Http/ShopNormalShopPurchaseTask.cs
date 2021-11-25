using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ShopNormalShopPurchaseTask : IHttpTask
	{
		private byte[] postData;

		private Action<ShopNormalShopPurchaseResponse> onSuccess;

		private Action<ErrorType, int, ShopNormalShopPurchaseResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ShopNormalShopPurchaseTask(ShopNormalShopPurchaseRequest request, Action<ShopNormalShopPurchaseResponse> onSuccess, Action<ErrorType, int, ShopNormalShopPurchaseResponse> onError)
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
