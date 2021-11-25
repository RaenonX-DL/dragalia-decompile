using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDebugTimeGetDebugTimeTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDebugTimeGetDebugTimeResponse> onSuccess;

		private Action<ErrorType, int, DebugDebugTimeGetDebugTimeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDebugTimeGetDebugTimeTask(DebugDebugTimeGetDebugTimeRequest request, Action<DebugDebugTimeGetDebugTimeResponse> onSuccess, Action<ErrorType, int, DebugDebugTimeGetDebugTimeResponse> onError)
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
