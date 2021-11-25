using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EventSummonGetDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<EventSummonGetDataResponse> onSuccess;

		private Action<ErrorType, int, EventSummonGetDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EventSummonGetDataTask(EventSummonGetDataRequest request, Action<EventSummonGetDataResponse> onSuccess, Action<ErrorType, int, EventSummonGetDataResponse> onError)
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
