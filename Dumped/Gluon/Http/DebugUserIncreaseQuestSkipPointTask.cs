using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserIncreaseQuestSkipPointTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserIncreaseQuestSkipPointResponse> onSuccess;

		private Action<ErrorType, int, DebugUserIncreaseQuestSkipPointResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserIncreaseQuestSkipPointTask(DebugUserIncreaseQuestSkipPointRequest request, Action<DebugUserIncreaseQuestSkipPointResponse> onSuccess, Action<ErrorType, int, DebugUserIncreaseQuestSkipPointResponse> onError)
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
