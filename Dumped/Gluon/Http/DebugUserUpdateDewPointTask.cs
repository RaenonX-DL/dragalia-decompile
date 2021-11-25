using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserUpdateDewPointTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserUpdateDewPointResponse> onSuccess;

		private Action<ErrorType, int, DebugUserUpdateDewPointResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserUpdateDewPointTask(DebugUserUpdateDewPointRequest request, Action<DebugUserUpdateDewPointResponse> onSuccess, Action<ErrorType, int, DebugUserUpdateDewPointResponse> onError)
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
