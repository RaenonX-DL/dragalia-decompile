using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDmodeUpdateDmodePointTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDmodeUpdateDmodePointResponse> onSuccess;

		private Action<ErrorType, int, DebugDmodeUpdateDmodePointResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDmodeUpdateDmodePointTask(DebugDmodeUpdateDmodePointRequest request, Action<DebugDmodeUpdateDmodePointResponse> onSuccess, Action<ErrorType, int, DebugDmodeUpdateDmodePointResponse> onError)
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
