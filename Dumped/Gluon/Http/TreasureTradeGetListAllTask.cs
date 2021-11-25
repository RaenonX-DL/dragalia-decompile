using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class TreasureTradeGetListAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<TreasureTradeGetListAllResponse> onSuccess;

		private Action<ErrorType, int, TreasureTradeGetListAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public TreasureTradeGetListAllTask(TreasureTradeGetListAllRequest request, Action<TreasureTradeGetListAllResponse> onSuccess, Action<ErrorType, int, TreasureTradeGetListAllResponse> onError)
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
