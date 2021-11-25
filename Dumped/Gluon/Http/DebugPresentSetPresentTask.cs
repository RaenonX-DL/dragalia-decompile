using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugPresentSetPresentTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugPresentSetPresentResponse> onSuccess;

		private Action<ErrorType, int, DebugPresentSetPresentResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugPresentSetPresentTask(DebugPresentSetPresentRequest request, Action<DebugPresentSetPresentResponse> onSuccess, Action<ErrorType, int, DebugPresentSetPresentResponse> onError)
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
