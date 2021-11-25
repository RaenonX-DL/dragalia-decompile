using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ShopItemSummonExecTask : IHttpTask
	{
		private byte[] postData;

		private Action<ShopItemSummonExecResponse> onSuccess;

		private Action<ErrorType, int, ShopItemSummonExecResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ShopItemSummonExecTask(ShopItemSummonExecRequest request, Action<ShopItemSummonExecResponse> onSuccess, Action<ErrorType, int, ShopItemSummonExecResponse> onError)
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
