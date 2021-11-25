using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class QuestSetQuestClearPartyMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<QuestSetQuestClearPartyMultiResponse> onSuccess;

		private Action<ErrorType, int, QuestSetQuestClearPartyMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public QuestSetQuestClearPartyMultiTask(QuestSetQuestClearPartyMultiRequest request, Action<QuestSetQuestClearPartyMultiResponse> onSuccess, Action<ErrorType, int, QuestSetQuestClearPartyMultiResponse> onError)
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
