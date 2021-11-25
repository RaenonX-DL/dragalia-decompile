using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EventSummonExecTask : IHttpTask
	{
		private byte[] postData;

		private Action<EventSummonExecResponse> onSuccess;

		private Action<ErrorType, int, EventSummonExecResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EventSummonExecTask(EventSummonExecRequest request, Action<EventSummonExecResponse> onSuccess, Action<ErrorType, int, EventSummonExecResponse> onError)
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
