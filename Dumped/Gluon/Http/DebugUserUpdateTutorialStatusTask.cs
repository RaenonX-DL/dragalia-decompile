using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserUpdateTutorialStatusTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserUpdateTutorialStatusResponse> onSuccess;

		private Action<ErrorType, int, DebugUserUpdateTutorialStatusResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserUpdateTutorialStatusTask(DebugUserUpdateTutorialStatusRequest request, Action<DebugUserUpdateTutorialStatusResponse> onSuccess, Action<ErrorType, int, DebugUserUpdateTutorialStatusResponse> onError)
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
