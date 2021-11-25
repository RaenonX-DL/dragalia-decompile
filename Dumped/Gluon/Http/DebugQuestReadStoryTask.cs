using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugQuestReadStoryTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugQuestReadStoryResponse> onSuccess;

		private Action<ErrorType, int, DebugQuestReadStoryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugQuestReadStoryTask(DebugQuestReadStoryRequest request, Action<DebugQuestReadStoryResponse> onSuccess, Action<ErrorType, int, DebugQuestReadStoryResponse> onError)
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
