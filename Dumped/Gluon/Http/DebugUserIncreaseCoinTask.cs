using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserIncreaseCoinTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserIncreaseCoinResponse> onSuccess;

		private Action<ErrorType, int, DebugUserIncreaseCoinResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserIncreaseCoinTask(DebugUserIncreaseCoinRequest request, Action<DebugUserIncreaseCoinResponse> onSuccess, Action<ErrorType, int, DebugUserIncreaseCoinResponse> onError)
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
