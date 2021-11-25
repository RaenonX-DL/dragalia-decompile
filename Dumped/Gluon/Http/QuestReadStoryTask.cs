using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class QuestReadStoryTask : IHttpTask
	{
		private byte[] postData;

		private Action<QuestReadStoryResponse> onSuccess;

		private Action<ErrorType, int, QuestReadStoryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public QuestReadStoryTask(QuestReadStoryRequest request, Action<QuestReadStoryResponse> onSuccess, Action<ErrorType, int, QuestReadStoryResponse> onError)
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
