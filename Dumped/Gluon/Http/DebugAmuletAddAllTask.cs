using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugAmuletAddAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugAmuletAddAllResponse> onSuccess;

		private Action<ErrorType, int, DebugAmuletAddAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugAmuletAddAllTask(DebugAmuletAddAllRequest request, Action<DebugAmuletAddAllResponse> onSuccess, Action<ErrorType, int, DebugAmuletAddAllResponse> onError)
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
