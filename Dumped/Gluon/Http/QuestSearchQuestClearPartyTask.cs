using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class QuestSearchQuestClearPartyTask : IHttpTask
	{
		private byte[] postData;

		private Action<QuestSearchQuestClearPartyResponse> onSuccess;

		private Action<ErrorType, int, QuestSearchQuestClearPartyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public QuestSearchQuestClearPartyTask(QuestSearchQuestClearPartyRequest request, Action<QuestSearchQuestClearPartyResponse> onSuccess, Action<ErrorType, int, QuestSearchQuestClearPartyResponse> onError)
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
