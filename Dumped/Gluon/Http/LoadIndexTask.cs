using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class LoadIndexTask : IHttpTask
	{
		private byte[] postData;

		private Action<LoadIndexResponse> onSuccess;

		private Action<ErrorType, int, LoadIndexResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public LoadIndexTask(LoadIndexRequest request, Action<LoadIndexResponse> onSuccess, Action<ErrorType, int, LoadIndexResponse> onError)
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
