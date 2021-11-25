using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CollectEventGetEventDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<CollectEventGetEventDataResponse> onSuccess;

		private Action<ErrorType, int, CollectEventGetEventDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CollectEventGetEventDataTask(CollectEventGetEventDataRequest request, Action<CollectEventGetEventDataResponse> onSuccess, Action<ErrorType, int, CollectEventGetEventDataResponse> onError)
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
