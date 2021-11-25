using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonSkipStartTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonSkipStartResponse> onSuccess;

		private Action<ErrorType, int, DungeonSkipStartResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonSkipStartTask(DungeonSkipStartRequest request, Action<DungeonSkipStartResponse> onSuccess, Action<ErrorType, int, DungeonSkipStartResponse> onError)
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
