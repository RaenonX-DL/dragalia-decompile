using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugCharaAddAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugCharaAddAllResponse> onSuccess;

		private Action<ErrorType, int, DebugCharaAddAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugCharaAddAllTask(DebugCharaAddAllRequest request, Action<DebugCharaAddAllResponse> onSuccess, Action<ErrorType, int, DebugCharaAddAllResponse> onError)
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
