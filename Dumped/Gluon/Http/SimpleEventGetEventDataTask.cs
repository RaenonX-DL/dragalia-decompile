using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SimpleEventGetEventDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<SimpleEventGetEventDataResponse> onSuccess;

		private Action<ErrorType, int, SimpleEventGetEventDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SimpleEventGetEventDataTask(SimpleEventGetEventDataRequest request, Action<SimpleEventGetEventDataResponse> onSuccess, Action<ErrorType, int, SimpleEventGetEventDataResponse> onError)
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
