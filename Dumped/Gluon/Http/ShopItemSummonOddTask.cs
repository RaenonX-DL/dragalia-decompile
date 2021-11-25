using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ShopItemSummonOddTask : IHttpTask
	{
		private byte[] postData;

		private Action<ShopItemSummonOddResponse> onSuccess;

		private Action<ErrorType, int, ShopItemSummonOddResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ShopItemSummonOddTask(ShopItemSummonOddRequest request, Action<ShopItemSummonOddResponse> onSuccess, Action<ErrorType, int, ShopItemSummonOddResponse> onError)
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
