using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ToolReauthTask : IHttpTask
	{
		private byte[] postData;

		private Action<ToolReauthResponse> onSuccess;

		private Action<ErrorType, int, ToolReauthResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ToolReauthTask(ToolReauthRequest request, Action<ToolReauthResponse> onSuccess, Action<ErrorType, int, ToolReauthResponse> onError)
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
