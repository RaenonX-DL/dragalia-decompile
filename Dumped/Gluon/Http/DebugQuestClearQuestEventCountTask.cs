using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugQuestClearQuestEventCountTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugQuestClearQuestEventCountResponse> onSuccess;

		private Action<ErrorType, int, DebugQuestClearQuestEventCountResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugQuestClearQuestEventCountTask(DebugQuestClearQuestEventCountRequest request, Action<DebugQuestClearQuestEventCountResponse> onSuccess, Action<ErrorType, int, DebugQuestClearQuestEventCountResponse> onError)
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
