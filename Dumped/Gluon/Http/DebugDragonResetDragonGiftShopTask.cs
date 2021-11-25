using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDragonResetDragonGiftShopTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDragonResetDragonGiftShopResponse> onSuccess;

		private Action<ErrorType, int, DebugDragonResetDragonGiftShopResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDragonResetDragonGiftShopTask(DebugDragonResetDragonGiftShopRequest request, Action<DebugDragonResetDragonGiftShopResponse> onSuccess, Action<ErrorType, int, DebugDragonResetDragonGiftShopResponse> onError)
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
