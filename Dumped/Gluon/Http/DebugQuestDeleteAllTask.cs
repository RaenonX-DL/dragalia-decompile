using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugQuestDeleteAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugQuestDeleteAllResponse> onSuccess;

		private Action<ErrorType, int, DebugQuestDeleteAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugQuestDeleteAllTask(DebugQuestDeleteAllRequest request, Action<DebugQuestDeleteAllResponse> onSuccess, Action<ErrorType, int, DebugQuestDeleteAllResponse> onError)
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
