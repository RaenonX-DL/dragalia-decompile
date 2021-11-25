using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserIncreaseDiamondTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserIncreaseDiamondResponse> onSuccess;

		private Action<ErrorType, int, DebugUserIncreaseDiamondResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserIncreaseDiamondTask(DebugUserIncreaseDiamondRequest request, Action<DebugUserIncreaseDiamondResponse> onSuccess, Action<ErrorType, int, DebugUserIncreaseDiamondResponse> onError)
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
