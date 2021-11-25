using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WebviewVersionUrlListTask : IHttpTask
	{
		private byte[] postData;

		private Action<WebviewVersionUrlListResponse> onSuccess;

		private Action<ErrorType, int, WebviewVersionUrlListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WebviewVersionUrlListTask(WebviewVersionUrlListRequest request, Action<WebviewVersionUrlListResponse> onSuccess, Action<ErrorType, int, WebviewVersionUrlListResponse> onError)
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
