using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class RedoableSummonPreExecTask : IHttpTask
	{
		private byte[] postData;

		private Action<RedoableSummonPreExecResponse> onSuccess;

		private Action<ErrorType, int, RedoableSummonPreExecResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public RedoableSummonPreExecTask(RedoableSummonPreExecRequest request, Action<RedoableSummonPreExecResponse> onSuccess, Action<ErrorType, int, RedoableSummonPreExecResponse> onError)
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
