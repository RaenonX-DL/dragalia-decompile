using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EventTradeGetListTask : IHttpTask
	{
		private byte[] postData;

		private Action<EventTradeGetListResponse> onSuccess;

		private Action<ErrorType, int, EventTradeGetListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EventTradeGetListTask(EventTradeGetListRequest request, Action<EventTradeGetListResponse> onSuccess, Action<ErrorType, int, EventTradeGetListResponse> onError)
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
