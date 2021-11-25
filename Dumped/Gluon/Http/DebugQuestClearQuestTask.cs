using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugQuestClearQuestTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugQuestClearQuestResponse> onSuccess;

		private Action<ErrorType, int, DebugQuestClearQuestResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugQuestClearQuestTask(DebugQuestClearQuestRequest request, Action<DebugQuestClearQuestResponse> onSuccess, Action<ErrorType, int, DebugQuestClearQuestResponse> onError)
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
