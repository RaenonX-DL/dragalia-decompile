using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class TreasureTradeGetListTask : IHttpTask
	{
		private byte[] postData;

		private Action<TreasureTradeGetListResponse> onSuccess;

		private Action<ErrorType, int, TreasureTradeGetListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public TreasureTradeGetListTask(TreasureTradeGetListRequest request, Action<TreasureTradeGetListResponse> onSuccess, Action<ErrorType, int, TreasureTradeGetListResponse> onError)
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
