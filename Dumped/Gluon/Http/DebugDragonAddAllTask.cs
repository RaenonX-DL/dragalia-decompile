using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDragonAddAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDragonAddAllResponse> onSuccess;

		private Action<ErrorType, int, DebugDragonAddAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDragonAddAllTask(DebugDragonAddAllRequest request, Action<DebugDragonAddAllResponse> onSuccess, Action<ErrorType, int, DebugDragonAddAllResponse> onError)
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
