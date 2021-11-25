using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EventStoryReadTask : IHttpTask
	{
		private byte[] postData;

		private Action<EventStoryReadResponse> onSuccess;

		private Action<ErrorType, int, EventStoryReadResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EventStoryReadTask(EventStoryReadRequest request, Action<EventStoryReadResponse> onSuccess, Action<ErrorType, int, EventStoryReadResponse> onError)
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
