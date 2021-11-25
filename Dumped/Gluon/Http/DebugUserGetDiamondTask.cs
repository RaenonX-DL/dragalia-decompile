using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserGetDiamondTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserGetDiamondResponse> onSuccess;

		private Action<ErrorType, int, DebugUserGetDiamondResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserGetDiamondTask(DebugUserGetDiamondRequest request, Action<DebugUserGetDiamondResponse> onSuccess, Action<ErrorType, int, DebugUserGetDiamondResponse> onError)
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
