using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugSummonUpdateSummonScoreAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugSummonUpdateSummonScoreAllResponse> onSuccess;

		private Action<ErrorType, int, DebugSummonUpdateSummonScoreAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugSummonUpdateSummonScoreAllTask(DebugSummonUpdateSummonScoreAllRequest request, Action<DebugSummonUpdateSummonScoreAllResponse> onSuccess, Action<ErrorType, int, DebugSummonUpdateSummonScoreAllResponse> onError)
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
