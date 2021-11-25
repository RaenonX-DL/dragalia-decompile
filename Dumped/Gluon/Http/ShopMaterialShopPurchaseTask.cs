using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ShopMaterialShopPurchaseTask : IHttpTask
	{
		private byte[] postData;

		private Action<ShopMaterialShopPurchaseResponse> onSuccess;

		private Action<ErrorType, int, ShopMaterialShopPurchaseResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ShopMaterialShopPurchaseTask(ShopMaterialShopPurchaseRequest request, Action<ShopMaterialShopPurchaseResponse> onSuccess, Action<ErrorType, int, ShopMaterialShopPurchaseResponse> onError)
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
