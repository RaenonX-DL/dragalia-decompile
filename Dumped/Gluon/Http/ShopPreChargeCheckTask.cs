using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ShopPreChargeCheckTask : IHttpTask
	{
		private byte[] postData;

		private Action<ShopPreChargeCheckResponse> onSuccess;

		private Action<ErrorType, int, ShopPreChargeCheckResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ShopPreChargeCheckTask(ShopPreChargeCheckRequest request, Action<ShopPreChargeCheckResponse> onSuccess, Action<ErrorType, int, ShopPreChargeCheckResponse> onError)
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
