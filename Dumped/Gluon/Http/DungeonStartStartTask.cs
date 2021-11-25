using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonStartStartTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonStartStartResponse> onSuccess;

		private Action<ErrorType, int, DungeonStartStartResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonStartStartTask(DungeonStartStartRequest request, Action<DungeonStartStartResponse> onSuccess, Action<ErrorType, int, DungeonStartStartResponse> onError)
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
