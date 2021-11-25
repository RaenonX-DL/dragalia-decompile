using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonSkipStartMultipleQuestTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonSkipStartMultipleQuestResponse> onSuccess;

		private Action<ErrorType, int, DungeonSkipStartMultipleQuestResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonSkipStartMultipleQuestTask(DungeonSkipStartMultipleQuestRequest request, Action<DungeonSkipStartMultipleQuestResponse> onSuccess, Action<ErrorType, int, DungeonSkipStartMultipleQuestResponse> onError)
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
