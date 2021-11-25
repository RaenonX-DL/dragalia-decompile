using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EventTradeTradeTask : IHttpTask
	{
		private byte[] postData;

		private Action<EventTradeTradeResponse> onSuccess;

		private Action<ErrorType, int, EventTradeTradeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EventTradeTradeTask(EventTradeTradeRequest request, Action<EventTradeTradeResponse> onSuccess, Action<ErrorType, int, EventTradeTradeResponse> onError)
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
