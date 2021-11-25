using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserUserRankTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserUserRankResponse> onSuccess;

		private Action<ErrorType, int, DebugUserUserRankResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserUserRankTask(DebugUserUserRankRequest request, Action<DebugUserUserRankResponse> onSuccess, Action<ErrorType, int, DebugUserUserRankResponse> onError)
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
