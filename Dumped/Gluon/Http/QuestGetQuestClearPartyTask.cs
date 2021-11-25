using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class QuestGetQuestClearPartyTask : IHttpTask
	{
		private byte[] postData;

		private Action<QuestGetQuestClearPartyResponse> onSuccess;

		private Action<ErrorType, int, QuestGetQuestClearPartyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public QuestGetQuestClearPartyTask(QuestGetQuestClearPartyRequest request, Action<QuestGetQuestClearPartyResponse> onSuccess, Action<ErrorType, int, QuestGetQuestClearPartyResponse> onError)
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
