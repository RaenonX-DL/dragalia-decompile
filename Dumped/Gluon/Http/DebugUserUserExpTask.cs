using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserUserExpTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserUserExpResponse> onSuccess;

		private Action<ErrorType, int, DebugUserUserExpResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserUserExpTask(DebugUserUserExpRequest request, Action<DebugUserUserExpResponse> onSuccess, Action<ErrorType, int, DebugUserUserExpResponse> onError)
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
