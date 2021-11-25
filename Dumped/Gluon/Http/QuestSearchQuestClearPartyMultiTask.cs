using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class QuestSearchQuestClearPartyMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<QuestSearchQuestClearPartyMultiResponse> onSuccess;

		private Action<ErrorType, int, QuestSearchQuestClearPartyMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public QuestSearchQuestClearPartyMultiTask(QuestSearchQuestClearPartyMultiRequest request, Action<QuestSearchQuestClearPartyMultiResponse> onSuccess, Action<ErrorType, int, QuestSearchQuestClearPartyMultiResponse> onError)
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
