using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserRecoverStaminaMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserRecoverStaminaMultiResponse> onSuccess;

		private Action<ErrorType, int, DebugUserRecoverStaminaMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserRecoverStaminaMultiTask(DebugUserRecoverStaminaMultiRequest request, Action<DebugUserRecoverStaminaMultiResponse> onSuccess, Action<ErrorType, int, DebugUserRecoverStaminaMultiResponse> onError)
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
