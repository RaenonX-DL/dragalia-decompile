using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class QuestGetQuestClearPartyMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<QuestGetQuestClearPartyMultiResponse> onSuccess;

		private Action<ErrorType, int, QuestGetQuestClearPartyMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public QuestGetQuestClearPartyMultiTask(QuestGetQuestClearPartyMultiRequest request, Action<QuestGetQuestClearPartyMultiResponse> onSuccess, Action<ErrorType, int, QuestGetQuestClearPartyMultiResponse> onError)
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
