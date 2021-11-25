using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugCharaAddCharaTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugCharaAddCharaResponse> onSuccess;

		private Action<ErrorType, int, DebugCharaAddCharaResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugCharaAddCharaTask(DebugCharaAddCharaRequest request, Action<DebugCharaAddCharaResponse> onSuccess, Action<ErrorType, int, DebugCharaAddCharaResponse> onError)
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
