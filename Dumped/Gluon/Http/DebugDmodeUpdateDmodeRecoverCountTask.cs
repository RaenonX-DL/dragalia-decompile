using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDmodeUpdateDmodeRecoverCountTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDmodeUpdateDmodeRecoverCountResponse> onSuccess;

		private Action<ErrorType, int, DebugDmodeUpdateDmodeRecoverCountResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDmodeUpdateDmodeRecoverCountTask(DebugDmodeUpdateDmodeRecoverCountRequest request, Action<DebugDmodeUpdateDmodeRecoverCountResponse> onSuccess, Action<ErrorType, int, DebugDmodeUpdateDmodeRecoverCountResponse> onError)
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
