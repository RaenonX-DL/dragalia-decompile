using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDmodeUpdateDmodeServitorPassiveMaxTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDmodeUpdateDmodeServitorPassiveMaxResponse> onSuccess;

		private Action<ErrorType, int, DebugDmodeUpdateDmodeServitorPassiveMaxResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDmodeUpdateDmodeServitorPassiveMaxTask(DebugDmodeUpdateDmodeServitorPassiveMaxRequest request, Action<DebugDmodeUpdateDmodeServitorPassiveMaxResponse> onSuccess, Action<ErrorType, int, DebugDmodeUpdateDmodeServitorPassiveMaxResponse> onError)
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
