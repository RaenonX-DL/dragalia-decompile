using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MemoryEventActivateTask : IHttpTask
	{
		private byte[] postData;

		private Action<MemoryEventActivateResponse> onSuccess;

		private Action<ErrorType, int, MemoryEventActivateResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MemoryEventActivateTask(MemoryEventActivateRequest request, Action<MemoryEventActivateResponse> onSuccess, Action<ErrorType, int, MemoryEventActivateResponse> onError)
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
