using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class QuestOpenTreasureTask : IHttpTask
	{
		private byte[] postData;

		private Action<QuestOpenTreasureResponse> onSuccess;

		private Action<ErrorType, int, QuestOpenTreasureResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public QuestOpenTreasureTask(QuestOpenTreasureRequest request, Action<QuestOpenTreasureResponse> onSuccess, Action<ErrorType, int, QuestOpenTreasureResponse> onError)
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
