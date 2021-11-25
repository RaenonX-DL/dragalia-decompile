using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ToolAuthTask : IHttpTask
	{
		private byte[] postData;

		private Action<ToolAuthResponse> onSuccess;

		private Action<ErrorType, int, ToolAuthResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ToolAuthTask(ToolAuthRequest request, Action<ToolAuthResponse> onSuccess, Action<ErrorType, int, ToolAuthResponse> onError)
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
