using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EventSummonResetTask : IHttpTask
	{
		private byte[] postData;

		private Action<EventSummonResetResponse> onSuccess;

		private Action<ErrorType, int, EventSummonResetResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EventSummonResetTask(EventSummonResetRequest request, Action<EventSummonResetResponse> onSuccess, Action<ErrorType, int, EventSummonResetResponse> onError)
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
