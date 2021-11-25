using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugPlatformInterfaceCallbackTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugPlatformInterfaceCallbackResponse> onSuccess;

		private Action<ErrorType, int, DebugPlatformInterfaceCallbackResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugPlatformInterfaceCallbackTask(DebugPlatformInterfaceCallbackRequest request, Action<DebugPlatformInterfaceCallbackResponse> onSuccess, Action<ErrorType, int, DebugPlatformInterfaceCallbackResponse> onError)
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
